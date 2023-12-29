using Microsoft.EntityFrameworkCore;

namespace EchoClip.Models;

public class DatabaseChatVoiceRecordingSeeder : IDatabaseSeeder
{
    public void seedData(ModelBuilder modlerBuilder)
    {
        modlerBuilder.Entity<ChatsVoiceRecording>().HasData(
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("8c2c8480-978f-4a8f-89ac-a70a49bed05a"),
                VoiceRecordingId = Guid.Parse("9723d8f3-83cd-45c2-883b-d4f439bb9c10"),
                DataOfAdded = new DateTime(2024, 1, 13, 10, 15, 30)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("8c2c8480-978f-4a8f-89ac-a70a49bed05a"),
                VoiceRecordingId = Guid.Parse("7b6c81ba-aa1f-468d-8669-980fba398f2f"),
                DataOfAdded = new DateTime(2024, 1, 13, 10, 20, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("8c2c8480-978f-4a8f-89ac-a70a49bed05a"),
                VoiceRecordingId = Guid.Parse("2debf88b-ed60-4aca-83af-c1ae01a574e0"),
                DataOfAdded = new DateTime(2024, 1, 13, 10, 30, 40)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("8c2c8480-978f-4a8f-89ac-a70a49bed05a"),
                VoiceRecordingId = Guid.Parse("94e1a1dc-70f6-4221-8e2c-853a7ca3ec36"),
                DataOfAdded = new DateTime(2024, 1, 13, 11, 20, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("8c2c8480-978f-4a8f-89ac-a70a49bed05a"),
                VoiceRecordingId = Guid.Parse("a70f4451-eaa1-456a-803b-428f3636ad08"),
                DataOfAdded = new DateTime(2024, 1, 13, 11, 30, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("8c2c8480-978f-4a8f-89ac-a70a49bed05a"),
                VoiceRecordingId = Guid.Parse("fe27c13d-6023-4d38-a12a-6154ef14a9b8"),
                DataOfAdded = new DateTime(2024, 1, 13, 12, 40, 30)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("8c2c8480-978f-4a8f-89ac-a70a49bed05a"),
                VoiceRecordingId = Guid.Parse("fc5ddfd3-2496-4dab-9a67-33fdb1fac662"),
                DataOfAdded = new DateTime(2024, 1, 13, 12, 50, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("8c2c8480-978f-4a8f-89ac-a70a49bed05a"),
                VoiceRecordingId = Guid.Parse("9a231f48-4e1a-4bfb-bfbf-11b374bd1e53"),
                DataOfAdded = new DateTime(2024, 1, 13, 12, 55, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("8c2c8480-978f-4a8f-89ac-a70a49bed05a"),
                VoiceRecordingId = Guid.Parse("0cbf9c89-d97c-4f3d-a063-570d16f47808"),
                DataOfAdded = new DateTime(2024, 1, 13, 13, 1, 20)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("8c2c8480-978f-4a8f-89ac-a70a49bed05a"),
                VoiceRecordingId = Guid.Parse("bac347b3-aca6-4e14-acb7-c9c7e91a2ea6"),
                DataOfAdded = new DateTime(2024, 1, 13, 13, 3, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("8c2c8480-978f-4a8f-89ac-a70a49bed05a"),
                VoiceRecordingId = Guid.Parse("8caee912-d7aa-4e63-80ec-63fc4d05f5e2"),
                DataOfAdded = new DateTime(2024, 1, 13, 14, 6, 20)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("8c2c8480-978f-4a8f-89ac-a70a49bed05a"),
                VoiceRecordingId = Guid.Parse("059df751-ae7f-4e2e-9fad-8994ffb19cfd"),
                DataOfAdded = new DateTime(2024, 1, 13, 15, 9, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("8c2c8480-978f-4a8f-89ac-a70a49bed05a"),
                VoiceRecordingId = Guid.Parse("c4439bcb-9ab7-4f75-b1e7-146018d1672c"),
                DataOfAdded = new DateTime(2024, 1, 13, 17, 23, 10)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("8c2c8480-978f-4a8f-89ac-a70a49bed05a"),
                VoiceRecordingId = Guid.Parse("12195f99-9979-482a-ae86-c95b4165e221"),
                DataOfAdded = new DateTime(2024, 1, 13, 19, 56, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("8c2c8480-978f-4a8f-89ac-a70a49bed05a"),
                VoiceRecordingId = Guid.Parse("d75c9d95-82ab-410b-ae61-66e963366428"),
                DataOfAdded = new DateTime(2024, 1, 13, 20, 11, 5)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("8c2c8480-978f-4a8f-89ac-a70a49bed05a"),
                VoiceRecordingId = Guid.Parse("ecbc94d1-ab61-4bab-a914-72ed2b7546ab"),
                DataOfAdded = new DateTime(2024, 1, 13, 23, 37, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"),
                VoiceRecordingId = Guid.Parse("b2f9023f-6c16-43e8-a750-742e40885bb7"),
                DataOfAdded = new DateTime(2024, 1, 13, 10, 15, 30)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"),
                VoiceRecordingId = Guid.Parse("ba5dfee8-5de5-4965-b482-e84b0a80027c"),
                DataOfAdded = new DateTime(2024, 1, 13, 10, 20, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"),
                VoiceRecordingId = Guid.Parse("6f9327c5-abe2-4407-85ff-cb77b5467f40"),
                DataOfAdded = new DateTime(2024, 1, 13, 10, 30, 40)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"),
                VoiceRecordingId = Guid.Parse("38aad1d5-c710-4be2-b478-2e5a27ad0a3b"),
                DataOfAdded = new DateTime(2024, 1, 13, 11, 20, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"),
                VoiceRecordingId = Guid.Parse("fd062277-2258-4c28-ace0-010fcb7c8146"),
                DataOfAdded = new DateTime(2024, 1, 13, 11, 30, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"),
                VoiceRecordingId = Guid.Parse("131f8219-eccf-46ff-9bcf-bab4af4ca13e"),
                DataOfAdded = new DateTime(2024, 1, 13, 12, 40, 30)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"),
                VoiceRecordingId = Guid.Parse("72c94129-2cfb-47a7-9c94-4ff094671e14"),
                DataOfAdded = new DateTime(2024, 1, 13, 12, 50, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"),
                VoiceRecordingId = Guid.Parse("db8789bd-cd24-405a-8efa-9443de243db6"),
                DataOfAdded = new DateTime(2024, 1, 13, 12, 55, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"),
                VoiceRecordingId = Guid.Parse("c89acb7c-f3b9-4401-99de-9d4b33cbe399"),
                DataOfAdded = new DateTime(2024, 1, 13, 13, 1, 20)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"),
                VoiceRecordingId = Guid.Parse("deddda20-f1f0-4e03-a80d-19061f1fbd90"),
                DataOfAdded = new DateTime(2024, 1, 13, 13, 3, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"),
                VoiceRecordingId = Guid.Parse("4114451e-08f6-4dd3-a22c-bf0a43b11b7c"),
                DataOfAdded = new DateTime(2024, 1, 13, 14, 6, 20)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"),
                VoiceRecordingId = Guid.Parse("4a207e32-be67-4f41-94c0-68b9d94aaf32"),
                DataOfAdded = new DateTime(2024, 1, 13, 15, 9, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"),
                VoiceRecordingId = Guid.Parse("27a642cc-f02d-4cc1-870e-8986eb8be384"),
                DataOfAdded = new DateTime(2024, 1, 13, 17, 23, 10)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"),
                VoiceRecordingId = Guid.Parse("cc048a44-ab17-4314-8a65-4a7b8848bd3e"),
                DataOfAdded = new DateTime(2024, 1, 13, 19, 56, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"),
                VoiceRecordingId = Guid.Parse("838a0d7a-4777-4999-b0ca-798962218c82"),
                DataOfAdded = new DateTime(2024, 1, 13, 20, 11, 5)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"),
                VoiceRecordingId = Guid.Parse("201545bc-8c7e-413a-8f9e-03a804370032"),
                DataOfAdded = new DateTime(2024, 1, 13, 23, 37, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("8b854df4-b93f-421b-8f52-76c7bf95fde9"),
                VoiceRecordingId = Guid.Parse("ce35d5c4-c88e-40d3-ac87-3a1f405207ae"),
                DataOfAdded = new DateTime(2024, 1, 13, 10, 15, 30)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("8b854df4-b93f-421b-8f52-76c7bf95fde9"),
                VoiceRecordingId = Guid.Parse("535536bc-716f-47cf-82e5-6e8b281ea20f"),
                DataOfAdded = new DateTime(2024, 1, 13, 10, 20, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("8b854df4-b93f-421b-8f52-76c7bf95fde9"),
                VoiceRecordingId = Guid.Parse("454d5e28-f151-474e-bb08-1f2e89af65f3"),
                DataOfAdded = new DateTime(2024, 1, 13, 10, 30, 40)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("8b854df4-b93f-421b-8f52-76c7bf95fde9"),
                VoiceRecordingId = Guid.Parse("8dac7bfa-1112-4744-85bc-db41d39399c2"),
                DataOfAdded = new DateTime(2024, 1, 13, 11, 20, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("8b854df4-b93f-421b-8f52-76c7bf95fde9"),
                VoiceRecordingId = Guid.Parse("4ade1e67-4124-4c67-98be-74c5892b0929"),
                DataOfAdded = new DateTime(2024, 1, 13, 11, 30, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("8b854df4-b93f-421b-8f52-76c7bf95fde9"),
                VoiceRecordingId = Guid.Parse("c72017a9-74c3-41af-a435-e78143ca258c"),
                DataOfAdded = new DateTime(2024, 1, 13, 12, 40, 30)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("8b854df4-b93f-421b-8f52-76c7bf95fde9"),
                VoiceRecordingId = Guid.Parse("5fea97fc-c769-4ec5-84ed-ed427739267e"),
                DataOfAdded = new DateTime(2024, 1, 13, 12, 50, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("8b854df4-b93f-421b-8f52-76c7bf95fde9"),
                VoiceRecordingId = Guid.Parse("c43bc3d1-c4f0-43c3-9ee0-ee9dc0dd8926"),
                DataOfAdded = new DateTime(2024, 1, 13, 12, 55, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("8b854df4-b93f-421b-8f52-76c7bf95fde9"),
                VoiceRecordingId = Guid.Parse("9723d8f3-83cd-45c2-883b-d4f439bb9c10"),
                DataOfAdded = new DateTime(2024, 1, 13, 13, 1, 20)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("8b854df4-b93f-421b-8f52-76c7bf95fde9"),
                VoiceRecordingId = Guid.Parse("2debf88b-ed60-4aca-83af-c1ae01a574e0"),
                DataOfAdded = new DateTime(2024, 1, 13, 13, 3, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("8b854df4-b93f-421b-8f52-76c7bf95fde9"),
                VoiceRecordingId = Guid.Parse("a70f4451-eaa1-456a-803b-428f3636ad08"),
                DataOfAdded = new DateTime(2024, 1, 13, 15, 9, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("8b854df4-b93f-421b-8f52-76c7bf95fde9"),
                VoiceRecordingId = Guid.Parse("fc5ddfd3-2496-4dab-9a67-33fdb1fac662"),
                DataOfAdded = new DateTime(2024, 1, 13, 17, 23, 10)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("8b854df4-b93f-421b-8f52-76c7bf95fde9"),
                VoiceRecordingId = Guid.Parse("0cbf9c89-d97c-4f3d-a063-570d16f47808"),
                DataOfAdded = new DateTime(2024, 1, 13, 19, 56, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("8b854df4-b93f-421b-8f52-76c7bf95fde9"),
                VoiceRecordingId = Guid.Parse("8caee912-d7aa-4e63-80ec-63fc4d05f5e2"),
                DataOfAdded = new DateTime(2024, 1, 13, 20, 11, 5)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("8b854df4-b93f-421b-8f52-76c7bf95fde9"),
                VoiceRecordingId = Guid.Parse("059df751-ae7f-4e2e-9fad-8994ffb19cfd"),
                DataOfAdded = new DateTime(2024, 1, 13, 23, 37, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("7999d70a-1a31-428e-9078-3c392dc1f4a8"),
                VoiceRecordingId = Guid.Parse("c43bc3d1-c4f0-43c3-9ee0-ee9dc0dd8926"),
                DataOfAdded = new DateTime(2024, 1, 13, 10, 15, 30)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("7999d70a-1a31-428e-9078-3c392dc1f4a8"),
                VoiceRecordingId = Guid.Parse("5fea97fc-c769-4ec5-84ed-ed427739267e"),
                DataOfAdded = new DateTime(2024, 1, 13, 10, 20, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("7999d70a-1a31-428e-9078-3c392dc1f4a8"),
                VoiceRecordingId = Guid.Parse("c72017a9-74c3-41af-a435-e78143ca258c"),
                DataOfAdded = new DateTime(2024, 1, 13, 10, 30, 40)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("7999d70a-1a31-428e-9078-3c392dc1f4a8"),
                VoiceRecordingId = Guid.Parse("4ade1e67-4124-4c67-98be-74c5892b0929"),
                DataOfAdded = new DateTime(2024, 1, 13, 11, 20, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("7999d70a-1a31-428e-9078-3c392dc1f4a8"),
                VoiceRecordingId = Guid.Parse("8dac7bfa-1112-4744-85bc-db41d39399c2"),
                DataOfAdded = new DateTime(2024, 1, 13, 11, 30, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("7999d70a-1a31-428e-9078-3c392dc1f4a8"),
                VoiceRecordingId = Guid.Parse("454d5e28-f151-474e-bb08-1f2e89af65f3"),
                DataOfAdded = new DateTime(2024, 1, 13, 12, 40, 30)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("7999d70a-1a31-428e-9078-3c392dc1f4a8"),
                VoiceRecordingId = Guid.Parse("535536bc-716f-47cf-82e5-6e8b281ea20f"),
                DataOfAdded = new DateTime(2024, 1, 13, 12, 50, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("7999d70a-1a31-428e-9078-3c392dc1f4a8"),
                VoiceRecordingId = Guid.Parse("ce35d5c4-c88e-40d3-ac87-3a1f405207ae"),
                DataOfAdded = new DateTime(2024, 1, 13, 12, 55, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("7999d70a-1a31-428e-9078-3c392dc1f4a8"),
                VoiceRecordingId = Guid.Parse("201545bc-8c7e-413a-8f9e-03a804370032"),
                DataOfAdded = new DateTime(2024, 1, 13, 13, 1, 20)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("7999d70a-1a31-428e-9078-3c392dc1f4a8"),
                VoiceRecordingId = Guid.Parse("838a0d7a-4777-4999-b0ca-798962218c82"),
                DataOfAdded = new DateTime(2024, 1, 13, 13, 3, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("7999d70a-1a31-428e-9078-3c392dc1f4a8"),
                VoiceRecordingId = Guid.Parse("cc048a44-ab17-4314-8a65-4a7b8848bd3e"),
                DataOfAdded = new DateTime(2024, 1, 13, 14, 6, 20)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("7999d70a-1a31-428e-9078-3c392dc1f4a8"),
                VoiceRecordingId = Guid.Parse("27a642cc-f02d-4cc1-870e-8986eb8be384"),
                DataOfAdded = new DateTime(2024, 1, 13, 15, 9, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("7999d70a-1a31-428e-9078-3c392dc1f4a8"),
                VoiceRecordingId = Guid.Parse("4a207e32-be67-4f41-94c0-68b9d94aaf32"),
                DataOfAdded = new DateTime(2024, 1, 13, 17, 23, 10)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("7999d70a-1a31-428e-9078-3c392dc1f4a8"),
                VoiceRecordingId = Guid.Parse("4114451e-08f6-4dd3-a22c-bf0a43b11b7c"),
                DataOfAdded = new DateTime(2024, 1, 13, 19, 56, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("7999d70a-1a31-428e-9078-3c392dc1f4a8"),
                VoiceRecordingId = Guid.Parse("deddda20-f1f0-4e03-a80d-19061f1fbd90"),
                DataOfAdded = new DateTime(2024, 1, 13, 20, 11, 5)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("7999d70a-1a31-428e-9078-3c392dc1f4a8"),
                VoiceRecordingId = Guid.Parse("c89acb7c-f3b9-4401-99de-9d4b33cbe399"),
                DataOfAdded = new DateTime(2024, 1, 13, 23, 37, 0)
            },

            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("ffda4624-660e-46a1-8a71-74e685fe6353"),
                VoiceRecordingId = Guid.Parse("db8789bd-cd24-405a-8efa-9443de243db6"),
                DataOfAdded = new DateTime(2024, 1, 13, 10, 15, 30)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("ffda4624-660e-46a1-8a71-74e685fe6353"),
                VoiceRecordingId = Guid.Parse("72c94129-2cfb-47a7-9c94-4ff094671e14"),
                DataOfAdded = new DateTime(2024, 1, 13, 10, 20, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("ffda4624-660e-46a1-8a71-74e685fe6353"),
                VoiceRecordingId = Guid.Parse("131f8219-eccf-46ff-9bcf-bab4af4ca13e"),
                DataOfAdded = new DateTime(2024, 1, 13, 10, 30, 40)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("ffda4624-660e-46a1-8a71-74e685fe6353"),
                VoiceRecordingId = Guid.Parse("fd062277-2258-4c28-ace0-010fcb7c8146"),
                DataOfAdded = new DateTime(2024, 1, 13, 11, 20, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("ffda4624-660e-46a1-8a71-74e685fe6353"),
                VoiceRecordingId = Guid.Parse("38aad1d5-c710-4be2-b478-2e5a27ad0a3b"),
                DataOfAdded = new DateTime(2024, 1, 13, 11, 30, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("ffda4624-660e-46a1-8a71-74e685fe6353"),
                VoiceRecordingId = Guid.Parse("6f9327c5-abe2-4407-85ff-cb77b5467f40"),
                DataOfAdded = new DateTime(2024, 1, 13, 12, 40, 30)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("ffda4624-660e-46a1-8a71-74e685fe6353"),
                VoiceRecordingId = Guid.Parse("ba5dfee8-5de5-4965-b482-e84b0a80027c"),
                DataOfAdded = new DateTime(2024, 1, 13, 12, 50, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("ffda4624-660e-46a1-8a71-74e685fe6353"),
                VoiceRecordingId = Guid.Parse("b2f9023f-6c16-43e8-a750-742e40885bb7"),
                DataOfAdded = new DateTime(2024, 1, 13, 12, 55, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("ffda4624-660e-46a1-8a71-74e685fe6353"),
                VoiceRecordingId = Guid.Parse("ecbc94d1-ab61-4bab-a914-72ed2b7546ab"),
                DataOfAdded = new DateTime(2024, 1, 13, 13, 1, 20)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("ffda4624-660e-46a1-8a71-74e685fe6353"),
                VoiceRecordingId = Guid.Parse("d75c9d95-82ab-410b-ae61-66e963366428"),
                DataOfAdded = new DateTime(2024, 1, 13, 13, 3, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("ffda4624-660e-46a1-8a71-74e685fe6353"),
                VoiceRecordingId = Guid.Parse("12195f99-9979-482a-ae86-c95b4165e221"),
                DataOfAdded = new DateTime(2024, 1, 13, 14, 6, 20)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("ffda4624-660e-46a1-8a71-74e685fe6353"),
                VoiceRecordingId = Guid.Parse("c4439bcb-9ab7-4f75-b1e7-146018d1672c"),
                DataOfAdded = new DateTime(2024, 1, 13, 20, 11, 5)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("ffda4624-660e-46a1-8a71-74e685fe6353"),
                VoiceRecordingId = Guid.Parse("059df751-ae7f-4e2e-9fad-8994ffb19cfd"),
                DataOfAdded = new DateTime(2024, 1, 13, 23, 37, 0)
            },

            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("ec719221-7073-4694-897f-bfeabc02c22e"),
                VoiceRecordingId = Guid.Parse("8caee912-d7aa-4e63-80ec-63fc4d05f5e2"),
                DataOfAdded = new DateTime(2024, 1, 13, 10, 15, 30)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("ec719221-7073-4694-897f-bfeabc02c22e"),
                VoiceRecordingId = Guid.Parse("bac347b3-aca6-4e14-acb7-c9c7e91a2ea6"),
                DataOfAdded = new DateTime(2024, 1, 13, 10, 20, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("ec719221-7073-4694-897f-bfeabc02c22e"),
                VoiceRecordingId = Guid.Parse("0cbf9c89-d97c-4f3d-a063-570d16f47808"),
                DataOfAdded = new DateTime(2024, 1, 13, 10, 30, 40)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("ec719221-7073-4694-897f-bfeabc02c22e"),
                VoiceRecordingId = Guid.Parse("9a231f48-4e1a-4bfb-bfbf-11b374bd1e53"),
                DataOfAdded = new DateTime(2024, 1, 13, 11, 20, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("ec719221-7073-4694-897f-bfeabc02c22e"),
                VoiceRecordingId = Guid.Parse("fc5ddfd3-2496-4dab-9a67-33fdb1fac662"),
                DataOfAdded = new DateTime(2024, 1, 13, 11, 30, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("ec719221-7073-4694-897f-bfeabc02c22e"),
                VoiceRecordingId = Guid.Parse("fe27c13d-6023-4d38-a12a-6154ef14a9b8"),
                DataOfAdded = new DateTime(2024, 1, 13, 12, 40, 30)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("ec719221-7073-4694-897f-bfeabc02c22e"),
                VoiceRecordingId = Guid.Parse("a70f4451-eaa1-456a-803b-428f3636ad08"),
                DataOfAdded = new DateTime(2024, 1, 13, 12, 50, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("ec719221-7073-4694-897f-bfeabc02c22e"),
                VoiceRecordingId = Guid.Parse("94e1a1dc-70f6-4221-8e2c-853a7ca3ec36"),
                DataOfAdded = new DateTime(2024, 1, 13, 12, 55, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("ec719221-7073-4694-897f-bfeabc02c22e"),
                VoiceRecordingId = Guid.Parse("2debf88b-ed60-4aca-83af-c1ae01a574e0"),
                DataOfAdded = new DateTime(2024, 1, 13, 13, 1, 20)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("ec719221-7073-4694-897f-bfeabc02c22e"),
                VoiceRecordingId = Guid.Parse("7b6c81ba-aa1f-468d-8669-980fba398f2f"),
                DataOfAdded = new DateTime(2024, 1, 13, 13, 3, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("ec719221-7073-4694-897f-bfeabc02c22e"),
                VoiceRecordingId = Guid.Parse("9723d8f3-83cd-45c2-883b-d4f439bb9c10"),
                DataOfAdded = new DateTime(2024, 1, 13, 14, 6, 20)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("ec719221-7073-4694-897f-bfeabc02c22e"),
                VoiceRecordingId = Guid.Parse("c43bc3d1-c4f0-43c3-9ee0-ee9dc0dd8926"),
                DataOfAdded = new DateTime(2024, 1, 13, 15, 9, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("ec719221-7073-4694-897f-bfeabc02c22e"),
                VoiceRecordingId = Guid.Parse("4ade1e67-4124-4c67-98be-74c5892b0929"),
                DataOfAdded = new DateTime(2024, 1, 13, 17, 23, 10)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("ec719221-7073-4694-897f-bfeabc02c22e"),
                VoiceRecordingId = Guid.Parse("454d5e28-f151-474e-bb08-1f2e89af65f3"),
                DataOfAdded = new DateTime(2024, 1, 13, 19, 56, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("ec719221-7073-4694-897f-bfeabc02c22e"),
                VoiceRecordingId = Guid.Parse("ce35d5c4-c88e-40d3-ac87-3a1f405207ae"),
                DataOfAdded = new DateTime(2024, 1, 13, 20, 11, 5)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("ec719221-7073-4694-897f-bfeabc02c22e"),
                VoiceRecordingId = Guid.Parse("838a0d7a-4777-4999-b0ca-798962218c82"),
                DataOfAdded = new DateTime(2024, 1, 13, 23, 37, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("4189917d-7073-405b-8c47-a391f23fa31b"),
                VoiceRecordingId = Guid.Parse("fc5ddfd3-2496-4dab-9a67-33fdb1fac662"),
                DataOfAdded = new DateTime(2024, 1, 13, 10, 15, 30)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("4189917d-7073-405b-8c47-a391f23fa31b"),
                VoiceRecordingId = Guid.Parse("0cbf9c89-d97c-4f3d-a063-570d16f47808"),
                DataOfAdded = new DateTime(2024, 1, 13, 10, 20, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("4189917d-7073-405b-8c47-a391f23fa31b"),
                VoiceRecordingId = Guid.Parse("8caee912-d7aa-4e63-80ec-63fc4d05f5e2"),
                DataOfAdded = new DateTime(2024, 1, 13, 10, 30, 40)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("4189917d-7073-405b-8c47-a391f23fa31b"),
                VoiceRecordingId = Guid.Parse("c4439bcb-9ab7-4f75-b1e7-146018d1672c"),
                DataOfAdded = new DateTime(2024, 1, 13, 11, 20, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("4189917d-7073-405b-8c47-a391f23fa31b"),
                VoiceRecordingId = Guid.Parse("d75c9d95-82ab-410b-ae61-66e963366428"),
                DataOfAdded = new DateTime(2024, 1, 13, 11, 30, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("4189917d-7073-405b-8c47-a391f23fa31b"),
                VoiceRecordingId = Guid.Parse("b2f9023f-6c16-43e8-a750-742e40885bb7"),
                DataOfAdded = new DateTime(2024, 1, 13, 12, 40, 30)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("4189917d-7073-405b-8c47-a391f23fa31b"),
                VoiceRecordingId = Guid.Parse("ba5dfee8-5de5-4965-b482-e84b0a80027c"),
                DataOfAdded = new DateTime(2024, 1, 13, 12, 50, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("4189917d-7073-405b-8c47-a391f23fa31b"),
                VoiceRecordingId = Guid.Parse("38aad1d5-c710-4be2-b478-2e5a27ad0a3b"),
                DataOfAdded = new DateTime(2024, 1, 13, 12, 55, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("4189917d-7073-405b-8c47-a391f23fa31b"),
                VoiceRecordingId = Guid.Parse("131f8219-eccf-46ff-9bcf-bab4af4ca13e"),
                DataOfAdded = new DateTime(2024, 1, 13, 13, 1, 20)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("4189917d-7073-405b-8c47-a391f23fa31b"),
                VoiceRecordingId = Guid.Parse("db8789bd-cd24-405a-8efa-9443de243db6"),
                DataOfAdded = new DateTime(2024, 1, 13, 13, 3, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("4189917d-7073-405b-8c47-a391f23fa31b"),
                VoiceRecordingId = Guid.Parse("deddda20-f1f0-4e03-a80d-19061f1fbd90"),
                DataOfAdded = new DateTime(2024, 1, 13, 14, 6, 20)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("4189917d-7073-405b-8c47-a391f23fa31b"),
                VoiceRecordingId = Guid.Parse("4a207e32-be67-4f41-94c0-68b9d94aaf32"),
                DataOfAdded = new DateTime(2024, 1, 13, 15, 9, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("4189917d-7073-405b-8c47-a391f23fa31b"),
                VoiceRecordingId = Guid.Parse("cc048a44-ab17-4314-8a65-4a7b8848bd3e"),
                DataOfAdded = new DateTime(2024, 1, 13, 17, 23, 10)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("4189917d-7073-405b-8c47-a391f23fa31b"),
                VoiceRecordingId = Guid.Parse("201545bc-8c7e-413a-8f9e-03a804370032"),
                DataOfAdded = new DateTime(2024, 1, 13, 19, 56, 0)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("4189917d-7073-405b-8c47-a391f23fa31b"),
                VoiceRecordingId = Guid.Parse("535536bc-716f-47cf-82e5-6e8b281ea20f"),
                DataOfAdded = new DateTime(2024, 1, 13, 20, 11, 5)
            },
            new ChatsVoiceRecording
            {
                ChatId = Guid.Parse("4189917d-7073-405b-8c47-a391f23fa31b"),
                VoiceRecordingId = Guid.Parse("8dac7bfa-1112-4744-85bc-db41d39399c2"),
                DataOfAdded = new DateTime(2024, 1, 13, 23, 37, 0)
            }
        );
    }
}
