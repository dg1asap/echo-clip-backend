using EchoClip.Models;

namespace EchoClip.Repositories.Interfaces;

public interface IChatRepository : IGenericRepository<Chat>
{
    List<Chat> GetChatsWithOwnerUserId(Guid myId);
}
