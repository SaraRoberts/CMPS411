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
                    { 1, "Hammond", "Hammond Location", "LA", "104 Smith Street", 70403 },
                    { 2, "Tickfaw", "Tickfaw Location", "LA", "92 Hill Street", 70442 },
                    { 3, "Independence", "Independence Location", "LA", "12044 Hwy 40", 70443 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "FirstName", "LastName", "Password", "Phone", "Role", "Salt" },
                values: new object[,]
                {
                    { 15, "student14@student.com", "Amanda", "Catalonato", "GWtW/iRklxi6DD0zDVUi3qDyE7FgJH3ber7cr2kxR70=", "1112223333", "User", new byte[] { 189, 178, 98, 167, 40, 165, 72, 168, 220, 29, 110, 203, 159, 58, 129, 77 } },
                    { 14, "student13@student.com", "Tom", "Avers", "GWtW/iRklxi6DD0zDVUi3qDyE7FgJH3ber7cr2kxR70=", "1112223333", "User", new byte[] { 189, 178, 98, 167, 40, 165, 72, 168, 220, 29, 110, 203, 159, 58, 129, 77 } },
                    { 13, "student12@student.com", "Lucy", "Vilardo", "GWtW/iRklxi6DD0zDVUi3qDyE7FgJH3ber7cr2kxR70=", "1112223333", "User", new byte[] { 189, 178, 98, 167, 40, 165, 72, 168, 220, 29, 110, 203, 159, 58, 129, 77 } },
                    { 12, "student11@student.com", "Gary", "Aimes", "GWtW/iRklxi6DD0zDVUi3qDyE7FgJH3ber7cr2kxR70=", "1112223333", "User", new byte[] { 189, 178, 98, 167, 40, 165, 72, 168, 220, 29, 110, 203, 159, 58, 129, 77 } },
                    { 11, "student10@student.com", "Tim", "Hammond", "GWtW/iRklxi6DD0zDVUi3qDyE7FgJH3ber7cr2kxR70=", "1112223333", "User", new byte[] { 189, 178, 98, 167, 40, 165, 72, 168, 220, 29, 110, 203, 159, 58, 129, 77 } },
                    { 10, "student9@student.com", "Babe", "Ruth", "GWtW/iRklxi6DD0zDVUi3qDyE7FgJH3ber7cr2kxR70=", "1112223333", "User", new byte[] { 189, 178, 98, 167, 40, 165, 72, 168, 220, 29, 110, 203, 159, 58, 129, 77 } },
                    { 9, "student8@student.com", "Colin", "Livers", "GWtW/iRklxi6DD0zDVUi3qDyE7FgJH3ber7cr2kxR70=", "1112223333", "User", new byte[] { 189, 178, 98, 167, 40, 165, 72, 168, 220, 29, 110, 203, 159, 58, 129, 77 } },
                    { 5, "student4@student.com", "Sharon", "Manino", "GWtW/iRklxi6DD0zDVUi3qDyE7FgJH3ber7cr2kxR70=", "1112223333", "Staff", new byte[] { 189, 178, 98, 167, 40, 165, 72, 168, 220, 29, 110, 203, 159, 58, 129, 77 } },
                    { 7, "student6@student.com", "Bill", "Everet", "GWtW/iRklxi6DD0zDVUi3qDyE7FgJH3ber7cr2kxR70=", "1112223333", "User", new byte[] { 189, 178, 98, 167, 40, 165, 72, 168, 220, 29, 110, 203, 159, 58, 129, 77 } },
                    { 6, "student5@student.com", "Amy", "Hillbond", "GWtW/iRklxi6DD0zDVUi3qDyE7FgJH3ber7cr2kxR70=", "1112223333", "Staff", new byte[] { 189, 178, 98, 167, 40, 165, 72, 168, 220, 29, 110, 203, 159, 58, 129, 77 } },
                    { 16, "student15@student.com", "Donald", "Hill", "GWtW/iRklxi6DD0zDVUi3qDyE7FgJH3ber7cr2kxR70=", "1112223333", "User", new byte[] { 189, 178, 98, 167, 40, 165, 72, 168, 220, 29, 110, 203, 159, 58, 129, 77 } },
                    { 4, "student3@student.com", "Russel", "Chavers", "GWtW/iRklxi6DD0zDVUi3qDyE7FgJH3ber7cr2kxR70=", "1112223333", "Staff", new byte[] { 189, 178, 98, 167, 40, 165, 72, 168, 220, 29, 110, 203, 159, 58, 129, 77 } },
                    { 3, "student2@student.com", "Mike", "Waters", "GWtW/iRklxi6DD0zDVUi3qDyE7FgJH3ber7cr2kxR70=", "1112223333", "Staff", new byte[] { 189, 178, 98, 167, 40, 165, 72, 168, 220, 29, 110, 203, 159, 58, 129, 77 } },
                    { 2, "student1@student.com", "Paul", "Dig", "GWtW/iRklxi6DD0zDVUi3qDyE7FgJH3ber7cr2kxR70=", "1112223333", "Staff", new byte[] { 189, 178, 98, 167, 40, 165, 72, 168, 220, 29, 110, 203, 159, 58, 129, 77 } },
                    { 1, "admin@admin.com", "Becky", "Smith", "zFweIpqfMFO0zCvggxGP1+gsUOCm9Ly9L5WIPUbVm9k=", "1112223333", "Admin", new byte[] { 73, 160, 177, 120, 69, 86, 219, 238, 225, 138, 248, 200, 157, 44, 13, 69 } },
                    { 8, "student7@student.com", "Trenton", "Hillsong", "GWtW/iRklxi6DD0zDVUi3qDyE7FgJH3ber7cr2kxR70=", "1112223333", "User", new byte[] { 189, 178, 98, 167, 40, 165, 72, 168, 220, 29, 110, 203, 159, 58, 129, 77 } },
                    { 17, "student16@student.com", "Richard", "Newman", "GWtW/iRklxi6DD0zDVUi3qDyE7FgJH3ber7cr2kxR70=", "1112223333", "User", new byte[] { 189, 178, 98, 167, 40, 165, 72, 168, 220, 29, 110, 203, 159, 58, 129, 77 } }
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
                    { 15, true, 41.0, 6, false, 4, 3, 50.0, 20, new DateTimeOffset(new DateTime(2016, 6, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 4, true, 54.0, 4, false, 5, 1, 50.0, 23, new DateTimeOffset(new DateTime(2018, 10, 21, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 3, true, 19.0, 4, false, 6, 1, 121.0, 11, new DateTimeOffset(new DateTime(2019, 5, 22, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 6, true, 39.0, 1, false, 2, 3, 137.0, 17, new DateTimeOffset(new DateTime(2016, 10, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 25, true, 44.0, 3, false, 6, 2, 73.0, 10, new DateTimeOffset(new DateTime(2019, 9, 7, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 8, true, 19.0, 3, false, 3, 2, 123.0, 15, new DateTimeOffset(new DateTime(2016, 7, 3, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 5, true, 27.0, 7, false, 6, 3, 53.0, 17, new DateTimeOffset(new DateTime(2019, 9, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 29, true, 30.0, 5, false, 2, 1, 114.0, 28, new DateTimeOffset(new DateTime(2016, 6, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 18, true, 24.0, 1, false, 5, 3, 82.0, 17, new DateTimeOffset(new DateTime(2019, 4, 4, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 19, true, 49.0, 5, false, 1, 2, 130.0, 23, new DateTimeOffset(new DateTime(2017, 2, 4, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 11, true, 23.0, 4, false, 1, 2, 118.0, 27, new DateTimeOffset(new DateTime(2018, 10, 8, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 16, true, 37.0, 2, false, 6, 2, 73.0, 19, new DateTimeOffset(new DateTime(2019, 12, 27, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 13, true, 18.0, 2, false, 2, 2, 62.0, 12, new DateTimeOffset(new DateTime(2019, 4, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 10, true, 25.0, 2, false, 5, 1, 56.0, 14, new DateTimeOffset(new DateTime(2016, 7, 22, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 26, true, 31.0, 6, false, 3, 2, 99.0, 15, new DateTimeOffset(new DateTime(2016, 1, 23, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 20, true, 39.0, 6, false, 1, 1, 56.0, 21, new DateTimeOffset(new DateTime(2017, 6, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 17, true, 35.0, 6, false, 1, 3, 149.0, 21, new DateTimeOffset(new DateTime(2019, 12, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 9, true, 23.0, 5, false, 3, 3, 86.0, 25, new DateTimeOffset(new DateTime(2017, 8, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 12, true, 38.0, 4, false, 2, 3, 109.0, 13, new DateTimeOffset(new DateTime(2016, 1, 22, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "EnrollmentId", "BookBought", "Confirmed", "InstanceId", "Paid", "Status", "UserId" },
                values: new object[,]
                {
                    { 38, false, new DateTime(2019, 7, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 4 },
                    { 49, false, new DateTime(2019, 11, 10, 15, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 15 },
                    { 48, false, new DateTime(2019, 1, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 14 },
                    { 47, true, new DateTime(2016, 12, 20, 15, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 13 },
                    { 46, false, new DateTime(2018, 7, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 12 },
                    { 45, false, new DateTime(2016, 4, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 11 },
                    { 44, true, new DateTime(2017, 4, 27, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 10 },
                    { 43, false, new DateTime(2016, 11, 21, 11, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 9 },
                    { 42, true, new DateTime(2016, 12, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 8 },
                    { 41, false, new DateTime(2016, 6, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 7 },
                    { 40, false, new DateTime(2016, 11, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 6 },
                    { 39, true, new DateTime(2016, 12, 4, 15, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 5 },
                    { 50, true, new DateTime(2019, 4, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 16 },
                    { 51, true, new DateTime(2019, 2, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 17 },
                    { 36, false, new DateTime(2019, 6, 20, 14, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 2 },
                    { 35, true, new DateTime(2019, 8, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 1 },
                    { 37, false, new DateTime(2017, 2, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 3 }
                });

            migrationBuilder.InsertData(
                table: "Instance",
                columns: new[] { "InstanceId", "BookAvailable", "BookPrice", "CourseId", "Graded", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[,]
                {
                    { 21, true, 34.0, 9, false, 4, 2, 100.0, 22, new DateTimeOffset(new DateTime(2017, 1, 18, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 1, true, 51.0, 9, false, 3, 1, 70.0, 21, new DateTimeOffset(new DateTime(2017, 10, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 24, true, 36.0, 10, false, 4, 2, 141.0, 15, new DateTimeOffset(new DateTime(2019, 9, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 23, true, 33.0, 10, false, 2, 2, 71.0, 12, new DateTimeOffset(new DateTime(2016, 11, 19, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 28, true, 18.0, 8, false, 1, 1, 122.0, 21, new DateTimeOffset(new DateTime(2018, 11, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 27, true, 38.0, 8, false, 1, 2, 73.0, 20, new DateTimeOffset(new DateTime(2017, 8, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 22, true, 26.0, 8, false, 3, 2, 78.0, 12, new DateTimeOffset(new DateTime(2019, 7, 17, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 14, true, 51.0, 8, false, 4, 2, 130.0, 12, new DateTimeOffset(new DateTime(2016, 1, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 7, true, 42.0, 8, false, 6, 1, 97.0, 13, new DateTimeOffset(new DateTime(2016, 6, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 2, true, 16.0, 8, false, 4, 2, 64.0, 14, new DateTimeOffset(new DateTime(2017, 2, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "EnrollmentId", "BookBought", "Confirmed", "InstanceId", "Paid", "Status", "UserId" },
                values: new object[,]
                {
                    { 18, true, new DateTime(2018, 6, 23, 7, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 1 },
                    { 15, true, new DateTime(2017, 8, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 15 },
                    { 14, false, new DateTime(2016, 12, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 14 },
                    { 13, true, new DateTime(2018, 12, 27, 15, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 13 },
                    { 12, false, new DateTime(2019, 7, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 12 },
                    { 11, true, new DateTime(2018, 1, 16, 7, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 11 },
                    { 10, true, new DateTime(2018, 6, 28, 17, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 10 },
                    { 9, true, new DateTime(2017, 5, 28, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 9 },
                    { 8, false, new DateTime(2019, 4, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 8 },
                    { 7, true, new DateTime(2019, 6, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 7 },
                    { 6, true, new DateTime(2019, 2, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 6 },
                    { 5, false, new DateTime(2017, 12, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 5 },
                    { 4, false, new DateTime(2017, 5, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 4 },
                    { 3, false, new DateTime(2016, 5, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 3 },
                    { 2, true, new DateTime(2019, 5, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 2 },
                    { 1, false, new DateTime(2018, 6, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 1 },
                    { 34, false, new DateTime(2018, 2, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 17 },
                    { 33, false, new DateTime(2018, 5, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 16 },
                    { 19, true, new DateTime(2019, 1, 28, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 2 },
                    { 20, true, new DateTime(2018, 8, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 3 },
                    { 21, true, new DateTime(2018, 11, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 4 },
                    { 22, true, new DateTime(2016, 5, 2, 13, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 5 },
                    { 23, true, new DateTime(2017, 9, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 6 },
                    { 24, false, new DateTime(2018, 4, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 7 },
                    { 16, true, new DateTime(2019, 1, 21, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 16 },
                    { 25, false, new DateTime(2017, 2, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 8 },
                    { 27, true, new DateTime(2017, 6, 14, 9, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 10 },
                    { 28, true, new DateTime(2019, 4, 3, 9, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 11 },
                    { 29, true, new DateTime(2017, 10, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 12 },
                    { 30, true, new DateTime(2019, 6, 19, 7, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 13 },
                    { 31, true, new DateTime(2016, 4, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 14 },
                    { 32, true, new DateTime(2019, 4, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 15 },
                    { 26, true, new DateTime(2019, 8, 26, 7, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 9 },
                    { 17, true, new DateTime(2019, 9, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 17 }
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
