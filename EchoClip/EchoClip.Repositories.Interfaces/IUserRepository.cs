using EchoClip.Models;

namespace EchoClip.Repositories.Interfaces
{
    public interface IUserRepository
    {
        void addUser(User user);
        bool isUserWithNameOrEmailAndPassword(string username, string email, string password);
        bool isUserWithNameOrEmailOrPassword(string username, string email, string password);
    }
}