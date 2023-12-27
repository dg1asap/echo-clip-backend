using EchoClip.Models;

namespace EchoClip.Repositories.Interfaces;

public interface IUserWhoJoinedChatRepository : IGenericRepository<UserWhoJoinedChat>
{
    List<UserWhoJoinedChat> GetChatIdWhereUserWithIdJointed(Guid myId);
    List<UserWhoJoinedChat> GetUsersWhoJoinedChatWithChatId(Guid chatId);
}
