using EchoClip.gRPC.Interfaces;
using EchoClip.Repositories.Interfaces;

namespace EchoClip.gRPC.Implementations;

public class CredentialsValidator(IUserRepository userRepository) : ICredentialsValidator
{
    public bool validLogin(string login, string password)
    {
        return userRepository.IsUserWithNameOrEmailAndPassword(login, login, password);
    }
}
