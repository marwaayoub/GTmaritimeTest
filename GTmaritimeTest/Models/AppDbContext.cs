using Microsoft.EntityFrameworkCore;

namespace GTmaritimeTest.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<MaritimeMessage> MaritimeMessages { get; set; }
    }
} 