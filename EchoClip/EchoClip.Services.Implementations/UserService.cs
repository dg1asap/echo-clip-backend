using EchoClip.gRPC.Interfaces;
using EchoClip.Models;
using EchoClip.Repositories.Interfaces;

namespace EchoClip.gRPC.Implementations;

public class UserService : IUserService
{
    private IUserRepository _userRepository;

    public UserService(IUserRepository userRepository) {
        _userRepository = userRepository;
    }

    public void CreateUser(string username, string password, string email) //TODO [Prioritet: LOW] Jak w .NET Core robić pojedyncza tranzakcje na 2 zapytania bazodanowe?
    {
        if (_userRepository.IsUserWithNameOrEmailOrPassword(username, email, password))
        {
            throw new Exception("This user exist, change login data");
        }

        User newUser = new User
        {
            UserId = Guid.NewGuid(),
            Username = username,
            Password = password,
            Email = email
        };

        _userRepository.AddUser(newUser);
    }

    public Guid? GetUserGuidFromUsernameOrEmail(string username, string email) => _userRepository.GetUserGUIDFormUsernameOrEmail(username, email);

    public List<User> GetUsersThatUserSetStatus(Guid myId, string relation)
    {
        throw new NotImplementedException();
    }

    public List<User> GetUsersWhoSetUserStatus(Guid myId, string relation)
    {
        throw new NotImplementedException();
    }

    public void SetRelationToUser(Guid myId, Guid userFriendId, string relation)
    {
        throw new NotImplementedException();
    }
}
