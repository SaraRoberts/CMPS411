using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KSS.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zipcode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Salt = table.Column<byte[]>(nullable: true),
                    Role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    CourseId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TypicalPrice = table.Column<int>(nullable: false),
                    BookAvailable = table.Column<bool>(nullable: false),
                    BookPrice = table.Column<decimal>(nullable: false),
                    PrereqId = table.Column<int>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_Course_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Course_Course_PrereqId",
                        column: x => x.PrereqId,
                        principalTable: "Course",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bio",
                columns: table => new
                {
                    StaffBioId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Picture = table.Column<string>(nullable: true),
                    Bio = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bio", x => x.StaffBioId);
                    table.ForeignKey(
                        name: "FK_Bio_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Instance",
                columns: table => new
                {
                    InstanceId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StartDate = table.Column<DateTimeOffset>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Seats = table.Column<int>(nullable: false),
                    Graded = table.Column<bool>(nullable: false),
                    CourseId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false),
                    InstructorId = table.Column<int>(nullable: false),
                    BookAvailable = table.Column<bool>(nullable: false),
                    BookPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instance", x => x.InstanceId);
                    table.ForeignKey(
                        name: "FK_Instance_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Instance_Users_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Instance_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Enrollment",
                columns: table => new
                {
                    EnrollmentId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    InstanceId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: false),
                    BookBought = table.Column<bool>(nullable: false),
                    Paid = table.Column<bool>(nullable: false),
                    Confirmed = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollment", x => x.EnrollmentId);
                    table.ForeignKey(
                        name: "FK_Enrollment_Instance_InstanceId",
                        column: x => x.InstanceId,
                        principalTable: "Instance",
                        principalColumn: "InstanceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Enrollment_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "CPR" },
                    { 2, "BLS" },
                    { 3, "AED" },
                    { 4, "EMT" }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "LocationId", "City", "Name", "State", "Street", "Zipcode" },
                values: new object[,]
                {
                    { 1, "Hammond", "Hammond Fire Department", "LA", "104 Smith Street", 70403 },
                    { 2, "Tickfaw", "Tickfaw Emergency Care", "LA", "92 Hill Street", 70442 },
                    { 3, "Independence", "Independence Fire", "LA", "12044 Hwy 40", 70443 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "FirstName", "LastName", "Password", "Phone", "Role", "Salt" },
                values: new object[,]
                {
                    { 15, "student14@student.com", "Amanda", "Catalonato", "1LVplJOTTvh5whisx5JjlNeOW1+bh3kzrVRu5CANh/Y=", "1112223333", "User", new byte[] { 7, 104, 56, 1, 82, 139, 36, 152, 31, 135, 14, 115, 209, 195, 1, 19 } },
                    { 14, "student13@student.com", "Tom", "Avers", "1LVplJOTTvh5whisx5JjlNeOW1+bh3kzrVRu5CANh/Y=", "1112223333", "User", new byte[] { 7, 104, 56, 1, 82, 139, 36, 152, 31, 135, 14, 115, 209, 195, 1, 19 } },
                    { 13, "student12@student.com", "Lucy", "Vilardo", "1LVplJOTTvh5whisx5JjlNeOW1+bh3kzrVRu5CANh/Y=", "1112223333", "User", new byte[] { 7, 104, 56, 1, 82, 139, 36, 152, 31, 135, 14, 115, 209, 195, 1, 19 } },
                    { 12, "student11@student.com", "Gary", "Aimes", "1LVplJOTTvh5whisx5JjlNeOW1+bh3kzrVRu5CANh/Y=", "1112223333", "User", new byte[] { 7, 104, 56, 1, 82, 139, 36, 152, 31, 135, 14, 115, 209, 195, 1, 19 } },
                    { 11, "student10@student.com", "Tim", "Hammond", "1LVplJOTTvh5whisx5JjlNeOW1+bh3kzrVRu5CANh/Y=", "1112223333", "User", new byte[] { 7, 104, 56, 1, 82, 139, 36, 152, 31, 135, 14, 115, 209, 195, 1, 19 } },
                    { 10, "student9@student.com", "Babe", "Ruth", "1LVplJOTTvh5whisx5JjlNeOW1+bh3kzrVRu5CANh/Y=", "1112223333", "User", new byte[] { 7, 104, 56, 1, 82, 139, 36, 152, 31, 135, 14, 115, 209, 195, 1, 19 } },
                    { 9, "student8@student.com", "Colin", "Livers", "1LVplJOTTvh5whisx5JjlNeOW1+bh3kzrVRu5CANh/Y=", "1112223333", "User", new byte[] { 7, 104, 56, 1, 82, 139, 36, 152, 31, 135, 14, 115, 209, 195, 1, 19 } },
                    { 5, "student4@student.com", "Sharon", "Manino", "1LVplJOTTvh5whisx5JjlNeOW1+bh3kzrVRu5CANh/Y=", "1112223333", "Staff", new byte[] { 7, 104, 56, 1, 82, 139, 36, 152, 31, 135, 14, 115, 209, 195, 1, 19 } },
                    { 7, "student6@student.com", "Bill", "Everet", "1LVplJOTTvh5whisx5JjlNeOW1+bh3kzrVRu5CANh/Y=", "1112223333", "User", new byte[] { 7, 104, 56, 1, 82, 139, 36, 152, 31, 135, 14, 115, 209, 195, 1, 19 } },
                    { 6, "student5@student.com", "Amy", "Hillbond", "1LVplJOTTvh5whisx5JjlNeOW1+bh3kzrVRu5CANh/Y=", "1112223333", "Staff", new byte[] { 7, 104, 56, 1, 82, 139, 36, 152, 31, 135, 14, 115, 209, 195, 1, 19 } },
                    { 16, "student15@student.com", "Donald", "Hill", "1LVplJOTTvh5whisx5JjlNeOW1+bh3kzrVRu5CANh/Y=", "1112223333", "User", new byte[] { 7, 104, 56, 1, 82, 139, 36, 152, 31, 135, 14, 115, 209, 195, 1, 19 } },
                    { 4, "student3@student.com", "Russel", "Chavers", "1LVplJOTTvh5whisx5JjlNeOW1+bh3kzrVRu5CANh/Y=", "1112223333", "Staff", new byte[] { 7, 104, 56, 1, 82, 139, 36, 152, 31, 135, 14, 115, 209, 195, 1, 19 } },
                    { 3, "student2@student.com", "Mike", "Waters", "1LVplJOTTvh5whisx5JjlNeOW1+bh3kzrVRu5CANh/Y=", "1112223333", "Staff", new byte[] { 7, 104, 56, 1, 82, 139, 36, 152, 31, 135, 14, 115, 209, 195, 1, 19 } },
                    { 2, "student1@student.com", "Paul", "Dig", "1LVplJOTTvh5whisx5JjlNeOW1+bh3kzrVRu5CANh/Y=", "1112223333", "Staff", new byte[] { 7, 104, 56, 1, 82, 139, 36, 152, 31, 135, 14, 115, 209, 195, 1, 19 } },
                    { 1, "admin@admin.com", "Becky", "Smith", "PuD9Mus/N0bR7I5chCeSSu9WtDIYBZea+y5z/u0htkM=", "1112223333", "Admin", new byte[] { 154, 5, 167, 149, 131, 140, 217, 208, 138, 75, 13, 187, 95, 145, 215, 255 } },
                    { 8, "student7@student.com", "Trenton", "Hillsong", "1LVplJOTTvh5whisx5JjlNeOW1+bh3kzrVRu5CANh/Y=", "1112223333", "User", new byte[] { 7, 104, 56, 1, 82, 139, 36, 152, 31, 135, 14, 115, 209, 195, 1, 19 } },
                    { 17, "student16@student.com", "Richard", "Newman", "1LVplJOTTvh5whisx5JjlNeOW1+bh3kzrVRu5CANh/Y=", "1112223333", "User", new byte[] { 7, 104, 56, 1, 82, 139, 36, 152, 31, 135, 14, 115, 209, 195, 1, 19 } }
                });

            migrationBuilder.InsertData(
                table: "Bio",
                columns: new[] { "StaffBioId", "Bio", "Picture", "UserId" },
                values: new object[,]
                {
                    { 1, "I am Staff 1!", "Placeholder", 1 },
                    { 2, "I am Staff 2!", "Placeholder", 2 },
                    { 3, "I am Staff 3!", "Placeholder", 3 },
                    { 4, "I am Staff 4!", "Placeholder", 4 },
                    { 5, "I am Staff 5!", "Placeholder", 5 },
                    { 6, "I am Staff 6!", "Placeholder", 6 }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "BookAvailable", "BookPrice", "CategoryId", "Description", "Name", "PrereqId", "TypicalPrice" },
                values: new object[,]
                {
                    { 1, true, 25m, 1, "A 4 ½ hour initial course designed for Healthcare Professionals.  The course covers Adult, Child, and Infant one-rescuer CPR AED, as well as a new focused emphasis on teamwork with the adult, child, and infant two-person rescue.  Topics also include Rescue Breathing and Foreign Body Airway Obstruction. Cost includes the use of a textbook, written and practical exams, and a course completion certification(good for 2 years).New 2015 Guidelines!", "Basic Life Support", null, 50 },
                    { 6, false, 0m, 1, "A 6-8 hour First Aid course designed for childcare workers whose job requires a pediatric-specific first aid completion card.  This course provides the skills to effectively asses and maintain a child’s life in the critical minutes following an emergency until the arrival of emergency personnel.  This course covers all State of Louisiana required modules including Child Care specific topics, General Principles, Medical Emergencies, Injury Emergencies, and Environmental Emergencies.  Also includes CPR and AED training for Adult, Children, and Infants. Cost includes use of a textbook, skills, and course completion certification(good for 2 years).New 2015 Guidelines!", "Heartsaver Pediatric First Aid", null, 50 },
                    { 2, false, 0m, 2, "A 4 hour refresher course for the Healthcare Professional; this course offers guidelines in one and two-rescuer adult, child, and infant CPR, Foreign Body Airway Obstruction, and AED training. Cost includes the use of a students’ textbook, written and practical exams, and course completion certification(good for 2 years).New 2015 Guidelines!", "Basic Life Support w/ CPR Refr", null, 50 },
                    { 5, true, 15m, 2, "A 4 hour course designed for the general public or lay rescuer whose job requires a first aid course completion card.  The course provides the skills to effectively asses and maintain life from the critical minutes of an emergency until the arrival of emergency service personnel.  Depending on which modules the candidate wishes to take, the basic first aid course consists of General Principles, Medical Emergencies, and Injury Emergencies.  Also includes CPR and AED training, and Environmental Emergencies. Cost includes use of a textbook, practice exam, and course completion certificate(good for 2 years).New 2015 Guidelines!", "Heartsaver First Aid ", null, 50 },
                    { 7, false, 0m, 2, "A 2 ½ hour entry level awareness program designed for the general public, parents, babysitters, grandparents, churches, clubs, etc.  The course covers American Heart Association guidelines for the one-rescuer adult including Pediatric CPR, relief of Foreign Body Airway Obstructions, the chain of survival, Basic First Aid, and recognizing the signs of a heart attack and stroke. Cost includes a student textbook.New 2016 Guidelines!", "Family and Friends CPR", null, 50 },
                    { 3, false, 0m, 3, "For those who have successfully completed the online portion of either BLS course.  Students MUST provide a copy of the online course completion certificate. Cost includes practice time, exam, and course completion certificate(good for 2 years)", "BLS Online Recert – Part 2", 3, 0 },
                    { 4, true, 15m, 4, "A 2-3 hour course designed to teach the lay rescuer (security guards, personal trainers, church organization teachers, etc.) how to recognize and treat life-threatening emergencies whose job requires a course completion card documenting one-rescuer adult and/or pediatric CPR, Foreign Body Airway Obstruction, and AED training. Cost includes the use of a textbook, practice exam, and course completion certificate(good for 2 years).New 2015 Guidelines!", "Heartsaver CPR/AED ", null, 50 }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "BookAvailable", "BookPrice", "CategoryId", "Description", "Name", "PrereqId", "TypicalPrice" },
                values: new object[,]
                {
                    { 8, false, 0m, 2, "This is a 16 - 20 hour course for those who wish to become AHA Instructor Candidates able to teach various levels of American Heart Association CPR.  Course is taught over 2 or 3 days. Successful completion of AHA BLS for Healthcare Providers Course, as well as each module instructor candidates wish to teach(Heartsaver First Aid, Heartsaver CPR / AED, etc.), and scoring 90 % or better on written examination(within 90 days of the instructor course) is required for completion. A letter of recommendation and completion of Core Instructor Course is required before applying. Cost includes all student level books, instructor manuals, practical exams, and test.New 2015 Guidelines!", "BLS CPR, Instructor Course", 1, 50 },
                    { 9, false, 0m, 1, "For those who have successfully completed the online portion of the Heartsaver CPR/AED course.  Students MUST provide a copy of the online course completion certificate. Cost includes practice time, exam, and course completion certificate(good for 2 years)", "CPR/AED Online Recert 2", 4, 50 },
                    { 10, false, 0m, 2, "For those who have successfully completed the online portion of the Heartsaver First Aid course.  Students MUST provide a copy of the online course completion certificate. Cost includes practice time, exam, and course completion certificate(good for 2 years)", "First Aid Online Recert 2", 5, 50 }
                });

            migrationBuilder.InsertData(
                table: "Instance",
                columns: new[] { "InstanceId", "BookAvailable", "BookPrice", "CourseId", "Graded", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[,]
                {
                    { 8, true, 21.0, 4, false, 4, 1, 138.0, 22, new DateTimeOffset(new DateTime(2018, 11, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 25, true, 40.0, 3, false, 3, 1, 141.0, 30, new DateTimeOffset(new DateTime(2016, 9, 23, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 22, true, 37.0, 3, false, 5, 2, 127.0, 28, new DateTimeOffset(new DateTime(2018, 2, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 1, true, 31.0, 3, false, 3, 1, 97.0, 26, new DateTimeOffset(new DateTime(2016, 4, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 24, true, 42.0, 7, false, 1, 3, 120.0, 13, new DateTimeOffset(new DateTime(2019, 7, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 17, true, 47.0, 7, false, 5, 2, 139.0, 21, new DateTimeOffset(new DateTime(2019, 4, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 13, true, 28.0, 7, false, 6, 2, 135.0, 23, new DateTimeOffset(new DateTime(2018, 3, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 19, true, 51.0, 2, false, 1, 2, 84.0, 10, new DateTimeOffset(new DateTime(2016, 7, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 18, true, 26.0, 2, false, 6, 3, 87.0, 25, new DateTimeOffset(new DateTime(2018, 10, 12, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 16, true, 50.0, 2, false, 4, 3, 45.0, 24, new DateTimeOffset(new DateTime(2019, 9, 19, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 14, true, 15.0, 2, false, 5, 3, 91.0, 30, new DateTimeOffset(new DateTime(2016, 5, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 27, true, 22.0, 6, false, 4, 3, 98.0, 30, new DateTimeOffset(new DateTime(2018, 3, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 26, true, 20.0, 6, false, 3, 2, 137.0, 14, new DateTimeOffset(new DateTime(2017, 5, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 10, true, 39.0, 6, false, 1, 3, 118.0, 26, new DateTimeOffset(new DateTime(2018, 3, 20, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 20, true, 27.0, 1, false, 2, 1, 132.0, 18, new DateTimeOffset(new DateTime(2018, 3, 26, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 12, true, 42.0, 1, false, 5, 3, 116.0, 16, new DateTimeOffset(new DateTime(2016, 7, 16, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 7, true, 49.0, 1, false, 3, 2, 83.0, 11, new DateTimeOffset(new DateTime(2017, 5, 12, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 3, true, 30.0, 1, false, 1, 1, 79.0, 21, new DateTimeOffset(new DateTime(2017, 3, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 2, true, 52.0, 1, false, 1, 2, 132.0, 24, new DateTimeOffset(new DateTime(2018, 6, 17, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 23, true, 55.0, 4, false, 3, 3, 61.0, 19, new DateTimeOffset(new DateTime(2018, 4, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 28, true, 33.0, 4, false, 3, 2, 108.0, 18, new DateTimeOffset(new DateTime(2016, 2, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "EnrollmentId", "BookBought", "Confirmed", "InstanceId", "Paid", "Status", "UserId" },
                values: new object[,]
                {
                    { 301, true, new DateTime(2016, 9, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 18, true, "E", 12 },
                    { 396, true, new DateTime(2018, 11, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), 24, false, "E", 5 },
                    { 395, false, new DateTime(2016, 8, 24, 10, 0, 0, 0, DateTimeKind.Unspecified), 24, true, "E", 4 },
                    { 394, true, new DateTime(2018, 10, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), 24, false, "E", 3 },
                    { 393, true, new DateTime(2018, 1, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 24, true, "E", 2 },
                    { 392, true, new DateTime(2017, 8, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 24, true, "E", 1 },
                    { 289, true, new DateTime(2019, 4, 23, 7, 0, 0, 0, DateTimeKind.Unspecified), 17, true, "E", 17 },
                    { 288, false, new DateTime(2018, 3, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), 17, false, "E", 16 },
                    { 287, false, new DateTime(2017, 2, 22, 11, 0, 0, 0, DateTimeKind.Unspecified), 17, false, "E", 15 },
                    { 397, false, new DateTime(2019, 8, 6, 13, 0, 0, 0, DateTimeKind.Unspecified), 24, false, "E", 6 },
                    { 286, true, new DateTime(2016, 5, 16, 9, 0, 0, 0, DateTimeKind.Unspecified), 17, false, "E", 14 },
                    { 284, false, new DateTime(2019, 6, 26, 12, 0, 0, 0, DateTimeKind.Unspecified), 17, false, "E", 12 },
                    { 283, false, new DateTime(2019, 8, 21, 18, 0, 0, 0, DateTimeKind.Unspecified), 17, true, "E", 11 },
                    { 282, false, new DateTime(2019, 7, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 17, true, "E", 10 },
                    { 281, false, new DateTime(2019, 1, 23, 15, 0, 0, 0, DateTimeKind.Unspecified), 17, false, "E", 9 },
                    { 280, false, new DateTime(2016, 4, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), 17, false, "E", 8 },
                    { 279, true, new DateTime(2019, 9, 21, 15, 0, 0, 0, DateTimeKind.Unspecified), 17, false, "E", 7 },
                    { 278, false, new DateTime(2019, 12, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), 17, false, "E", 6 },
                    { 277, true, new DateTime(2017, 12, 15, 9, 0, 0, 0, DateTimeKind.Unspecified), 17, false, "E", 5 },
                    { 285, false, new DateTime(2019, 7, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), 17, true, "E", 13 },
                    { 276, false, new DateTime(2016, 4, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 17, true, "E", 4 },
                    { 398, true, new DateTime(2016, 10, 22, 9, 0, 0, 0, DateTimeKind.Unspecified), 24, false, "E", 7 },
                    { 400, false, new DateTime(2016, 6, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 24, true, "E", 9 },
                    { 10, false, new DateTime(2017, 5, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 10 },
                    { 9, false, new DateTime(2016, 12, 10, 7, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 9 },
                    { 8, true, new DateTime(2016, 11, 25, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 8 },
                    { 7, true, new DateTime(2018, 11, 13, 7, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 7 },
                    { 6, false, new DateTime(2017, 12, 19, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 6 },
                    { 5, true, new DateTime(2017, 5, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 5 },
                    { 4, false, new DateTime(2018, 4, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 4 },
                    { 3, true, new DateTime(2019, 1, 19, 15, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 3 },
                    { 399, false, new DateTime(2018, 10, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), 24, false, "E", 8 },
                    { 2, true, new DateTime(2019, 5, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 2 },
                    { 408, false, new DateTime(2018, 8, 27, 14, 0, 0, 0, DateTimeKind.Unspecified), 24, false, "E", 17 },
                    { 407, true, new DateTime(2016, 1, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 24, true, "E", 16 },
                    { 406, false, new DateTime(2017, 2, 4, 7, 0, 0, 0, DateTimeKind.Unspecified), 24, true, "E", 15 },
                    { 405, true, new DateTime(2017, 6, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), 24, false, "E", 14 },
                    { 404, false, new DateTime(2019, 11, 8, 14, 0, 0, 0, DateTimeKind.Unspecified), 24, false, "E", 13 },
                    { 403, true, new DateTime(2017, 1, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), 24, false, "E", 12 },
                    { 402, false, new DateTime(2019, 1, 20, 7, 0, 0, 0, DateTimeKind.Unspecified), 24, true, "E", 11 },
                    { 401, true, new DateTime(2016, 2, 23, 7, 0, 0, 0, DateTimeKind.Unspecified), 24, false, "E", 10 },
                    { 1, true, new DateTime(2018, 11, 9, 9, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 1 },
                    { 275, false, new DateTime(2017, 9, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), 17, false, "E", 3 },
                    { 274, true, new DateTime(2019, 12, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), 17, false, "E", 2 },
                    { 273, false, new DateTime(2018, 8, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), 17, true, "E", 1 },
                    { 317, true, new DateTime(2019, 6, 25, 13, 0, 0, 0, DateTimeKind.Unspecified), 19, true, "E", 11 },
                    { 316, true, new DateTime(2016, 1, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), 19, true, "E", 10 },
                    { 315, true, new DateTime(2019, 10, 18, 7, 0, 0, 0, DateTimeKind.Unspecified), 19, true, "E", 9 },
                    { 314, false, new DateTime(2017, 8, 10, 11, 0, 0, 0, DateTimeKind.Unspecified), 19, true, "E", 8 },
                    { 313, false, new DateTime(2016, 8, 25, 7, 0, 0, 0, DateTimeKind.Unspecified), 19, true, "E", 7 },
                    { 312, true, new DateTime(2016, 8, 23, 15, 0, 0, 0, DateTimeKind.Unspecified), 19, false, "E", 6 },
                    { 311, true, new DateTime(2018, 9, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), 19, true, "E", 5 },
                    { 310, false, new DateTime(2016, 12, 18, 14, 0, 0, 0, DateTimeKind.Unspecified), 19, false, "E", 4 },
                    { 318, true, new DateTime(2018, 10, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), 19, false, "E", 12 },
                    { 309, true, new DateTime(2017, 1, 18, 14, 0, 0, 0, DateTimeKind.Unspecified), 19, true, "E", 3 },
                    { 307, true, new DateTime(2018, 8, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), 19, true, "E", 1 },
                    { 306, true, new DateTime(2017, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified), 18, false, "E", 17 },
                    { 305, false, new DateTime(2018, 2, 25, 11, 0, 0, 0, DateTimeKind.Unspecified), 18, false, "E", 16 },
                    { 304, false, new DateTime(2019, 3, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 18, false, "E", 15 },
                    { 303, true, new DateTime(2018, 10, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 18, true, "E", 14 },
                    { 302, true, new DateTime(2016, 5, 5, 7, 0, 0, 0, DateTimeKind.Unspecified), 18, false, "E", 13 },
                    { 475, true, new DateTime(2016, 9, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), 28, false, "E", 16 },
                    { 300, false, new DateTime(2016, 12, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 18, true, "E", 11 },
                    { 308, false, new DateTime(2016, 6, 23, 17, 0, 0, 0, DateTimeKind.Unspecified), 19, false, "E", 2 },
                    { 319, true, new DateTime(2018, 2, 28, 18, 0, 0, 0, DateTimeKind.Unspecified), 19, false, "E", 13 },
                    { 320, false, new DateTime(2017, 2, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), 19, true, "E", 14 },
                    { 321, true, new DateTime(2018, 1, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 19, true, "E", 15 },
                    { 221, false, new DateTime(2017, 9, 18, 18, 0, 0, 0, DateTimeKind.Unspecified), 13, true, "E", 17 },
                    { 220, false, new DateTime(2016, 10, 16, 7, 0, 0, 0, DateTimeKind.Unspecified), 13, true, "E", 16 },
                    { 219, true, new DateTime(2016, 12, 16, 15, 0, 0, 0, DateTimeKind.Unspecified), 13, false, "E", 15 },
                    { 218, true, new DateTime(2017, 8, 13, 13, 0, 0, 0, DateTimeKind.Unspecified), 13, true, "E", 14 },
                    { 217, false, new DateTime(2018, 12, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), 13, false, "E", 13 },
                    { 216, false, new DateTime(2017, 12, 5, 11, 0, 0, 0, DateTimeKind.Unspecified), 13, false, "E", 12 },
                    { 215, true, new DateTime(2016, 4, 17, 7, 0, 0, 0, DateTimeKind.Unspecified), 13, false, "E", 11 },
                    { 214, true, new DateTime(2016, 8, 17, 7, 0, 0, 0, DateTimeKind.Unspecified), 13, false, "E", 10 },
                    { 213, false, new DateTime(2016, 10, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), 13, true, "E", 9 },
                    { 212, false, new DateTime(2018, 1, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), 13, false, "E", 8 },
                    { 211, false, new DateTime(2019, 4, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), 13, true, "E", 7 },
                    { 210, false, new DateTime(2017, 1, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), 13, true, "E", 6 },
                    { 209, true, new DateTime(2016, 11, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), 13, false, "E", 5 },
                    { 208, false, new DateTime(2017, 6, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), 13, true, "E", 4 },
                    { 207, false, new DateTime(2017, 8, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), 13, false, "E", 3 },
                    { 206, false, new DateTime(2019, 12, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), 13, true, "E", 2 },
                    { 205, true, new DateTime(2016, 6, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 13, true, "E", 1 },
                    { 323, false, new DateTime(2019, 9, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 19, true, "E", 17 },
                    { 322, true, new DateTime(2018, 8, 25, 9, 0, 0, 0, DateTimeKind.Unspecified), 19, false, "E", 16 },
                    { 11, true, new DateTime(2019, 12, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 11 },
                    { 12, false, new DateTime(2016, 6, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 12 },
                    { 13, false, new DateTime(2019, 9, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 13 },
                    { 14, false, new DateTime(2018, 6, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 14 },
                    { 383, true, new DateTime(2016, 9, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), 23, false, "E", 9 },
                    { 382, true, new DateTime(2017, 7, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), 23, false, "E", 8 },
                    { 381, true, new DateTime(2017, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 23, true, "E", 7 },
                    { 380, false, new DateTime(2019, 5, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), 23, true, "E", 6 },
                    { 379, false, new DateTime(2017, 5, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), 23, true, "E", 5 },
                    { 378, false, new DateTime(2019, 1, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 23, true, "E", 4 },
                    { 377, false, new DateTime(2017, 10, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 23, false, "E", 3 },
                    { 376, false, new DateTime(2016, 9, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 23, false, "E", 2 },
                    { 384, false, new DateTime(2016, 11, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), 23, true, "E", 10 },
                    { 375, true, new DateTime(2016, 5, 22, 17, 0, 0, 0, DateTimeKind.Unspecified), 23, true, "E", 1 },
                    { 135, true, new DateTime(2016, 12, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), 8, true, "E", 16 },
                    { 134, true, new DateTime(2017, 6, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 8, true, "E", 15 },
                    { 133, false, new DateTime(2019, 7, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 8, false, "E", 14 },
                    { 132, false, new DateTime(2017, 8, 25, 11, 0, 0, 0, DateTimeKind.Unspecified), 8, true, "E", 13 },
                    { 131, true, new DateTime(2018, 1, 3, 7, 0, 0, 0, DateTimeKind.Unspecified), 8, false, "E", 12 },
                    { 130, false, new DateTime(2017, 9, 8, 9, 0, 0, 0, DateTimeKind.Unspecified), 8, false, "E", 11 },
                    { 129, false, new DateTime(2016, 2, 9, 13, 0, 0, 0, DateTimeKind.Unspecified), 8, false, "E", 10 },
                    { 128, false, new DateTime(2016, 7, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 8, false, "E", 9 },
                    { 136, false, new DateTime(2016, 4, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 8, true, "E", 17 },
                    { 385, true, new DateTime(2016, 7, 19, 14, 0, 0, 0, DateTimeKind.Unspecified), 23, true, "E", 11 },
                    { 386, false, new DateTime(2018, 2, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), 23, false, "E", 12 },
                    { 387, true, new DateTime(2019, 5, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 23, false, "E", 13 },
                    { 474, false, new DateTime(2016, 9, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), 28, false, "E", 15 },
                    { 473, false, new DateTime(2016, 7, 23, 15, 0, 0, 0, DateTimeKind.Unspecified), 28, true, "E", 14 },
                    { 472, true, new DateTime(2018, 4, 21, 18, 0, 0, 0, DateTimeKind.Unspecified), 28, true, "E", 13 },
                    { 471, false, new DateTime(2017, 1, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), 28, false, "E", 12 },
                    { 470, false, new DateTime(2017, 12, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), 28, false, "E", 11 },
                    { 469, false, new DateTime(2019, 6, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), 28, true, "E", 10 },
                    { 468, true, new DateTime(2018, 6, 22, 14, 0, 0, 0, DateTimeKind.Unspecified), 28, true, "E", 9 },
                    { 467, false, new DateTime(2018, 2, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), 28, true, "E", 8 },
                    { 466, true, new DateTime(2016, 12, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), 28, false, "E", 7 },
                    { 465, true, new DateTime(2017, 3, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), 28, true, "E", 6 },
                    { 464, true, new DateTime(2019, 8, 8, 7, 0, 0, 0, DateTimeKind.Unspecified), 28, false, "E", 5 },
                    { 463, true, new DateTime(2018, 10, 25, 7, 0, 0, 0, DateTimeKind.Unspecified), 28, false, "E", 4 },
                    { 462, false, new DateTime(2019, 5, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 28, false, "E", 3 },
                    { 461, false, new DateTime(2016, 6, 16, 11, 0, 0, 0, DateTimeKind.Unspecified), 28, true, "E", 2 },
                    { 460, true, new DateTime(2018, 6, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), 28, true, "E", 1 },
                    { 391, false, new DateTime(2019, 9, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), 23, true, "E", 17 },
                    { 390, false, new DateTime(2018, 5, 19, 7, 0, 0, 0, DateTimeKind.Unspecified), 23, true, "E", 16 },
                    { 389, true, new DateTime(2018, 4, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), 23, false, "E", 15 },
                    { 388, true, new DateTime(2016, 1, 12, 11, 0, 0, 0, DateTimeKind.Unspecified), 23, false, "E", 14 },
                    { 127, false, new DateTime(2018, 9, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), 8, false, "E", 8 },
                    { 299, true, new DateTime(2017, 10, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 18, false, "E", 10 },
                    { 126, true, new DateTime(2018, 9, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 8, false, "E", 7 },
                    { 124, true, new DateTime(2017, 4, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 8, false, "E", 5 },
                    { 372, false, new DateTime(2016, 5, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 22, false, "E", 15 },
                    { 371, false, new DateTime(2018, 10, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), 22, false, "E", 14 },
                    { 370, false, new DateTime(2019, 2, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), 22, false, "E", 13 },
                    { 369, false, new DateTime(2019, 8, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), 22, true, "E", 12 },
                    { 368, false, new DateTime(2018, 4, 23, 13, 0, 0, 0, DateTimeKind.Unspecified), 22, true, "E", 11 },
                    { 367, false, new DateTime(2017, 7, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 22, false, "E", 10 },
                    { 366, false, new DateTime(2019, 10, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), 22, true, "E", 9 },
                    { 365, true, new DateTime(2016, 8, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 22, false, "E", 8 },
                    { 373, false, new DateTime(2017, 2, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), 22, true, "E", 16 },
                    { 364, false, new DateTime(2016, 12, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 22, false, "E", 7 },
                    { 362, true, new DateTime(2018, 4, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), 22, true, "E", 5 },
                    { 361, false, new DateTime(2019, 4, 26, 11, 0, 0, 0, DateTimeKind.Unspecified), 22, true, "E", 4 },
                    { 360, true, new DateTime(2016, 11, 20, 9, 0, 0, 0, DateTimeKind.Unspecified), 22, true, "E", 3 },
                    { 359, true, new DateTime(2016, 8, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), 22, false, "E", 2 },
                    { 358, false, new DateTime(2019, 9, 19, 15, 0, 0, 0, DateTimeKind.Unspecified), 22, false, "E", 1 },
                    { 17, false, new DateTime(2019, 2, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 17 },
                    { 16, true, new DateTime(2017, 10, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 16 },
                    { 15, true, new DateTime(2018, 4, 21, 7, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 15 },
                    { 363, true, new DateTime(2018, 12, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), 22, false, "E", 6 },
                    { 374, false, new DateTime(2018, 7, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), 22, false, "E", 17 },
                    { 409, true, new DateTime(2019, 2, 8, 13, 0, 0, 0, DateTimeKind.Unspecified), 25, false, "E", 1 },
                    { 410, true, new DateTime(2019, 5, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), 25, true, "E", 2 },
                    { 123, false, new DateTime(2017, 2, 21, 14, 0, 0, 0, DateTimeKind.Unspecified), 8, false, "E", 4 },
                    { 122, false, new DateTime(2019, 1, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 8, true, "E", 3 },
                    { 121, true, new DateTime(2018, 7, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 8, true, "E", 2 },
                    { 120, true, new DateTime(2018, 4, 20, 14, 0, 0, 0, DateTimeKind.Unspecified), 8, true, "E", 1 },
                    { 425, false, new DateTime(2019, 11, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 25, false, "E", 17 },
                    { 424, false, new DateTime(2019, 7, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 25, true, "E", 16 },
                    { 423, false, new DateTime(2016, 10, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), 25, false, "E", 15 },
                    { 422, true, new DateTime(2018, 9, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 25, false, "E", 14 },
                    { 421, false, new DateTime(2017, 7, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), 25, true, "E", 13 },
                    { 420, true, new DateTime(2016, 1, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), 25, true, "E", 12 },
                    { 419, true, new DateTime(2016, 12, 8, 13, 0, 0, 0, DateTimeKind.Unspecified), 25, false, "E", 11 },
                    { 418, true, new DateTime(2019, 12, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 25, true, "E", 10 },
                    { 417, true, new DateTime(2018, 10, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), 25, false, "E", 9 },
                    { 416, false, new DateTime(2017, 6, 13, 17, 0, 0, 0, DateTimeKind.Unspecified), 25, false, "E", 8 },
                    { 415, false, new DateTime(2018, 10, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), 25, false, "E", 7 },
                    { 414, false, new DateTime(2016, 11, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 25, true, "E", 6 },
                    { 413, true, new DateTime(2018, 10, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), 25, false, "E", 5 },
                    { 412, true, new DateTime(2019, 4, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), 25, true, "E", 4 },
                    { 411, true, new DateTime(2016, 9, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 25, true, "E", 3 },
                    { 125, false, new DateTime(2019, 1, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), 8, true, "E", 6 },
                    { 298, true, new DateTime(2018, 3, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), 18, false, "E", 9 },
                    { 476, true, new DateTime(2016, 1, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), 28, false, "E", 17 },
                    { 296, true, new DateTime(2018, 3, 8, 7, 0, 0, 0, DateTimeKind.Unspecified), 18, false, "E", 7 },
                    { 201, false, new DateTime(2019, 8, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), 12, true, "E", 14 },
                    { 200, false, new DateTime(2018, 2, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), 12, true, "E", 13 },
                    { 199, true, new DateTime(2017, 8, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), 12, false, "E", 12 },
                    { 198, true, new DateTime(2017, 5, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), 12, false, "E", 11 },
                    { 197, true, new DateTime(2017, 11, 18, 18, 0, 0, 0, DateTimeKind.Unspecified), 12, true, "E", 10 },
                    { 196, false, new DateTime(2017, 10, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), 12, false, "E", 9 },
                    { 195, true, new DateTime(2019, 12, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), 12, true, "E", 8 },
                    { 194, false, new DateTime(2016, 9, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), 12, true, "E", 7 },
                    { 193, false, new DateTime(2018, 7, 14, 11, 0, 0, 0, DateTimeKind.Unspecified), 12, true, "E", 6 },
                    { 192, true, new DateTime(2018, 7, 26, 13, 0, 0, 0, DateTimeKind.Unspecified), 12, true, "E", 5 },
                    { 191, true, new DateTime(2019, 3, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), 12, true, "E", 4 },
                    { 190, true, new DateTime(2019, 7, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), 12, true, "E", 3 },
                    { 189, true, new DateTime(2019, 7, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 12, false, "E", 2 },
                    { 188, true, new DateTime(2019, 5, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), 12, false, "E", 1 },
                    { 119, false, new DateTime(2017, 11, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), 7, false, "E", 17 },
                    { 118, true, new DateTime(2018, 4, 18, 17, 0, 0, 0, DateTimeKind.Unspecified), 7, true, "E", 16 },
                    { 117, true, new DateTime(2017, 6, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 7, false, "E", 15 },
                    { 116, true, new DateTime(2019, 10, 16, 14, 0, 0, 0, DateTimeKind.Unspecified), 7, true, "E", 14 },
                    { 115, false, new DateTime(2016, 4, 12, 14, 0, 0, 0, DateTimeKind.Unspecified), 7, true, "E", 13 },
                    { 202, false, new DateTime(2016, 9, 25, 18, 0, 0, 0, DateTimeKind.Unspecified), 12, false, "E", 15 },
                    { 114, true, new DateTime(2016, 7, 6, 13, 0, 0, 0, DateTimeKind.Unspecified), 7, true, "E", 12 },
                    { 203, true, new DateTime(2019, 2, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), 12, true, "E", 16 },
                    { 324, true, new DateTime(2017, 11, 7, 9, 0, 0, 0, DateTimeKind.Unspecified), 20, false, "E", 1 },
                    { 156, false, new DateTime(2017, 10, 15, 11, 0, 0, 0, DateTimeKind.Unspecified), 10, true, "E", 3 },
                    { 155, false, new DateTime(2019, 3, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), 10, false, "E", 2 },
                    { 154, false, new DateTime(2017, 12, 5, 11, 0, 0, 0, DateTimeKind.Unspecified), 10, true, "E", 1 },
                    { 340, false, new DateTime(2017, 11, 14, 7, 0, 0, 0, DateTimeKind.Unspecified), 20, false, "E", 17 },
                    { 339, true, new DateTime(2017, 3, 22, 11, 0, 0, 0, DateTimeKind.Unspecified), 20, true, "E", 16 },
                    { 338, false, new DateTime(2019, 1, 23, 15, 0, 0, 0, DateTimeKind.Unspecified), 20, true, "E", 15 },
                    { 337, false, new DateTime(2016, 4, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 20, true, "E", 14 },
                    { 336, true, new DateTime(2017, 6, 4, 18, 0, 0, 0, DateTimeKind.Unspecified), 20, false, "E", 13 },
                    { 335, false, new DateTime(2016, 12, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), 20, true, "E", 12 },
                    { 334, true, new DateTime(2019, 8, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 20, false, "E", 11 },
                    { 333, true, new DateTime(2019, 4, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), 20, true, "E", 10 },
                    { 332, false, new DateTime(2016, 9, 26, 7, 0, 0, 0, DateTimeKind.Unspecified), 20, false, "E", 9 },
                    { 331, true, new DateTime(2019, 7, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), 20, false, "E", 8 },
                    { 330, false, new DateTime(2018, 6, 15, 7, 0, 0, 0, DateTimeKind.Unspecified), 20, false, "E", 7 },
                    { 329, false, new DateTime(2016, 5, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 20, true, "E", 6 },
                    { 328, false, new DateTime(2018, 5, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), 20, true, "E", 5 },
                    { 327, true, new DateTime(2017, 12, 9, 7, 0, 0, 0, DateTimeKind.Unspecified), 20, true, "E", 4 },
                    { 326, true, new DateTime(2019, 3, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 20, true, "E", 3 },
                    { 325, false, new DateTime(2016, 3, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 20, true, "E", 2 },
                    { 204, true, new DateTime(2016, 3, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 12, false, "E", 17 },
                    { 297, false, new DateTime(2018, 3, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 18, false, "E", 8 },
                    { 113, true, new DateTime(2018, 1, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 7, false, "E", 11 },
                    { 111, false, new DateTime(2019, 1, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 7, true, "E", 9 },
                    { 36, false, new DateTime(2018, 7, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 2 },
                    { 35, false, new DateTime(2016, 3, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 1 },
                    { 34, false, new DateTime(2018, 7, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 17 },
                    { 33, true, new DateTime(2019, 1, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 16 },
                    { 32, false, new DateTime(2018, 4, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 15 },
                    { 31, false, new DateTime(2019, 4, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 14 },
                    { 30, false, new DateTime(2018, 2, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 13 },
                    { 29, true, new DateTime(2018, 5, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 12 },
                    { 28, true, new DateTime(2019, 4, 18, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 11 },
                    { 27, false, new DateTime(2019, 4, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 10 },
                    { 26, true, new DateTime(2018, 1, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 9 },
                    { 25, true, new DateTime(2017, 7, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 8 },
                    { 24, true, new DateTime(2017, 8, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 7 },
                    { 23, true, new DateTime(2017, 10, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 6 },
                    { 22, true, new DateTime(2016, 12, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 5 },
                    { 21, false, new DateTime(2017, 2, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 4 },
                    { 20, false, new DateTime(2016, 12, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 3 },
                    { 19, false, new DateTime(2016, 8, 2, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 2 },
                    { 18, true, new DateTime(2016, 11, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 1 },
                    { 37, true, new DateTime(2016, 8, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 3 },
                    { 112, true, new DateTime(2016, 8, 14, 7, 0, 0, 0, DateTimeKind.Unspecified), 7, false, "E", 10 },
                    { 38, false, new DateTime(2016, 11, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 4 },
                    { 40, true, new DateTime(2017, 8, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 6 },
                    { 110, true, new DateTime(2018, 5, 17, 15, 0, 0, 0, DateTimeKind.Unspecified), 7, false, "E", 8 },
                    { 109, false, new DateTime(2017, 2, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 7, false, "E", 7 },
                    { 108, false, new DateTime(2016, 4, 3, 7, 0, 0, 0, DateTimeKind.Unspecified), 7, true, "E", 6 },
                    { 107, false, new DateTime(2017, 11, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), 7, true, "E", 5 },
                    { 106, false, new DateTime(2016, 12, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 7, false, "E", 4 },
                    { 105, false, new DateTime(2018, 4, 17, 15, 0, 0, 0, DateTimeKind.Unspecified), 7, false, "E", 3 },
                    { 104, false, new DateTime(2017, 5, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), 7, false, "E", 2 },
                    { 103, false, new DateTime(2019, 6, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), 7, false, "E", 1 },
                    { 51, false, new DateTime(2017, 10, 26, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 17 },
                    { 50, true, new DateTime(2016, 12, 19, 14, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 16 },
                    { 49, true, new DateTime(2019, 9, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 15 },
                    { 48, true, new DateTime(2019, 6, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 14 },
                    { 47, false, new DateTime(2016, 2, 19, 10, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 13 },
                    { 46, false, new DateTime(2017, 6, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 12 },
                    { 45, true, new DateTime(2017, 3, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 11 },
                    { 44, false, new DateTime(2019, 10, 21, 11, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 10 },
                    { 43, true, new DateTime(2018, 12, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 9 },
                    { 42, false, new DateTime(2019, 3, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 8 },
                    { 41, false, new DateTime(2017, 8, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 7 },
                    { 39, false, new DateTime(2019, 10, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 5 },
                    { 158, true, new DateTime(2017, 4, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), 10, false, "E", 5 },
                    { 157, true, new DateTime(2018, 9, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), 10, false, "E", 4 },
                    { 160, true, new DateTime(2019, 12, 8, 7, 0, 0, 0, DateTimeKind.Unspecified), 10, true, "E", 7 },
                    { 238, false, new DateTime(2017, 4, 27, 15, 0, 0, 0, DateTimeKind.Unspecified), 14, false, "E", 17 },
                    { 237, false, new DateTime(2018, 4, 16, 14, 0, 0, 0, DateTimeKind.Unspecified), 14, false, "E", 16 },
                    { 236, true, new DateTime(2017, 2, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), 14, true, "E", 15 },
                    { 235, false, new DateTime(2018, 2, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 14, true, "E", 14 },
                    { 234, false, new DateTime(2017, 6, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 14, false, "E", 13 },
                    { 233, false, new DateTime(2017, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), 14, false, "E", 12 },
                    { 232, true, new DateTime(2019, 4, 10, 15, 0, 0, 0, DateTimeKind.Unspecified), 14, false, "E", 11 },
                    { 231, false, new DateTime(2018, 6, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 14, false, "E", 10 },
                    { 256, false, new DateTime(2017, 9, 24, 13, 0, 0, 0, DateTimeKind.Unspecified), 16, false, "E", 1 },
                    { 230, false, new DateTime(2019, 5, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 14, true, "E", 9 },
                    { 228, true, new DateTime(2016, 7, 2, 7, 0, 0, 0, DateTimeKind.Unspecified), 14, true, "E", 7 },
                    { 227, false, new DateTime(2016, 5, 18, 18, 0, 0, 0, DateTimeKind.Unspecified), 14, false, "E", 6 },
                    { 226, false, new DateTime(2018, 6, 19, 14, 0, 0, 0, DateTimeKind.Unspecified), 14, true, "E", 5 },
                    { 225, true, new DateTime(2018, 9, 22, 11, 0, 0, 0, DateTimeKind.Unspecified), 14, false, "E", 4 },
                    { 224, true, new DateTime(2019, 6, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 14, false, "E", 3 },
                    { 223, true, new DateTime(2019, 7, 24, 15, 0, 0, 0, DateTimeKind.Unspecified), 14, true, "E", 2 },
                    { 222, false, new DateTime(2019, 8, 12, 13, 0, 0, 0, DateTimeKind.Unspecified), 14, false, "E", 1 },
                    { 459, true, new DateTime(2018, 5, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 27, true, "E", 17 },
                    { 229, true, new DateTime(2019, 6, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), 14, true, "E", 8 },
                    { 257, true, new DateTime(2019, 8, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), 16, false, "E", 2 },
                    { 258, false, new DateTime(2017, 4, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), 16, true, "E", 3 },
                    { 259, true, new DateTime(2019, 5, 17, 18, 0, 0, 0, DateTimeKind.Unspecified), 16, true, "E", 4 },
                    { 295, true, new DateTime(2018, 1, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), 18, true, "E", 6 },
                    { 294, true, new DateTime(2019, 12, 16, 7, 0, 0, 0, DateTimeKind.Unspecified), 18, false, "E", 5 },
                    { 293, true, new DateTime(2017, 8, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), 18, false, "E", 4 },
                    { 292, true, new DateTime(2017, 7, 5, 13, 0, 0, 0, DateTimeKind.Unspecified), 18, true, "E", 3 },
                    { 291, true, new DateTime(2019, 7, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), 18, true, "E", 2 }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "EnrollmentId", "BookBought", "Confirmed", "InstanceId", "Paid", "Status", "UserId" },
                values: new object[,]
                {
                    { 290, true, new DateTime(2017, 5, 18, 9, 0, 0, 0, DateTimeKind.Unspecified), 18, true, "E", 1 },
                    { 272, false, new DateTime(2017, 3, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), 16, true, "E", 17 },
                    { 271, false, new DateTime(2018, 6, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 16, false, "E", 16 },
                    { 270, false, new DateTime(2016, 8, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 16, false, "E", 15 },
                    { 269, false, new DateTime(2017, 5, 17, 13, 0, 0, 0, DateTimeKind.Unspecified), 16, false, "E", 14 },
                    { 268, true, new DateTime(2019, 7, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), 16, false, "E", 13 },
                    { 267, false, new DateTime(2018, 4, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), 16, false, "E", 12 },
                    { 266, true, new DateTime(2017, 11, 15, 11, 0, 0, 0, DateTimeKind.Unspecified), 16, true, "E", 11 },
                    { 265, true, new DateTime(2018, 6, 10, 14, 0, 0, 0, DateTimeKind.Unspecified), 16, true, "E", 10 },
                    { 264, true, new DateTime(2019, 12, 16, 14, 0, 0, 0, DateTimeKind.Unspecified), 16, false, "E", 9 },
                    { 263, true, new DateTime(2018, 5, 21, 15, 0, 0, 0, DateTimeKind.Unspecified), 16, true, "E", 8 },
                    { 262, true, new DateTime(2016, 7, 21, 11, 0, 0, 0, DateTimeKind.Unspecified), 16, true, "E", 7 },
                    { 261, false, new DateTime(2016, 11, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 16, true, "E", 6 },
                    { 260, false, new DateTime(2016, 7, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), 16, false, "E", 5 },
                    { 159, true, new DateTime(2019, 5, 10, 15, 0, 0, 0, DateTimeKind.Unspecified), 10, true, "E", 6 },
                    { 457, true, new DateTime(2017, 11, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 27, true, "E", 15 },
                    { 458, false, new DateTime(2017, 5, 23, 15, 0, 0, 0, DateTimeKind.Unspecified), 27, false, "E", 16 },
                    { 455, true, new DateTime(2017, 2, 20, 9, 0, 0, 0, DateTimeKind.Unspecified), 27, true, "E", 13 },
                    { 436, true, new DateTime(2019, 7, 28, 15, 0, 0, 0, DateTimeKind.Unspecified), 26, true, "E", 11 },
                    { 435, false, new DateTime(2016, 7, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), 26, false, "E", 10 },
                    { 434, true, new DateTime(2018, 12, 14, 7, 0, 0, 0, DateTimeKind.Unspecified), 26, true, "E", 9 },
                    { 433, false, new DateTime(2016, 8, 4, 15, 0, 0, 0, DateTimeKind.Unspecified), 26, true, "E", 8 },
                    { 432, true, new DateTime(2019, 2, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 26, false, "E", 7 },
                    { 431, false, new DateTime(2017, 12, 28, 17, 0, 0, 0, DateTimeKind.Unspecified), 26, true, "E", 6 },
                    { 430, true, new DateTime(2019, 3, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), 26, true, "E", 5 },
                    { 429, false, new DateTime(2017, 4, 23, 15, 0, 0, 0, DateTimeKind.Unspecified), 26, true, "E", 4 },
                    { 428, false, new DateTime(2017, 11, 17, 18, 0, 0, 0, DateTimeKind.Unspecified), 26, false, "E", 3 },
                    { 427, true, new DateTime(2018, 6, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), 26, false, "E", 2 },
                    { 426, true, new DateTime(2017, 2, 17, 18, 0, 0, 0, DateTimeKind.Unspecified), 26, true, "E", 1 },
                    { 170, false, new DateTime(2018, 9, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 10, true, "E", 17 },
                    { 169, true, new DateTime(2017, 9, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 10, true, "E", 16 },
                    { 168, false, new DateTime(2019, 9, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 10, false, "E", 15 },
                    { 167, false, new DateTime(2016, 6, 24, 9, 0, 0, 0, DateTimeKind.Unspecified), 10, false, "E", 14 },
                    { 166, true, new DateTime(2018, 9, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 10, true, "E", 13 },
                    { 165, true, new DateTime(2017, 8, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 10, true, "E", 12 },
                    { 164, true, new DateTime(2018, 4, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), 10, false, "E", 11 },
                    { 163, true, new DateTime(2016, 10, 10, 7, 0, 0, 0, DateTimeKind.Unspecified), 10, true, "E", 10 },
                    { 162, false, new DateTime(2018, 4, 24, 9, 0, 0, 0, DateTimeKind.Unspecified), 10, false, "E", 9 },
                    { 161, true, new DateTime(2016, 4, 28, 18, 0, 0, 0, DateTimeKind.Unspecified), 10, false, "E", 8 },
                    { 437, true, new DateTime(2017, 6, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), 26, false, "E", 12 },
                    { 456, false, new DateTime(2016, 9, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), 27, false, "E", 14 },
                    { 438, false, new DateTime(2019, 4, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), 26, false, "E", 13 },
                    { 440, false, new DateTime(2016, 4, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), 26, true, "E", 15 },
                    { 454, false, new DateTime(2019, 3, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 27, true, "E", 12 },
                    { 453, false, new DateTime(2019, 5, 28, 17, 0, 0, 0, DateTimeKind.Unspecified), 27, false, "E", 11 },
                    { 452, true, new DateTime(2018, 11, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), 27, true, "E", 10 },
                    { 451, false, new DateTime(2018, 5, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), 27, true, "E", 9 },
                    { 450, false, new DateTime(2017, 4, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 27, true, "E", 8 },
                    { 449, false, new DateTime(2019, 12, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), 27, false, "E", 7 },
                    { 448, false, new DateTime(2016, 11, 24, 7, 0, 0, 0, DateTimeKind.Unspecified), 27, false, "E", 6 },
                    { 439, true, new DateTime(2018, 4, 12, 14, 0, 0, 0, DateTimeKind.Unspecified), 26, false, "E", 14 },
                    { 446, true, new DateTime(2019, 9, 21, 14, 0, 0, 0, DateTimeKind.Unspecified), 27, false, "E", 4 },
                    { 447, true, new DateTime(2016, 8, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 27, false, "E", 5 },
                    { 444, false, new DateTime(2018, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 27, true, "E", 2 },
                    { 443, false, new DateTime(2018, 4, 22, 9, 0, 0, 0, DateTimeKind.Unspecified), 27, false, "E", 1 },
                    { 442, false, new DateTime(2019, 6, 23, 15, 0, 0, 0, DateTimeKind.Unspecified), 26, true, "E", 17 },
                    { 441, true, new DateTime(2019, 10, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), 26, false, "E", 16 },
                    { 445, false, new DateTime(2016, 5, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), 27, true, "E", 3 }
                });

            migrationBuilder.InsertData(
                table: "Instance",
                columns: new[] { "InstanceId", "BookAvailable", "BookPrice", "CourseId", "Graded", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[,]
                {
                    { 15, true, 17.0, 10, false, 5, 3, 99.0, 30, new DateTimeOffset(new DateTime(2017, 1, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 11, true, 24.0, 10, false, 2, 2, 117.0, 17, new DateTimeOffset(new DateTime(2017, 5, 26, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 5, true, 25.0, 10, false, 2, 3, 120.0, 18, new DateTimeOffset(new DateTime(2017, 6, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 4, true, 40.0, 10, false, 5, 2, 52.0, 23, new DateTimeOffset(new DateTime(2016, 3, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 6, true, 44.0, 9, false, 6, 1, 52.0, 22, new DateTimeOffset(new DateTime(2017, 1, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 9, true, 15.0, 9, false, 1, 3, 145.0, 23, new DateTimeOffset(new DateTime(2019, 11, 24, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 29, true, 51.0, 9, false, 6, 2, 69.0, 23, new DateTimeOffset(new DateTime(2017, 1, 10, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 21, true, 29.0, 8, false, 6, 3, 96.0, 29, new DateTimeOffset(new DateTime(2016, 2, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "EnrollmentId", "BookBought", "Confirmed", "InstanceId", "Paid", "Status", "UserId" },
                values: new object[,]
                {
                    { 341, false, new DateTime(2016, 6, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), 21, false, "E", 1 },
                    { 100, true, new DateTime(2016, 7, 2, 7, 0, 0, 0, DateTimeKind.Unspecified), 6, true, "E", 15 },
                    { 99, true, new DateTime(2017, 3, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), 6, false, "E", 14 },
                    { 98, false, new DateTime(2019, 11, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 6, false, "E", 13 },
                    { 97, true, new DateTime(2019, 10, 16, 9, 0, 0, 0, DateTimeKind.Unspecified), 6, false, "E", 12 },
                    { 96, false, new DateTime(2017, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, true, "E", 11 },
                    { 95, false, new DateTime(2017, 5, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, false, "E", 10 },
                    { 94, true, new DateTime(2018, 8, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 6, false, "E", 9 },
                    { 93, false, new DateTime(2016, 2, 5, 7, 0, 0, 0, DateTimeKind.Unspecified), 6, false, "E", 8 },
                    { 92, true, new DateTime(2019, 3, 20, 13, 0, 0, 0, DateTimeKind.Unspecified), 6, true, "E", 7 },
                    { 91, true, new DateTime(2018, 3, 9, 9, 0, 0, 0, DateTimeKind.Unspecified), 6, false, "E", 6 },
                    { 90, true, new DateTime(2016, 1, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, false, "E", 5 },
                    { 89, false, new DateTime(2017, 4, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), 6, true, "E", 4 },
                    { 88, false, new DateTime(2019, 4, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), 6, false, "E", 3 },
                    { 87, true, new DateTime(2017, 2, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), 6, true, "E", 2 },
                    { 101, true, new DateTime(2016, 8, 24, 18, 0, 0, 0, DateTimeKind.Unspecified), 6, false, "E", 16 },
                    { 86, true, new DateTime(2016, 11, 21, 13, 0, 0, 0, DateTimeKind.Unspecified), 6, true, "E", 1 },
                    { 254, true, new DateTime(2018, 10, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 15, true, "E", 16 },
                    { 253, true, new DateTime(2016, 4, 13, 10, 0, 0, 0, DateTimeKind.Unspecified), 15, true, "E", 15 },
                    { 252, true, new DateTime(2018, 1, 13, 10, 0, 0, 0, DateTimeKind.Unspecified), 15, false, "E", 14 },
                    { 251, false, new DateTime(2016, 4, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 15, false, "E", 13 },
                    { 250, true, new DateTime(2018, 2, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 15, false, "E", 12 },
                    { 249, true, new DateTime(2018, 11, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), 15, true, "E", 11 },
                    { 248, false, new DateTime(2018, 12, 22, 14, 0, 0, 0, DateTimeKind.Unspecified), 15, true, "E", 10 },
                    { 247, false, new DateTime(2019, 11, 28, 13, 0, 0, 0, DateTimeKind.Unspecified), 15, false, "E", 9 },
                    { 246, false, new DateTime(2017, 12, 4, 15, 0, 0, 0, DateTimeKind.Unspecified), 15, true, "E", 8 },
                    { 245, true, new DateTime(2017, 12, 11, 7, 0, 0, 0, DateTimeKind.Unspecified), 15, true, "E", 7 },
                    { 244, true, new DateTime(2019, 11, 5, 7, 0, 0, 0, DateTimeKind.Unspecified), 15, false, "E", 6 },
                    { 243, false, new DateTime(2019, 10, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), 15, true, "E", 5 },
                    { 242, false, new DateTime(2017, 2, 19, 10, 0, 0, 0, DateTimeKind.Unspecified), 15, false, "E", 4 },
                    { 241, false, new DateTime(2016, 2, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), 15, true, "E", 3 },
                    { 255, false, new DateTime(2019, 5, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), 15, false, "E", 17 },
                    { 240, true, new DateTime(2017, 8, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 15, true, "E", 2 },
                    { 102, false, new DateTime(2019, 10, 6, 7, 0, 0, 0, DateTimeKind.Unspecified), 6, false, "E", 17 },
                    { 138, false, new DateTime(2018, 9, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 9, true, "E", 2 },
                    { 491, false, new DateTime(2019, 9, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 29, false, "E", 15 },
                    { 490, true, new DateTime(2018, 6, 5, 13, 0, 0, 0, DateTimeKind.Unspecified), 29, true, "E", 14 },
                    { 489, true, new DateTime(2018, 12, 17, 7, 0, 0, 0, DateTimeKind.Unspecified), 29, false, "E", 13 },
                    { 488, true, new DateTime(2017, 8, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 29, true, "E", 12 },
                    { 487, false, new DateTime(2017, 5, 2, 13, 0, 0, 0, DateTimeKind.Unspecified), 29, false, "E", 11 },
                    { 486, true, new DateTime(2018, 12, 9, 9, 0, 0, 0, DateTimeKind.Unspecified), 29, false, "E", 10 },
                    { 485, true, new DateTime(2017, 6, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 29, false, "E", 9 },
                    { 484, false, new DateTime(2017, 12, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), 29, false, "E", 8 },
                    { 483, true, new DateTime(2018, 1, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 29, false, "E", 7 },
                    { 482, true, new DateTime(2017, 4, 15, 7, 0, 0, 0, DateTimeKind.Unspecified), 29, false, "E", 6 },
                    { 481, true, new DateTime(2016, 1, 16, 15, 0, 0, 0, DateTimeKind.Unspecified), 29, false, "E", 5 },
                    { 480, false, new DateTime(2016, 12, 3, 7, 0, 0, 0, DateTimeKind.Unspecified), 29, false, "E", 4 },
                    { 479, false, new DateTime(2018, 9, 19, 14, 0, 0, 0, DateTimeKind.Unspecified), 29, true, "E", 3 },
                    { 478, false, new DateTime(2016, 12, 28, 9, 0, 0, 0, DateTimeKind.Unspecified), 29, true, "E", 2 },
                    { 137, false, new DateTime(2019, 12, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), 9, false, "E", 1 },
                    { 477, true, new DateTime(2016, 11, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 29, true, "E", 1 },
                    { 152, true, new DateTime(2016, 3, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 9, false, "E", 16 },
                    { 151, true, new DateTime(2017, 10, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 9, true, "E", 15 },
                    { 150, false, new DateTime(2019, 8, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), 9, false, "E", 14 },
                    { 149, false, new DateTime(2016, 8, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), 9, false, "E", 13 },
                    { 148, true, new DateTime(2017, 12, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 9, true, "E", 12 },
                    { 147, false, new DateTime(2018, 2, 9, 9, 0, 0, 0, DateTimeKind.Unspecified), 9, true, "E", 11 },
                    { 146, true, new DateTime(2018, 9, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 9, false, "E", 10 },
                    { 145, false, new DateTime(2018, 6, 13, 13, 0, 0, 0, DateTimeKind.Unspecified), 9, false, "E", 9 },
                    { 144, false, new DateTime(2019, 12, 10, 15, 0, 0, 0, DateTimeKind.Unspecified), 9, false, "E", 8 },
                    { 143, false, new DateTime(2017, 10, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 9, false, "E", 7 },
                    { 142, false, new DateTime(2017, 10, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 9, true, "E", 6 },
                    { 141, false, new DateTime(2017, 9, 5, 11, 0, 0, 0, DateTimeKind.Unspecified), 9, false, "E", 5 },
                    { 140, true, new DateTime(2017, 10, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), 9, false, "E", 4 },
                    { 139, true, new DateTime(2016, 3, 22, 14, 0, 0, 0, DateTimeKind.Unspecified), 9, true, "E", 3 },
                    { 153, false, new DateTime(2018, 8, 6, 13, 0, 0, 0, DateTimeKind.Unspecified), 9, false, "E", 17 },
                    { 239, true, new DateTime(2016, 2, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), 15, false, "E", 1 },
                    { 187, true, new DateTime(2017, 4, 16, 14, 0, 0, 0, DateTimeKind.Unspecified), 11, true, "E", 17 },
                    { 186, false, new DateTime(2016, 9, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), 11, false, "E", 16 },
                    { 65, true, new DateTime(2016, 12, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 4, false, "E", 14 },
                    { 64, true, new DateTime(2017, 9, 19, 14, 0, 0, 0, DateTimeKind.Unspecified), 4, true, "E", 13 },
                    { 63, false, new DateTime(2017, 8, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), 4, false, "E", 12 },
                    { 62, false, new DateTime(2017, 12, 24, 9, 0, 0, 0, DateTimeKind.Unspecified), 4, true, "E", 11 },
                    { 61, false, new DateTime(2018, 12, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 4, true, "E", 10 },
                    { 60, false, new DateTime(2018, 6, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), 4, false, "E", 9 },
                    { 59, true, new DateTime(2017, 10, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 4, false, "E", 8 },
                    { 58, false, new DateTime(2016, 5, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), 4, false, "E", 7 },
                    { 57, true, new DateTime(2017, 5, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 4, true, "E", 6 },
                    { 56, true, new DateTime(2016, 7, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), 4, false, "E", 5 },
                    { 55, false, new DateTime(2017, 8, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 4, true, "E", 4 },
                    { 54, false, new DateTime(2017, 4, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), 4, true, "E", 3 },
                    { 53, false, new DateTime(2018, 8, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), 4, true, "E", 2 },
                    { 52, false, new DateTime(2016, 5, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), 4, false, "E", 1 },
                    { 66, false, new DateTime(2017, 1, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), 4, false, "E", 15 },
                    { 357, true, new DateTime(2016, 2, 28, 9, 0, 0, 0, DateTimeKind.Unspecified), 21, false, "E", 17 },
                    { 355, true, new DateTime(2018, 10, 26, 15, 0, 0, 0, DateTimeKind.Unspecified), 21, true, "E", 15 },
                    { 354, false, new DateTime(2016, 3, 22, 7, 0, 0, 0, DateTimeKind.Unspecified), 21, true, "E", 14 },
                    { 353, false, new DateTime(2018, 3, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), 21, true, "E", 13 },
                    { 352, true, new DateTime(2016, 11, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), 21, true, "E", 12 },
                    { 351, true, new DateTime(2019, 8, 4, 15, 0, 0, 0, DateTimeKind.Unspecified), 21, true, "E", 11 },
                    { 350, false, new DateTime(2017, 12, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 21, true, "E", 10 },
                    { 349, false, new DateTime(2019, 10, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), 21, false, "E", 9 },
                    { 348, false, new DateTime(2019, 7, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), 21, false, "E", 8 },
                    { 347, true, new DateTime(2017, 4, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), 21, true, "E", 7 },
                    { 346, true, new DateTime(2017, 3, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), 21, false, "E", 6 },
                    { 345, false, new DateTime(2018, 11, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 21, false, "E", 5 },
                    { 344, false, new DateTime(2019, 6, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 21, true, "E", 4 },
                    { 343, false, new DateTime(2017, 1, 6, 13, 0, 0, 0, DateTimeKind.Unspecified), 21, false, "E", 3 },
                    { 342, true, new DateTime(2018, 10, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), 21, false, "E", 2 },
                    { 356, true, new DateTime(2018, 7, 12, 11, 0, 0, 0, DateTimeKind.Unspecified), 21, true, "E", 16 },
                    { 67, false, new DateTime(2016, 2, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), 4, false, "E", 16 },
                    { 68, false, new DateTime(2017, 1, 23, 11, 0, 0, 0, DateTimeKind.Unspecified), 4, true, "E", 17 },
                    { 69, true, new DateTime(2019, 9, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 5, true, "E", 1 },
                    { 185, true, new DateTime(2017, 2, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), 11, true, "E", 15 },
                    { 184, false, new DateTime(2016, 4, 24, 9, 0, 0, 0, DateTimeKind.Unspecified), 11, false, "E", 14 },
                    { 183, true, new DateTime(2016, 9, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), 11, true, "E", 13 },
                    { 182, true, new DateTime(2018, 4, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), 11, false, "E", 12 },
                    { 181, false, new DateTime(2019, 5, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), 11, true, "E", 11 },
                    { 180, true, new DateTime(2019, 9, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), 11, false, "E", 10 },
                    { 179, true, new DateTime(2017, 6, 6, 7, 0, 0, 0, DateTimeKind.Unspecified), 11, false, "E", 9 },
                    { 178, false, new DateTime(2017, 5, 20, 13, 0, 0, 0, DateTimeKind.Unspecified), 11, true, "E", 8 },
                    { 177, false, new DateTime(2018, 12, 8, 13, 0, 0, 0, DateTimeKind.Unspecified), 11, false, "E", 7 },
                    { 176, false, new DateTime(2016, 12, 21, 7, 0, 0, 0, DateTimeKind.Unspecified), 11, true, "E", 6 },
                    { 175, false, new DateTime(2019, 8, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), 11, true, "E", 5 },
                    { 174, true, new DateTime(2016, 6, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 11, false, "E", 4 },
                    { 173, false, new DateTime(2017, 5, 8, 9, 0, 0, 0, DateTimeKind.Unspecified), 11, false, "E", 3 },
                    { 172, false, new DateTime(2018, 11, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), 11, false, "E", 2 },
                    { 171, true, new DateTime(2016, 9, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), 11, true, "E", 1 },
                    { 85, true, new DateTime(2018, 10, 18, 13, 0, 0, 0, DateTimeKind.Unspecified), 5, true, "E", 17 },
                    { 84, false, new DateTime(2018, 7, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), 5, true, "E", 16 },
                    { 70, false, new DateTime(2019, 12, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), 5, false, "E", 2 },
                    { 71, false, new DateTime(2018, 11, 23, 13, 0, 0, 0, DateTimeKind.Unspecified), 5, false, "E", 3 },
                    { 72, true, new DateTime(2019, 8, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 5, true, "E", 4 },
                    { 73, true, new DateTime(2018, 12, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), 5, true, "E", 5 },
                    { 74, false, new DateTime(2017, 8, 4, 15, 0, 0, 0, DateTimeKind.Unspecified), 5, true, "E", 6 },
                    { 75, false, new DateTime(2018, 6, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 5, true, "E", 7 },
                    { 492, false, new DateTime(2016, 7, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), 29, true, "E", 16 },
                    { 76, true, new DateTime(2019, 8, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 5, false, "E", 8 },
                    { 78, true, new DateTime(2016, 10, 23, 7, 0, 0, 0, DateTimeKind.Unspecified), 5, false, "E", 10 },
                    { 79, false, new DateTime(2016, 4, 18, 9, 0, 0, 0, DateTimeKind.Unspecified), 5, false, "E", 11 },
                    { 80, false, new DateTime(2016, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, false, "E", 12 },
                    { 81, true, new DateTime(2019, 12, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 5, true, "E", 13 },
                    { 82, false, new DateTime(2018, 11, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), 5, false, "E", 14 },
                    { 83, false, new DateTime(2019, 7, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), 5, true, "E", 15 },
                    { 77, true, new DateTime(2016, 9, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 5, false, "E", 9 },
                    { 493, true, new DateTime(2019, 11, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), 29, false, "E", 17 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bio_UserId",
                table: "Bio",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_CategoryId",
                table: "Course",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_PrereqId",
                table: "Course",
                column: "PrereqId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_InstanceId",
                table: "Enrollment",
                column: "InstanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_UserId",
                table: "Enrollment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Instance_CourseId",
                table: "Instance",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Instance_InstructorId",
                table: "Instance",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Instance_LocationId",
                table: "Instance",
                column: "LocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bio");

            migrationBuilder.DropTable(
                name: "Enrollment");

            migrationBuilder.DropTable(
                name: "Instance");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
