using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KSS.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
                name: "Staff",
                columns: table => new
                {
                    StaffId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Picture = table.Column<string>(nullable: true),
                    Bio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffId);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    CourseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Salt = table.Column<byte[]>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    StaffId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "StaffId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Instance",
                columns: table => new
                {
                    InstanceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StartDate = table.Column<DateTimeOffset>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    CourseId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false),
                    Seats = table.Column<int>(nullable: false),
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
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InstanceId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: false),
                    BookBought = table.Column<bool>(nullable: false),
                    Paid = table.Column<bool>(nullable: false),
                    Confirmed = table.Column<bool>(nullable: false)
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
                table: "Staff",
                columns: new[] { "StaffId", "Bio", "Picture" },
                values: new object[,]
                {
                    { 7, "I am Staff 7!", "Placeholder" },
                    { 6, "I am Staff 6!", "Placeholder" },
                    { 4, "I am Staff 4!", "Placeholder" },
                    { 5, "I am Staff 5!", "Placeholder" },
                    { 2, "I am Staff 2!", "Placeholder" },
                    { 1, "I am Staff 1!", "Placeholder" },
                    { 3, "I am Staff 3!", "Placeholder" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "FirstName", "LastName", "Password", "Phone", "Role", "Salt", "StaffId" },
                values: new object[,]
                {
                    { 15, "student14@student.com", "Amanda", "Catalonato", "PZJm1P8KQaqGmsuo0VrPwO5qcCpv6QcjRgX+DyGVp1M=", "1112223333", "User", new byte[] { 187, 236, 157, 178, 112, 157, 31, 89, 240, 10, 110, 241, 243, 98, 118, 78 }, null },
                    { 1, "admin@admin.com", "Becky", "Smith", "4MzHj23ikIsyimD469f0fZuAoZWiN5fkXa9/GMNntp8=", "1112223333", "Admin", new byte[] { 39, 72, 105, 193, 151, 178, 7, 125, 201, 38, 69, 187, 219, 98, 81, 29 }, null },
                    { 3, "student2@student.com", "Mike", "Waters", "PZJm1P8KQaqGmsuo0VrPwO5qcCpv6QcjRgX+DyGVp1M=", "1112223333", "User", new byte[] { 187, 236, 157, 178, 112, 157, 31, 89, 240, 10, 110, 241, 243, 98, 118, 78 }, null },
                    { 4, "student3@student.com", "Russel", "Chavers", "PZJm1P8KQaqGmsuo0VrPwO5qcCpv6QcjRgX+DyGVp1M=", "1112223333", "User", new byte[] { 187, 236, 157, 178, 112, 157, 31, 89, 240, 10, 110, 241, 243, 98, 118, 78 }, null },
                    { 5, "student4@student.com", "Sharon", "Manino", "PZJm1P8KQaqGmsuo0VrPwO5qcCpv6QcjRgX+DyGVp1M=", "1112223333", "User", new byte[] { 187, 236, 157, 178, 112, 157, 31, 89, 240, 10, 110, 241, 243, 98, 118, 78 }, null },
                    { 7, "student6@student.com", "Bill", "Everet", "PZJm1P8KQaqGmsuo0VrPwO5qcCpv6QcjRgX+DyGVp1M=", "1112223333", "User", new byte[] { 187, 236, 157, 178, 112, 157, 31, 89, 240, 10, 110, 241, 243, 98, 118, 78 }, null },
                    { 9, "student8@student.com", "Colin", "Livers", "PZJm1P8KQaqGmsuo0VrPwO5qcCpv6QcjRgX+DyGVp1M=", "1112223333", "User", new byte[] { 187, 236, 157, 178, 112, 157, 31, 89, 240, 10, 110, 241, 243, 98, 118, 78 }, null },
                    { 10, "student9@student.com", "Babe", "Ruth", "PZJm1P8KQaqGmsuo0VrPwO5qcCpv6QcjRgX+DyGVp1M=", "1112223333", "User", new byte[] { 187, 236, 157, 178, 112, 157, 31, 89, 240, 10, 110, 241, 243, 98, 118, 78 }, null },
                    { 12, "student11@student.com", "Gary", "Aimes", "PZJm1P8KQaqGmsuo0VrPwO5qcCpv6QcjRgX+DyGVp1M=", "1112223333", "User", new byte[] { 187, 236, 157, 178, 112, 157, 31, 89, 240, 10, 110, 241, 243, 98, 118, 78 }, null },
                    { 17, "student16@student.com", "Richard", "Newman", "PZJm1P8KQaqGmsuo0VrPwO5qcCpv6QcjRgX+DyGVp1M=", "1112223333", "User", new byte[] { 187, 236, 157, 178, 112, 157, 31, 89, 240, 10, 110, 241, 243, 98, 118, 78 }, null }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "BookAvailable", "BookPrice", "CategoryId", "Description", "Name", "PrereqId", "TypicalPrice" },
                values: new object[,]
                {
                    { 1, true, 25m, 1, "A 4 ½ hour initial course designed for Healthcare Professionals.  The course covers Adult, Child, and Infant one-rescuer CPR AED, as well as a new focused emphasis on teamwork with the adult, child, and infant two-person rescue.  Topics also include Rescue Breathing and Foreign Body Airway Obstruction. Cost includes the use of a textbook, written and practical exams, and a course completion certification(good for 2 years).New 2015 Guidelines!", "Basic Life Support (BLS) for Healthcare Professionals", null, 50 },
                    { 6, false, 0m, 1, "A 6-8 hour First Aid course designed for childcare workers whose job requires a pediatric-specific first aid completion card.  This course provides the skills to effectively asses and maintain a child’s life in the critical minutes following an emergency until the arrival of emergency personnel.  This course covers all State of Louisiana required modules including Child Care specific topics, General Principles, Medical Emergencies, Injury Emergencies, and Environmental Emergencies.  Also includes CPR and AED training for Adult, Children, and Infants. Cost includes use of a textbook, skills, and course completion certification(good for 2 years).New 2015 Guidelines!", "Heartsaver Pediatric First Aid Course (Daycare/Childcare Providers)", null, 50 },
                    { 2, false, 0m, 2, "A 4 hour refresher course for the Healthcare Professional; this course offers guidelines in one and two-rescuer adult, child, and infant CPR, Foreign Body Airway Obstruction, and AED training. Cost includes the use of a students’ textbook, written and practical exams, and course completion certification(good for 2 years).New 2015 Guidelines!", "Basic Life Support (BLS) with CPR for Healthcare Professionals -  Refresher", null, 50 },
                    { 5, true, 15m, 2, "A 4 hour course designed for the general public or lay rescuer whose job requires a first aid course completion card.  The course provides the skills to effectively asses and maintain life from the critical minutes of an emergency until the arrival of emergency service personnel.  Depending on which modules the candidate wishes to take, the basic first aid course consists of General Principles, Medical Emergencies, and Injury Emergencies.  Also includes CPR and AED training, and Environmental Emergencies. Cost includes use of a textbook, practice exam, and course completion certificate(good for 2 years).New 2015 Guidelines!", "Heartsaver First Aid ", null, 50 },
                    { 7, false, 0m, 2, "A 2 ½ hour entry level awareness program designed for the general public, parents, babysitters, grandparents, churches, clubs, etc.  The course covers American Heart Association guidelines for the one-rescuer adult including Pediatric CPR, relief of Foreign Body Airway Obstructions, the chain of survival, Basic First Aid, and recognizing the signs of a heart attack and stroke. Cost includes a student textbook.New 2016 Guidelines!", "Family and Friends CPR (course designed for general public; non-certification course)", null, 50 },
                    { 3, false, 0m, 3, "For those who have successfully completed the online portion of either BLS course.  Students MUST provide a copy of the online course completion certificate. Cost includes practice time, exam, and course completion certificate(good for 2 years)", "BLS Online Recertification – Part 2", 3, 0 },
                    { 4, true, 15m, 4, "A 2-3 hour course designed to teach the lay rescuer (security guards, personal trainers, church organization teachers, etc.) how to recognize and treat life-threatening emergencies whose job requires a course completion card documenting one-rescuer adult and/or pediatric CPR, Foreign Body Airway Obstruction, and AED training. Cost includes the use of a textbook, practice exam, and course completion certificate(good for 2 years).New 2015 Guidelines!", "Heartsaver CPR/AED ", null, 50 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "FirstName", "LastName", "Password", "Phone", "Role", "Salt", "StaffId" },
                values: new object[,]
                {
                    { 2, "student1@student.com", "Paul", "Dig", "PZJm1P8KQaqGmsuo0VrPwO5qcCpv6QcjRgX+DyGVp1M=", "1112223333", "User", new byte[] { 187, 236, 157, 178, 112, 157, 31, 89, 240, 10, 110, 241, 243, 98, 118, 78 }, 1 },
                    { 6, "student5@student.com", "Amy", "Hillbond", "PZJm1P8KQaqGmsuo0VrPwO5qcCpv6QcjRgX+DyGVp1M=", "1112223333", "User", new byte[] { 187, 236, 157, 178, 112, 157, 31, 89, 240, 10, 110, 241, 243, 98, 118, 78 }, 2 },
                    { 8, "student7@student.com", "Trenton", "Hillsong", "PZJm1P8KQaqGmsuo0VrPwO5qcCpv6QcjRgX+DyGVp1M=", "1112223333", "User", new byte[] { 187, 236, 157, 178, 112, 157, 31, 89, 240, 10, 110, 241, 243, 98, 118, 78 }, 3 },
                    { 11, "student10@student.com", "Tim", "Hammond", "PZJm1P8KQaqGmsuo0VrPwO5qcCpv6QcjRgX+DyGVp1M=", "1112223333", "User", new byte[] { 187, 236, 157, 178, 112, 157, 31, 89, 240, 10, 110, 241, 243, 98, 118, 78 }, 4 },
                    { 13, "student12@student.com", "Lucy", "Vilardo", "PZJm1P8KQaqGmsuo0VrPwO5qcCpv6QcjRgX+DyGVp1M=", "1112223333", "User", new byte[] { 187, 236, 157, 178, 112, 157, 31, 89, 240, 10, 110, 241, 243, 98, 118, 78 }, 5 },
                    { 14, "student13@student.com", "Tom", "Avers", "PZJm1P8KQaqGmsuo0VrPwO5qcCpv6QcjRgX+DyGVp1M=", "1112223333", "User", new byte[] { 187, 236, 157, 178, 112, 157, 31, 89, 240, 10, 110, 241, 243, 98, 118, 78 }, 6 },
                    { 16, "student15@student.com", "Donald", "Hill", "PZJm1P8KQaqGmsuo0VrPwO5qcCpv6QcjRgX+DyGVp1M=", "1112223333", "User", new byte[] { 187, 236, 157, 178, 112, 157, 31, 89, 240, 10, 110, 241, 243, 98, 118, 78 }, 7 }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "BookAvailable", "BookPrice", "CategoryId", "Description", "Name", "PrereqId", "TypicalPrice" },
                values: new object[,]
                {
                    { 8, false, 0m, 2, "This is a 16 - 20 hour course for those who wish to become AHA Instructor Candidates able to teach various levels of American Heart Association CPR.  Course is taught over 2 or 3 days. Successful completion of AHA BLS for Healthcare Providers Course, as well as each module instructor candidates wish to teach(Heartsaver First Aid, Heartsaver CPR / AED, etc.), and scoring 90 % or better on written examination(within 90 days of the instructor course) is required for completion. A letter of recommendation and completion of Core Instructor Course is required before applying. Cost includes all student level books, instructor manuals, practical exams, and test.New 2015 Guidelines!", "BLS CPR for Healthcare Providers, Instructor Course", 1, 50 },
                    { 10, false, 0m, 2, "For those who have successfully completed the online portion of the Heartsaver First Aid course.  Students MUST provide a copy of the online course completion certificate. Cost includes practice time, exam, and course completion certificate(good for 2 years)", "First Aid Online Recertification – Part 2", 5, 50 },
                    { 9, false, 0m, 1, "For those who have successfully completed the online portion of the Heartsaver CPR/AED course.  Students MUST provide a copy of the online course completion certificate. Cost includes practice time, exam, and course completion certificate(good for 2 years)", "CPR/AED Online Recertification – Part 2", 4, 50 }
                });

            migrationBuilder.InsertData(
                table: "Instance",
                columns: new[] { "InstanceId", "BookAvailable", "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[,]
                {
                    { 9, true, 50.0, 3, 2, 3, 45.0, 10, new DateTimeOffset(new DateTime(2018, 10, 1, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 2, true, 30.0, 1, 2, 2, 45.0, 10, new DateTimeOffset(new DateTime(2018, 7, 22, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 11, true, 50.0, 4, 4, 1, 45.0, 25, new DateTimeOffset(new DateTime(2018, 10, 25, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 10, true, 100.0, 4, 3, 1, 45.0, 25, new DateTimeOffset(new DateTime(2018, 10, 24, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 8, true, 90.0, 3, 1, 2, 45.0, 10, new DateTimeOffset(new DateTime(2018, 9, 29, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 7, true, 60.0, 3, 7, 1, 45.0, 12, new DateTimeOffset(new DateTime(2018, 9, 30, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 15, true, 300.0, 5, 1, 2, 45.0, 25, new DateTimeOffset(new DateTime(2018, 11, 14, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 14, true, 50.0, 5, 7, 2, 45.0, 25, new DateTimeOffset(new DateTime(2018, 11, 13, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 12, true, 50.0, 5, 5, 1, 45.0, 15, new DateTimeOffset(new DateTime(2018, 11, 1, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 5, true, 50.0, 2, 5, 2, 45.0, 30, new DateTimeOffset(new DateTime(2018, 9, 12, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 4, true, 250.0, 2, 4, 1, 45.0, 10, new DateTimeOffset(new DateTime(2018, 8, 12, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 3, true, 50.0, 1, 3, 3, 45.0, 30, new DateTimeOffset(new DateTime(2018, 8, 2, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 1, true, 50.0, 1, 1, 1, 45.0, 25, new DateTimeOffset(new DateTime(2018, 7, 1, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 6, true, 10.0, 2, 6, 3, 45.0, 10, new DateTimeOffset(new DateTime(2018, 9, 21, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 13, true, 30.0, 5, 6, 2, 45.0, 25, new DateTimeOffset(new DateTime(2018, 11, 11, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "EnrollmentId", "BookBought", "Confirmed", "InstanceId", "Paid", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, false, true, 1, false, "E", 12 },
                    { 16, false, true, 6, false, "E", 8 },
                    { 15, false, true, 6, true, "E", 7 },
                    { 14, false, false, 6, true, "E", 6 },
                    { 24, false, true, 9, true, "E", 14 },
                    { 23, false, true, 9, true, "E", 14 },
                    { 22, false, false, 9, true, "E", 13 },
                    { 6, false, true, 2, true, "E", 6 },
                    { 5, false, false, 2, true, "E", 5 },
                    { 4, false, false, 2, true, "E", 4 },
                    { 28, false, false, 11, false, "E", 17 },
                    { 27, false, true, 10, true, "E", 16 },
                    { 26, false, true, 10, true, "E", 15 },
                    { 25, false, true, 10, false, "E", 14 },
                    { 21, false, true, 8, false, "E", 12 },
                    { 20, false, true, 8, true, "E", 11 },
                    { 19, false, true, 8, false, "E", 10 },
                    { 18, false, true, 7, true, "E", 10 },
                    { 17, false, true, 7, false, "E", 9 },
                    { 30, false, true, 12, true, "E", 17 },
                    { 29, false, true, 12, true, "E", 3 },
                    { 13, false, true, 5, true, "E", 5 },
                    { 12, false, true, 5, true, "E", 4 },
                    { 11, false, true, 4, true, "E", 3 },
                    { 10, false, true, 4, false, "E", 2 },
                    { 9, false, true, 3, true, "E", 13 },
                    { 8, false, false, 3, false, "E", 8 },
                    { 7, false, true, 3, true, "E", 7 },
                    { 3, false, true, 1, true, "E", 3 },
                    { 2, false, true, 1, true, "E", 2 },
                    { 31, false, false, 13, true, "E", 2 },
                    { 32, false, true, 13, true, "E", 3 }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Users_StaffId",
                table: "Users",
                column: "StaffId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropTable(
                name: "Staff");
        }
    }
}
