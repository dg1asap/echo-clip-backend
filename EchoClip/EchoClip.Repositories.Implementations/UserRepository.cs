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

        public bool IsUserWithNameOrEmailAndPassword(string username, string email, string password)
        {
            return _context.Users.Any(u => (u.Username == username || u.Email == email) && u.Password == password);
        }

        public bool IsUserWithNameOrEmailOrPassword(string username, string email, string password)
        {
            return _context.Users.Any(u => u.Username == username || u.Email == email || u.Password == password);
        }

        public void AddUser(Users user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public Guid? GetUserGUIDFormUsernameOrEmail(string username, string email)
        {
            return _context.Users
                .Where(u => u.Username == username || u.Email == email)
                .Select(u => u.User_id)
                .FirstOrDefault();
        }
    }
}
