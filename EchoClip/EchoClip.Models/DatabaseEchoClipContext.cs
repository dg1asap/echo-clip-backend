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
        modelBuilder.Entity<Users>()
            .HasIndex(u => u.Username)
            .IsUnique();

        modelBuilder.Entity<Users>()
            .HasIndex(u => u.Email)
            .IsUnique();

        // --- oOo --- Klucze glow zlozone --- oOo ---
        modelBuilder.Entity<UsersWhoJoinedChats>()
            .HasKey(e => new { e.User_id, e.Chat_id });

        modelBuilder.Entity<ChatsVoiceRecordings>()
            .HasKey(e => new { e.ChatId, e.VoiceRecordingId });

        // --- oOo --- Tablice intersekcji --- oOo ---
        modelBuilder.Entity<UsersWhoJoinedChats>()
            .HasOne(e => e.User)
            .WithMany(e => e.Users_who_joined_chats)
            .HasForeignKey(e => e.User_id);

        modelBuilder.Entity<UsersWhoJoinedChats>()
            .HasOne(e => e.Chat)
            .WithMany(e => e.Users_who_joined_chats)
            .HasForeignKey(e => e.Chat_id);

        modelBuilder.Entity<ChatsVoiceRecordings>()
            .HasOne(e => e.VoiceRecording)
            .WithMany(e => e.ChatsVoiceRecordings)
            .HasForeignKey(e => e.VoiceRecordingId);

        modelBuilder.Entity<ChatsVoiceRecordings>()
            .HasOne(e => e.Chat)
            .WithMany(e => e.ChatsVoiceRecordings)
            .HasForeignKey(e => e.ChatId);

        // --- oOo --- Klucze obce --- oOo ---
        modelBuilder.Entity<Users>()
            .HasMany(e => e.Created_chats)
            .WithOne(e => e.Owner_user)
            .HasForeignKey(e => e.Owner_user_id)
            .IsRequired();
    }

    public DbSet<Users> Users { get; set; }
    public DbSet<Chats> Chats { get; set; }
    public DbSet<VoiceRecordings> Voice_recordings { get; set; }
    public DbSet<UsersWhoJoinedChats> Users_who_joined_chats { get; set; }
    public DbSet<ChatsVoiceRecordings> Chats_voice_recordings { get; set; }
}
