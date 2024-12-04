using Microsoft.EntityFrameworkCore;

namespace MyAWebpp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Register> Customers { get; set; }
    }
}
