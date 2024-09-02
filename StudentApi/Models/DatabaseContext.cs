using Microsoft.EntityFrameworkCore;

namespace StudentApi.Models
{
    public class DatabaseContext : DbContext
    {
       public DbSet<Student> Students { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
        {
        }
    }
}
