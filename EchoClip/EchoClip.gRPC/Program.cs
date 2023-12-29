using EchoClip.gRPC.Services;
using EchoClip.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using EchoClip.gRPC.Interfaces;
using EchoClip.gRPC.Implementations;
using EchoClip.Repositories.Interfaces;
using EchoClip.Repositories.Implementations;
using EchoClip.Services.Implementations;

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

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

builder.Services.AddAuthentication();
builder.Services.AddAuthorization(); // SSS-------

builder.Services.AddGrpc();
builder.Services.AddDbContext<DatabaseEchoClipContext>(
    o => o.UseNpgsql(builder.Configuration.GetConnectionString("database"))
    );
builder.Services.AddScoped<ICredentialsValidator, CredentialsValidator>();
builder.Services.AddScoped<JwtAuthManager>();

builder.Services.AddScoped<IChatRepository, ChatRepository>();
builder.Services.AddScoped<IChatVoiceRecordingRepository, ChatVoiceRecordingRepository>();
builder.Services.AddScoped<IUserRelationshipRepository, UserRelationshipRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserWhoJoinedChatRepository, UserWhoJoinedChatRepository>();
builder.Services.AddScoped<IVoiceRecordingRepository, VoiceRecordingRepository>();

builder.Services.AddScoped<IChatService, ChatService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IVoiceRecordingService, VoiceRecordingService>();
builder.Services.AddScoped<UserFromTokenReader>();

builder.Services.AddHttpContextAccessor();
var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

app.MapGrpcService<AuthController>();
app.MapGrpcService<ChatController>();
app.MapGrpcService<GreeterController>();
app.MapGrpcService<UserController>();
app.MapGrpcService<VoiceRecordingController>();

/*app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");
*/
app.Run();
