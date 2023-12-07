using EchoClip.gRPC.Services;
using EchoClip.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(JwtAuthManager.JWT_TOKEN_KEY)),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});

builder.Services.AddAuthentication();
builder.Services.AddAuthorization(); // SSS-------

builder.Services.AddGrpc();
builder.Services.AddDbContext<DatabaseEchoClipContext>(
    o => o.UseNpgsql(builder.Configuration.GetConnectionString("database"))
    );
builder.Services.AddScoped<JwtAuthManager>();
/*builder.Services.AddScoped<IAuthService, AuthService>();*/
//builder.Services.AddScoped<AuthController, IAuthService>();

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

app.MapGrpcService<AuthController>();
app.MapGrpcService<GreeterController>();

/*app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");
*/
app.Run();
