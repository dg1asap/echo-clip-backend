using EchoClip.Models;
using EchoClip.Repositories.Interfaces;

namespace EchoClip.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly DatabaseEchoClipContext _context;

        public UserRepository(DatabaseEchoClipContext context)
        {
            _context = context;
        }

        public bool isUserWithNameOrEmailAndPassword(string username, string email, string password)
        {
            return _context.Users.Any(u => (u.Username == username || u.Email == email) && u.Password == password);
        }

        public bool isUserWithNameOrEmailOrPassword(string username, string email, string password)
        {
            return _context.Users.Any(u => u.Username == username || u.Email == email || u.Password == password);
        }

        public void addUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}
