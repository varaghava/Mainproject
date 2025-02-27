using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mainproject.Models;


namespace Mainproject.Data
{
    public class MainprojectContext : DbContext
    {
        public MainprojectContext (DbContextOptions<MainprojectContext> options)
            : base(options)
        {
        }

        public DbSet<Mainproject.Models.Doctor> Doctor { get; set; } = default!;
        public DbSet<Mainproject.Models.Patient> Patient { get; set; } = default!;
        public DbSet<Mainproject.Models.User> User { get; set; } = default!;
        
    }
}
