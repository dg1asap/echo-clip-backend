using EchoClip.Models;

namespace EchoClip.Repositories.Interfaces
{
    public interface IUserRepository
    {
        void AddUser(User user);
        bool IsUserWithNameOrEmaiAndPassword(string username, string email, string password);
    }
}