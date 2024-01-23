using EchoClip.gRPC.Interfaces;
using EchoClip.Models;
using EchoClip.Repositories.Interfaces;

namespace EchoClip.gRPC.Implementations;

public class UserService(IUserRepository userRepository,
    IUserRelationshipRepository userRelationshipRepository) : IUserService
{
    private readonly IUserRepository _userRepository = userRepository;

    private readonly IUserRelationshipRepository _userRelationshipRepository = userRelationshipRepository;

    public void CreateUser(string username, string password, string email, string name, string surname) //TODO [Prioritet: LOW] Jak w .NET Core robić pojedyncza tranzakcje na 2 zapytania bazodanowe?
    {
        if (userRepository.IsUserWithNameOrEmailOrPassword(username, email, password))
        {
            throw new Exception("This user exist, change login data");
        }

        User newUser = new User
        {
            UserId = Guid.NewGuid(),
            Username = username,
            Password = password,
            Email = email,
            Name = name,
            Surname = surname
        };

        userRepository.Insert(newUser);
        userRepository.Save();
    }

    public Guid? GetUserGuidFromUsernameOrEmail(string username, string email) => userRepository.GetUserGUIDFormUsernameOrEmail(username, email);

    // TODO myId zmienic na bardziej ogolna nazwe
    public List<User> GetUsersThatUserSetStatus(Guid userId, string relation)
    {
        List<UserRelationship> userRelationships = _userRelationshipRepository.GetUserRelationshipsWithUserIdAndStatus(userId, relation);

        List<User> user = new List<User>();
        foreach (UserRelationship userRelationship in userRelationships)
        {
            User userFriend = _userRepository.GetById(userRelationship.UserFriendId);

            if (userFriend != null) 
            {
                user.Add(userFriend);
            }
        }
        return user;
    }

    // TODO myId zmienic na bardziej ogolna nazwe
    public List<User> GetUsersWhoSetUserStatus(Guid userId, string relation)
    {
        List<UserRelationship> userRelationships = _userRelationshipRepository.GetUserRelationshipsWithUserFriendIdAndStatus(userId, relation);

        List<User> user = new List<User>();
        foreach (UserRelationship userRelationship in userRelationships)
        {
            User userFriend = _userRepository.GetById(userRelationship.UserId);

            if (userFriend != null)
            {
                user.Add(userFriend);
            }
        }
        return user;
    }

    public void SetRelationToUser(Guid userId, Guid userFriendId, string relation)
    {
        UserRelationship userRelationship = new UserRelationship
        {
            UserId = userId,
            UserFriendId = userFriendId,
            Status = relation
        };
        _userRelationshipRepository.Insert(userRelationship);
        _userRelationshipRepository.Save();
    }

    public User? GetUser(Guid userId)
    {
        User? user = _userRepository.GetById(userId);
        return user;
    }

    public List<User> GetUsersWithoutRelation(Guid userId)
    {
        var users = _userRepository.GetAll();

        List<User> userWithoutRelation = new List<User>();

        foreach (var user in users)
        {
            if(!_userRelationshipRepository.UserHasRelationWithFriend(userId, user.UserId) && userId != user.UserId)
            {
                userWithoutRelation.Add(user);
            }   
        }

        return userWithoutRelation;
    }
}
