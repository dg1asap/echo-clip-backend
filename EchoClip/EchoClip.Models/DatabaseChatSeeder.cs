using Microsoft.EntityFrameworkCore;

namespace EchoClip.Models;

public class DatabaseChatSeeder : IDatabaseSeeder
{
    public void seedData(ModelBuilder modlerBuilder)
    {
        modlerBuilder.Entity<Chat>().HasData(
            new Chat
            {
                ChatId = Guid.Parse("8c2c8480-978f-4a8f-89ac-a70a49bed05a"),
                Name = "Tango Quebec",
                OwnerUserId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
            },
            new Chat
            {
                ChatId = Guid.Parse("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"),
                Name = "Alfa Golf",
                OwnerUserId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
            },
            new Chat
            {
                ChatId = Guid.Parse("8b854df4-b93f-421b-8f52-76c7bf95fde9"),
                Name = "Lima Sierra Bravo",
                OwnerUserId = Guid.Parse("81e75865-2b69-4440-af1d-bcbd2817abbe"),
            },
            new Chat
            {
                ChatId = Guid.Parse("7999d70a-1a31-428e-9078-3c392dc1f4a8"),
                Name = "Victor X-ray",
                OwnerUserId = Guid.Parse("70693fa5-9180-4f05-854d-5d86aa286535"),
            },
            new Chat
            {
                ChatId = Guid.Parse("ffda4624-660e-46a1-8a71-74e685fe6353"),
                Name = "Papa Zulu",
                OwnerUserId = Guid.Parse("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"),
            },
            new Chat
            {
                ChatId = Guid.Parse("ec719221-7073-4694-897f-bfeabc02c22e"),
                Name = "Yankee",
                OwnerUserId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
            },
            new Chat
            {
                ChatId = Guid.Parse("4189917d-7073-405b-8c47-a391f23fa31b"),
                Name = "Delta Uniform",
                OwnerUserId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
            }
        );
    }
}
