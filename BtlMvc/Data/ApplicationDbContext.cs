using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BtlMvc.Models;

namespace DemoMvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<BtlMvc.Models.Student> Student { get; set; } = default!;
        public DbSet<BtlMvc.Models.Employee> Employee { get; set; } = default!;
    }
}
