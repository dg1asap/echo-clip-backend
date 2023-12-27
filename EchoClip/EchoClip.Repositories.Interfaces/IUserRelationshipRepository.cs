using EchoClip.Models;

namespace EchoClip.Repositories.Interfaces;

public interface IUserRelationshipRepository : IGenericRepository<UserRelationship>
{
    List<UserRelationship> GetUserRelationshipsWithUserFriendIdAndStatus(Guid userId, string relation);
    List<UserRelationship> GetUserRelationshipsWithUserIdAndStatus(Guid userId, string relation);
}
