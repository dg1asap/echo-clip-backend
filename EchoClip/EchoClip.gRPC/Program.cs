using EchoClip.gRPC.Services;
using EchoClip.Models;
using EchoClip.Services.Implementations;
using EchoClip.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGrpc();
builder.Services.AddDbContext<DatabaseEchoClipContext>(
    o => o.UseNpgsql(builder.Configuration.GetConnectionString("database"))
    );
builder.Services.AddScoped<IAuthService, AuthService>();
//builder.Services.AddScoped<AuthController, IAuthService>();

var app = builder.Build();

app.MapGrpcService<GreeterController>();
app.MapGrpcService<AuthController>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
