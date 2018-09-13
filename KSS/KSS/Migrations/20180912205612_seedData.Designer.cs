﻿// <auto-generated />
using System;
using KSS.Areas.Admin.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KSS.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20180912205612_seedData")]
    partial class seedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KSS.Areas.Admin.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Book");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int?>("PrereqId");

                    b.HasKey("CourseId");

                    b.HasIndex("PrereqId");

                    b.ToTable("Course");

                    b.HasData(
                        new { CourseId = 1, Book = false, Description = "CPR ", Name = "CPR 101" },
                        new { CourseId = 2, Book = false, Description = "Hammond", Name = "CPR 201" },
                        new { CourseId = 3, Book = false, Description = "Hammond", Name = "CPR 301" },
                        new { CourseId = 4, Book = false, Description = "Hammond", Name = "EMT 101" },
                        new { CourseId = 5, Book = false, Description = "Hammond", Name = "EMT 201" },
                        new { CourseId = 6, Book = false, Description = "Hammond", Name = "EMT 301" }
                    );
                });

            modelBuilder.Entity("KSS.Areas.Admin.Models.Enrollment", b =>
                {
                    b.Property<int>("EnrollmentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InstanceId");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<int>("UserId");

                    b.HasKey("EnrollmentId");

                    b.HasIndex("InstanceId");

                    b.HasIndex("UserId");

                    b.ToTable("Enrollment");

                    b.HasData(
                        new { EnrollmentId = 1, InstanceId = 1, Status = "E", UserId = 12 },
                        new { EnrollmentId = 17, InstanceId = 7, Status = "E", UserId = 9 },
                        new { EnrollmentId = 2, InstanceId = 1, Status = "E", UserId = 2 },
                        new { EnrollmentId = 18, InstanceId = 7, Status = "E", UserId = 10 },
                        new { EnrollmentId = 3, InstanceId = 1, Status = "E", UserId = 3 },
                        new { EnrollmentId = 19, InstanceId = 8, Status = "E", UserId = 10 },
                        new { EnrollmentId = 4, InstanceId = 2, Status = "E", UserId = 4 },
                        new { EnrollmentId = 20, InstanceId = 8, Status = "E", UserId = 11 },
                        new { EnrollmentId = 5, InstanceId = 2, Status = "E", UserId = 5 },
                        new { EnrollmentId = 21, InstanceId = 8, Status = "E", UserId = 12 },
                        new { EnrollmentId = 6, InstanceId = 2, Status = "E", UserId = 6 },
                        new { EnrollmentId = 22, InstanceId = 9, Status = "E", UserId = 13 },
                        new { EnrollmentId = 7, InstanceId = 3, Status = "E", UserId = 7 },
                        new { EnrollmentId = 23, InstanceId = 9, Status = "E", UserId = 14 },
                        new { EnrollmentId = 8, InstanceId = 3, Status = "E", UserId = 8 },
                        new { EnrollmentId = 24, InstanceId = 9, Status = "E", UserId = 14 },
                        new { EnrollmentId = 9, InstanceId = 3, Status = "E", UserId = 13 },
                        new { EnrollmentId = 25, InstanceId = 10, Status = "E", UserId = 14 },
                        new { EnrollmentId = 10, InstanceId = 4, Status = "E", UserId = 2 },
                        new { EnrollmentId = 26, InstanceId = 10, Status = "E", UserId = 15 },
                        new { EnrollmentId = 11, InstanceId = 4, Status = "E", UserId = 3 },
                        new { EnrollmentId = 27, InstanceId = 10, Status = "E", UserId = 16 },
                        new { EnrollmentId = 12, InstanceId = 5, Status = "E", UserId = 4 },
                        new { EnrollmentId = 28, InstanceId = 11, Status = "E", UserId = 17 },
                        new { EnrollmentId = 13, InstanceId = 5, Status = "E", UserId = 5 },
                        new { EnrollmentId = 29, InstanceId = 12, Status = "E", UserId = 3 },
                        new { EnrollmentId = 14, InstanceId = 6, Status = "E", UserId = 6 },
                        new { EnrollmentId = 30, InstanceId = 12, Status = "E", UserId = 17 },
                        new { EnrollmentId = 15, InstanceId = 6, Status = "E", UserId = 7 },
                        new { EnrollmentId = 31, InstanceId = 13, Status = "E", UserId = 2 },
                        new { EnrollmentId = 16, InstanceId = 6, Status = "E", UserId = 8 },
                        new { EnrollmentId = 32, InstanceId = 13, Status = "E", UserId = 3 }
                    );
                });

            modelBuilder.Entity("KSS.Areas.Admin.Models.Instance", b =>
                {
                    b.Property<int>("InstanceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId");

                    b.Property<int>("LocationId");

                    b.Property<double>("Price");

                    b.Property<int>("Seats");

                    b.Property<DateTimeOffset>("StartDate");

                    b.HasKey("InstanceId");

                    b.HasIndex("CourseId");

                    b.HasIndex("LocationId");

                    b.ToTable("Instance");

                    b.HasData(
                        new { InstanceId = 1, CourseId = 1, LocationId = 1, Price = 45.0, Seats = 25, StartDate = new DateTimeOffset(new DateTime(2018, 7, 1, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                        new { InstanceId = 2, CourseId = 1, LocationId = 2, Price = 45.0, Seats = 10, StartDate = new DateTimeOffset(new DateTime(2018, 7, 22, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                        new { InstanceId = 3, CourseId = 1, LocationId = 3, Price = 45.0, Seats = 30, StartDate = new DateTimeOffset(new DateTime(2018, 8, 2, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                        new { InstanceId = 4, CourseId = 2, LocationId = 1, Price = 45.0, Seats = 10, StartDate = new DateTimeOffset(new DateTime(2018, 8, 12, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                        new { InstanceId = 5, CourseId = 2, LocationId = 2, Price = 45.0, Seats = 30, StartDate = new DateTimeOffset(new DateTime(2018, 9, 12, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                        new { InstanceId = 6, CourseId = 2, LocationId = 3, Price = 45.0, Seats = 10, StartDate = new DateTimeOffset(new DateTime(2018, 9, 21, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                        new { InstanceId = 7, CourseId = 3, LocationId = 1, Price = 45.0, Seats = 12, StartDate = new DateTimeOffset(new DateTime(2018, 9, 30, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                        new { InstanceId = 8, CourseId = 3, LocationId = 2, Price = 45.0, Seats = 10, StartDate = new DateTimeOffset(new DateTime(2018, 9, 29, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                        new { InstanceId = 9, CourseId = 3, LocationId = 3, Price = 45.0, Seats = 10, StartDate = new DateTimeOffset(new DateTime(2018, 10, 1, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                        new { InstanceId = 10, CourseId = 4, LocationId = 1, Price = 45.0, Seats = 25, StartDate = new DateTimeOffset(new DateTime(2018, 10, 24, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                        new { InstanceId = 11, CourseId = 4, LocationId = 1, Price = 45.0, Seats = 25, StartDate = new DateTimeOffset(new DateTime(2018, 10, 25, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                        new { InstanceId = 12, CourseId = 5, LocationId = 1, Price = 45.0, Seats = 15, StartDate = new DateTimeOffset(new DateTime(2018, 11, 1, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                        new { InstanceId = 13, CourseId = 5, LocationId = 2, Price = 45.0, Seats = 25, StartDate = new DateTimeOffset(new DateTime(2018, 11, 11, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                        new { InstanceId = 14, CourseId = 5, LocationId = 2, Price = 45.0, Seats = 25, StartDate = new DateTimeOffset(new DateTime(2018, 11, 13, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                        new { InstanceId = 15, CourseId = 5, LocationId = 2, Price = 45.0, Seats = 25, StartDate = new DateTimeOffset(new DateTime(2018, 11, 14, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) }
                    );
                });

            modelBuilder.Entity("KSS.Areas.Admin.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("State");

                    b.Property<string>("Street");

                    b.Property<int>("Zipcode");

                    b.HasKey("LocationId");

                    b.ToTable("Location");

                    b.HasData(
                        new { LocationId = 1, City = "Hammond", State = "LA", Street = "104 Smith Street", Zipcode = 70403 },
                        new { LocationId = 2, City = "Tickfaw", State = "LA", Street = "92 Hill Street", Zipcode = 70442 },
                        new { LocationId = 3, City = "Independence", State = "LA", Street = "12044 Hwy 40", Zipcode = 70443 }
                    );
                });

            modelBuilder.Entity("KSS.Areas.Admin.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<string>("Phone");

                    b.Property<string>("Role");

                    b.Property<byte[]>("Salt");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new { UserId = 1, Email = "admin@admin.com", FirstName = "Smith", LastName = "Hammond", Password = "YpMFOfOxVxnZBqHd6ahEPRNyeG8BHtmwtZYXqC99ydQ=", Phone = "1112223333", Role = "Admin", Salt = new byte[] { 51, 80, 51, 12, 169, 93, 189, 143, 52, 28, 99, 109, 215, 250, 219, 8 } },
                        new { UserId = 2, Email = "student1@student.com", FirstName = "Smith", LastName = "Hammond", Password = "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", Phone = "1112223333", Role = "User", Salt = new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } },
                        new { UserId = 3, Email = "student2@student.com", FirstName = "Smith", LastName = "Hammond", Password = "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", Phone = "1112223333", Role = "User", Salt = new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } },
                        new { UserId = 4, Email = "student3@student.com", FirstName = "Smith", LastName = "Hammond", Password = "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", Phone = "1112223333", Role = "User", Salt = new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } },
                        new { UserId = 5, Email = "student4@student.com", FirstName = "Smith", LastName = "Hammond", Password = "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", Phone = "1112223333", Role = "User", Salt = new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } },
                        new { UserId = 6, Email = "student5@student.com", FirstName = "Smith", LastName = "Hammond", Password = "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", Phone = "1112223333", Role = "User", Salt = new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } },
                        new { UserId = 7, Email = "student6@student.com", FirstName = "Smith", LastName = "Hammond", Password = "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", Phone = "1112223333", Role = "User", Salt = new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } },
                        new { UserId = 8, Email = "student7@student.com", FirstName = "Smith", LastName = "Hammond", Password = "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", Phone = "1112223333", Role = "User", Salt = new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } },
                        new { UserId = 9, Email = "student8@student.com", FirstName = "Smith", LastName = "Hammond", Password = "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", Phone = "1112223333", Role = "User", Salt = new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } },
                        new { UserId = 10, Email = "student9@student.com", FirstName = "Smith", LastName = "Hammond", Password = "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", Phone = "1112223333", Role = "User", Salt = new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } },
                        new { UserId = 11, Email = "student10@student.com", FirstName = "Smith", LastName = "Hammond", Password = "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", Phone = "1112223333", Role = "User", Salt = new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } },
                        new { UserId = 12, Email = "student11@student.com", FirstName = "Smith", LastName = "Hammond", Password = "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", Phone = "1112223333", Role = "User", Salt = new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } },
                        new { UserId = 13, Email = "student12@student.com", FirstName = "Smith", LastName = "Hammond", Password = "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", Phone = "1112223333", Role = "User", Salt = new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } },
                        new { UserId = 14, Email = "student13@student.com", FirstName = "Smith", LastName = "Hammond", Password = "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", Phone = "1112223333", Role = "User", Salt = new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } },
                        new { UserId = 15, Email = "student14@student.com", FirstName = "Smith", LastName = "Hammond", Password = "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", Phone = "1112223333", Role = "User", Salt = new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } },
                        new { UserId = 16, Email = "student15@student.com", FirstName = "Smith", LastName = "Hammond", Password = "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", Phone = "1112223333", Role = "User", Salt = new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } },
                        new { UserId = 17, Email = "student16@student.com", FirstName = "Smith", LastName = "Hammond", Password = "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", Phone = "1112223333", Role = "User", Salt = new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } }
                    );
                });

            modelBuilder.Entity("KSS.Areas.Admin.Models.Course", b =>
                {
                    b.HasOne("KSS.Areas.Admin.Models.Course", "Prereq")
                        .WithMany("Courses")
                        .HasForeignKey("PrereqId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("KSS.Areas.Admin.Models.Enrollment", b =>
                {
                    b.HasOne("KSS.Areas.Admin.Models.Instance", "Instance")
                        .WithMany("Enrollments")
                        .HasForeignKey("InstanceId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("KSS.Areas.Admin.Models.User", "User")
                        .WithMany("Enrollments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("KSS.Areas.Admin.Models.Instance", b =>
                {
                    b.HasOne("KSS.Areas.Admin.Models.Course", "Course")
                        .WithMany("Instances")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("KSS.Areas.Admin.Models.Location", "Location")
                        .WithMany("Instances")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}