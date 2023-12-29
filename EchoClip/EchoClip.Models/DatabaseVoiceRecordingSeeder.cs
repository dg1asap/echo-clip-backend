using Microsoft.EntityFrameworkCore;

namespace EchoClip.Models;

public class DatabaseVoiceRecordingSeeder : IDatabaseSeeder
{
    private readonly string audioFolderPath;

    public DatabaseVoiceRecordingSeeder()
    {
        this.audioFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "..", "..", "Audio");
    }

    public void seedData(ModelBuilder modlerBuilder)
    {
        modlerBuilder.Entity<VoiceRecording>().HasData(
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("9723d8f3-83cd-45c2-883b-d4f439bb9c10"),
                Name = "cinematic-sound-effect-for-short-film-previews",
                OwnerUserId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
                AudioDataPath = "038777_cinematic-sound-effect-for-short-film-previews-61011.mp3",
                UploadDataTime = new DateTime(2024, 1, 1, 16, 10, 0)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("7b6c81ba-aa1f-468d-8669-980fba398f2f"),
                Name = "acoustic-guitar-short-intro-ish-live-recording",
                OwnerUserId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
                AudioDataPath = "acoustic-guitar-short-intro-ish-live-recording-163329.mp3",
                UploadDataTime = new DateTime(2024, 1, 1, 16, 20, 0)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("2debf88b-ed60-4aca-83af-c1ae01a574e0"),
                Name = "beautiful-piano-logo",
                OwnerUserId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
                AudioDataPath = "beautiful-piano-logo-143488.mp3",
                UploadDataTime = new DateTime(2024, 1, 1, 16, 30, 10)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("94e1a1dc-70f6-4221-8e2c-853a7ca3ec36"),
                Name = "christmas-ident",
                OwnerUserId = Guid.Parse("81e75865-2b69-4440-af1d-bcbd2817abbe"),
                AudioDataPath = "christmas-ident-21090.mp3",
                UploadDataTime = new DateTime(2024, 1, 1, 16, 40, 0)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("a70f4451-eaa1-456a-803b-428f3636ad08"),
                Name = "christmas-vibes-windy-whoosh-magical-chimes",
                OwnerUserId = Guid.Parse("81e75865-2b69-4440-af1d-bcbd2817abbe"),
                AudioDataPath = "christmas-vibes-windy-whoosh-magical-chimes-180863.mp3",
                UploadDataTime = new DateTime(2024, 1, 1, 16, 50, 20)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("fe27c13d-6023-4d38-a12a-6154ef14a9b8"),
                Name = "click-124467",
                OwnerUserId = Guid.Parse("70693fa5-9180-4f05-854d-5d86aa286535"),
                AudioDataPath = "click-124467.mp3",
                UploadDataTime = new DateTime(2024, 1, 1, 17, 0, 0)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("fc5ddfd3-2496-4dab-9a67-33fdb1fac662"),
                Name = "click-button-140",
                OwnerUserId = Guid.Parse("70693fa5-9180-4f05-854d-5d86aa286535"),
                AudioDataPath = "click-button-140881.mp3",
                UploadDataTime = new DateTime(2024, 1, 1, 17, 10, 30)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("9a231f48-4e1a-4bfb-bfbf-11b374bd1e53"),
                Name = "click_effect-86",
                OwnerUserId = Guid.Parse("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"),
                AudioDataPath = "click_effect-86995.mp3",
                UploadDataTime = new DateTime(2024, 1, 1, 17, 20, 0)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("0cbf9c89-d97c-4f3d-a063-570d16f47808"),
                Name = "crystal-logo",
                OwnerUserId = Guid.Parse("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"),
                AudioDataPath = "crystal-logo-21091.mp3",
                UploadDataTime = new DateTime(2024, 1, 1, 18, 0, 0)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("bac347b3-aca6-4e14-acb7-c9c7e91a2ea6"),
                Name = "dark-engine-logo",
                OwnerUserId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
                AudioDataPath = "dark-engine-logo-141942.mp3",
                UploadDataTime = new DateTime(2024, 1, 2, 1, 0, 30)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("8caee912-d7aa-4e63-80ec-63fc4d05f5e2"),
                Name = "dramatic-reveal",
                OwnerUserId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
                AudioDataPath = "dramatic-reveal-21469.mp3",
                UploadDataTime = new DateTime(2024, 1, 2, 17, 0, 0)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("059df751-ae7f-4e2e-9fad-8994ffb19cfd"),
                Name = "epic-glitch-hit-logo",
                OwnerUserId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
                AudioDataPath = "epic-glitch-hit-logo-142960.mp3",
                UploadDataTime = new DateTime(2024, 1, 2, 18, 20, 0)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("c4439bcb-9ab7-4f75-b1e7-146018d1672c"),
                Name = "epic-hybrid-logo",
                OwnerUserId = Guid.Parse("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"),
                AudioDataPath = "epic-hybrid-logo-157092.mp3",
                UploadDataTime = new DateTime(2024, 1, 3, 14, 0, 10)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("12195f99-9979-482a-ae86-c95b4165e221"),
                Name = "finger-snap",
                OwnerUserId = Guid.Parse("de1565eb-061b-4ffe-a1af-63a370bebaa7"),
                AudioDataPath = "finger-snap-179180.mp3",
                UploadDataTime = new DateTime(2024, 1, 3, 17, 0, 0)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("d75c9d95-82ab-410b-ae61-66e963366428"),
                Name = "friendly-melody",
                OwnerUserId = Guid.Parse("fc029e14-d132-4bf3-a958-490d18320df7"),
                AudioDataPath = "friendly-melody-14015.mp3",
                UploadDataTime = new DateTime(2024, 1, 4, 16, 40, 0)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("ecbc94d1-ab61-4bab-a914-72ed2b7546ab"),
                Name = "funny-laughing-sound",
                OwnerUserId = Guid.Parse("1b854f16-2261-42b1-a614-5f9106a03b63"),
                AudioDataPath = "funny-laughing-sound-180125.mp3",
                UploadDataTime = new DateTime(2024, 1, 5, 12, 15, 15)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("b2f9023f-6c16-43e8-a750-742e40885bb7"),
                Name = "heroic-intro",
                OwnerUserId = Guid.Parse("c9772f81-2145-4338-ad2d-9504b4b3dc6a"),
                AudioDataPath = "heroic-intro-21468.mp3",
                UploadDataTime = new DateTime(2024, 1, 5, 16, 0, 0)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("ba5dfee8-5de5-4965-b482-e84b0a80027c"),
                Name = "impact-piano-logo",
                OwnerUserId = Guid.Parse("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"),
                AudioDataPath = "impact-piano-logo-108961.mp3",
                UploadDataTime = new DateTime(2024, 1, 6, 10, 10, 10)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("6f9327c5-abe2-4407-85ff-cb77b5467f40"),
                Name = "intro-music-black-box-brand-jingle",
                OwnerUserId = Guid.Parse("57692189-acbb-4aa2-b2c9-6a5291e611af"),
                AudioDataPath = "intro-music-black-box-brand-jingle-13222.mp3",
                UploadDataTime = new DateTime(2024, 1, 6, 20, 20, 20)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("38aad1d5-c710-4be2-b478-2e5a27ad0a3b"),
                Name = "modern-tech-logo",
                OwnerUserId = Guid.Parse("57692189-acbb-4aa2-b2c9-6a5291e611af"),
                AudioDataPath = "modern-tech-logo-13492.mp3",
                UploadDataTime = new DateTime(2024, 1, 7, 12, 11, 20)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("fd062277-2258-4c28-ace0-010fcb7c8146"),
                Name = "positive-orchestral-jingle",
                OwnerUserId = Guid.Parse("57692189-acbb-4aa2-b2c9-6a5291e611af"),
                AudioDataPath = "positive-orchestral-jingle-21444.mp3",
                UploadDataTime = new DateTime(2024, 1, 7, 13, 22, 40)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("131f8219-eccf-46ff-9bcf-bab4af4ca13e"),
                Name = "record_scratch",
                OwnerUserId = Guid.Parse("8bc1ae99-62b1-4c3b-936a-ed89898adceb"),
                AudioDataPath = "record_scratch-108233.mp3",
                UploadDataTime = new DateTime(2024, 1, 7, 14, 44, 10)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("72c94129-2cfb-47a7-9c94-4ff094671e14"),
                Name = "reverse-logo",
                OwnerUserId = Guid.Parse("85fd205e-86a0-419b-8d59-7dc80f5b734e"),
                AudioDataPath = "reverse-logo-143857.mp3",
                UploadDataTime = new DateTime(2024, 1, 7, 15, 12, 10)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("db8789bd-cd24-405a-8efa-9443de243db6"),
                Name = "short-crowd-cheer",
                OwnerUserId = Guid.Parse("9b419875-e449-4d74-9dd7-7c9630374799"),
                AudioDataPath = "short-crowd-cheer-6713.mp3",
                UploadDataTime = new DateTime(2024, 1, 8, 16, 25, 10)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("c89acb7c-f3b9-4401-99de-9d4b33cbe399"),
                Name = "short-logo",
                OwnerUserId = Guid.Parse("cd61d42e-6981-480e-aaf5-4869d78b9b81"),
                AudioDataPath = "short-logo-108964.mp3",
                UploadDataTime = new DateTime(2024, 1, 8, 17, 35, 12)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("deddda20-f1f0-4e03-a80d-19061f1fbd90"),
                Name = "short-success-sound-glockenspiel-treasure-video-game",
                OwnerUserId = Guid.Parse("c8d49eba-1396-41f3-9414-8bfd2021b793"),
                AudioDataPath = "short-success-sound-glockenspiel-treasure-video-game-6346.mp3",
                UploadDataTime = new DateTime(2024, 1, 8, 18, 38, 0)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("4114451e-08f6-4dd3-a22c-bf0a43b11b7c"),
                Name = "short-whoosh-13x",
                OwnerUserId = Guid.Parse("e22141d8-f3ce-49db-bcf9-cdd1961b48b5"),
                AudioDataPath = "short-whoosh-13x-14526.mp3",
                UploadDataTime = new DateTime(2024, 1, 9, 19, 23, 0)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("4a207e32-be67-4f41-94c0-68b9d94aaf32"),
                Name = "simple-clean-logo",
                OwnerUserId = Guid.Parse("e22141d8-f3ce-49db-bcf9-cdd1961b48b5"),
                AudioDataPath = "simple-clean-logo-13775.mp3",
                UploadDataTime = new DateTime(2024, 1, 9, 20, 24, 44)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("27a642cc-f02d-4cc1-870e-8986eb8be384"),
                Name = "simple-hi-tech-logo",
                OwnerUserId = Guid.Parse("99ba6920-55ac-4657-8712-c7241f23c9bf"),
                AudioDataPath = "simple-hi-tech-logo-13774.mp3",
                UploadDataTime = new DateTime(2024, 1, 9, 21, 50, 0)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("cc048a44-ab17-4314-8a65-4a7b8848bd3e"),
                Name = "sound-1-16",
                OwnerUserId = Guid.Parse("8cbc3199-5acc-4e26-8e4b-3e84c563dfca"),
                AudioDataPath = "sound-1-167181.mp3",
                UploadDataTime = new DateTime(2024, 1, 10, 22, 59, 23)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("838a0d7a-4777-4999-b0ca-798962218c82"),
                Name = "sport-rock-logo1-13",
                OwnerUserId = Guid.Parse("213c170b-0b1c-499f-8e18-d35e5a7707ff"),
                AudioDataPath = "sport-rock-logo1-13776.mp3",
                UploadDataTime = new DateTime(2024, 1, 10, 23, 59, 0)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("201545bc-8c7e-413a-8f9e-03a804370032"),
                Name = "stingers-001-629",
                OwnerUserId = Guid.Parse("b2a250cb-9279-4c0a-b6ac-262e4d43225e"),
                AudioDataPath = "stingers-001-6294.mp3",
                UploadDataTime = new DateTime(2024, 1, 11, 9, 58, 34)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("ce35d5c4-c88e-40d3-ac87-3a1f405207ae"),
                Name = "stomp-logo",
                OwnerUserId = Guid.Parse("e41fa0bd-0a3e-45d6-89ec-b2c753a1ddb5"),
                AudioDataPath = "stomp-logo-4-13784.mp3",
                UploadDataTime = new DateTime(2024, 1, 11, 10, 57, 12)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("535536bc-716f-47cf-82e5-6e8b281ea20f"),
                Name = "summer-night-piano-solo",
                OwnerUserId = Guid.Parse("a7958e4c-1912-49c2-bc24-563f7a2c8d8c"),
                AudioDataPath = "summer-night-piano-solo-6885.mp3",
                UploadDataTime = new DateTime(2024, 1, 11, 12, 22, 0)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("454d5e28-f151-474e-bb08-1f2e89af65f3"),
                Name = "suspense-intro",
                OwnerUserId = Guid.Parse("a7958e4c-1912-49c2-bc24-563f7a2c8d8c"),
                AudioDataPath = "suspense-intro-21472.mp3",
                UploadDataTime = new DateTime(2024, 1, 11, 16, 53, 50)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("8dac7bfa-1112-4744-85bc-db41d39399c2"),
                Name = "suspense-sting",
                OwnerUserId = Guid.Parse("a7958e4c-1912-49c2-bc24-563f7a2c8d8c"),
                AudioDataPath = "suspense-sting-14028.mp3",
                UploadDataTime = new DateTime(2024, 1, 11, 18, 42, 0)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("4ade1e67-4124-4c67-98be-74c5892b0929"),
                Name = "teddy-short-comedy-audio-logo-happy-cartoony-intro-outro-music",
                OwnerUserId = Guid.Parse("8cbc3199-5acc-4e26-8e4b-3e84c563dfca"),
                AudioDataPath = "teddy-short-comedy-audio-logo-happy-cartoony-intro-outro-music-145155.mp3",
                UploadDataTime = new DateTime(2024, 1, 12, 9, 41, 5)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("c72017a9-74c3-41af-a435-e78143ca258c"),
                Name = "tv-background-intro",
                OwnerUserId = Guid.Parse("8cbc3199-5acc-4e26-8e4b-3e84c563dfca"),
                AudioDataPath = "tv-background-intro-14030.mp3",
                UploadDataTime = new DateTime(2024, 1, 12, 10, 2, 0)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("5fea97fc-c769-4ec5-84ed-ed427739267e"),
                Name = "war-horn-blast",
                OwnerUserId = Guid.Parse("cd61d42e-6981-480e-aaf5-4869d78b9b81"),
                AudioDataPath = "war-horn-blast-14760.mp3",
                UploadDataTime = new DateTime(2024, 1, 12, 13, 1, 0)
            },
            new VoiceRecording
            {
                VoiceRecordingId = Guid.Parse("c43bc3d1-c4f0-43c3-9ee0-ee9dc0dd8926"),
                Name = "winter-holiday-logo",
                OwnerUserId = Guid.Parse("cd61d42e-6981-480e-aaf5-4869d78b9b81"),
                AudioDataPath = "winter-holiday-logo-14033.mp3",
                UploadDataTime = new DateTime(2024, 1, 12, 10, 1, 5)
            }
        );
    }
}
