using System;
using System.Collections.Generic;
using System.Text;
using KSS.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KSS.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<KSSUser> KSSUsers { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }
        public DbSet<Instance> Instance { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Location> Location { get; set; }
    }
}
