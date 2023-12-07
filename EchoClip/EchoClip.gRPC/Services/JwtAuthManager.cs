using EchoClip.gRPC.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EchoClip.gRPC.Services
{
    public class JwtAuthManager
    {
        public const string JWT_TOKEN_KEY = "bceec74c6566995de11fbeda032c3f7e4ba04d282b9106e424a018fa8bdaac72"; // TODO Wymyslony! Zmienic na Produkcji!!!!
        private const int JWT_TOKEN_VALIDITY = 30;
        private ICredentialsValidator _credentialsValidator;

        public JwtAuthManager(ICredentialsValidator credentialsValidator)
        {
            _credentialsValidator = credentialsValidator;
        }

        public AuthResponse Authenticate(AuthRequest authRequest)
        {
            if (!_credentialsValidator.validLogin(authRequest.Login, authRequest.Password))
            {
                return null;
            }
               
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.ASCII.GetBytes(JWT_TOKEN_KEY);
            var tokenExpireDataTime = DateTime.Now.AddMinutes(JWT_TOKEN_VALIDITY);
            var securityTokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new List<Claim>
                {
                    new Claim("username", authRequest.Login),  // TODO tu do sprawdzenia czy bedzie dzialalo i dla logowania przy pomocy loginu: username i email
                    new Claim(ClaimTypes.Role, "Administrator")
                }),
                Expires = tokenExpireDataTime,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };

            var securityToken = jwtSecurityTokenHandler.CreateToken(securityTokenDescriptor);
            var token = jwtSecurityTokenHandler.WriteToken(securityToken);

            return new AuthResponse
            {
                AccessToken = token,
                ExpiresIn = (int)tokenExpireDataTime.Subtract(DateTime.Now).TotalSeconds
            };
        }
    }
}
