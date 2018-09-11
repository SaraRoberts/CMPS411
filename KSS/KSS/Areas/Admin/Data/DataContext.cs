using KSS.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSS.Areas.Admin.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            this.Database.Migrate();
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }
        public DbSet<Instance> Instance { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Location> Location { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            //Course
            modelBuilder.Entity<Course>()
                .HasOne(e => e.Prereq)
                .WithMany(e => e.Courses)
                .OnDelete(DeleteBehavior.Restrict);

            //Instance
            modelBuilder.Entity<Instance>()
                .HasOne(e => e.Course)
                .WithMany(e => e.Instances)
                .HasForeignKey(e => e.CourseId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            modelBuilder.Entity<Instance>()
                .HasOne(e => e.Location)
                .WithMany(e => e.Instances)
                .HasForeignKey(e => e.LocationId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            //Enrollment
            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.User)
                .WithMany(e => e.Enrollments)
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Instance)
                .WithMany(e => e.Enrollments)
                .HasForeignKey(e => e.InstanceId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
        }
    }
}
