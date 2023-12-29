using EchoClip.Models;

namespace EchoClip.gRPC.Interfaces
{
    public interface IChatService
    {
        void AddVoiceRecordingToChat(Guid voiceRecordingId, Guid czatId);
        void AddFriendToChat(Guid myId, Guid friendId, Guid chatId);
        void CreateChat(string name, Guid ownerId);
        List<Chat> GetChatsICreated(Guid myId);
        List<Chat> GetJointedChats(Guid myId);
        List<User> GetUsersInChat(Guid czatId);
        List<VoiceRecording> GetVoiceRecordingsInChat(Guid chatId);
    }
}