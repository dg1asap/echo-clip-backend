using EchoClip.gRPC.Interfaces;
using EchoClip.Models;

namespace EchoClip.Services.Implementations;

public class ChatService : IChatService
{
    public void AddVoiceRecordingToChat(string voiceRecordingId, string czatId)
    {
        throw new NotImplementedException();
    }

    public void CreateChat(string name)
    {
        throw new NotImplementedException();
    }

    public List<Chat> GetChatsICreated(Guid myId)
    {
        throw new NotImplementedException();
    }

    public List<Chat> GetJointedChats(Guid myId)
    {
        throw new NotImplementedException();
    }

    public List<User> GetUsersInChat(string czatId)
    {
        throw new NotImplementedException();
    }

    public List<VoiceRecording> GetVocieRocrdingsInChat(string chatId)
    {
        throw new NotImplementedException();
    }
}
