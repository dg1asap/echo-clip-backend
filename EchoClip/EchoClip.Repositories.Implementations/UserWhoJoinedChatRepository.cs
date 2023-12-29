using EchoClip.Models;
using EchoClip.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EchoClip.Repositories.Implementations;

public class UserWhoJoinedChatRepository : GenericRepository<UserWhoJoinedChat>, IUserWhoJoinedChatRepository
{
    public UserWhoJoinedChatRepository(DatabaseEchoClipContext context) : base(context) { }

    public List<UserWhoJoinedChat> GetChatIdWhereUserWithIdJointed(Guid myId)
    {
        return _table.Where(e => e.UserId == myId).ToList();
    }

    public List<UserWhoJoinedChat> GetUsersWhoJoinedChatWithChatId(Guid chatId)
    {
        return _table.Where(e => e.ChatId == chatId).ToList();
    }

    public bool IsUserInChat(Guid userId, Guid chatId)
    {
        return _table.Any(e => e.UserId == userId && e.ChatId == chatId);
    }
}
