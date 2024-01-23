using EchoClip.Models;

namespace EchoClip.gRPC.Interfaces;

public interface IUserService
{
    void CreateUser(string username, string password, string email, string name, string surname);
    Guid? GetUserGuidFromUsernameOrEmail(string username, string email);
    List<User> GetUsersThatUserSetStatus(Guid myId, string relation);
    List<User> GetUsersWhoSetUserStatus(Guid myId, string relation);
    void SetRelationToUser(Guid myId, Guid userFriendId, string relation);
    User? GetUser(Guid userId);
    List<User> GetUsersWithoutRelation(Guid userId);
}
