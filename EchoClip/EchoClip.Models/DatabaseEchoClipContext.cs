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
    }

    public DbSet<User> Users { get; set; }
}
