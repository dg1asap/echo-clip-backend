namespace EchoClip.gRPC.Interfaces
{
    public interface ICredentialsValidator
    {
        bool validLogin(string login, string password);
    }
}