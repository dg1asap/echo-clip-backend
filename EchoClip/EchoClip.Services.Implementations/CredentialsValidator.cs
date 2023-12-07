using EchoClip.gRPC.Interfaces;
using EchoClip.Repositories.Interfaces;

namespace EchoClip.gRPC.Implementations
{
    public class CredentialsValidator : ICredentialsValidator
    {
        private IUserRepository _userRepository;

        public CredentialsValidator(IUserRepository userRepository) {
            _userRepository = userRepository;
        }
        
        public bool validLogin(string login, string password)
        {
            return _userRepository.IsUserWithNameOrEmaiAndPassword(login, login, password);
        }
    }
}
