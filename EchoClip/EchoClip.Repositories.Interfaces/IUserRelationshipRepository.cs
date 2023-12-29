using EchoClip.Models;

namespace EchoClip.Repositories.Interfaces;

public interface IUserRelationshipRepository : IGenericRepository<UserRelationship>
{
    List<UserRelationship> GetUserRelationshipsWithUserFriendIdAndStatus(Guid userFriendId, string relation);
    List<UserRelationship> GetUserRelationshipsWithUserIdAndStatus(Guid userId, string relation);
    bool UserHasFriendWithStatus(Guid myId, Guid friendId, string status);
}
