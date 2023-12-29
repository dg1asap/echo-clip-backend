using Microsoft.EntityFrameworkCore;

namespace EchoClip.Models;

public class DatabaseUserRelationshipSeeder : IDatabaseSeeder
{
    public void seedData(ModelBuilder modlerBuilder)
    {
        modlerBuilder.Entity<UserRelationship>().HasData(
            new UserRelationship
            {
                UserId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
                UserFriendId = Guid.Parse("81e75865-2b69-4440-af1d-bcbd2817abbe"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
                UserFriendId = Guid.Parse("70693fa5-9180-4f05-854d-5d86aa286535"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
                UserFriendId = Guid.Parse("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
                UserFriendId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
                UserFriendId = Guid.Parse("de1565eb-061b-4ffe-a1af-63a370bebaa7"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
                UserFriendId = Guid.Parse("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
                UserFriendId = Guid.Parse("fc029e14-d132-4bf3-a958-490d18320df7"),
                Status = "PENDING"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
                UserFriendId = Guid.Parse("1b854f16-2261-42b1-a614-5f9106a03b63"),
                Status = "REJECTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
                UserFriendId = Guid.Parse("c9772f81-2145-4338-ad2d-9504b4b3dc6a"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
                UserFriendId = Guid.Parse("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
                UserFriendId = Guid.Parse("57692189-acbb-4aa2-b2c9-6a5291e611af"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
                UserFriendId = Guid.Parse("8bc1ae99-62b1-4c3b-936a-ed89898adceb"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
                UserFriendId = Guid.Parse("85fd205e-86a0-419b-8d59-7dc80f5b734e"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
                UserFriendId = Guid.Parse("9b419875-e449-4d74-9dd7-7c9630374799"),
                Status = "REJECTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("81e75865-2b69-4440-af1d-bcbd2817abbe"),
                UserFriendId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("81e75865-2b69-4440-af1d-bcbd2817abbe"),
                UserFriendId = Guid.Parse("70693fa5-9180-4f05-854d-5d86aa286535"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("81e75865-2b69-4440-af1d-bcbd2817abbe"),
                UserFriendId = Guid.Parse("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"),
                Status = "PENDING"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("81e75865-2b69-4440-af1d-bcbd2817abbe"),
                UserFriendId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
                Status = "PENDING"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("81e75865-2b69-4440-af1d-bcbd2817abbe"),
                UserFriendId = Guid.Parse("de1565eb-061b-4ffe-a1af-63a370bebaa7"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("81e75865-2b69-4440-af1d-bcbd2817abbe"),
                UserFriendId = Guid.Parse("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("81e75865-2b69-4440-af1d-bcbd2817abbe"),
                UserFriendId = Guid.Parse("fc029e14-d132-4bf3-a958-490d18320df7"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("81e75865-2b69-4440-af1d-bcbd2817abbe"),
                UserFriendId = Guid.Parse("1b854f16-2261-42b1-a614-5f9106a03b63"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("81e75865-2b69-4440-af1d-bcbd2817abbe"),
                UserFriendId = Guid.Parse("c9772f81-2145-4338-ad2d-9504b4b3dc6a"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("81e75865-2b69-4440-af1d-bcbd2817abbe"),
                UserFriendId = Guid.Parse("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("81e75865-2b69-4440-af1d-bcbd2817abbe"),
                UserFriendId = Guid.Parse("57692189-acbb-4aa2-b2c9-6a5291e611af"),
                Status = "REJECTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("81e75865-2b69-4440-af1d-bcbd2817abbe"),
                UserFriendId = Guid.Parse("8bc1ae99-62b1-4c3b-936a-ed89898adceb"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("81e75865-2b69-4440-af1d-bcbd2817abbe"),
                UserFriendId = Guid.Parse("85fd205e-86a0-419b-8d59-7dc80f5b734e"),
                Status = "PENDING"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("81e75865-2b69-4440-af1d-bcbd2817abbe"),
                UserFriendId = Guid.Parse("9b419875-e449-4d74-9dd7-7c9630374799"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("70693fa5-9180-4f05-854d-5d86aa286535"),
                UserFriendId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("70693fa5-9180-4f05-854d-5d86aa286535"),
                UserFriendId = Guid.Parse("81e75865-2b69-4440-af1d-bcbd2817abbe"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("70693fa5-9180-4f05-854d-5d86aa286535"),
                UserFriendId = Guid.Parse("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("70693fa5-9180-4f05-854d-5d86aa286535"),
                UserFriendId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("70693fa5-9180-4f05-854d-5d86aa286535"),
                UserFriendId = Guid.Parse("de1565eb-061b-4ffe-a1af-63a370bebaa7"),
                Status = "PENDING"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("70693fa5-9180-4f05-854d-5d86aa286535"),
                UserFriendId = Guid.Parse("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("70693fa5-9180-4f05-854d-5d86aa286535"),
                UserFriendId = Guid.Parse("fc029e14-d132-4bf3-a958-490d18320df7"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("70693fa5-9180-4f05-854d-5d86aa286535"),
                UserFriendId = Guid.Parse("1b854f16-2261-42b1-a614-5f9106a03b63"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("70693fa5-9180-4f05-854d-5d86aa286535"),
                UserFriendId = Guid.Parse("c9772f81-2145-4338-ad2d-9504b4b3dc6a"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("70693fa5-9180-4f05-854d-5d86aa286535"),
                UserFriendId = Guid.Parse("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("70693fa5-9180-4f05-854d-5d86aa286535"),
                UserFriendId = Guid.Parse("57692189-acbb-4aa2-b2c9-6a5291e611af"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("70693fa5-9180-4f05-854d-5d86aa286535"),
                UserFriendId = Guid.Parse("8bc1ae99-62b1-4c3b-936a-ed89898adceb"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("70693fa5-9180-4f05-854d-5d86aa286535"),
                UserFriendId = Guid.Parse("85fd205e-86a0-419b-8d59-7dc80f5b734e"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("70693fa5-9180-4f05-854d-5d86aa286535"),
                UserFriendId = Guid.Parse("9b419875-e449-4d74-9dd7-7c9630374799"),
                Status = "PENDING"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"),
                UserFriendId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"),
                UserFriendId = Guid.Parse("81e75865-2b69-4440-af1d-bcbd2817abbe"),
                Status = "REJECTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"),
                UserFriendId = Guid.Parse("70693fa5-9180-4f05-854d-5d86aa286535"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"),
                UserFriendId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"),
                UserFriendId = Guid.Parse("de1565eb-061b-4ffe-a1af-63a370bebaa7"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"),
                UserFriendId = Guid.Parse("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"),
                UserFriendId = Guid.Parse("fc029e14-d132-4bf3-a958-490d18320df7"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"),
                UserFriendId = Guid.Parse("1b854f16-2261-42b1-a614-5f9106a03b63"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"),
                UserFriendId = Guid.Parse("c9772f81-2145-4338-ad2d-9504b4b3dc6a"),
                Status = "PENDING"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"),
                UserFriendId = Guid.Parse("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"),
                UserFriendId = Guid.Parse("57692189-acbb-4aa2-b2c9-6a5291e611af"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"),
                UserFriendId = Guid.Parse("8bc1ae99-62b1-4c3b-936a-ed89898adceb"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"),
                UserFriendId = Guid.Parse("85fd205e-86a0-419b-8d59-7dc80f5b734e"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"),
                UserFriendId = Guid.Parse("9b419875-e449-4d74-9dd7-7c9630374799"),
                Status = "REJECTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
                UserFriendId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
                UserFriendId = Guid.Parse("81e75865-2b69-4440-af1d-bcbd2817abbe"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
                UserFriendId = Guid.Parse("70693fa5-9180-4f05-854d-5d86aa286535"),
                Status = "PENDING"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
                UserFriendId = Guid.Parse("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
                UserFriendId = Guid.Parse("de1565eb-061b-4ffe-a1af-63a370bebaa7"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
                UserFriendId = Guid.Parse("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
                UserFriendId = Guid.Parse("fc029e14-d132-4bf3-a958-490d18320df7"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
                UserFriendId = Guid.Parse("1b854f16-2261-42b1-a614-5f9106a03b63"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
                UserFriendId = Guid.Parse("c9772f81-2145-4338-ad2d-9504b4b3dc6a"),
                Status = "REJECTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
                UserFriendId = Guid.Parse("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
                UserFriendId = Guid.Parse("57692189-acbb-4aa2-b2c9-6a5291e611af"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
                UserFriendId = Guid.Parse("8bc1ae99-62b1-4c3b-936a-ed89898adceb"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
                UserFriendId = Guid.Parse("85fd205e-86a0-419b-8d59-7dc80f5b734e"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
                UserFriendId = Guid.Parse("9b419875-e449-4d74-9dd7-7c9630374799"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("de1565eb-061b-4ffe-a1af-63a370bebaa7"),
                UserFriendId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
                Status = "PENDING"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("de1565eb-061b-4ffe-a1af-63a370bebaa7"),
                UserFriendId = Guid.Parse("81e75865-2b69-4440-af1d-bcbd2817abbe"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("de1565eb-061b-4ffe-a1af-63a370bebaa7"),
                UserFriendId = Guid.Parse("70693fa5-9180-4f05-854d-5d86aa286535"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("de1565eb-061b-4ffe-a1af-63a370bebaa7"),
                UserFriendId = Guid.Parse("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("de1565eb-061b-4ffe-a1af-63a370bebaa7"),
                UserFriendId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("de1565eb-061b-4ffe-a1af-63a370bebaa7"),
                UserFriendId = Guid.Parse("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("de1565eb-061b-4ffe-a1af-63a370bebaa7"),
                UserFriendId = Guid.Parse("fc029e14-d132-4bf3-a958-490d18320df7"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("de1565eb-061b-4ffe-a1af-63a370bebaa7"),
                UserFriendId = Guid.Parse("1b854f16-2261-42b1-a614-5f9106a03b63"),
                Status = "REJECTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("de1565eb-061b-4ffe-a1af-63a370bebaa7"),
                UserFriendId = Guid.Parse("c9772f81-2145-4338-ad2d-9504b4b3dc6a"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("de1565eb-061b-4ffe-a1af-63a370bebaa7"),
                UserFriendId = Guid.Parse("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("de1565eb-061b-4ffe-a1af-63a370bebaa7"),
                UserFriendId = Guid.Parse("57692189-acbb-4aa2-b2c9-6a5291e611af"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("de1565eb-061b-4ffe-a1af-63a370bebaa7"),
                UserFriendId = Guid.Parse("8bc1ae99-62b1-4c3b-936a-ed89898adceb"),
                Status = "PENDING"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("de1565eb-061b-4ffe-a1af-63a370bebaa7"),
                UserFriendId = Guid.Parse("85fd205e-86a0-419b-8d59-7dc80f5b734e"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("de1565eb-061b-4ffe-a1af-63a370bebaa7"),
                UserFriendId = Guid.Parse("9b419875-e449-4d74-9dd7-7c9630374799"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"),
                UserFriendId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"),
                UserFriendId = Guid.Parse("81e75865-2b69-4440-af1d-bcbd2817abbe"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"),
                UserFriendId = Guid.Parse("70693fa5-9180-4f05-854d-5d86aa286535"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"),
                UserFriendId = Guid.Parse("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"),
                UserFriendId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"),
                UserFriendId = Guid.Parse("de1565eb-061b-4ffe-a1af-63a370bebaa7"),
                Status = "REJECTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"),
                UserFriendId = Guid.Parse("fc029e14-d132-4bf3-a958-490d18320df7"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"),
                UserFriendId = Guid.Parse("1b854f16-2261-42b1-a614-5f9106a03b63"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"),
                UserFriendId = Guid.Parse("c9772f81-2145-4338-ad2d-9504b4b3dc6a"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"),
                UserFriendId = Guid.Parse("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"),
                UserFriendId = Guid.Parse("57692189-acbb-4aa2-b2c9-6a5291e611af"),
                Status = "PENDING"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"),
                UserFriendId = Guid.Parse("8bc1ae99-62b1-4c3b-936a-ed89898adceb"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"),
                UserFriendId = Guid.Parse("85fd205e-86a0-419b-8d59-7dc80f5b734e"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"),
                UserFriendId = Guid.Parse("9b419875-e449-4d74-9dd7-7c9630374799"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("fc029e14-d132-4bf3-a958-490d18320df7"),
                UserFriendId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("fc029e14-d132-4bf3-a958-490d18320df7"),
                UserFriendId = Guid.Parse("81e75865-2b69-4440-af1d-bcbd2817abbe"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("fc029e14-d132-4bf3-a958-490d18320df7"),
                UserFriendId = Guid.Parse("70693fa5-9180-4f05-854d-5d86aa286535"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("fc029e14-d132-4bf3-a958-490d18320df7"),
                UserFriendId = Guid.Parse("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("fc029e14-d132-4bf3-a958-490d18320df7"),
                UserFriendId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("fc029e14-d132-4bf3-a958-490d18320df7"),
                UserFriendId = Guid.Parse("de1565eb-061b-4ffe-a1af-63a370bebaa7"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("fc029e14-d132-4bf3-a958-490d18320df7"),
                UserFriendId = Guid.Parse("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"),
                Status = "REJECTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("fc029e14-d132-4bf3-a958-490d18320df7"),
                UserFriendId = Guid.Parse("1b854f16-2261-42b1-a614-5f9106a03b63"),
                Status = "PENDING"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("fc029e14-d132-4bf3-a958-490d18320df7"),
                UserFriendId = Guid.Parse("c9772f81-2145-4338-ad2d-9504b4b3dc6a"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("fc029e14-d132-4bf3-a958-490d18320df7"),
                UserFriendId = Guid.Parse("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("fc029e14-d132-4bf3-a958-490d18320df7"),
                UserFriendId = Guid.Parse("57692189-acbb-4aa2-b2c9-6a5291e611af"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("fc029e14-d132-4bf3-a958-490d18320df7"),
                UserFriendId = Guid.Parse("8bc1ae99-62b1-4c3b-936a-ed89898adceb"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("fc029e14-d132-4bf3-a958-490d18320df7"),
                UserFriendId = Guid.Parse("85fd205e-86a0-419b-8d59-7dc80f5b734e"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("fc029e14-d132-4bf3-a958-490d18320df7"),
                UserFriendId = Guid.Parse("9b419875-e449-4d74-9dd7-7c9630374799"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("1b854f16-2261-42b1-a614-5f9106a03b63"),
                UserFriendId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("1b854f16-2261-42b1-a614-5f9106a03b63"),
                UserFriendId = Guid.Parse("81e75865-2b69-4440-af1d-bcbd2817abbe"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("1b854f16-2261-42b1-a614-5f9106a03b63"),
                UserFriendId = Guid.Parse("70693fa5-9180-4f05-854d-5d86aa286535"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("1b854f16-2261-42b1-a614-5f9106a03b63"),
                UserFriendId = Guid.Parse("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"),
                Status = "REJECTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("1b854f16-2261-42b1-a614-5f9106a03b63"),
                UserFriendId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("1b854f16-2261-42b1-a614-5f9106a03b63"),
                UserFriendId = Guid.Parse("de1565eb-061b-4ffe-a1af-63a370bebaa7"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("1b854f16-2261-42b1-a614-5f9106a03b63"),
                UserFriendId = Guid.Parse("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("1b854f16-2261-42b1-a614-5f9106a03b63"),
                UserFriendId = Guid.Parse("fc029e14-d132-4bf3-a958-490d18320df7"),
                Status = "PENDING"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("1b854f16-2261-42b1-a614-5f9106a03b63"),
                UserFriendId = Guid.Parse("c9772f81-2145-4338-ad2d-9504b4b3dc6a"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("1b854f16-2261-42b1-a614-5f9106a03b63"),
                UserFriendId = Guid.Parse("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("1b854f16-2261-42b1-a614-5f9106a03b63"),
                UserFriendId = Guid.Parse("57692189-acbb-4aa2-b2c9-6a5291e611af"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("1b854f16-2261-42b1-a614-5f9106a03b63"),
                UserFriendId = Guid.Parse("8bc1ae99-62b1-4c3b-936a-ed89898adceb"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("1b854f16-2261-42b1-a614-5f9106a03b63"),
                UserFriendId = Guid.Parse("85fd205e-86a0-419b-8d59-7dc80f5b734e"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("1b854f16-2261-42b1-a614-5f9106a03b63"),
                UserFriendId = Guid.Parse("9b419875-e449-4d74-9dd7-7c9630374799"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("c9772f81-2145-4338-ad2d-9504b4b3dc6a"),
                UserFriendId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("c9772f81-2145-4338-ad2d-9504b4b3dc6a"),
                UserFriendId = Guid.Parse("81e75865-2b69-4440-af1d-bcbd2817abbe"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("c9772f81-2145-4338-ad2d-9504b4b3dc6a"),
                UserFriendId = Guid.Parse("70693fa5-9180-4f05-854d-5d86aa286535"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("c9772f81-2145-4338-ad2d-9504b4b3dc6a"),
                UserFriendId = Guid.Parse("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("c9772f81-2145-4338-ad2d-9504b4b3dc6a"),
                UserFriendId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("c9772f81-2145-4338-ad2d-9504b4b3dc6a"),
                UserFriendId = Guid.Parse("de1565eb-061b-4ffe-a1af-63a370bebaa7"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("c9772f81-2145-4338-ad2d-9504b4b3dc6a"),
                UserFriendId = Guid.Parse("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("c9772f81-2145-4338-ad2d-9504b4b3dc6a"),
                UserFriendId = Guid.Parse("fc029e14-d132-4bf3-a958-490d18320df7"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("c9772f81-2145-4338-ad2d-9504b4b3dc6a"),
                UserFriendId = Guid.Parse("1b854f16-2261-42b1-a614-5f9106a03b63"),
                Status = "REJECTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("c9772f81-2145-4338-ad2d-9504b4b3dc6a"),
                UserFriendId = Guid.Parse("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"),
                Status = "PENDING"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("c9772f81-2145-4338-ad2d-9504b4b3dc6a"),
                UserFriendId = Guid.Parse("57692189-acbb-4aa2-b2c9-6a5291e611af"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("c9772f81-2145-4338-ad2d-9504b4b3dc6a"),
                UserFriendId = Guid.Parse("8bc1ae99-62b1-4c3b-936a-ed89898adceb"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("c9772f81-2145-4338-ad2d-9504b4b3dc6a"),
                UserFriendId = Guid.Parse("85fd205e-86a0-419b-8d59-7dc80f5b734e"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("c9772f81-2145-4338-ad2d-9504b4b3dc6a"),
                UserFriendId = Guid.Parse("9b419875-e449-4d74-9dd7-7c9630374799"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"),
                UserFriendId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"),
                UserFriendId = Guid.Parse("81e75865-2b69-4440-af1d-bcbd2817abbe"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"),
                UserFriendId = Guid.Parse("70693fa5-9180-4f05-854d-5d86aa286535"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"),
                UserFriendId = Guid.Parse("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"),
                UserFriendId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"),
                UserFriendId = Guid.Parse("de1565eb-061b-4ffe-a1af-63a370bebaa7"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"),
                UserFriendId = Guid.Parse("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"),
                UserFriendId = Guid.Parse("fc029e14-d132-4bf3-a958-490d18320df7"),
                Status = "PENDING"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"),
                UserFriendId = Guid.Parse("1b854f16-2261-42b1-a614-5f9106a03b63"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"),
                UserFriendId = Guid.Parse("c9772f81-2145-4338-ad2d-9504b4b3dc6a"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"),
                UserFriendId = Guid.Parse("57692189-acbb-4aa2-b2c9-6a5291e611af"),
                Status = "REJECTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"),
                UserFriendId = Guid.Parse("8bc1ae99-62b1-4c3b-936a-ed89898adceb"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"),
                UserFriendId = Guid.Parse("85fd205e-86a0-419b-8d59-7dc80f5b734e"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"),
                UserFriendId = Guid.Parse("9b419875-e449-4d74-9dd7-7c9630374799"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("57692189-acbb-4aa2-b2c9-6a5291e611af"),
                UserFriendId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("57692189-acbb-4aa2-b2c9-6a5291e611af"),
                UserFriendId = Guid.Parse("81e75865-2b69-4440-af1d-bcbd2817abbe"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("57692189-acbb-4aa2-b2c9-6a5291e611af"),
                UserFriendId = Guid.Parse("70693fa5-9180-4f05-854d-5d86aa286535"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("57692189-acbb-4aa2-b2c9-6a5291e611af"),
                UserFriendId = Guid.Parse("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"),
                Status = "PENDING"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("57692189-acbb-4aa2-b2c9-6a5291e611af"),
                UserFriendId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("57692189-acbb-4aa2-b2c9-6a5291e611af"),
                UserFriendId = Guid.Parse("de1565eb-061b-4ffe-a1af-63a370bebaa7"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("57692189-acbb-4aa2-b2c9-6a5291e611af"),
                UserFriendId = Guid.Parse("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("57692189-acbb-4aa2-b2c9-6a5291e611af"),
                UserFriendId = Guid.Parse("fc029e14-d132-4bf3-a958-490d18320df7"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("57692189-acbb-4aa2-b2c9-6a5291e611af"),
                UserFriendId = Guid.Parse("1b854f16-2261-42b1-a614-5f9106a03b63"),
                Status = "REJECTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("57692189-acbb-4aa2-b2c9-6a5291e611af"),
                UserFriendId = Guid.Parse("c9772f81-2145-4338-ad2d-9504b4b3dc6a"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("57692189-acbb-4aa2-b2c9-6a5291e611af"),
                UserFriendId = Guid.Parse("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("57692189-acbb-4aa2-b2c9-6a5291e611af"),
                UserFriendId = Guid.Parse("8bc1ae99-62b1-4c3b-936a-ed89898adceb"),
                Status = "PENDING"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("57692189-acbb-4aa2-b2c9-6a5291e611af"),
                UserFriendId = Guid.Parse("85fd205e-86a0-419b-8d59-7dc80f5b734e"),
                Status = "ACCEPTED"
            },
            new UserRelationship
            {
                UserId = Guid.Parse("57692189-acbb-4aa2-b2c9-6a5291e611af"),
                UserFriendId = Guid.Parse("9b419875-e449-4d74-9dd7-7c9630374799"),
                Status = "ACCEPTED"
            }
        );
    }
}
