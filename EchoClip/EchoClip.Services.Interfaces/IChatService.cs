using EchoClip.Models;

namespace EchoClip.gRPC.Interfaces
{
    public interface IChatService
    {
        void AddVoiceRecordingToChat(Guid voiceRecordingId, Guid czatId);
        void AddFriendToChat(Guid myId, Guid friendId, Guid chatId);
        Chat CreateChat(string name, Guid ownerId);
        List<Tuple<Chat, VoiceRecording?>> GetChatsICreated(Guid myId);
        List<Tuple<Chat,VoiceRecording?>> GetJointedChats(Guid myId);
        List<User> GetUsersInChat(Guid czatId);
        List<VoiceRecording> GetVoiceRecordingsInChat(Guid chatId);
        VoiceRecording? GetLatestVoiceRecordingInChat(Guid chatId);
    }
}