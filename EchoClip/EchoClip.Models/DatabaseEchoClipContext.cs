using EchoClip.Models;
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
        modelBuilder.Entity<UsersChats>()
            .HasKey(e => new { e.UsersId, e.ChatId });

        modelBuilder.Entity<ChatsVoiceRecordings>()
            .HasKey(e => new { e.ChatId, e.VoiceRecordingsId });

        // --- oOo --- Tablice intersekcji --- oOo ---
        modelBuilder.Entity<Users>()
            .HasMany(e => e.Chats)
            .WithMany(e => e.Users)
            .UsingEntity<UsersChats>();

        modelBuilder.Entity<Chats>()
            .HasMany(e => e.Users)
            .WithMany(e => e.Chats)
            .UsingEntity<UsersChats>();

        modelBuilder.Entity<Chats>()
            .HasMany(e => e.VoiceRecordings)
            .WithMany(e => e.Chats)
            .UsingEntity<ChatsVoiceRecordings>();

        modelBuilder.Entity<VoiceRecordings>()
            .HasMany(e => e.Chats)
            .WithMany(e => e.VoiceRecordings)
            .UsingEntity<ChatsVoiceRecordings>();          
    }

    public DbSet<Users> Users { get; set; }
    public DbSet<Friends> Friends { get; set; }
    public DbSet<FriendInvates> FriendInvates { get; set; }
    public DbSet<Chats> Chats { get; set; }
    public DbSet<VoiceRecordings> VoiceRecordings { get; set; }
    public DbSet<UsersChats> UsersChats { get; set; }
    public DbSet<ChatsVoiceRecordings> ChatsVoiceRecordings { get; set; }
}
