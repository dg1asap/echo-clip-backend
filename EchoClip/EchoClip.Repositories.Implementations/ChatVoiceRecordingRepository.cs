using EchoClip.Models;
using EchoClip.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EchoClip.Repositories.Implementations;

public class ChatVoiceRecordingRepository : GenericRepository<ChatsVoiceRecording>, IChatVoiceRecordingRepository
{
    public ChatVoiceRecordingRepository(DatabaseEchoClipContext context) : base(context) { }

    public List<ChatsVoiceRecording> GetChatVoiceRecordingWithChatId(Guid chatId)
    {
        return _table.Where(e => e.ChatId == chatId).ToList();
    }
}
