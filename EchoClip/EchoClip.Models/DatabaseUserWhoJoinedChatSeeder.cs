using Microsoft.EntityFrameworkCore;

namespace EchoClip.Models;

public class DatabaseUserWhoJoinedChatSeeder : IDatabaseSeeder
{
    public void seedData(ModelBuilder modlerBuilder)
    {
        modlerBuilder.Entity<UserWhoJoinedChat>().HasData(
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
                ChatId = Guid.Parse("8c2c8480-978f-4a8f-89ac-a70a49bed05a")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
                ChatId = Guid.Parse("3408c6f5-bcf0-467e-a068-b8b8bbb0689f")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
                ChatId = Guid.Parse("8b854df4-b93f-421b-8f52-76c7bf95fde9")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
                ChatId = Guid.Parse("7999d70a-1a31-428e-9078-3c392dc1f4a8")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
                ChatId = Guid.Parse("ffda4624-660e-46a1-8a71-74e685fe6353")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
                ChatId = Guid.Parse("4189917d-7073-405b-8c47-a391f23fa31b")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("81e75865-2b69-4440-af1d-bcbd2817abbe"),
                ChatId = Guid.Parse("8c2c8480-978f-4a8f-89ac-a70a49bed05a")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("81e75865-2b69-4440-af1d-bcbd2817abbe"),
                ChatId = Guid.Parse("8b854df4-b93f-421b-8f52-76c7bf95fde9")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("81e75865-2b69-4440-af1d-bcbd2817abbe"),
                ChatId = Guid.Parse("7999d70a-1a31-428e-9078-3c392dc1f4a8")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("81e75865-2b69-4440-af1d-bcbd2817abbe"),
                ChatId = Guid.Parse("ffda4624-660e-46a1-8a71-74e685fe6353")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("81e75865-2b69-4440-af1d-bcbd2817abbe"),
                ChatId = Guid.Parse("ec719221-7073-4694-897f-bfeabc02c22e")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("81e75865-2b69-4440-af1d-bcbd2817abbe"),
                ChatId = Guid.Parse("4189917d-7073-405b-8c47-a391f23fa31b")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("70693fa5-9180-4f05-854d-5d86aa286535"),
                ChatId = Guid.Parse("8c2c8480-978f-4a8f-89ac-a70a49bed05a")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("70693fa5-9180-4f05-854d-5d86aa286535"),
                ChatId = Guid.Parse("7999d70a-1a31-428e-9078-3c392dc1f4a8")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("70693fa5-9180-4f05-854d-5d86aa286535"),
                ChatId = Guid.Parse("ffda4624-660e-46a1-8a71-74e685fe6353")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("70693fa5-9180-4f05-854d-5d86aa286535"),
                ChatId = Guid.Parse("ec719221-7073-4694-897f-bfeabc02c22e")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("70693fa5-9180-4f05-854d-5d86aa286535"),
                ChatId = Guid.Parse("4189917d-7073-405b-8c47-a391f23fa31b")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"),
                ChatId = Guid.Parse("8c2c8480-978f-4a8f-89ac-a70a49bed05a")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"),
                ChatId = Guid.Parse("8b854df4-b93f-421b-8f52-76c7bf95fde9")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"),
                ChatId = Guid.Parse("7999d70a-1a31-428e-9078-3c392dc1f4a8")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"),
                ChatId = Guid.Parse("ffda4624-660e-46a1-8a71-74e685fe6353")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"),
                ChatId = Guid.Parse("ec719221-7073-4694-897f-bfeabc02c22e")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"),
                ChatId = Guid.Parse("4189917d-7073-405b-8c47-a391f23fa31b")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
                ChatId = Guid.Parse("8c2c8480-978f-4a8f-89ac-a70a49bed05a")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
                ChatId = Guid.Parse("3408c6f5-bcf0-467e-a068-b8b8bbb0689f")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
                ChatId = Guid.Parse("4189917d-7073-405b-8c47-a391f23fa31b")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
                ChatId = Guid.Parse("8b854df4-b93f-421b-8f52-76c7bf95fde9")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
                ChatId = Guid.Parse("7999d70a-1a31-428e-9078-3c392dc1f4a8")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
                ChatId = Guid.Parse("ffda4624-660e-46a1-8a71-74e685fe6353")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
                ChatId = Guid.Parse("ec719221-7073-4694-897f-bfeabc02c22e")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"),
                ChatId = Guid.Parse("8c2c8480-978f-4a8f-89ac-a70a49bed05a")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"),
                ChatId = Guid.Parse("3408c6f5-bcf0-467e-a068-b8b8bbb0689f")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"),
                ChatId = Guid.Parse("ffda4624-660e-46a1-8a71-74e685fe6353")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"),
                ChatId = Guid.Parse("ec719221-7073-4694-897f-bfeabc02c22e")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"),
                ChatId = Guid.Parse("4189917d-7073-405b-8c47-a391f23fa31b")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("fc029e14-d132-4bf3-a958-490d18320df7"),
                ChatId = Guid.Parse("8c2c8480-978f-4a8f-89ac-a70a49bed05a")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("fc029e14-d132-4bf3-a958-490d18320df7"),
                ChatId = Guid.Parse("3408c6f5-bcf0-467e-a068-b8b8bbb0689f")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("fc029e14-d132-4bf3-a958-490d18320df7"),
                ChatId = Guid.Parse("ec719221-7073-4694-897f-bfeabc02c22e")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("fc029e14-d132-4bf3-a958-490d18320df7"),
                ChatId = Guid.Parse("4189917d-7073-405b-8c47-a391f23fa31b")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("1b854f16-2261-42b1-a614-5f9106a03b63"),
                ChatId = Guid.Parse("8b854df4-b93f-421b-8f52-76c7bf95fde9")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("1b854f16-2261-42b1-a614-5f9106a03b63"),
                ChatId = Guid.Parse("7999d70a-1a31-428e-9078-3c392dc1f4a8")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("1b854f16-2261-42b1-a614-5f9106a03b63"),
                ChatId = Guid.Parse("ffda4624-660e-46a1-8a71-74e685fe6353")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("1b854f16-2261-42b1-a614-5f9106a03b63"),
                ChatId = Guid.Parse("4189917d-7073-405b-8c47-a391f23fa31b")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("c9772f81-2145-4338-ad2d-9504b4b3dc6a"),
                ChatId = Guid.Parse("8c2c8480-978f-4a8f-89ac-a70a49bed05a")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("c9772f81-2145-4338-ad2d-9504b4b3dc6a"),
                ChatId = Guid.Parse("3408c6f5-bcf0-467e-a068-b8b8bbb0689f")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("c9772f81-2145-4338-ad2d-9504b4b3dc6a"),
                ChatId = Guid.Parse("8b854df4-b93f-421b-8f52-76c7bf95fde9")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("c9772f81-2145-4338-ad2d-9504b4b3dc6a"),
                ChatId = Guid.Parse("7999d70a-1a31-428e-9078-3c392dc1f4a8")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("c9772f81-2145-4338-ad2d-9504b4b3dc6a"),
                ChatId = Guid.Parse("ffda4624-660e-46a1-8a71-74e685fe6353")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("c9772f81-2145-4338-ad2d-9504b4b3dc6a"),
                ChatId = Guid.Parse("4189917d-7073-405b-8c47-a391f23fa31b")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"),
                ChatId = Guid.Parse("8c2c8480-978f-4a8f-89ac-a70a49bed05a")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"),
                ChatId = Guid.Parse("3408c6f5-bcf0-467e-a068-b8b8bbb0689f")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"),
                ChatId = Guid.Parse("8b854df4-b93f-421b-8f52-76c7bf95fde9")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"),
                ChatId = Guid.Parse("7999d70a-1a31-428e-9078-3c392dc1f4a8")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"),
                ChatId = Guid.Parse("ffda4624-660e-46a1-8a71-74e685fe6353")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"),
                ChatId = Guid.Parse("ec719221-7073-4694-897f-bfeabc02c22e")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"),
                ChatId = Guid.Parse("4189917d-7073-405b-8c47-a391f23fa31b")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("57692189-acbb-4aa2-b2c9-6a5291e611af"),
                ChatId = Guid.Parse("8c2c8480-978f-4a8f-89ac-a70a49bed05a")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("57692189-acbb-4aa2-b2c9-6a5291e611af"),
                ChatId = Guid.Parse("3408c6f5-bcf0-467e-a068-b8b8bbb0689f")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("57692189-acbb-4aa2-b2c9-6a5291e611af"),
                ChatId = Guid.Parse("8b854df4-b93f-421b-8f52-76c7bf95fde9")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("57692189-acbb-4aa2-b2c9-6a5291e611af"),
                ChatId = Guid.Parse("ffda4624-660e-46a1-8a71-74e685fe6353")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("57692189-acbb-4aa2-b2c9-6a5291e611af"),
                ChatId = Guid.Parse("ec719221-7073-4694-897f-bfeabc02c22e")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("57692189-acbb-4aa2-b2c9-6a5291e611af"),
                ChatId = Guid.Parse("4189917d-7073-405b-8c47-a391f23fa31b")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("8bc1ae99-62b1-4c3b-936a-ed89898adceb"),
                ChatId = Guid.Parse("8c2c8480-978f-4a8f-89ac-a70a49bed05a")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("8bc1ae99-62b1-4c3b-936a-ed89898adceb"),
                ChatId = Guid.Parse("3408c6f5-bcf0-467e-a068-b8b8bbb0689f")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("8bc1ae99-62b1-4c3b-936a-ed89898adceb"),
                ChatId = Guid.Parse("7999d70a-1a31-428e-9078-3c392dc1f4a8")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("8bc1ae99-62b1-4c3b-936a-ed89898adceb"),
                ChatId = Guid.Parse("ffda4624-660e-46a1-8a71-74e685fe6353")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("8bc1ae99-62b1-4c3b-936a-ed89898adceb"),
                ChatId = Guid.Parse("ec719221-7073-4694-897f-bfeabc02c22e")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("8bc1ae99-62b1-4c3b-936a-ed89898adceb"),
                ChatId = Guid.Parse("4189917d-7073-405b-8c47-a391f23fa31b")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("85fd205e-86a0-419b-8d59-7dc80f5b734e"),
                ChatId = Guid.Parse("8c2c8480-978f-4a8f-89ac-a70a49bed05a")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("85fd205e-86a0-419b-8d59-7dc80f5b734e"),
                ChatId = Guid.Parse("8b854df4-b93f-421b-8f52-76c7bf95fde9")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("85fd205e-86a0-419b-8d59-7dc80f5b734e"),
                ChatId = Guid.Parse("7999d70a-1a31-428e-9078-3c392dc1f4a8")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("85fd205e-86a0-419b-8d59-7dc80f5b734e"),
                ChatId = Guid.Parse("ffda4624-660e-46a1-8a71-74e685fe6353")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("85fd205e-86a0-419b-8d59-7dc80f5b734e"),
                ChatId = Guid.Parse("ec719221-7073-4694-897f-bfeabc02c22e")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("85fd205e-86a0-419b-8d59-7dc80f5b734e"),
                ChatId = Guid.Parse("4189917d-7073-405b-8c47-a391f23fa31b")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("9b419875-e449-4d74-9dd7-7c9630374799"),
                ChatId = Guid.Parse("8c2c8480-978f-4a8f-89ac-a70a49bed05a")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("9b419875-e449-4d74-9dd7-7c9630374799"),
                ChatId = Guid.Parse("3408c6f5-bcf0-467e-a068-b8b8bbb0689f")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("9b419875-e449-4d74-9dd7-7c9630374799"),
                ChatId = Guid.Parse("8b854df4-b93f-421b-8f52-76c7bf95fde9")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("9b419875-e449-4d74-9dd7-7c9630374799"),
                ChatId = Guid.Parse("7999d70a-1a31-428e-9078-3c392dc1f4a8")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("9b419875-e449-4d74-9dd7-7c9630374799"),
                ChatId = Guid.Parse("ec719221-7073-4694-897f-bfeabc02c22e")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("9b419875-e449-4d74-9dd7-7c9630374799"),
                ChatId = Guid.Parse("4189917d-7073-405b-8c47-a391f23fa31b")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("cd61d42e-6981-480e-aaf5-4869d78b9b81"),
                ChatId = Guid.Parse("3408c6f5-bcf0-467e-a068-b8b8bbb0689f")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("cd61d42e-6981-480e-aaf5-4869d78b9b81"),
                ChatId = Guid.Parse("8b854df4-b93f-421b-8f52-76c7bf95fde9")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("cd61d42e-6981-480e-aaf5-4869d78b9b81"),
                ChatId = Guid.Parse("7999d70a-1a31-428e-9078-3c392dc1f4a8")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("cd61d42e-6981-480e-aaf5-4869d78b9b81"),
                ChatId = Guid.Parse("ffda4624-660e-46a1-8a71-74e685fe6353")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("cd61d42e-6981-480e-aaf5-4869d78b9b81"),
                ChatId = Guid.Parse("ec719221-7073-4694-897f-bfeabc02c22e")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("cd61d42e-6981-480e-aaf5-4869d78b9b81"),
                ChatId = Guid.Parse("4189917d-7073-405b-8c47-a391f23fa31b")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("c8d49eba-1396-41f3-9414-8bfd2021b793"),
                ChatId = Guid.Parse("8c2c8480-978f-4a8f-89ac-a70a49bed05a")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("c8d49eba-1396-41f3-9414-8bfd2021b793"),
                ChatId = Guid.Parse("3408c6f5-bcf0-467e-a068-b8b8bbb0689f")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("c8d49eba-1396-41f3-9414-8bfd2021b793"),
                ChatId = Guid.Parse("8b854df4-b93f-421b-8f52-76c7bf95fde9")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("c8d49eba-1396-41f3-9414-8bfd2021b793"),
                ChatId = Guid.Parse("7999d70a-1a31-428e-9078-3c392dc1f4a8")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("e22141d8-f3ce-49db-bcf9-cdd1961b48b5"),
                ChatId = Guid.Parse("8c2c8480-978f-4a8f-89ac-a70a49bed05a")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("e22141d8-f3ce-49db-bcf9-cdd1961b48b5"),
                ChatId = Guid.Parse("3408c6f5-bcf0-467e-a068-b8b8bbb0689f")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("e22141d8-f3ce-49db-bcf9-cdd1961b48b5"),
                ChatId = Guid.Parse("8b854df4-b93f-421b-8f52-76c7bf95fde9")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("e22141d8-f3ce-49db-bcf9-cdd1961b48b5"),
                ChatId = Guid.Parse("7999d70a-1a31-428e-9078-3c392dc1f4a8")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("e22141d8-f3ce-49db-bcf9-cdd1961b48b5"),
                ChatId = Guid.Parse("ffda4624-660e-46a1-8a71-74e685fe6353")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("e22141d8-f3ce-49db-bcf9-cdd1961b48b5"),
                ChatId = Guid.Parse("ec719221-7073-4694-897f-bfeabc02c22e")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("99ba6920-55ac-4657-8712-c7241f23c9bf"),
                ChatId = Guid.Parse("8c2c8480-978f-4a8f-89ac-a70a49bed05a")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("99ba6920-55ac-4657-8712-c7241f23c9bf"),
                ChatId = Guid.Parse("3408c6f5-bcf0-467e-a068-b8b8bbb0689f")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("99ba6920-55ac-4657-8712-c7241f23c9bf"),
                ChatId = Guid.Parse("8b854df4-b93f-421b-8f52-76c7bf95fde9")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("99ba6920-55ac-4657-8712-c7241f23c9bf"),
                ChatId = Guid.Parse("7999d70a-1a31-428e-9078-3c392dc1f4a8")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("99ba6920-55ac-4657-8712-c7241f23c9bf"),
                ChatId = Guid.Parse("ec719221-7073-4694-897f-bfeabc02c22e")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("99ba6920-55ac-4657-8712-c7241f23c9bf"),
                ChatId = Guid.Parse("4189917d-7073-405b-8c47-a391f23fa31b")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("8cbc3199-5acc-4e26-8e4b-3e84c563dfca"),
                ChatId = Guid.Parse("8c2c8480-978f-4a8f-89ac-a70a49bed05a")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("8cbc3199-5acc-4e26-8e4b-3e84c563dfca"),
                ChatId = Guid.Parse("3408c6f5-bcf0-467e-a068-b8b8bbb0689f")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("8cbc3199-5acc-4e26-8e4b-3e84c563dfca"),
                ChatId = Guid.Parse("8b854df4-b93f-421b-8f52-76c7bf95fde9")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("8cbc3199-5acc-4e26-8e4b-3e84c563dfca"),
                ChatId = Guid.Parse("7999d70a-1a31-428e-9078-3c392dc1f4a8")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("8cbc3199-5acc-4e26-8e4b-3e84c563dfca"),
                ChatId = Guid.Parse("ec719221-7073-4694-897f-bfeabc02c22e")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("8cbc3199-5acc-4e26-8e4b-3e84c563dfca"),
                ChatId = Guid.Parse("4189917d-7073-405b-8c47-a391f23fa31b")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("213c170b-0b1c-499f-8e18-d35e5a7707ff"),
                ChatId = Guid.Parse("8c2c8480-978f-4a8f-89ac-a70a49bed05a")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("213c170b-0b1c-499f-8e18-d35e5a7707ff"),
                ChatId = Guid.Parse("3408c6f5-bcf0-467e-a068-b8b8bbb0689f")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("213c170b-0b1c-499f-8e18-d35e5a7707ff"),
                ChatId = Guid.Parse("8b854df4-b93f-421b-8f52-76c7bf95fde9")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("213c170b-0b1c-499f-8e18-d35e5a7707ff"),
                ChatId = Guid.Parse("7999d70a-1a31-428e-9078-3c392dc1f4a8")
            },
            new UserWhoJoinedChat
            {
                UserId = Guid.Parse("213c170b-0b1c-499f-8e18-d35e5a7707ff"),
                ChatId = Guid.Parse("4189917d-7073-405b-8c47-a391f23fa31b")
            }
        );
    }
}
