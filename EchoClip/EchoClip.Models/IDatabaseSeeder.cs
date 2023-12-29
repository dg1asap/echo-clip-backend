using Microsoft.EntityFrameworkCore;

namespace EchoClip.Models;

public interface IDatabaseSeeder
{
    void seedData(ModelBuilder modlerBuilder);
}
