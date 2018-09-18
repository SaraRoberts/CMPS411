﻿using KSS.Areas.Admin.Models;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

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
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //User
            modelBuilder.Entity<User>()
                .HasOne(e => e.Staff)
                .WithMany(e => e.User)
                .HasForeignKey(e => e.StaffId)
                .OnDelete(DeleteBehavior.Cascade);

            //Course
            modelBuilder.Entity<Course>()
                .HasOne(e => e.Prereq)
                .WithMany(e => e.Courses)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Course>()
                .HasOne(e => e.CourseCategory)
                .WithMany(e => e.Courses)
                .HasForeignKey(e => e.CategoryId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

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
            
            /*
            // Seeding database
            modelBuilder.Entity<Course>().HasData
            (
                new Course { CourseId = 1, Name = "Basic Life Support (BLS) for Healthcare Professionals", Description = "A 4 ½ hour initial course designed for Healthcare Professionals.  The course covers Adult, Child, and Infant one-rescuer CPR AED, as well as a new focused emphasis on teamwork with the adult, child, and infant two-person rescue.  Topics also include Rescue Breathing and Foreign Body Airway Obstruction. Cost includes the use of a textbook, written and practical exams, and a course completion certification(good for 2 years).New 2015 Guidelines!", BookAvailable = true, BookPrice = 25, PrereqId = null },
                new Course { CourseId = 2, Name = "Basic Life Support (BLS) with CPR for Healthcare Professionals -  Refresher", Description = "A 4 hour refresher course for the Healthcare Professional; this course offers guidelines in one and two-rescuer adult, child, and infant CPR, Foreign Body Airway Obstruction, and AED training. Cost includes the use of a students’ textbook, written and practical exams, and course completion certification(good for 2 years).New 2015 Guidelines!", BookAvailable = false, BookPrice = 0, PrereqId = null },
                new Course { CourseId = 3, Name = "BLS Online Recertification – Part 2", Description = "For those who have successfully completed the online portion of either BLS course.  Students MUST provide a copy of the online course completion certificate. Cost includes practice time, exam, and course completion certificate(good for 2 years)", BookAvailable = false, BookPrice = 0, PrereqId = 1 },
                new Course { CourseId = 4, Name = "Heartsaver CPR/AED ", Description = "A 2-3 hour course designed to teach the lay rescuer (security guards, personal trainers, church organization teachers, etc.) how to recognize and treat life-threatening emergencies whose job requires a course completion card documenting one-rescuer adult and/or pediatric CPR, Foreign Body Airway Obstruction, and AED training. Cost includes the use of a textbook, practice exam, and course completion certificate(good for 2 years).New 2015 Guidelines!", BookAvailable = true, BookPrice = 15, PrereqId = null },
                new Course { CourseId = 5, Name = "Heartsaver First Aid ", Description = "A 4 hour course designed for the general public or lay rescuer whose job requires a first aid course completion card.  The course provides the skills to effectively asses and maintain life from the critical minutes of an emergency until the arrival of emergency service personnel.  Depending on which modules the candidate wishes to take, the basic first aid course consists of General Principles, Medical Emergencies, and Injury Emergencies.  Also includes CPR and AED training, and Environmental Emergencies. Cost includes use of a textbook, practice exam, and course completion certificate(good for 2 years).New 2015 Guidelines!", BookAvailable = true, BookPrice = 15, PrereqId = null },
                new Course { CourseId = 6, Name = "Heartsaver Pediatric First Aid Course (Daycare/Childcare Providers)", Description = "A 6-8 hour First Aid course designed for childcare workers whose job requires a pediatric-specific first aid completion card.  This course provides the skills to effectively asses and maintain a child’s life in the critical minutes following an emergency until the arrival of emergency personnel.  This course covers all State of Louisiana required modules including Child Care specific topics, General Principles, Medical Emergencies, Injury Emergencies, and Environmental Emergencies.  Also includes CPR and AED training for Adult, Children, and Infants. Cost includes use of a textbook, skills, and course completion certification(good for 2 years).New 2015 Guidelines!", BookAvailable = false, BookPrice = 0, PrereqId = null },
                new Course { CourseId = 7, Name = "Family and Friends CPR (course designed for general public; non-certification course)", Description = "A 2 ½ hour entry level awareness program designed for the general public, parents, babysitters, grandparents, churches, clubs, etc.  The course covers American Heart Association guidelines for the one-rescuer adult including Pediatric CPR, relief of Foreign Body Airway Obstructions, the chain of survival, Basic First Aid, and recognizing the signs of a heart attack and stroke. Cost includes a student textbook.New 2016 Guidelines!", BookAvailable = false, BookPrice = 0, PrereqId = null },
                new Course { CourseId = 8, Name = "BLS CPR for Healthcare Providers, Instructor Course", Description = "This is a 16 - 20 hour course for those who wish to become AHA Instructor Candidates able to teach various levels of American Heart Association CPR.  Course is taught over 2 or 3 days. Successful completion of AHA BLS for Healthcare Providers Course, as well as each module instructor candidates wish to teach(Heartsaver First Aid, Heartsaver CPR / AED, etc.), and scoring 90 % or better on written examination(within 90 days of the instructor course) is required for completion. A letter of recommendation and completion of Core Instructor Course is required before applying. Cost includes all student level books, instructor manuals, practical exams, and test.New 2015 Guidelines!", BookAvailable = false, BookPrice = 0, PrereqId = 1 },
                new Course { CourseId = 9, Name = "CPR/AED Online Recertification – Part 2", Description = "For those who have successfully completed the online portion of the Heartsaver CPR/AED course.  Students MUST provide a copy of the online course completion certificate. Cost includes practice time, exam, and course completion certificate(good for 2 years)", BookAvailable = false, BookPrice = 0, PrereqId = 4 },
                new Course { CourseId = 10, Name = "First Aid Online Recertification – Part 2", Description = "For those who have successfully completed the online portion of the Heartsaver First Aid course.  Students MUST provide a copy of the online course completion certificate. Cost includes practice time, exam, and course completion certificate(good for 2 years)", BookAvailable = false, BookPrice = 0, PrereqId = 5 }
            );
       
            modelBuilder.Entity<Enrollment>().HasData
            (
                new Enrollment { EnrollmentId = 1, InstanceId = 1, UserId = 12, Status = 'E', BookBought = false }, new Enrollment { EnrollmentId = 17, InstanceId = 7, UserId = 9, Status = 'E', BookBought = false },
                new Enrollment { EnrollmentId = 2, InstanceId = 1, UserId = 2, Status = 'E', BookBought = false }, new Enrollment { EnrollmentId = 18, InstanceId = 7, UserId = 10, Status = 'E', BookBought = false },
                new Enrollment { EnrollmentId = 3, InstanceId = 1, UserId = 3, Status = 'E', BookBought = false }, new Enrollment { EnrollmentId = 19, InstanceId = 8, UserId = 10, Status = 'E', BookBought = false },
                new Enrollment { EnrollmentId = 4, InstanceId = 2, UserId = 4, Status = 'E', BookBought = false }, new Enrollment { EnrollmentId = 20, InstanceId = 8, UserId = 11, Status = 'E', BookBought = false },
                new Enrollment { EnrollmentId = 5, InstanceId = 2, UserId = 5, Status = 'E', BookBought = false }, new Enrollment { EnrollmentId = 21, InstanceId = 8, UserId = 12, Status = 'E', BookBought = false },
                new Enrollment { EnrollmentId = 6, InstanceId = 2, UserId = 6, Status = 'E', BookBought = false }, new Enrollment { EnrollmentId = 22, InstanceId = 9, UserId = 13, Status = 'E', BookBought = false },
                new Enrollment { EnrollmentId = 7, InstanceId = 3, UserId = 7, Status = 'E', BookBought = false }, new Enrollment { EnrollmentId = 23, InstanceId = 9, UserId = 14, Status = 'E', BookBought = false },
                new Enrollment { EnrollmentId = 8, InstanceId = 3, UserId = 8, Status = 'E', BookBought = false }, new Enrollment { EnrollmentId = 24, InstanceId = 9, UserId = 14, Status = 'E', BookBought = false },
                new Enrollment { EnrollmentId = 9, InstanceId = 3, UserId = 13, Status = 'E', BookBought = false }, new Enrollment { EnrollmentId = 25, InstanceId = 10, UserId = 14, Status = 'E', BookBought = false },
                new Enrollment { EnrollmentId = 10, InstanceId = 4, UserId = 2, Status = 'E', BookBought = false }, new Enrollment { EnrollmentId = 26, InstanceId = 10, UserId = 15, Status = 'E', BookBought = false },
                new Enrollment { EnrollmentId = 11, InstanceId = 4, UserId = 3, Status = 'E', BookBought = false }, new Enrollment { EnrollmentId = 27, InstanceId = 10, UserId = 16, Status = 'E', BookBought = false },
                new Enrollment { EnrollmentId = 12, InstanceId = 5, UserId = 4, Status = 'E', BookBought = false }, new Enrollment { EnrollmentId = 28, InstanceId = 11, UserId = 17, Status = 'E', BookBought = false },
                new Enrollment { EnrollmentId = 13, InstanceId = 5, UserId = 5, Status = 'E', BookBought = false }, new Enrollment { EnrollmentId = 29, InstanceId = 12, UserId = 3, Status = 'E', BookBought = false },
                new Enrollment { EnrollmentId = 14, InstanceId = 6, UserId = 6, Status = 'E', BookBought = false }, new Enrollment { EnrollmentId = 30, InstanceId = 12, UserId = 17, Status = 'E', BookBought = false },
                new Enrollment { EnrollmentId = 15, InstanceId = 6, UserId = 7, Status = 'E', BookBought = false }, new Enrollment { EnrollmentId = 31, InstanceId = 13, UserId = 2, Status = 'E', BookBought = false },
                new Enrollment { EnrollmentId = 16, InstanceId = 6, UserId = 8, Status = 'E', BookBought = false }, new Enrollment { EnrollmentId = 32, InstanceId = 13, UserId = 3, Status = 'E', BookBought = false }
            );
            modelBuilder.Entity<Instance>().HasData
            (
                new Instance { InstanceId = 1, StartDate = new DateTimeOffset(2018, 7, 1, 8, 6, 32, new TimeSpan(-6, 0, 0)), Price = 45.00, CourseId = 1, LocationId = 1, Seats = 25 },
                new Instance { InstanceId = 2, StartDate = new DateTimeOffset(2018, 7, 22, 8, 6, 32, new TimeSpan(-6, 0, 0)), Price = 45.00, CourseId = 1, LocationId = 2, Seats = 10 },
                new Instance { InstanceId = 3, StartDate = new DateTimeOffset(2018, 8, 2, 8, 6, 32, new TimeSpan(-6, 0, 0)), Price = 45.00, CourseId = 1, LocationId = 3, Seats = 30 },
                new Instance { InstanceId = 4, StartDate = new DateTimeOffset(2018, 8, 12, 8, 6, 32, new TimeSpan(-6, 0, 0)), Price = 45.00, CourseId = 2, LocationId = 1, Seats = 10 },
                new Instance { InstanceId = 5, StartDate = new DateTimeOffset(2018, 9, 12, 8, 6, 32, new TimeSpan(-6, 0, 0)), Price = 45.00, CourseId = 2, LocationId = 2, Seats = 30 },
                new Instance { InstanceId = 6, StartDate = new DateTimeOffset(2018, 9, 21, 8, 6, 32, new TimeSpan(-6, 0, 0)), Price = 45.00, CourseId = 2, LocationId = 3, Seats = 10 },
                new Instance { InstanceId = 7, StartDate = new DateTimeOffset(2018, 9, 30, 8, 6, 32, new TimeSpan(-6, 0, 0)), Price = 45.00, CourseId = 3, LocationId = 1, Seats = 12 },
                new Instance { InstanceId = 8, StartDate = new DateTimeOffset(2018, 9, 29, 8, 6, 32, new TimeSpan(-6, 0, 0)), Price = 45.00, CourseId = 3, LocationId = 2, Seats = 10 },
                new Instance { InstanceId = 9, StartDate = new DateTimeOffset(2018, 10, 1, 8, 6, 32, new TimeSpan(-6, 0, 0)), Price = 45.00, CourseId = 3, LocationId = 3, Seats = 10 },
                new Instance { InstanceId = 10, StartDate = new DateTimeOffset(2018, 10, 24, 8, 6, 32, new TimeSpan(-6, 0, 0)), Price = 45.00, CourseId = 4, LocationId = 1, Seats = 25 },
                new Instance { InstanceId = 11, StartDate = new DateTimeOffset(2018, 10, 25, 8, 6, 32, new TimeSpan(-6, 0, 0)), Price = 45.00, CourseId = 4, LocationId = 1, Seats = 25 },
                new Instance { InstanceId = 12, StartDate = new DateTimeOffset(2018, 11, 1, 8, 6, 32, new TimeSpan(-6, 0, 0)), Price = 45.00, CourseId = 5, LocationId = 1, Seats = 15 },
                new Instance { InstanceId = 13, StartDate = new DateTimeOffset(2018, 11, 11, 8, 6, 32, new TimeSpan(-6, 0, 0)), Price = 45.00, CourseId = 5, LocationId = 2, Seats = 25 },
                new Instance { InstanceId = 14, StartDate = new DateTimeOffset(2018, 11, 13, 8, 6, 32, new TimeSpan(-6, 0, 0)), Price = 45.00, CourseId = 5, LocationId = 2, Seats = 25 },
                new Instance { InstanceId = 15, StartDate = new DateTimeOffset(2018, 11, 14, 8, 6, 32, new TimeSpan(-6, 0, 0)), Price = 45.00, CourseId = 5, LocationId = 2, Seats = 25 }
            );
            modelBuilder.Entity<Location>().HasData
            (
                new Location { LocationId = 1, Street = "104 Smith Street", City = "Hammond", State = "LA", Zipcode = 70403 },
                new Location { LocationId = 2, Street = "92 Hill Street", City = "Tickfaw", State = "LA", Zipcode = 70442 },
                new Location { LocationId = 3, Street = "12044 Hwy 40", City = "Independence", State = "LA", Zipcode = 70443 }
            );
            */
            //------admin password/salt
            byte[] saltAdmin = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltAdmin);
            }
            string hashedAdmin = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: "admin",
                salt: saltAdmin,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));

            //------student password/salt
            byte[] saltStudent = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltStudent);
            }
            string hashedStudent = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: "student",
                salt: saltStudent,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));

            modelBuilder.Entity<User>().HasData
            (
                // admin
                new User { UserId = 1, FirstName = "Becky", LastName = "Smith", Phone = "1112223333", Email = "admin@admin.com", Password = hashedAdmin, Salt = saltAdmin, Role = "Admin" },
                // students
                new User { UserId = 2, FirstName = "Paul", LastName = "Dig", Phone = "1112223333", Email = "student1@student.com", Password = hashedStudent, Salt = saltStudent, Role = "User" },
                new User { UserId = 3, FirstName = "Mike", LastName = "Waters", Phone = "1112223333", Email = "student2@student.com", Password = hashedStudent, Salt = saltStudent, Role = "User" },
                new User { UserId = 4, FirstName = "Russel", LastName = "Chavers", Phone = "1112223333", Email = "student3@student.com", Password = hashedStudent, Salt = saltStudent, Role = "User" },
                new User { UserId = 5, FirstName = "Sharon", LastName = "Manino", Phone = "1112223333", Email = "student4@student.com", Password = hashedStudent, Salt = saltStudent, Role = "User" },
                new User { UserId = 6, FirstName = "Amy", LastName = "Hillbond", Phone = "1112223333", Email = "student5@student.com", Password = hashedStudent, Salt = saltStudent, Role = "User" },
                new User { UserId = 7, FirstName = "Bill", LastName = "Everet", Phone = "1112223333", Email = "student6@student.com", Password = hashedStudent, Salt = saltStudent, Role = "User" },
                new User { UserId = 8, FirstName = "Trenton", LastName = "Hillsong", Phone = "1112223333", Email = "student7@student.com", Password = hashedStudent, Salt = saltStudent, Role = "User" },
                new User { UserId = 9, FirstName = "Colin", LastName = "Livers", Phone = "1112223333", Email = "student8@student.com", Password = hashedStudent, Salt = saltStudent, Role = "User" },
                new User { UserId = 10, FirstName = "Babe", LastName = "Ruth", Phone = "1112223333", Email = "student9@student.com", Password = hashedStudent, Salt = saltStudent, Role = "User" },
                new User { UserId = 11, FirstName = "Tim", LastName = "Hammond", Phone = "1112223333", Email = "student10@student.com", Password = hashedStudent, Salt = saltStudent, Role = "User" },
                new User { UserId = 12, FirstName = "Gary", LastName = "Aimes", Phone = "1112223333", Email = "student11@student.com", Password = hashedStudent, Salt = saltStudent, Role = "User" },
                new User { UserId = 13, FirstName = "Lucy", LastName = "Vilardo", Phone = "1112223333", Email = "student12@student.com", Password = hashedStudent, Salt = saltStudent, Role = "User" },
                new User { UserId = 14, FirstName = "Tom", LastName = "Avers", Phone = "1112223333", Email = "student13@student.com", Password = hashedStudent, Salt = saltStudent, Role = "User" },
                new User { UserId = 15, FirstName = "Amanda", LastName = "Catalonato", Phone = "1112223333", Email = "student14@student.com", Password = hashedStudent, Salt = saltStudent, Role = "User" },
                new User { UserId = 16, FirstName = "Donald", LastName = "Hill", Phone = "1112223333", Email = "student15@student.com", Password = hashedStudent, Salt = saltStudent, Role = "User" },
                new User { UserId = 17, FirstName = "Richard", LastName = "Newman", Phone = "1112223333", Email = "student16@student.com", Password = hashedStudent, Salt = saltStudent, Role = "User" }
            );
        }
    }
}
