namespace EchoClip.gRPC.Interfaces
{
    public interface IUserService
    {
        void CreateUser(string username, string password, string email);
        Guid? GetUserGuidFromUsernameOrEmail(string username, string email);
    }
}
