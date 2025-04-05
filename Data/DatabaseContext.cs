using daily_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace daily_backend.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
        public DbSet<Article> Articles { get; set; }
    }
}


