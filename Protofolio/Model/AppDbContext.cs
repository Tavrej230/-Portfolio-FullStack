using Microsoft.EntityFrameworkCore;

namespace Protofolio.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        public DbSet<ContactMessage> ContactMessages
        {
            get; set;
        }
    }
}
