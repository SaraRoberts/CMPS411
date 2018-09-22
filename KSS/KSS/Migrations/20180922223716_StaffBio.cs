using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KSS.Migrations
{
    public partial class StaffBio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bio",
                columns: table => new
                {
                    StaffBioId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Picture = table.Column<string>(nullable: true),
                    Bio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bio", x => x.StaffBioId);
                });

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
                    Role = table.Column<string>(nullable: true),
                    StaffId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Bio_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Bio",
                        principalColumn: "StaffBioId",
                        onDelete: ReferentialAction.Cascade);
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
                name: "Instance",
                columns: table => new
                {
                    InstanceId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
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
                table: "Bio",
                columns: new[] { "StaffBioId", "Bio", "Picture" },
                values: new object[,]
                {
                    { 5, "I am Staff 5!", "Placeholder" },
                    { 7, "I am Staff 7!", "Placeholder" },
                    { 6, "I am Staff 6!", "Placeholder" },
                    { 4, "I am Staff 4!", "Placeholder" },
                    { 3, "I am Staff 3!", "Placeholder" },
                    { 2, "I am Staff 2!", "Placeholder" },
                    { 1, "I am Staff 1!", "Placeholder" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "CPR" },
                    { 4, "EMT" },
                    { 3, "AED" },
                    { 2, "BLS" }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "LocationId", "City", "Name", "State", "Street", "Zipcode" },
                values: new object[,]
                {
                    { 2, "Tickfaw", "Tickfaw Location", "LA", "92 Hill Street", 70442 },
                    { 1, "Hammond", "Hammond Location", "LA", "104 Smith Street", 70403 },
                    { 3, "Independence", "Independence Location", "LA", "12044 Hwy 40", 70443 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "FirstName", "LastName", "Password", "Phone", "Role", "Salt", "StaffId" },
                values: new object[,]
                {
                    { 15, "student14@student.com", "Amanda", "Catalonato", "HmeXE4u5XwRTPAdjHd83z36lgztTmimwYqNnHeosNSI=", "1112223333", "User", new byte[] { 17, 107, 232, 70, 177, 216, 25, 96, 181, 109, 70, 174, 116, 197, 45, 171 }, null },
                    { 1, "admin@admin.com", "Becky", "Smith", "lfzrBEb8a7A6ztyujUAMfm10eaEld+uN1t9byW0OdPQ=", "1112223333", "Admin", new byte[] { 69, 145, 20, 214, 223, 116, 139, 25, 13, 177, 197, 2, 199, 55, 82, 203 }, null },
                    { 3, "student2@student.com", "Mike", "Waters", "HmeXE4u5XwRTPAdjHd83z36lgztTmimwYqNnHeosNSI=", "1112223333", "User", new byte[] { 17, 107, 232, 70, 177, 216, 25, 96, 181, 109, 70, 174, 116, 197, 45, 171 }, null },
                    { 4, "student3@student.com", "Russel", "Chavers", "HmeXE4u5XwRTPAdjHd83z36lgztTmimwYqNnHeosNSI=", "1112223333", "User", new byte[] { 17, 107, 232, 70, 177, 216, 25, 96, 181, 109, 70, 174, 116, 197, 45, 171 }, null },
                    { 5, "student4@student.com", "Sharon", "Manino", "HmeXE4u5XwRTPAdjHd83z36lgztTmimwYqNnHeosNSI=", "1112223333", "User", new byte[] { 17, 107, 232, 70, 177, 216, 25, 96, 181, 109, 70, 174, 116, 197, 45, 171 }, null },
                    { 7, "student6@student.com", "Bill", "Everet", "HmeXE4u5XwRTPAdjHd83z36lgztTmimwYqNnHeosNSI=", "1112223333", "User", new byte[] { 17, 107, 232, 70, 177, 216, 25, 96, 181, 109, 70, 174, 116, 197, 45, 171 }, null },
                    { 9, "student8@student.com", "Colin", "Livers", "HmeXE4u5XwRTPAdjHd83z36lgztTmimwYqNnHeosNSI=", "1112223333", "User", new byte[] { 17, 107, 232, 70, 177, 216, 25, 96, 181, 109, 70, 174, 116, 197, 45, 171 }, null },
                    { 10, "student9@student.com", "Babe", "Ruth", "HmeXE4u5XwRTPAdjHd83z36lgztTmimwYqNnHeosNSI=", "1112223333", "User", new byte[] { 17, 107, 232, 70, 177, 216, 25, 96, 181, 109, 70, 174, 116, 197, 45, 171 }, null },
                    { 12, "student11@student.com", "Gary", "Aimes", "HmeXE4u5XwRTPAdjHd83z36lgztTmimwYqNnHeosNSI=", "1112223333", "User", new byte[] { 17, 107, 232, 70, 177, 216, 25, 96, 181, 109, 70, 174, 116, 197, 45, 171 }, null },
                    { 17, "student16@student.com", "Richard", "Newman", "HmeXE4u5XwRTPAdjHd83z36lgztTmimwYqNnHeosNSI=", "1112223333", "User", new byte[] { 17, 107, 232, 70, 177, 216, 25, 96, 181, 109, 70, 174, 116, 197, 45, 171 }, null }
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
                    { 2, "student1@student.com", "Paul", "Dig", "HmeXE4u5XwRTPAdjHd83z36lgztTmimwYqNnHeosNSI=", "1112223333", "User", new byte[] { 17, 107, 232, 70, 177, 216, 25, 96, 181, 109, 70, 174, 116, 197, 45, 171 }, 1 },
                    { 6, "student5@student.com", "Amy", "Hillbond", "HmeXE4u5XwRTPAdjHd83z36lgztTmimwYqNnHeosNSI=", "1112223333", "User", new byte[] { 17, 107, 232, 70, 177, 216, 25, 96, 181, 109, 70, 174, 116, 197, 45, 171 }, 2 },
                    { 8, "student7@student.com", "Trenton", "Hillsong", "HmeXE4u5XwRTPAdjHd83z36lgztTmimwYqNnHeosNSI=", "1112223333", "User", new byte[] { 17, 107, 232, 70, 177, 216, 25, 96, 181, 109, 70, 174, 116, 197, 45, 171 }, 3 },
                    { 11, "student10@student.com", "Tim", "Hammond", "HmeXE4u5XwRTPAdjHd83z36lgztTmimwYqNnHeosNSI=", "1112223333", "User", new byte[] { 17, 107, 232, 70, 177, 216, 25, 96, 181, 109, 70, 174, 116, 197, 45, 171 }, 4 },
                    { 13, "student12@student.com", "Lucy", "Vilardo", "HmeXE4u5XwRTPAdjHd83z36lgztTmimwYqNnHeosNSI=", "1112223333", "User", new byte[] { 17, 107, 232, 70, 177, 216, 25, 96, 181, 109, 70, 174, 116, 197, 45, 171 }, 5 },
                    { 14, "student13@student.com", "Tom", "Avers", "HmeXE4u5XwRTPAdjHd83z36lgztTmimwYqNnHeosNSI=", "1112223333", "User", new byte[] { 17, 107, 232, 70, 177, 216, 25, 96, 181, 109, 70, 174, 116, 197, 45, 171 }, 6 },
                    { 16, "student15@student.com", "Donald", "Hill", "HmeXE4u5XwRTPAdjHd83z36lgztTmimwYqNnHeosNSI=", "1112223333", "User", new byte[] { 17, 107, 232, 70, 177, 216, 25, 96, 181, 109, 70, 174, 116, 197, 45, 171 }, 7 }
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
                    { 8, true, 51.0, 2, 6, 2, 58.0, 14, new DateTimeOffset(new DateTime(2016, 11, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 24, true, 52.0, 1, 2, 2, 91.0, 27, new DateTimeOffset(new DateTime(2018, 4, 17, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 15, true, 33.0, 5, 2, 1, 79.0, 14, new DateTimeOffset(new DateTime(2019, 5, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 12, true, 37.0, 2, 2, 3, 100.0, 24, new DateTimeOffset(new DateTime(2016, 5, 28, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 11, true, 39.0, 2, 2, 1, 58.0, 24, new DateTimeOffset(new DateTime(2017, 2, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 6, true, 52.0, 4, 3, 2, 75.0, 12, new DateTimeOffset(new DateTime(2018, 4, 21, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 5, true, 26.0, 4, 5, 2, 68.0, 25, new DateTimeOffset(new DateTime(2018, 7, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 1, true, 53.0, 4, 1, 3, 117.0, 27, new DateTimeOffset(new DateTime(2019, 8, 2, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 29, true, 46.0, 3, 1, 2, 55.0, 18, new DateTimeOffset(new DateTime(2018, 4, 25, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 18, true, 49.0, 3, 5, 3, 84.0, 24, new DateTimeOffset(new DateTime(2017, 4, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 4, true, 18.0, 3, 4, 2, 94.0, 27, new DateTimeOffset(new DateTime(2016, 8, 17, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 3, true, 44.0, 5, 4, 3, 45.0, 23, new DateTimeOffset(new DateTime(2017, 5, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 23, true, 25.0, 2, 3, 1, 114.0, 19, new DateTimeOffset(new DateTime(2019, 6, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 25, true, 18.0, 6, 5, 1, 51.0, 12, new DateTimeOffset(new DateTime(2018, 5, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 21, true, 17.0, 6, 4, 2, 119.0, 15, new DateTimeOffset(new DateTime(2018, 7, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 2, true, 33.0, 6, 3, 1, 135.0, 12, new DateTimeOffset(new DateTime(2018, 3, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 28, true, 38.0, 1, 3, 2, 51.0, 18, new DateTimeOffset(new DateTime(2019, 10, 19, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 7, true, 26.0, 1, 5, 3, 80.0, 25, new DateTimeOffset(new DateTime(2016, 2, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 13, true, 43.0, 6, 6, 2, 73.0, 28, new DateTimeOffset(new DateTime(2016, 3, 11, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 22, true, 44.0, 2, 6, 1, 78.0, 26, new DateTimeOffset(new DateTime(2018, 8, 4, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "EnrollmentId", "BookBought", "Confirmed", "InstanceId", "Paid", "Status", "UserId" },
                values: new object[,]
                {
                    { 41, false, new DateTime(2016, 8, 21, 14, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 7 },
                    { 42, true, new DateTime(2018, 7, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 8 },
                    { 43, true, new DateTime(2018, 7, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 9 },
                    { 44, true, new DateTime(2019, 9, 23, 15, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 10 },
                    { 45, false, new DateTime(2017, 1, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 11 },
                    { 46, false, new DateTime(2018, 1, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 12 },
                    { 47, true, new DateTime(2019, 11, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 13 },
                    { 48, true, new DateTime(2018, 7, 6, 13, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 14 },
                    { 49, true, new DateTime(2018, 9, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 15 },
                    { 50, true, new DateTime(2017, 6, 14, 11, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 16 },
                    { 51, false, new DateTime(2018, 10, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 17 },
                    { 1, false, new DateTime(2017, 2, 25, 9, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 1 },
                    { 2, false, new DateTime(2019, 3, 22, 17, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 2 },
                    { 3, false, new DateTime(2017, 9, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 3 },
                    { 4, false, new DateTime(2019, 1, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 4 },
                    { 5, false, new DateTime(2018, 5, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 5 },
                    { 6, false, new DateTime(2019, 6, 21, 11, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 6 },
                    { 7, false, new DateTime(2018, 11, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 7 },
                    { 8, true, new DateTime(2016, 2, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 8 },
                    { 9, true, new DateTime(2018, 11, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 9 },
                    { 10, true, new DateTime(2016, 7, 20, 14, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 10 },
                    { 11, true, new DateTime(2018, 8, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 11 },
                    { 12, true, new DateTime(2016, 11, 9, 9, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 12 },
                    { 13, true, new DateTime(2018, 8, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 13 },
                    { 14, true, new DateTime(2016, 10, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 14 },
                    { 15, true, new DateTime(2018, 1, 14, 13, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 15 },
                    { 16, false, new DateTime(2016, 12, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 16 },
                    { 40, false, new DateTime(2017, 3, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 6 },
                    { 17, true, new DateTime(2017, 1, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 17 },
                    { 38, false, new DateTime(2018, 6, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 4 },
                    { 18, true, new DateTime(2016, 5, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 1 },
                    { 19, false, new DateTime(2018, 6, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 2 },
                    { 20, true, new DateTime(2018, 1, 27, 15, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 3 },
                    { 21, false, new DateTime(2017, 8, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 4 },
                    { 22, false, new DateTime(2017, 10, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 5 },
                    { 23, false, new DateTime(2016, 7, 6, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 6 },
                    { 24, true, new DateTime(2016, 3, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 7 },
                    { 25, true, new DateTime(2016, 8, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 8 },
                    { 26, false, new DateTime(2016, 10, 18, 9, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 9 },
                    { 27, false, new DateTime(2017, 9, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 10 },
                    { 28, false, new DateTime(2017, 4, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 11 },
                    { 29, false, new DateTime(2018, 2, 12, 14, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 12 },
                    { 39, true, new DateTime(2016, 10, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 5 },
                    { 30, true, new DateTime(2016, 3, 23, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 13 },
                    { 32, false, new DateTime(2016, 11, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 15 },
                    { 33, false, new DateTime(2016, 11, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 16 },
                    { 34, true, new DateTime(2017, 11, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 17 },
                    { 35, true, new DateTime(2016, 5, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 1 },
                    { 36, false, new DateTime(2016, 6, 9, 13, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 2 },
                    { 37, true, new DateTime(2018, 12, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 3 },
                    { 31, false, new DateTime(2017, 9, 21, 11, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 14 }
                });

            migrationBuilder.InsertData(
                table: "Instance",
                columns: new[] { "InstanceId", "BookAvailable", "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[,]
                {
                    { 26, true, 31.0, 9, 2, 2, 129.0, 12, new DateTimeOffset(new DateTime(2016, 9, 25, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 20, true, 16.0, 9, 3, 1, 56.0, 15, new DateTimeOffset(new DateTime(2019, 12, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 14, true, 48.0, 9, 5, 3, 62.0, 11, new DateTimeOffset(new DateTime(2016, 10, 4, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 9, true, 15.0, 10, 3, 1, 137.0, 17, new DateTimeOffset(new DateTime(2019, 1, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 10, true, 41.0, 10, 6, 2, 113.0, 30, new DateTimeOffset(new DateTime(2018, 7, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 16, true, 23.0, 10, 2, 3, 51.0, 15, new DateTimeOffset(new DateTime(2018, 12, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 17, true, 55.0, 10, 2, 3, 108.0, 26, new DateTimeOffset(new DateTime(2017, 4, 6, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 27, true, 18.0, 8, 1, 1, 86.0, 16, new DateTimeOffset(new DateTime(2017, 12, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 19, true, 35.0, 8, 3, 3, 130.0, 17, new DateTimeOffset(new DateTime(2018, 1, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) }
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
                name: "Bio");
        }
    }
}
