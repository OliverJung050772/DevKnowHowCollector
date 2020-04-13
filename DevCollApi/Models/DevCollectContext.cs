using Microsoft.EntityFrameworkCore;

namespace DevCollApi.Models
{
    public class DevCollectContext : DbContext
    {
        public DevCollectContext(DbContextOptions<DevCollectContext> options)
            : base(options)
        { }
        
        public DbSet<Collection> Collections { get; set; }
        public DbSet<Member> Members { get; set; } 
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source = devcoll.db");
    }
}
