using EchoClip.gRPC.Interfaces;
using EchoClip.Models;
using EchoClip.Repositories.Interfaces;

namespace EchoClip.Services.Implementations;

public class ChatService(IChatRepository chatRepository, 
    IChatVoiceRecordingRepository chatVoiceRecordingRepository, 
    IUserWhoJoinedChatRepository userWhoJoinedChatRepository,
    IVoiceRecordingRepository voiceRecordingRepository,
    IUserRepository userRepository,
    IUserRelationshipRepository userRelationshipRepository) : IChatService
{
    private readonly IChatRepository _chatRepository = chatRepository;

    private readonly IChatVoiceRecordingRepository _chatVoiceRecordingRepository = chatVoiceRecordingRepository;

    private readonly IUserWhoJoinedChatRepository _userWhoJoinedChatRepository = userWhoJoinedChatRepository;

    private readonly IUserRepository _userRepository = userRepository;

    private readonly IVoiceRecordingRepository _voiceRecordingRepository = voiceRecordingRepository;

    private readonly IUserRelationshipRepository _userRelationshipRepository = userRelationshipRepository;

    public void AddVoiceRecordingToChat(Guid voiceRecordingId, Guid czatId)
    {
        ChatsVoiceRecording chatsVoiceRecording = new ChatsVoiceRecording
        {
            ChatId = czatId,
            VoiceRecordingId = voiceRecordingId,
            DataOfAdded = DateTime.Now
        };
        _chatVoiceRecordingRepository.Insert(chatsVoiceRecording);
        _chatVoiceRecordingRepository.Save();
    }

    public void AddFriendToChat(Guid myId, Guid friendId, Guid chatId)
    {
        if (!_userWhoJoinedChatRepository.IsUserInChat(friendId, chatId) && _userRelationshipRepository.UserHasFriendWithStatus(myId, friendId, "ACCEPTED"))
        {
            UserWhoJoinedChat userWhoJoinedChat = new UserWhoJoinedChat
            {
                UserId = friendId,
                ChatId = chatId
            };
            _userWhoJoinedChatRepository.Insert(userWhoJoinedChat);
            _userWhoJoinedChatRepository.Save();
        }
    }

    public Chat CreateChat(string name, Guid ownerId)
    {
        Chat chat = new Chat
        {
            ChatId = Guid.NewGuid(),
            Name = name,
            OwnerUserId = ownerId
        };
        _chatRepository.Insert(chat);
        _chatRepository.Save();

        return chat;
    }

    public List<Tuple<Chat, VoiceRecording?>> GetChatsICreated(Guid myId)
    {
        List<Chat> chats = _chatRepository.GetChatsWithOwnerUserId(myId);
        List<Tuple<Chat, VoiceRecording?>> chatList = new List<Tuple<Chat, VoiceRecording?>>();
        foreach(Chat chat in chats)
        {
            ChatsVoiceRecording? latestChatVoiceRecording = _chatVoiceRecordingRepository.GetLatestChatVoiceRecordingWithChatId(chat.ChatId);
            VoiceRecording? voiceRecording = null;
            if (latestChatVoiceRecording != null)
            {
                voiceRecording = _voiceRecordingRepository.GetById(latestChatVoiceRecording.VoiceRecordingId);
            }

            chatList.Add(new Tuple<Chat, VoiceRecording?>(chat, voiceRecording));

        }

        return chatList;
    }

    public List<Tuple<Chat, VoiceRecording?>> GetJointedChats(Guid myId)
    {
        List<UserWhoJoinedChat> userWhoJoinedChats = _userWhoJoinedChatRepository.GetChatIdWhereUserWithIdJointed(myId);

        List<Tuple<Chat, VoiceRecording?>> chats = new List<Tuple<Chat, VoiceRecording?>>();
        foreach (UserWhoJoinedChat userWhoJoinedChat in userWhoJoinedChats)
        {
            Chat chat = _chatRepository.GetById(userWhoJoinedChat.ChatId);

            ChatsVoiceRecording? latestChatVoiceRecording = _chatVoiceRecordingRepository.GetLatestChatVoiceRecordingWithChatId(chat.ChatId);
            VoiceRecording? voiceRecording = null;
            if (latestChatVoiceRecording != null)
            {
                voiceRecording = _voiceRecordingRepository.GetById(latestChatVoiceRecording.VoiceRecordingId);
            }

            if (chat != null)
            {
                chats.Add(new Tuple<Chat, VoiceRecording?>(chat, voiceRecording));
            }
        }

        return chats;
    }

    public List<User> GetUsersInChat(Guid chatId)
    {
        List<UserWhoJoinedChat> userWhoJoinedChats = _userWhoJoinedChatRepository.GetUsersWhoJoinedChatWithChatId(chatId);

        List<User> users = new List<User>();
        foreach (UserWhoJoinedChat userWhoJoinedChat in userWhoJoinedChats)
        {
            User user = _userRepository.GetById(userWhoJoinedChat.UserId);

            if (user != null)
            {
                users.Add(user);
            }
        }

        return users;
    }

    // TODO W razie problemow z wydajnoscia zmienic na pojedyncze odpytanie z bazy danych
    public List<VoiceRecording> GetVoiceRecordingsInChat(Guid chatId)
    {
        List<ChatsVoiceRecording> chatsVoiceRecordings = _chatVoiceRecordingRepository.GetChatVoiceRecordingWithChatId(chatId);
        chatsVoiceRecordings.Sort((x, y) => x.DataOfAdded.CompareTo(y.DataOfAdded));

        List<VoiceRecording> voiceRecordings = new List<VoiceRecording>();
        foreach (ChatsVoiceRecording chatVoiceRecording in chatsVoiceRecordings)
        {
            VoiceRecording voiceRecording = _voiceRecordingRepository.GetById(chatVoiceRecording.VoiceRecordingId);

            if (voiceRecording != null)
            {
                voiceRecordings.Add(voiceRecording);
            }
        }

        return voiceRecordings;
    }

    public VoiceRecording? GetLatestVoiceRecordingInChat(Guid chatId)
    {
        ChatsVoiceRecording? latestChatVoiceRecording = _chatVoiceRecordingRepository.GetLatestChatVoiceRecordingWithChatId(chatId);
        if (latestChatVoiceRecording != null)
        {
            VoiceRecording voiceRecording = _voiceRecordingRepository.GetById(latestChatVoiceRecording.VoiceRecordingId);
            return voiceRecording;
        }
        return null;
    }
}
