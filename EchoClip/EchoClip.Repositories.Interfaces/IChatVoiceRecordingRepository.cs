using EchoClip.Models;

namespace EchoClip.Repositories.Interfaces;

public interface IChatVoiceRecordingRepository : IGenericRepository<ChatsVoiceRecording>
{
    List<ChatsVoiceRecording> GetChatVoiceRecordingWithChatId(Guid chatId);

    ChatsVoiceRecording? GetLatestChatVoiceRecordingWithChatId(Guid chatId);
}
