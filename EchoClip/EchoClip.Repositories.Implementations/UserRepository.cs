using EchoClip.Models;
using EchoClip.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EchoClip.Repositories.Implementations;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    public UserRepository(DatabaseEchoClipContext context) : base(context) { }

    public bool IsUserWithNameOrEmailAndPassword(string username, string email, string password)
    {
        return _table.Any(u => (u.Username == username || u.Email == email) && u.Password == password);
    }

    public bool IsUserWithNameOrEmailOrPassword(string username, string email, string password)
    {
        return _table.Any(u => u.Username == username || u.Email == email || u.Password == password);
    }

    public Guid? GetUserGUIDFormUsernameOrEmail(string username, string email)
    {
        return _table.Where(u => u.Username == username || u.Email == email)
            .Select(u => u.UserId)
            .FirstOrDefault();
    }

}
