using Jotex.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jotex.Data
{
    public class JotexDbContext : DbContext
    {
        public JotexDbContext(DbContextOptions<JotexDbContext> options) : base(options) { }
        public DbSet<Service> Services { get; set; }
    }
}
