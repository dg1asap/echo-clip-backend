using EchoClip.Models;

namespace EchoClip.gRPC.Interfaces;

public interface IUserService
{
    void CreateUser(string username, string password, string email);
    Guid? GetUserGuidFromUsernameOrEmail(string username, string email);
    List<User> GetUsersThatUserSetStatus(Guid myId, string relation);
    List<User> GetUsersWhoSetUserStatus(Guid myId, string relation);
    void SetRelationToUser(Guid myId, Guid userFriendId, string relation);
}
