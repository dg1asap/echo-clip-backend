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

        modelBuilder.Entity<ChatsVoiceRecording>()
            .HasIndex(u => u.DataOfAdded)
            .IsUnique();

        // --- oOo --- Klucze glow zlozone --- oOo ---
        modelBuilder.Entity<UserWhoJoinedChat>()
            .HasKey(e => new { e.UserId, e.ChatId });

        modelBuilder.Entity<ChatsVoiceRecording>()
            .HasKey(e => new { e.ChatId, e.VoiceRecordingId });

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

        // --- oOo --- Klucze obce --- oOo ---
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
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Chat> Chats { get; set; }
    public DbSet<VoiceRecording> Voice_recordings { get; set; }
    public DbSet<UserWhoJoinedChat> Users_who_joined_chats { get; set; }
    public DbSet<ChatsVoiceRecording> Chats_voice_recordings { get; set; }
}
