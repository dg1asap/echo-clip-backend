using EchoClip.Models;
using EchoClip.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EchoClip.Repositories.Implementations;

public class UserRelationshipRepository : GenericRepository<UserRelationship>, IUserRelationshipRepository
{
    public UserRelationshipRepository(DatabaseEchoClipContext context) : base(context) { }

    public List<UserRelationship> GetUserRelationshipsWithUserFriendIdAndStatus(Guid userFriendId, string relation)
    {
        return _table.Where(e => e.UserFriendId == userFriendId && e.Status == relation).ToList();
    }

    public List<UserRelationship> GetUserRelationshipsWithUserIdAndStatus(Guid userId, string relation)
    {
        return _table.Where(e => e.UserId == userId && e.Status == relation).ToList();
    }

    public bool UserHasFriendWithStatus(Guid myId, Guid friendId, string status)
    {
        return _table.Any(e => e.UserId == myId && e.UserFriendId == friendId && e.Status == status);
    }

    public bool UserHasRelationWithFriend(Guid userId, Guid friendId)
    {
        return _table.Any(e => ((e.UserId == userId && e.UserFriendId == friendId) || (e.UserFriendId == userId && e.UserId == friendId)));
    }

    public bool UserHasRelationWithFriendAndStatus(Guid userId, Guid friendId, string[] status)
    {
        return _table.Any(e => ((e.UserId == userId && e.UserFriendId == friendId) || (e.UserFriendId == userId && e.UserId == friendId)) && status.Contains(e.Status));
    }
}
