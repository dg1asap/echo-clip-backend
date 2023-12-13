using EchoClip.Models;

namespace EchoClip.Repositories.Interfaces
{
    public interface IUserRepository
    {
        void AddUser(User user);
        bool IsUserWithNameOrEmailAndPassword(string username, string email, string password);
        bool IsUserWithNameOrEmailOrPassword(string username, string email, string password);
        Guid? GetUserGUIDFormUsernameOrEmail(string username, string email);
    }
}