using EchoClip.Models;

namespace EchoClip.gRPC.Interfaces
{
    public interface IChatService
    {
        void AddVoiceRecordingToChat(string voiceRecordingId, string czatId);
        void CreateChat(string name);
        List<Chat> GetChatsICreated(Guid myId);
        List<Chat> GetJointedChats(Guid myId);
        List<User> GetUsersInChat(string czatId);
        List<VoiceRecording> GetVocieRocrdingsInChat(string chatId);
    }
}