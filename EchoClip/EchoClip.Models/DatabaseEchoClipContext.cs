using Microsoft.EntityFrameworkCore;

namespace EchoClip.Models;

public class DatabaseEchoClipContext : DbContext
{
    public DatabaseEchoClipContext(DbContextOptions<DatabaseEchoClipContext> options):
        base(options)
    {
        Database.Migrate();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseSerialColumns();

        // --- oOo --- Klucze unikalne --- oOo ---
        modelBuilder.Entity<User>()
            .HasIndex(u => u.Username)
            .IsUnique();

        modelBuilder.Entity<User>()
            .HasIndex(u => u.Email)
            .IsUnique();

        // --- oOo --- Klucze glow zlozone --- oOo ---
        modelBuilder.Entity<UserWhoJoinedChat>()
            .HasKey(e => new { e.UserId, e.ChatId });

        modelBuilder.Entity<ChatsVoiceRecording>()
            .HasKey(e => new { e.ChatId, e.VoiceRecordingId });

        modelBuilder.Entity<UserRelationship>()
            .HasKey(e => new { e.UserId, e.UserFriendId });

        // --- oOo --- Tablice intersekcji --- oOo ---
        modelBuilder.Entity<UserWhoJoinedChat>()
            .HasOne(e => e.User)
            .WithMany(e => e.UsersWhoJoinedChats)
            .HasForeignKey(e => e.UserId);

        modelBuilder.Entity<UserWhoJoinedChat>()
            .HasOne(e => e.Chat)
            .WithMany(e => e.UsersWhoJoinedChats)
            .HasForeignKey(e => e.ChatId);


        modelBuilder.Entity<ChatsVoiceRecording>()
            .HasOne(e => e.VoiceRecording)
            .WithMany(e => e.ChatsVoiceRecordings)
            .HasForeignKey(e => e.VoiceRecordingId);

        modelBuilder.Entity<ChatsVoiceRecording>()
            .HasOne(e => e.Chat)
            .WithMany(e => e.ChatsVoiceRecordings)
            .HasForeignKey(e => e.ChatId);


        modelBuilder.Entity<UserRelationship>()
            .HasOne(e => e.User)
            .WithMany(e => e.UserRelationshipsToOther)
            .HasForeignKey(e => e.UserId);

        modelBuilder.Entity<UserRelationship>()
            .HasOne(e => e.UserFriend)
            .WithMany(e => e.OthersRelationshipsToUser)
            .HasForeignKey(e => e.UserFriendId);

        // --- oOo --- Zwiazki jeden do wielu --- oOo ---
        modelBuilder.Entity<User>()
            .HasMany(e => e.CreatedChats)
            .WithOne(e => e.OwnerUser)
            .HasForeignKey(e => e.OwnerUserId)
            .IsRequired();

        modelBuilder.Entity<User>()
            .HasMany(e => e.VoiceRecordings)
            .WithOne(e => e.OwnerUser)
            .HasForeignKey(e => e.OwnerUserId)
            .IsRequired();

        // --- oOo --- Check constrains --- oOo ---
        modelBuilder.Entity<UserRelationship>()
            .ToTable("Users_relationships")
            .HasCheckConstraint("CK_USER_STAT", "\"Status\" IN ('PENDING', 'ACCEPTED', 'REJECTED')");

        DatabaseUserSeeder databaseUserSeeder = new DatabaseUserSeeder();
        DatabaseChatSeeder databaseChatSeeder = new DatabaseChatSeeder();
        DatabaseVoiceRecordingSeeder databaseVoiceRecordingSeeder = new DatabaseVoiceRecordingSeeder();

        DatabaseUserRelationshipSeeder databaseUserRelationshipSeeder = new DatabaseUserRelationshipSeeder();
        DatabaseUserWhoJoinedChatSeeder databaseUserWhoJoinedChatSeeder = new DatabaseUserWhoJoinedChatSeeder();
        DatabaseChatVoiceRecordingSeeder databaseChatVoiceRecordingSeeder = new DatabaseChatVoiceRecordingSeeder();

        databaseUserSeeder.seedData(modelBuilder);
        databaseChatSeeder.seedData(modelBuilder);
        databaseVoiceRecordingSeeder.seedData(modelBuilder);

        databaseUserRelationshipSeeder.seedData(modelBuilder);
        databaseUserWhoJoinedChatSeeder.seedData(modelBuilder);
        databaseChatVoiceRecordingSeeder.seedData(modelBuilder);
    }

/*    public DbSet<User> Users { get; set; }
    public DbSet<Chat> Chats { get; set; }
    public DbSet<VoiceRecording> VoiceRecordings { get; set; }
    public DbSet<UserWhoJoinedChat> UsersWhoJoinedChats { get; set; }
    public DbSet<ChatsVoiceRecording> ChatsVoiceRecordings { get; set; }
    public DbSet<UserRelationship> UserRelationships { get; set; }*/
}
