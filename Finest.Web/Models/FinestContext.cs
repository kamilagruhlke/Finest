using Microsoft.EntityFrameworkCore;

namespace Finest.Models
{
    public class FinestContext : DbContext
    {
        public FinestContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<FinestModel> Finest { get; set; }
    }
}
