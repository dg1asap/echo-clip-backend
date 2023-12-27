using EchoClip.Models;
using EchoClip.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EchoClip.Repositories.Implementations;

public class UserRelationshipRepository : GenericRepository<UserRelationship>, IUserRelationshipRepository
{
    public UserRelationshipRepository(DatabaseEchoClipContext context) : base(context) { }

    public List<UserRelationship> GetUserRelationshipsWithUserFriendIdAndStatus(Guid userId, string relation)
    {
        return _table.Where(e => e.UserFriendId == userId && e.Status == relation).ToList();
    }

    public List<UserRelationship> GetUserRelationshipsWithUserIdAndStatus(Guid userId, string relation)
    {
        throw new NotImplementedException();
    }
}
