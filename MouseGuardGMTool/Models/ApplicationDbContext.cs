using Microsoft.EntityFrameworkCore;
using MouseGuardGMTool.Models;
namespace MouseGuardGMTool.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
        public DbSet<TheGuard> TheGuards { get; set; }
    }
}
