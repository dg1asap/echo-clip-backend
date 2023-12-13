namespace EchoClip.gRPC.Interfaces
{
    public interface IUserService
    {
        void createUser(string username, string password, string email);
    }
}