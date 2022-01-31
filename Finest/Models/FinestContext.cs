using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
