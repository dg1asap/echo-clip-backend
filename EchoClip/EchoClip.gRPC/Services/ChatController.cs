using EchoClip.gRPC.Interfaces;
using EchoClip.Models;
using Grpc.Core;

namespace EchoClip.gRPC.Services; 

class ChatController(ILogger<AuthController> logger, IChatService chatService, UserFromTokenReader userFromTokenReader) : gRPC.ChatController.ChatControllerBase
{
    private readonly ILogger<AuthController> _logger = logger;
    private readonly IChatService _chatService;
    private readonly UserFromTokenReader _userFromTokenReader = userFromTokenReader;

    public override Task<AddVoiceRecordingToChatResponse> AddVoiceRecordingToChat(AddVoiceRecordingToChatRequest request, ServerCallContext context)
    {
        _chatService.AddVoiceRecordingToChat(Guid.Parse(request.VoiceRecordingId), Guid.Parse(request.ChatId));
        return Task.FromResult(new AddVoiceRecordingToChatResponse{});
    }

    public override Task<CreateChatResponse> CreateChat(CreateChatRequest request, ServerCallContext context)
    {
        Guid myId = _userFromTokenReader.GetUserGUID() ?? throw new RpcException(new Status(StatusCode.InvalidArgument, "To nie jest mój guid!"));

        _chatService.CreateChat(request.Name, myId);

        return Task.FromResult(new CreateChatResponse{});
    }

    public override Task<GetChatsICreatedResponse> GetChatsICreated(GetChatsICreatedRequest request, ServerCallContext context)
    {
        Guid myId = _userFromTokenReader.GetUserGUID() ?? throw new RpcException(new Status(StatusCode.InvalidArgument, "To nie jest mój guid!"));
        List<Chat> chats = _chatService.GetChatsICreated(myId);
        List<UserChatMessage> usersChatMessage = chats.Select(
            chat => new UserChatMessage
            {
                Id = chat.ChatId.ToString(),
                Name = chat.Name
            }).ToList();

        return Task.FromResult(new GetChatsICreatedResponse
        {
            CreatedChats = { usersChatMessage }
        });
    }

    public override Task<GetJointedChatsResponse> GetJointedChats(GetJointedChatsRequest request, ServerCallContext context)
    {
        Guid myId = _userFromTokenReader.GetUserGUID() ?? throw new RpcException(new Status(StatusCode.InvalidArgument, "To nie jest mój guid!"));
        List<Chat> chats = _chatService.GetJointedChats(myId);
        List<UserChatMessage> usersChatMessage = chats.Select(
            chat => new UserChatMessage
            {
                Id = chat.ChatId.ToString(),
                Name = chat.Name
            }).ToList();

        return Task.FromResult(new GetJointedChatsResponse
        {
            JointedChats = { usersChatMessage }
        });
    }

    public override Task<GetUsersInChatResponse> GetUsersInChat(GetUsersInChatRequest request, ServerCallContext context)
    {
        List<User> users = _chatService.GetUsersInChat(Guid.Parse(request.ChatId));
        List<UserFromChatMessage> usersFromChatMessages = users.Select(
            user => new UserFromChatMessage
            {
                Username = user.Username,
                Name = user.Name,
                Surname = user.Surname
            }).ToList();

        return Task.FromResult(new GetUsersInChatResponse
        {
            UserFromChatMessage = { usersFromChatMessages }
        });
    }

    public override Task<GetVoiceRecordingsInChatResponse> GetVocieRocrdingsInChat(GetVoiceRecordingsInChatRequest request, ServerCallContext context)
    {
        List<VoiceRecording> voiceRecordings = _chatService.GetVoiceRecordingsInChat(Guid.Parse(request.ChatId));
        List<VoiceRecodringInChatMessage> voiceRecodringInChatMessages = voiceRecordings.Select(
            voiceRecording => new VoiceRecodringInChatMessage {
                Id = voiceRecording.VoiceRecordingId.ToString(),
                Name = voiceRecording.Name
        }).ToList();
         
        return Task.FromResult(new GetVoiceRecordingsInChatResponse
        {
            VoiceRecodringInChatInfo = { voiceRecodringInChatMessages }
        });
    }
}
