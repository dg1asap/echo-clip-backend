using EchoClip.Models;
using EchoClip.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EchoClip.Repositories.Implementations;

public class ChatRepository : GenericRepository<Chat>, IChatRepository
{
    public ChatRepository(DatabaseEchoClipContext context) : base(context) { }

    public List<Chat> GetChatsWithOwnerUserId(Guid myId)
    {
        return _table.Where(e => e.OwnerUserId == myId).ToList();
    }
}
