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
                    Graded = table.Column<bool>(nullable: false),
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
                    { 15, "student14@student.com", "Amanda", "Catalonato", "Pxdce+Nsj8g9W+Ke8jhUszO5md76tQ/XWIsMXb5sk08=", "1112223333", "User", new byte[] { 167, 55, 55, 136, 75, 204, 117, 252, 109, 138, 14, 43, 174, 11, 57, 161 } },
                    { 14, "student13@student.com", "Tom", "Avers", "Pxdce+Nsj8g9W+Ke8jhUszO5md76tQ/XWIsMXb5sk08=", "1112223333", "User", new byte[] { 167, 55, 55, 136, 75, 204, 117, 252, 109, 138, 14, 43, 174, 11, 57, 161 } },
                    { 13, "student12@student.com", "Lucy", "Vilardo", "Pxdce+Nsj8g9W+Ke8jhUszO5md76tQ/XWIsMXb5sk08=", "1112223333", "User", new byte[] { 167, 55, 55, 136, 75, 204, 117, 252, 109, 138, 14, 43, 174, 11, 57, 161 } },
                    { 12, "student11@student.com", "Gary", "Aimes", "Pxdce+Nsj8g9W+Ke8jhUszO5md76tQ/XWIsMXb5sk08=", "1112223333", "User", new byte[] { 167, 55, 55, 136, 75, 204, 117, 252, 109, 138, 14, 43, 174, 11, 57, 161 } },
                    { 11, "student10@student.com", "Tim", "Hammond", "Pxdce+Nsj8g9W+Ke8jhUszO5md76tQ/XWIsMXb5sk08=", "1112223333", "User", new byte[] { 167, 55, 55, 136, 75, 204, 117, 252, 109, 138, 14, 43, 174, 11, 57, 161 } },
                    { 10, "student9@student.com", "Babe", "Ruth", "Pxdce+Nsj8g9W+Ke8jhUszO5md76tQ/XWIsMXb5sk08=", "1112223333", "User", new byte[] { 167, 55, 55, 136, 75, 204, 117, 252, 109, 138, 14, 43, 174, 11, 57, 161 } },
                    { 9, "student8@student.com", "Colin", "Livers", "Pxdce+Nsj8g9W+Ke8jhUszO5md76tQ/XWIsMXb5sk08=", "1112223333", "User", new byte[] { 167, 55, 55, 136, 75, 204, 117, 252, 109, 138, 14, 43, 174, 11, 57, 161 } },
                    { 5, "student4@student.com", "Sharon", "Manino", "Pxdce+Nsj8g9W+Ke8jhUszO5md76tQ/XWIsMXb5sk08=", "1112223333", "Staff", new byte[] { 167, 55, 55, 136, 75, 204, 117, 252, 109, 138, 14, 43, 174, 11, 57, 161 } },
                    { 7, "student6@student.com", "Bill", "Everet", "Pxdce+Nsj8g9W+Ke8jhUszO5md76tQ/XWIsMXb5sk08=", "1112223333", "User", new byte[] { 167, 55, 55, 136, 75, 204, 117, 252, 109, 138, 14, 43, 174, 11, 57, 161 } },
                    { 6, "student5@student.com", "Amy", "Hillbond", "Pxdce+Nsj8g9W+Ke8jhUszO5md76tQ/XWIsMXb5sk08=", "1112223333", "Staff", new byte[] { 167, 55, 55, 136, 75, 204, 117, 252, 109, 138, 14, 43, 174, 11, 57, 161 } },
                    { 16, "student15@student.com", "Donald", "Hill", "Pxdce+Nsj8g9W+Ke8jhUszO5md76tQ/XWIsMXb5sk08=", "1112223333", "User", new byte[] { 167, 55, 55, 136, 75, 204, 117, 252, 109, 138, 14, 43, 174, 11, 57, 161 } },
                    { 4, "student3@student.com", "Russel", "Chavers", "Pxdce+Nsj8g9W+Ke8jhUszO5md76tQ/XWIsMXb5sk08=", "1112223333", "Staff", new byte[] { 167, 55, 55, 136, 75, 204, 117, 252, 109, 138, 14, 43, 174, 11, 57, 161 } },
                    { 3, "student2@student.com", "Mike", "Waters", "Pxdce+Nsj8g9W+Ke8jhUszO5md76tQ/XWIsMXb5sk08=", "1112223333", "Staff", new byte[] { 167, 55, 55, 136, 75, 204, 117, 252, 109, 138, 14, 43, 174, 11, 57, 161 } },
                    { 2, "student1@student.com", "Paul", "Dig", "Pxdce+Nsj8g9W+Ke8jhUszO5md76tQ/XWIsMXb5sk08=", "1112223333", "Staff", new byte[] { 167, 55, 55, 136, 75, 204, 117, 252, 109, 138, 14, 43, 174, 11, 57, 161 } },
                    { 1, "admin@admin.com", "Becky", "Smith", "sVKj+RNzOrdgapKsp8WSNhNAOUEc6GCW5SZ86z85YcQ=", "1112223333", "Admin", new byte[] { 82, 223, 153, 55, 107, 188, 136, 17, 179, 166, 132, 10, 40, 98, 109, 23 } },
                    { 8, "student7@student.com", "Trenton", "Hillsong", "Pxdce+Nsj8g9W+Ke8jhUszO5md76tQ/XWIsMXb5sk08=", "1112223333", "User", new byte[] { 167, 55, 55, 136, 75, 204, 117, 252, 109, 138, 14, 43, 174, 11, 57, 161 } },
                    { 17, "student16@student.com", "Richard", "Newman", "Pxdce+Nsj8g9W+Ke8jhUszO5md76tQ/XWIsMXb5sk08=", "1112223333", "User", new byte[] { 167, 55, 55, 136, 75, 204, 117, 252, 109, 138, 14, 43, 174, 11, 57, 161 } }
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
                    { 3, true, 48.0, 3, false, 2, 2, 124.0, 24, new DateTimeOffset(new DateTime(2018, 8, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 11, true, 22.0, 7, false, 3, 1, 116.0, 19, new DateTimeOffset(new DateTime(2019, 4, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 10, true, 43.0, 7, false, 2, 3, 53.0, 29, new DateTimeOffset(new DateTime(2018, 4, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 2, true, 46.0, 7, false, 4, 1, 77.0, 18, new DateTimeOffset(new DateTime(2016, 8, 27, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 1, true, 23.0, 7, false, 3, 1, 149.0, 16, new DateTimeOffset(new DateTime(2019, 2, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 18, true, 41.0, 5, false, 2, 1, 48.0, 26, new DateTimeOffset(new DateTime(2018, 1, 19, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 16, true, 34.0, 5, false, 1, 1, 73.0, 22, new DateTimeOffset(new DateTime(2016, 7, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 14, true, 20.0, 5, false, 2, 1, 140.0, 25, new DateTimeOffset(new DateTime(2019, 7, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 12, true, 41.0, 5, false, 1, 1, 128.0, 15, new DateTimeOffset(new DateTime(2016, 8, 27, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 7, true, 30.0, 5, false, 6, 1, 75.0, 28, new DateTimeOffset(new DateTime(2017, 4, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 29, true, 55.0, 2, false, 4, 1, 105.0, 16, new DateTimeOffset(new DateTime(2017, 8, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 24, true, 52.0, 2, false, 1, 1, 145.0, 26, new DateTimeOffset(new DateTime(2016, 6, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 19, true, 50.0, 2, false, 4, 2, 108.0, 21, new DateTimeOffset(new DateTime(2018, 5, 21, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 9, true, 39.0, 2, false, 5, 2, 47.0, 26, new DateTimeOffset(new DateTime(2018, 5, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 17, true, 27.0, 6, false, 3, 2, 139.0, 15, new DateTimeOffset(new DateTime(2019, 9, 12, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 26, true, 47.0, 1, false, 3, 2, 52.0, 19, new DateTimeOffset(new DateTime(2019, 4, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 21, true, 46.0, 4, false, 2, 3, 146.0, 21, new DateTimeOffset(new DateTime(2019, 12, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 23, true, 29.0, 4, false, 1, 1, 73.0, 26, new DateTimeOffset(new DateTime(2018, 2, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "EnrollmentId", "BookBought", "Confirmed", "InstanceId", "Paid", "Status", "UserId" },
                values: new object[,]
                {
                    { 235, false, new DateTime(2017, 1, 13, 7, 0, 0, 0, DateTimeKind.Unspecified), 14, true, "E", 14 },
                    { 18, true, new DateTime(2019, 8, 10, 7, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 1 },
                    { 17, false, new DateTime(2019, 7, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 17 },
                    { 16, true, new DateTime(2017, 12, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 16 },
                    { 15, true, new DateTime(2016, 6, 25, 9, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 15 },
                    { 14, false, new DateTime(2016, 11, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 14 },
                    { 13, true, new DateTime(2018, 11, 25, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 13 },
                    { 12, false, new DateTime(2017, 8, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 12 },
                    { 11, true, new DateTime(2019, 3, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 11 },
                    { 10, false, new DateTime(2018, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 10 },
                    { 9, false, new DateTime(2019, 3, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 9 },
                    { 8, true, new DateTime(2016, 12, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 8 },
                    { 7, true, new DateTime(2016, 12, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 7 },
                    { 6, false, new DateTime(2016, 5, 12, 14, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 6 },
                    { 5, false, new DateTime(2016, 10, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 5 },
                    { 4, false, new DateTime(2016, 11, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 4 },
                    { 19, false, new DateTime(2017, 8, 24, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 2 },
                    { 20, false, new DateTime(2016, 3, 16, 9, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 3 },
                    { 21, false, new DateTime(2016, 2, 18, 14, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 4 },
                    { 22, true, new DateTime(2016, 8, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 5 },
                    { 157, true, new DateTime(2016, 4, 23, 15, 0, 0, 0, DateTimeKind.Unspecified), 10, false, "E", 4 },
                    { 156, true, new DateTime(2018, 6, 18, 14, 0, 0, 0, DateTimeKind.Unspecified), 10, true, "E", 3 },
                    { 155, false, new DateTime(2018, 11, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), 10, false, "E", 2 },
                    { 154, true, new DateTime(2018, 2, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), 10, true, "E", 1 },
                    { 34, false, new DateTime(2019, 8, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 17 },
                    { 33, false, new DateTime(2017, 3, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 16 },
                    { 32, true, new DateTime(2017, 2, 12, 18, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 15 },
                    { 3, false, new DateTime(2016, 5, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 3 },
                    { 31, true, new DateTime(2016, 9, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 14 },
                    { 29, true, new DateTime(2016, 6, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 12 },
                    { 28, false, new DateTime(2019, 3, 16, 11, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 11 },
                    { 27, true, new DateTime(2016, 4, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 10 },
                    { 26, true, new DateTime(2016, 9, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 9 },
                    { 25, true, new DateTime(2016, 1, 23, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 8 },
                    { 24, true, new DateTime(2018, 2, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 7 },
                    { 23, false, new DateTime(2018, 3, 24, 13, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 6 },
                    { 30, true, new DateTime(2019, 11, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 13 },
                    { 2, false, new DateTime(2019, 4, 27, 15, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 2 },
                    { 1, false, new DateTime(2016, 6, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 1 },
                    { 306, true, new DateTime(2019, 6, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), 18, true, "E", 17 },
                    { 268, true, new DateTime(2017, 11, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 16, true, "E", 13 },
                    { 267, false, new DateTime(2018, 4, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), 16, true, "E", 12 },
                    { 266, false, new DateTime(2019, 10, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), 16, true, "E", 11 },
                    { 265, false, new DateTime(2017, 12, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 16, false, "E", 10 },
                    { 264, false, new DateTime(2016, 9, 26, 15, 0, 0, 0, DateTimeKind.Unspecified), 16, false, "E", 9 },
                    { 263, false, new DateTime(2016, 7, 25, 11, 0, 0, 0, DateTimeKind.Unspecified), 16, false, "E", 8 },
                    { 262, true, new DateTime(2016, 1, 21, 18, 0, 0, 0, DateTimeKind.Unspecified), 16, true, "E", 7 },
                    { 269, false, new DateTime(2016, 6, 28, 15, 0, 0, 0, DateTimeKind.Unspecified), 16, false, "E", 14 },
                    { 261, true, new DateTime(2016, 10, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 16, false, "E", 6 },
                    { 259, false, new DateTime(2019, 10, 15, 11, 0, 0, 0, DateTimeKind.Unspecified), 16, false, "E", 4 },
                    { 258, true, new DateTime(2016, 6, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 16, false, "E", 3 },
                    { 257, true, new DateTime(2018, 1, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), 16, true, "E", 2 },
                    { 256, true, new DateTime(2017, 6, 5, 7, 0, 0, 0, DateTimeKind.Unspecified), 16, true, "E", 1 },
                    { 238, false, new DateTime(2016, 11, 19, 15, 0, 0, 0, DateTimeKind.Unspecified), 14, false, "E", 17 },
                    { 237, true, new DateTime(2019, 12, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), 14, true, "E", 16 },
                    { 236, false, new DateTime(2018, 4, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), 14, true, "E", 15 },
                    { 260, true, new DateTime(2019, 12, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), 16, false, "E", 5 },
                    { 158, true, new DateTime(2019, 5, 28, 17, 0, 0, 0, DateTimeKind.Unspecified), 10, true, "E", 5 },
                    { 270, true, new DateTime(2018, 6, 16, 11, 0, 0, 0, DateTimeKind.Unspecified), 16, true, "E", 15 },
                    { 272, false, new DateTime(2019, 12, 12, 7, 0, 0, 0, DateTimeKind.Unspecified), 16, true, "E", 17 },
                    { 305, true, new DateTime(2017, 5, 3, 9, 0, 0, 0, DateTimeKind.Unspecified), 18, true, "E", 16 },
                    { 304, true, new DateTime(2017, 2, 28, 13, 0, 0, 0, DateTimeKind.Unspecified), 18, false, "E", 15 },
                    { 303, false, new DateTime(2016, 7, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 18, false, "E", 14 },
                    { 302, true, new DateTime(2016, 4, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 18, true, "E", 13 },
                    { 301, true, new DateTime(2016, 8, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 18, true, "E", 12 },
                    { 300, true, new DateTime(2016, 6, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), 18, true, "E", 11 },
                    { 299, false, new DateTime(2018, 4, 17, 9, 0, 0, 0, DateTimeKind.Unspecified), 18, false, "E", 10 },
                    { 271, false, new DateTime(2016, 1, 25, 18, 0, 0, 0, DateTimeKind.Unspecified), 16, true, "E", 16 },
                    { 298, true, new DateTime(2017, 7, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), 18, true, "E", 9 },
                    { 296, false, new DateTime(2018, 11, 22, 17, 0, 0, 0, DateTimeKind.Unspecified), 18, true, "E", 7 },
                    { 295, true, new DateTime(2018, 2, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), 18, false, "E", 6 },
                    { 294, true, new DateTime(2017, 9, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), 18, true, "E", 5 },
                    { 293, true, new DateTime(2016, 11, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 18, false, "E", 4 },
                    { 292, true, new DateTime(2016, 12, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), 18, true, "E", 3 },
                    { 291, false, new DateTime(2019, 10, 16, 10, 0, 0, 0, DateTimeKind.Unspecified), 18, true, "E", 2 },
                    { 290, false, new DateTime(2017, 3, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 18, true, "E", 1 },
                    { 297, false, new DateTime(2019, 6, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 18, true, "E", 8 },
                    { 390, true, new DateTime(2018, 4, 11, 7, 0, 0, 0, DateTimeKind.Unspecified), 23, false, "E", 16 },
                    { 159, false, new DateTime(2016, 10, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 10, false, "E", 6 },
                    { 161, true, new DateTime(2016, 3, 12, 11, 0, 0, 0, DateTimeKind.Unspecified), 10, false, "E", 8 },
                    { 352, true, new DateTime(2018, 2, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), 21, false, "E", 12 },
                    { 351, true, new DateTime(2019, 1, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), 21, true, "E", 11 },
                    { 350, false, new DateTime(2019, 8, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 21, false, "E", 10 },
                    { 349, false, new DateTime(2017, 8, 22, 9, 0, 0, 0, DateTimeKind.Unspecified), 21, false, "E", 9 },
                    { 348, true, new DateTime(2018, 7, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 21, false, "E", 8 },
                    { 347, false, new DateTime(2018, 6, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 21, false, "E", 7 },
                    { 346, false, new DateTime(2016, 5, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), 21, true, "E", 6 },
                    { 345, true, new DateTime(2016, 5, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 21, false, "E", 5 },
                    { 344, true, new DateTime(2016, 1, 18, 9, 0, 0, 0, DateTimeKind.Unspecified), 21, true, "E", 4 },
                    { 343, true, new DateTime(2017, 8, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 21, true, "E", 3 },
                    { 342, false, new DateTime(2019, 9, 26, 13, 0, 0, 0, DateTimeKind.Unspecified), 21, false, "E", 2 },
                    { 341, false, new DateTime(2019, 12, 27, 7, 0, 0, 0, DateTimeKind.Unspecified), 21, false, "E", 1 },
                    { 51, false, new DateTime(2016, 1, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 17 },
                    { 50, false, new DateTime(2018, 9, 27, 14, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 16 },
                    { 49, true, new DateTime(2017, 10, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 15 },
                    { 353, false, new DateTime(2017, 6, 8, 9, 0, 0, 0, DateTimeKind.Unspecified), 21, false, "E", 13 },
                    { 354, true, new DateTime(2017, 4, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 21, false, "E", 14 },
                    { 355, false, new DateTime(2019, 10, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), 21, true, "E", 15 },
                    { 356, false, new DateTime(2017, 12, 17, 9, 0, 0, 0, DateTimeKind.Unspecified), 21, true, "E", 16 },
                    { 389, true, new DateTime(2019, 3, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 23, true, "E", 15 },
                    { 388, true, new DateTime(2016, 9, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), 23, true, "E", 14 },
                    { 387, true, new DateTime(2019, 4, 4, 18, 0, 0, 0, DateTimeKind.Unspecified), 23, false, "E", 13 },
                    { 386, true, new DateTime(2016, 9, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), 23, false, "E", 12 },
                    { 385, true, new DateTime(2018, 11, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 23, false, "E", 11 },
                    { 384, false, new DateTime(2016, 3, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), 23, false, "E", 10 },
                    { 383, true, new DateTime(2016, 10, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), 23, true, "E", 9 },
                    { 48, false, new DateTime(2017, 5, 2, 13, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 14 },
                    { 382, false, new DateTime(2017, 4, 18, 18, 0, 0, 0, DateTimeKind.Unspecified), 23, false, "E", 8 },
                    { 380, false, new DateTime(2017, 6, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 23, true, "E", 6 },
                    { 379, true, new DateTime(2018, 3, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), 23, true, "E", 5 },
                    { 378, true, new DateTime(2019, 5, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 23, false, "E", 4 },
                    { 377, true, new DateTime(2018, 5, 19, 15, 0, 0, 0, DateTimeKind.Unspecified), 23, true, "E", 3 },
                    { 376, true, new DateTime(2018, 12, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), 23, true, "E", 2 },
                    { 375, true, new DateTime(2017, 6, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), 23, false, "E", 1 },
                    { 357, false, new DateTime(2016, 5, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), 21, true, "E", 17 },
                    { 381, true, new DateTime(2018, 1, 12, 13, 0, 0, 0, DateTimeKind.Unspecified), 23, false, "E", 7 },
                    { 47, true, new DateTime(2019, 12, 21, 13, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 13 },
                    { 46, false, new DateTime(2018, 6, 18, 7, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 12 },
                    { 45, true, new DateTime(2017, 3, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 11 },
                    { 177, true, new DateTime(2019, 6, 27, 13, 0, 0, 0, DateTimeKind.Unspecified), 11, true, "E", 7 },
                    { 176, true, new DateTime(2018, 12, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 11, false, "E", 6 },
                    { 175, true, new DateTime(2018, 1, 16, 14, 0, 0, 0, DateTimeKind.Unspecified), 11, false, "E", 5 },
                    { 174, true, new DateTime(2016, 6, 18, 9, 0, 0, 0, DateTimeKind.Unspecified), 11, true, "E", 4 },
                    { 173, true, new DateTime(2017, 11, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), 11, false, "E", 3 },
                    { 172, true, new DateTime(2019, 9, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), 11, false, "E", 2 },
                    { 171, false, new DateTime(2019, 3, 12, 7, 0, 0, 0, DateTimeKind.Unspecified), 11, false, "E", 1 },
                    { 178, true, new DateTime(2019, 11, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 11, false, "E", 8 },
                    { 170, false, new DateTime(2018, 1, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), 10, false, "E", 17 },
                    { 168, false, new DateTime(2018, 9, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), 10, false, "E", 15 },
                    { 167, true, new DateTime(2017, 5, 19, 14, 0, 0, 0, DateTimeKind.Unspecified), 10, true, "E", 14 },
                    { 166, false, new DateTime(2018, 8, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), 10, true, "E", 13 },
                    { 165, false, new DateTime(2017, 7, 11, 13, 0, 0, 0, DateTimeKind.Unspecified), 10, false, "E", 12 },
                    { 164, true, new DateTime(2018, 8, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 10, true, "E", 11 },
                    { 163, true, new DateTime(2016, 11, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 10, true, "E", 10 },
                    { 162, true, new DateTime(2019, 11, 26, 11, 0, 0, 0, DateTimeKind.Unspecified), 10, false, "E", 9 },
                    { 169, true, new DateTime(2018, 4, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), 10, false, "E", 16 },
                    { 160, false, new DateTime(2016, 10, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), 10, false, "E", 7 },
                    { 179, false, new DateTime(2017, 1, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), 11, false, "E", 9 },
                    { 181, false, new DateTime(2019, 4, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), 11, true, "E", 11 },
                    { 44, false, new DateTime(2017, 7, 21, 14, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 10 },
                    { 43, false, new DateTime(2018, 8, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 9 },
                    { 42, false, new DateTime(2019, 10, 2, 17, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 8 },
                    { 41, true, new DateTime(2017, 7, 17, 13, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 7 },
                    { 40, true, new DateTime(2018, 4, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 6 },
                    { 39, true, new DateTime(2016, 7, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 5 },
                    { 38, false, new DateTime(2018, 2, 3, 7, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 4 },
                    { 180, false, new DateTime(2018, 10, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), 11, true, "E", 10 },
                    { 37, false, new DateTime(2019, 6, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 3 },
                    { 35, false, new DateTime(2018, 9, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 1 },
                    { 187, true, new DateTime(2017, 11, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 11, true, "E", 17 },
                    { 186, true, new DateTime(2018, 7, 28, 9, 0, 0, 0, DateTimeKind.Unspecified), 11, true, "E", 16 },
                    { 185, false, new DateTime(2016, 2, 18, 14, 0, 0, 0, DateTimeKind.Unspecified), 11, true, "E", 15 },
                    { 184, false, new DateTime(2017, 6, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), 11, false, "E", 14 },
                    { 183, true, new DateTime(2018, 7, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), 11, false, "E", 13 },
                    { 182, false, new DateTime(2019, 10, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), 11, true, "E", 12 },
                    { 36, true, new DateTime(2018, 11, 19, 15, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 2 },
                    { 234, false, new DateTime(2019, 11, 14, 7, 0, 0, 0, DateTimeKind.Unspecified), 14, false, "E", 13 },
                    { 391, false, new DateTime(2018, 8, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 23, false, "E", 17 },
                    { 232, true, new DateTime(2019, 7, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 14, true, "E", 11 },
                    { 310, false, new DateTime(2019, 7, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 19, true, "E", 4 },
                    { 309, true, new DateTime(2018, 5, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), 19, false, "E", 3 },
                    { 308, false, new DateTime(2019, 5, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), 19, true, "E", 2 },
                    { 307, true, new DateTime(2016, 3, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 19, false, "E", 1 },
                    { 153, true, new DateTime(2017, 7, 16, 7, 0, 0, 0, DateTimeKind.Unspecified), 9, false, "E", 17 },
                    { 152, false, new DateTime(2018, 4, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), 9, true, "E", 16 },
                    { 151, false, new DateTime(2016, 11, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), 9, true, "E", 15 },
                    { 150, true, new DateTime(2019, 3, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 9, true, "E", 14 },
                    { 149, false, new DateTime(2019, 10, 9, 13, 0, 0, 0, DateTimeKind.Unspecified), 9, true, "E", 13 },
                    { 148, false, new DateTime(2017, 1, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), 9, false, "E", 12 },
                    { 147, true, new DateTime(2016, 10, 17, 15, 0, 0, 0, DateTimeKind.Unspecified), 9, true, "E", 11 },
                    { 146, false, new DateTime(2017, 8, 26, 15, 0, 0, 0, DateTimeKind.Unspecified), 9, true, "E", 10 },
                    { 145, true, new DateTime(2017, 9, 9, 7, 0, 0, 0, DateTimeKind.Unspecified), 9, false, "E", 9 },
                    { 144, false, new DateTime(2017, 8, 8, 9, 0, 0, 0, DateTimeKind.Unspecified), 9, false, "E", 8 },
                    { 143, false, new DateTime(2019, 1, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), 9, false, "E", 7 },
                    { 311, true, new DateTime(2018, 1, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), 19, true, "E", 5 },
                    { 312, false, new DateTime(2017, 4, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), 19, true, "E", 6 },
                    { 313, true, new DateTime(2019, 3, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 19, true, "E", 7 },
                    { 314, true, new DateTime(2019, 12, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 19, false, "E", 8 },
                    { 398, true, new DateTime(2019, 6, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 24, false, "E", 7 },
                    { 397, false, new DateTime(2016, 11, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 24, false, "E", 6 },
                    { 396, true, new DateTime(2016, 10, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 24, true, "E", 5 },
                    { 395, true, new DateTime(2017, 12, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 24, true, "E", 4 },
                    { 394, false, new DateTime(2016, 11, 3, 7, 0, 0, 0, DateTimeKind.Unspecified), 24, false, "E", 3 },
                    { 393, false, new DateTime(2017, 2, 14, 7, 0, 0, 0, DateTimeKind.Unspecified), 24, false, "E", 2 },
                    { 392, true, new DateTime(2019, 8, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), 24, false, "E", 1 },
                    { 142, true, new DateTime(2019, 5, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 9, false, "E", 6 },
                    { 323, true, new DateTime(2017, 8, 2, 15, 0, 0, 0, DateTimeKind.Unspecified), 19, false, "E", 17 },
                    { 321, false, new DateTime(2017, 4, 6, 13, 0, 0, 0, DateTimeKind.Unspecified), 19, true, "E", 15 },
                    { 320, true, new DateTime(2016, 9, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 19, true, "E", 14 },
                    { 319, false, new DateTime(2018, 8, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), 19, true, "E", 13 },
                    { 318, true, new DateTime(2017, 1, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), 19, true, "E", 12 },
                    { 317, true, new DateTime(2017, 5, 27, 9, 0, 0, 0, DateTimeKind.Unspecified), 19, false, "E", 11 },
                    { 316, false, new DateTime(2017, 3, 13, 7, 0, 0, 0, DateTimeKind.Unspecified), 19, false, "E", 10 },
                    { 315, true, new DateTime(2017, 8, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), 19, false, "E", 9 },
                    { 322, false, new DateTime(2017, 10, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 19, true, "E", 16 },
                    { 141, false, new DateTime(2017, 1, 24, 13, 0, 0, 0, DateTimeKind.Unspecified), 9, false, "E", 5 },
                    { 140, false, new DateTime(2019, 7, 19, 10, 0, 0, 0, DateTimeKind.Unspecified), 9, true, "E", 4 },
                    { 139, true, new DateTime(2018, 12, 21, 7, 0, 0, 0, DateTimeKind.Unspecified), 9, false, "E", 3 },
                    { 441, true, new DateTime(2019, 7, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), 26, true, "E", 16 },
                    { 440, true, new DateTime(2016, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), 26, false, "E", 15 },
                    { 439, true, new DateTime(2016, 11, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), 26, true, "E", 14 },
                    { 438, false, new DateTime(2018, 4, 12, 14, 0, 0, 0, DateTimeKind.Unspecified), 26, true, "E", 13 },
                    { 437, true, new DateTime(2017, 1, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 26, false, "E", 12 },
                    { 436, false, new DateTime(2018, 6, 4, 7, 0, 0, 0, DateTimeKind.Unspecified), 26, true, "E", 11 },
                    { 435, false, new DateTime(2019, 3, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 26, false, "E", 10 },
                    { 442, true, new DateTime(2019, 10, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), 26, false, "E", 17 },
                    { 434, true, new DateTime(2017, 8, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), 26, false, "E", 9 },
                    { 432, true, new DateTime(2017, 5, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 26, true, "E", 7 },
                    { 431, true, new DateTime(2019, 2, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), 26, false, "E", 6 },
                    { 430, false, new DateTime(2018, 10, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), 26, true, "E", 5 },
                    { 429, false, new DateTime(2018, 11, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), 26, false, "E", 4 },
                    { 428, false, new DateTime(2018, 9, 26, 11, 0, 0, 0, DateTimeKind.Unspecified), 26, true, "E", 3 },
                    { 427, true, new DateTime(2018, 12, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), 26, true, "E", 2 },
                    { 426, false, new DateTime(2018, 6, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), 26, true, "E", 1 },
                    { 433, false, new DateTime(2019, 7, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), 26, false, "E", 8 },
                    { 233, false, new DateTime(2019, 3, 3, 7, 0, 0, 0, DateTimeKind.Unspecified), 14, true, "E", 12 },
                    { 273, true, new DateTime(2017, 8, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 17, true, "E", 1 },
                    { 275, true, new DateTime(2019, 2, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), 17, true, "E", 3 },
                    { 138, true, new DateTime(2017, 3, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), 9, false, "E", 2 },
                    { 137, false, new DateTime(2019, 2, 26, 11, 0, 0, 0, DateTimeKind.Unspecified), 9, false, "E", 1 },
                    { 289, true, new DateTime(2019, 4, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), 17, false, "E", 17 },
                    { 288, true, new DateTime(2018, 7, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), 17, false, "E", 16 },
                    { 287, false, new DateTime(2019, 12, 14, 9, 0, 0, 0, DateTimeKind.Unspecified), 17, true, "E", 15 },
                    { 286, false, new DateTime(2018, 12, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), 17, true, "E", 14 },
                    { 285, false, new DateTime(2018, 2, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), 17, false, "E", 13 },
                    { 274, false, new DateTime(2019, 4, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), 17, false, "E", 2 },
                    { 284, true, new DateTime(2016, 7, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), 17, true, "E", 12 },
                    { 282, true, new DateTime(2018, 1, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), 17, false, "E", 10 },
                    { 281, false, new DateTime(2017, 7, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 17, false, "E", 9 },
                    { 280, true, new DateTime(2019, 5, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 17, false, "E", 8 },
                    { 279, false, new DateTime(2019, 7, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), 17, true, "E", 7 },
                    { 278, false, new DateTime(2018, 3, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), 17, false, "E", 6 },
                    { 277, false, new DateTime(2016, 4, 21, 14, 0, 0, 0, DateTimeKind.Unspecified), 17, true, "E", 5 },
                    { 276, true, new DateTime(2017, 4, 28, 10, 0, 0, 0, DateTimeKind.Unspecified), 17, true, "E", 4 },
                    { 283, true, new DateTime(2018, 3, 3, 13, 0, 0, 0, DateTimeKind.Unspecified), 17, false, "E", 11 },
                    { 400, true, new DateTime(2017, 7, 23, 13, 0, 0, 0, DateTimeKind.Unspecified), 24, false, "E", 9 },
                    { 399, true, new DateTime(2019, 7, 26, 11, 0, 0, 0, DateTimeKind.Unspecified), 24, true, "E", 8 },
                    { 402, false, new DateTime(2019, 7, 22, 11, 0, 0, 0, DateTimeKind.Unspecified), 24, true, "E", 11 },
                    { 194, true, new DateTime(2018, 10, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), 12, false, "E", 7 },
                    { 193, true, new DateTime(2017, 3, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), 12, true, "E", 6 },
                    { 192, false, new DateTime(2016, 5, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 12, false, "E", 5 },
                    { 191, true, new DateTime(2019, 2, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), 12, false, "E", 4 },
                    { 190, true, new DateTime(2016, 5, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), 12, true, "E", 3 },
                    { 189, true, new DateTime(2016, 2, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), 12, true, "E", 2 },
                    { 188, false, new DateTime(2019, 10, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), 12, true, "E", 1 },
                    { 119, true, new DateTime(2018, 4, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), 7, true, "E", 17 },
                    { 118, false, new DateTime(2016, 9, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), 7, false, "E", 16 },
                    { 117, true, new DateTime(2016, 4, 17, 7, 0, 0, 0, DateTimeKind.Unspecified), 7, false, "E", 15 },
                    { 116, false, new DateTime(2017, 9, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 7, true, "E", 14 },
                    { 115, false, new DateTime(2017, 8, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), 7, false, "E", 13 },
                    { 114, false, new DateTime(2016, 3, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), 7, true, "E", 12 },
                    { 113, false, new DateTime(2019, 7, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), 7, true, "E", 11 },
                    { 112, true, new DateTime(2019, 11, 9, 7, 0, 0, 0, DateTimeKind.Unspecified), 7, true, "E", 10 },
                    { 195, false, new DateTime(2017, 3, 17, 18, 0, 0, 0, DateTimeKind.Unspecified), 12, true, "E", 8 },
                    { 196, false, new DateTime(2017, 7, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), 12, false, "E", 9 },
                    { 197, false, new DateTime(2018, 4, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 12, false, "E", 10 },
                    { 198, false, new DateTime(2019, 6, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 12, false, "E", 11 },
                    { 231, true, new DateTime(2016, 12, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 14, true, "E", 10 },
                    { 230, false, new DateTime(2017, 4, 25, 11, 0, 0, 0, DateTimeKind.Unspecified), 14, false, "E", 9 },
                    { 229, true, new DateTime(2019, 10, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), 14, false, "E", 8 },
                    { 228, true, new DateTime(2018, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), 14, true, "E", 7 },
                    { 227, false, new DateTime(2018, 11, 26, 13, 0, 0, 0, DateTimeKind.Unspecified), 14, true, "E", 6 },
                    { 226, true, new DateTime(2017, 6, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), 14, true, "E", 5 },
                    { 225, false, new DateTime(2016, 3, 13, 10, 0, 0, 0, DateTimeKind.Unspecified), 14, false, "E", 4 },
                    { 111, true, new DateTime(2017, 6, 22, 14, 0, 0, 0, DateTimeKind.Unspecified), 7, false, "E", 9 },
                    { 224, false, new DateTime(2018, 10, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 14, true, "E", 3 },
                    { 222, true, new DateTime(2017, 5, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), 14, false, "E", 1 },
                    { 204, true, new DateTime(2018, 9, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 12, true, "E", 17 },
                    { 203, false, new DateTime(2018, 6, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), 12, false, "E", 16 },
                    { 202, false, new DateTime(2018, 1, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), 12, false, "E", 15 },
                    { 201, false, new DateTime(2018, 2, 6, 11, 0, 0, 0, DateTimeKind.Unspecified), 12, true, "E", 14 },
                    { 200, false, new DateTime(2019, 2, 21, 7, 0, 0, 0, DateTimeKind.Unspecified), 12, false, "E", 13 },
                    { 199, true, new DateTime(2019, 11, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), 12, true, "E", 12 },
                    { 223, false, new DateTime(2019, 6, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 14, false, "E", 2 },
                    { 401, true, new DateTime(2016, 7, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 24, true, "E", 10 },
                    { 110, false, new DateTime(2016, 6, 7, 9, 0, 0, 0, DateTimeKind.Unspecified), 7, true, "E", 8 },
                    { 108, true, new DateTime(2019, 6, 23, 9, 0, 0, 0, DateTimeKind.Unspecified), 7, true, "E", 6 },
                    { 487, true, new DateTime(2017, 10, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), 29, true, "E", 11 },
                    { 486, true, new DateTime(2016, 10, 6, 9, 0, 0, 0, DateTimeKind.Unspecified), 29, false, "E", 10 },
                    { 485, true, new DateTime(2016, 10, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 29, true, "E", 9 },
                    { 484, true, new DateTime(2016, 10, 23, 13, 0, 0, 0, DateTimeKind.Unspecified), 29, false, "E", 8 },
                    { 483, true, new DateTime(2019, 12, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), 29, true, "E", 7 },
                    { 482, true, new DateTime(2016, 11, 24, 10, 0, 0, 0, DateTimeKind.Unspecified), 29, false, "E", 6 },
                    { 481, true, new DateTime(2016, 12, 23, 10, 0, 0, 0, DateTimeKind.Unspecified), 29, false, "E", 5 },
                    { 480, false, new DateTime(2017, 8, 17, 15, 0, 0, 0, DateTimeKind.Unspecified), 29, false, "E", 4 },
                    { 479, false, new DateTime(2019, 3, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), 29, false, "E", 3 },
                    { 478, true, new DateTime(2016, 10, 18, 13, 0, 0, 0, DateTimeKind.Unspecified), 29, false, "E", 2 },
                    { 477, true, new DateTime(2018, 2, 19, 14, 0, 0, 0, DateTimeKind.Unspecified), 29, true, "E", 1 },
                    { 408, true, new DateTime(2019, 7, 21, 11, 0, 0, 0, DateTimeKind.Unspecified), 24, false, "E", 17 },
                    { 407, true, new DateTime(2017, 8, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), 24, false, "E", 16 },
                    { 406, false, new DateTime(2017, 9, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 24, true, "E", 15 },
                    { 405, true, new DateTime(2018, 10, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 24, false, "E", 14 },
                    { 404, false, new DateTime(2019, 8, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 24, false, "E", 13 },
                    { 403, true, new DateTime(2016, 12, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), 24, true, "E", 12 },
                    { 488, true, new DateTime(2018, 7, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), 29, true, "E", 12 },
                    { 109, false, new DateTime(2018, 9, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), 7, true, "E", 7 },
                    { 489, true, new DateTime(2019, 8, 22, 11, 0, 0, 0, DateTimeKind.Unspecified), 29, false, "E", 13 },
                    { 491, false, new DateTime(2016, 11, 27, 15, 0, 0, 0, DateTimeKind.Unspecified), 29, true, "E", 15 },
                    { 492, false, new DateTime(2018, 8, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), 29, true, "E", 16 }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "EnrollmentId", "BookBought", "Confirmed", "InstanceId", "Paid", "Status", "UserId" },
                values: new object[,]
                {
                    { 493, false, new DateTime(2016, 7, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), 29, false, "E", 17 },
                    { 107, false, new DateTime(2019, 11, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), 7, true, "E", 5 },
                    { 106, true, new DateTime(2016, 5, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), 7, true, "E", 4 },
                    { 105, false, new DateTime(2017, 3, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 7, true, "E", 3 },
                    { 104, true, new DateTime(2017, 8, 25, 7, 0, 0, 0, DateTimeKind.Unspecified), 7, false, "E", 2 },
                    { 490, true, new DateTime(2018, 8, 9, 9, 0, 0, 0, DateTimeKind.Unspecified), 29, false, "E", 14 },
                    { 103, false, new DateTime(2017, 8, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), 7, true, "E", 1 }
                });

            migrationBuilder.InsertData(
                table: "Instance",
                columns: new[] { "InstanceId", "BookAvailable", "BookPrice", "CourseId", "Graded", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[,]
                {
                    { 13, true, 28.0, 9, false, 2, 3, 66.0, 16, new DateTimeOffset(new DateTime(2018, 5, 23, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 15, true, 31.0, 9, false, 6, 2, 89.0, 28, new DateTimeOffset(new DateTime(2017, 2, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 27, true, 54.0, 10, false, 1, 1, 122.0, 18, new DateTimeOffset(new DateTime(2019, 11, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 22, true, 15.0, 10, false, 6, 2, 67.0, 23, new DateTimeOffset(new DateTime(2016, 2, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 20, true, 28.0, 10, false, 5, 1, 51.0, 16, new DateTimeOffset(new DateTime(2019, 5, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 8, true, 20.0, 10, false, 1, 2, 77.0, 15, new DateTimeOffset(new DateTime(2017, 12, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 6, true, 20.0, 10, false, 4, 3, 131.0, 29, new DateTimeOffset(new DateTime(2016, 8, 15, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 5, true, 42.0, 10, false, 1, 2, 78.0, 11, new DateTimeOffset(new DateTime(2018, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 4, true, 23.0, 10, false, 4, 2, 69.0, 25, new DateTimeOffset(new DateTime(2017, 8, 5, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 28, true, 51.0, 10, false, 1, 2, 101.0, 24, new DateTimeOffset(new DateTime(2019, 12, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 25, true, 51.0, 8, false, 1, 1, 90.0, 28, new DateTimeOffset(new DateTime(2016, 3, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "EnrollmentId", "BookBought", "Confirmed", "InstanceId", "Paid", "Status", "UserId" },
                values: new object[,]
                {
                    { 409, false, new DateTime(2019, 4, 9, 13, 0, 0, 0, DateTimeKind.Unspecified), 25, true, "E", 1 },
                    { 443, true, new DateTime(2017, 4, 16, 9, 0, 0, 0, DateTimeKind.Unspecified), 27, true, "E", 1 },
                    { 444, false, new DateTime(2016, 5, 17, 7, 0, 0, 0, DateTimeKind.Unspecified), 27, false, "E", 2 },
                    { 445, true, new DateTime(2018, 5, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), 27, true, "E", 3 },
                    { 446, true, new DateTime(2018, 5, 13, 17, 0, 0, 0, DateTimeKind.Unspecified), 27, false, "E", 4 },
                    { 447, false, new DateTime(2016, 4, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), 27, true, "E", 5 },
                    { 448, true, new DateTime(2017, 10, 9, 13, 0, 0, 0, DateTimeKind.Unspecified), 27, true, "E", 6 },
                    { 449, true, new DateTime(2018, 12, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), 27, true, "E", 7 },
                    { 450, true, new DateTime(2016, 11, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), 27, false, "E", 8 },
                    { 451, true, new DateTime(2017, 2, 26, 13, 0, 0, 0, DateTimeKind.Unspecified), 27, false, "E", 9 },
                    { 452, true, new DateTime(2016, 6, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), 27, false, "E", 10 },
                    { 453, false, new DateTime(2018, 8, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 27, true, "E", 11 },
                    { 454, true, new DateTime(2017, 2, 18, 18, 0, 0, 0, DateTimeKind.Unspecified), 27, true, "E", 12 },
                    { 455, false, new DateTime(2016, 1, 17, 9, 0, 0, 0, DateTimeKind.Unspecified), 27, true, "E", 13 },
                    { 456, true, new DateTime(2019, 9, 15, 7, 0, 0, 0, DateTimeKind.Unspecified), 27, false, "E", 14 },
                    { 457, true, new DateTime(2019, 10, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 27, true, "E", 15 },
                    { 458, false, new DateTime(2018, 9, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 27, false, "E", 16 },
                    { 459, true, new DateTime(2017, 6, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), 27, false, "E", 17 },
                    { 460, true, new DateTime(2019, 6, 26, 7, 0, 0, 0, DateTimeKind.Unspecified), 28, true, "E", 1 },
                    { 461, false, new DateTime(2018, 11, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), 28, true, "E", 2 },
                    { 374, false, new DateTime(2017, 6, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), 22, true, "E", 17 },
                    { 373, false, new DateTime(2018, 8, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), 22, false, "E", 16 },
                    { 372, true, new DateTime(2017, 1, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), 22, true, "E", 15 },
                    { 371, false, new DateTime(2019, 5, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), 22, true, "E", 14 },
                    { 334, false, new DateTime(2018, 1, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), 20, true, "E", 11 },
                    { 335, true, new DateTime(2018, 9, 24, 7, 0, 0, 0, DateTimeKind.Unspecified), 20, false, "E", 12 },
                    { 336, false, new DateTime(2016, 10, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 20, true, "E", 13 },
                    { 337, true, new DateTime(2019, 5, 17, 7, 0, 0, 0, DateTimeKind.Unspecified), 20, true, "E", 14 },
                    { 338, false, new DateTime(2017, 5, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), 20, true, "E", 15 },
                    { 339, false, new DateTime(2016, 4, 20, 15, 0, 0, 0, DateTimeKind.Unspecified), 20, true, "E", 16 },
                    { 340, false, new DateTime(2019, 4, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), 20, false, "E", 17 },
                    { 358, false, new DateTime(2016, 3, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), 22, false, "E", 1 },
                    { 359, true, new DateTime(2019, 8, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), 22, true, "E", 2 },
                    { 462, false, new DateTime(2017, 9, 21, 9, 0, 0, 0, DateTimeKind.Unspecified), 28, false, "E", 3 },
                    { 360, false, new DateTime(2019, 6, 20, 15, 0, 0, 0, DateTimeKind.Unspecified), 22, true, "E", 3 },
                    { 362, true, new DateTime(2017, 4, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), 22, false, "E", 5 },
                    { 363, false, new DateTime(2017, 12, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), 22, false, "E", 6 },
                    { 364, false, new DateTime(2017, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 22, false, "E", 7 },
                    { 365, false, new DateTime(2017, 10, 18, 7, 0, 0, 0, DateTimeKind.Unspecified), 22, true, "E", 8 },
                    { 366, false, new DateTime(2019, 5, 23, 10, 0, 0, 0, DateTimeKind.Unspecified), 22, true, "E", 9 },
                    { 367, false, new DateTime(2018, 2, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 22, false, "E", 10 },
                    { 368, false, new DateTime(2017, 4, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), 22, true, "E", 11 },
                    { 369, false, new DateTime(2017, 2, 6, 13, 0, 0, 0, DateTimeKind.Unspecified), 22, false, "E", 12 },
                    { 370, false, new DateTime(2018, 7, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), 22, false, "E", 13 },
                    { 361, true, new DateTime(2019, 9, 18, 17, 0, 0, 0, DateTimeKind.Unspecified), 22, true, "E", 4 },
                    { 333, false, new DateTime(2019, 9, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), 20, true, "E", 10 },
                    { 463, true, new DateTime(2019, 3, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), 28, true, "E", 4 },
                    { 465, true, new DateTime(2017, 12, 22, 17, 0, 0, 0, DateTimeKind.Unspecified), 28, false, "E", 6 },
                    { 218, true, new DateTime(2019, 9, 2, 7, 0, 0, 0, DateTimeKind.Unspecified), 13, false, "E", 14 },
                    { 219, false, new DateTime(2019, 10, 19, 15, 0, 0, 0, DateTimeKind.Unspecified), 13, false, "E", 15 },
                    { 220, true, new DateTime(2018, 9, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), 13, true, "E", 16 },
                    { 221, false, new DateTime(2017, 1, 21, 7, 0, 0, 0, DateTimeKind.Unspecified), 13, true, "E", 17 },
                    { 239, false, new DateTime(2017, 3, 26, 13, 0, 0, 0, DateTimeKind.Unspecified), 15, true, "E", 1 },
                    { 240, false, new DateTime(2016, 12, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), 15, true, "E", 2 },
                    { 241, false, new DateTime(2018, 11, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), 15, true, "E", 3 },
                    { 242, false, new DateTime(2018, 7, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), 15, true, "E", 4 },
                    { 243, false, new DateTime(2016, 8, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), 15, false, "E", 5 },
                    { 244, true, new DateTime(2017, 10, 21, 14, 0, 0, 0, DateTimeKind.Unspecified), 15, false, "E", 6 },
                    { 245, true, new DateTime(2019, 1, 24, 7, 0, 0, 0, DateTimeKind.Unspecified), 15, true, "E", 7 },
                    { 246, false, new DateTime(2016, 3, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), 15, true, "E", 8 },
                    { 247, true, new DateTime(2019, 8, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 15, true, "E", 9 },
                    { 248, false, new DateTime(2016, 12, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), 15, true, "E", 10 },
                    { 249, true, new DateTime(2017, 10, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 15, true, "E", 11 },
                    { 250, false, new DateTime(2019, 11, 5, 11, 0, 0, 0, DateTimeKind.Unspecified), 15, true, "E", 12 },
                    { 251, true, new DateTime(2016, 6, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 15, false, "E", 13 },
                    { 252, false, new DateTime(2019, 5, 21, 18, 0, 0, 0, DateTimeKind.Unspecified), 15, true, "E", 14 },
                    { 253, false, new DateTime(2016, 6, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), 15, false, "E", 15 },
                    { 217, false, new DateTime(2016, 9, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), 13, true, "E", 13 },
                    { 216, false, new DateTime(2019, 4, 26, 11, 0, 0, 0, DateTimeKind.Unspecified), 13, true, "E", 12 },
                    { 215, true, new DateTime(2019, 8, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), 13, true, "E", 11 },
                    { 214, false, new DateTime(2019, 2, 6, 12, 0, 0, 0, DateTimeKind.Unspecified), 13, false, "E", 10 },
                    { 466, false, new DateTime(2018, 11, 13, 10, 0, 0, 0, DateTimeKind.Unspecified), 28, false, "E", 7 },
                    { 467, true, new DateTime(2017, 11, 14, 11, 0, 0, 0, DateTimeKind.Unspecified), 28, true, "E", 8 },
                    { 468, false, new DateTime(2017, 4, 18, 9, 0, 0, 0, DateTimeKind.Unspecified), 28, false, "E", 9 },
                    { 469, true, new DateTime(2019, 6, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), 28, true, "E", 10 },
                    { 470, true, new DateTime(2017, 2, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), 28, true, "E", 11 },
                    { 471, false, new DateTime(2018, 7, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), 28, false, "E", 12 },
                    { 472, true, new DateTime(2018, 8, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 28, true, "E", 13 },
                    { 473, true, new DateTime(2016, 8, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), 28, true, "E", 14 },
                    { 474, true, new DateTime(2018, 1, 28, 18, 0, 0, 0, DateTimeKind.Unspecified), 28, false, "E", 15 },
                    { 464, false, new DateTime(2016, 6, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 28, true, "E", 5 },
                    { 475, true, new DateTime(2017, 3, 25, 13, 0, 0, 0, DateTimeKind.Unspecified), 28, true, "E", 16 },
                    { 205, false, new DateTime(2018, 7, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), 13, false, "E", 1 },
                    { 206, true, new DateTime(2017, 9, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), 13, false, "E", 2 },
                    { 207, true, new DateTime(2016, 8, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), 13, true, "E", 3 },
                    { 208, false, new DateTime(2018, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 13, true, "E", 4 },
                    { 209, false, new DateTime(2017, 11, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 13, true, "E", 5 },
                    { 210, false, new DateTime(2018, 10, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), 13, false, "E", 6 },
                    { 211, true, new DateTime(2016, 9, 14, 7, 0, 0, 0, DateTimeKind.Unspecified), 13, true, "E", 7 },
                    { 212, true, new DateTime(2019, 12, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), 13, true, "E", 8 },
                    { 213, true, new DateTime(2019, 1, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), 13, false, "E", 9 },
                    { 476, true, new DateTime(2017, 11, 14, 9, 0, 0, 0, DateTimeKind.Unspecified), 28, false, "E", 17 },
                    { 254, false, new DateTime(2019, 6, 16, 7, 0, 0, 0, DateTimeKind.Unspecified), 15, true, "E", 16 },
                    { 332, false, new DateTime(2019, 5, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), 20, true, "E", 9 },
                    { 330, false, new DateTime(2018, 12, 17, 15, 0, 0, 0, DateTimeKind.Unspecified), 20, false, "E", 7 },
                    { 60, true, new DateTime(2019, 10, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), 4, false, "E", 9 },
                    { 61, false, new DateTime(2018, 12, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 4, true, "E", 10 },
                    { 62, false, new DateTime(2018, 10, 12, 18, 0, 0, 0, DateTimeKind.Unspecified), 4, false, "E", 11 },
                    { 63, true, new DateTime(2016, 11, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 4, false, "E", 12 },
                    { 64, false, new DateTime(2017, 7, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 4, true, "E", 13 },
                    { 65, false, new DateTime(2018, 11, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), 4, true, "E", 14 },
                    { 66, true, new DateTime(2018, 3, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), 4, false, "E", 15 },
                    { 67, false, new DateTime(2018, 4, 26, 14, 0, 0, 0, DateTimeKind.Unspecified), 4, false, "E", 16 },
                    { 68, true, new DateTime(2016, 2, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), 4, false, "E", 17 },
                    { 69, true, new DateTime(2019, 2, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), 5, true, "E", 1 },
                    { 70, false, new DateTime(2019, 12, 21, 11, 0, 0, 0, DateTimeKind.Unspecified), 5, true, "E", 2 },
                    { 71, false, new DateTime(2018, 2, 4, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, true, "E", 3 },
                    { 72, false, new DateTime(2019, 11, 16, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, true, "E", 4 },
                    { 73, false, new DateTime(2016, 8, 20, 15, 0, 0, 0, DateTimeKind.Unspecified), 5, false, "E", 5 },
                    { 74, true, new DateTime(2018, 3, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 5, false, "E", 6 },
                    { 75, true, new DateTime(2019, 11, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), 5, false, "E", 7 },
                    { 76, false, new DateTime(2018, 2, 5, 11, 0, 0, 0, DateTimeKind.Unspecified), 5, false, "E", 8 },
                    { 77, true, new DateTime(2016, 2, 22, 9, 0, 0, 0, DateTimeKind.Unspecified), 5, true, "E", 9 },
                    { 78, true, new DateTime(2017, 6, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), 5, true, "E", 10 },
                    { 59, false, new DateTime(2016, 12, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), 4, false, "E", 8 },
                    { 58, false, new DateTime(2016, 5, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), 4, false, "E", 7 },
                    { 57, false, new DateTime(2018, 3, 5, 7, 0, 0, 0, DateTimeKind.Unspecified), 4, false, "E", 6 },
                    { 56, true, new DateTime(2018, 5, 24, 13, 0, 0, 0, DateTimeKind.Unspecified), 4, false, "E", 5 },
                    { 410, true, new DateTime(2018, 10, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), 25, false, "E", 2 },
                    { 411, false, new DateTime(2018, 10, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), 25, true, "E", 3 },
                    { 412, false, new DateTime(2017, 12, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), 25, false, "E", 4 },
                    { 413, true, new DateTime(2016, 9, 21, 14, 0, 0, 0, DateTimeKind.Unspecified), 25, true, "E", 5 },
                    { 414, true, new DateTime(2018, 5, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), 25, false, "E", 6 },
                    { 415, false, new DateTime(2018, 10, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 25, false, "E", 7 },
                    { 416, false, new DateTime(2017, 11, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), 25, false, "E", 8 },
                    { 417, false, new DateTime(2017, 11, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), 25, false, "E", 9 },
                    { 418, false, new DateTime(2019, 1, 19, 15, 0, 0, 0, DateTimeKind.Unspecified), 25, false, "E", 10 },
                    { 79, true, new DateTime(2019, 3, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), 5, false, "E", 11 },
                    { 419, false, new DateTime(2017, 2, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), 25, true, "E", 11 },
                    { 421, false, new DateTime(2016, 3, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), 25, false, "E", 13 },
                    { 422, true, new DateTime(2017, 9, 8, 13, 0, 0, 0, DateTimeKind.Unspecified), 25, true, "E", 14 },
                    { 423, false, new DateTime(2018, 12, 9, 9, 0, 0, 0, DateTimeKind.Unspecified), 25, true, "E", 15 },
                    { 424, false, new DateTime(2017, 10, 14, 9, 0, 0, 0, DateTimeKind.Unspecified), 25, false, "E", 16 },
                    { 425, true, new DateTime(2016, 5, 26, 9, 0, 0, 0, DateTimeKind.Unspecified), 25, false, "E", 17 },
                    { 52, false, new DateTime(2017, 6, 24, 7, 0, 0, 0, DateTimeKind.Unspecified), 4, false, "E", 1 },
                    { 53, true, new DateTime(2017, 9, 7, 13, 0, 0, 0, DateTimeKind.Unspecified), 4, false, "E", 2 },
                    { 54, false, new DateTime(2019, 10, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), 4, false, "E", 3 },
                    { 55, false, new DateTime(2016, 3, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), 4, false, "E", 4 },
                    { 420, true, new DateTime(2016, 10, 17, 18, 0, 0, 0, DateTimeKind.Unspecified), 25, false, "E", 12 },
                    { 331, false, new DateTime(2017, 8, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 20, true, "E", 8 },
                    { 80, true, new DateTime(2017, 12, 10, 14, 0, 0, 0, DateTimeKind.Unspecified), 5, true, "E", 12 },
                    { 82, true, new DateTime(2019, 9, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), 5, false, "E", 14 },
                    { 124, true, new DateTime(2019, 10, 26, 11, 0, 0, 0, DateTimeKind.Unspecified), 8, false, "E", 5 },
                    { 125, true, new DateTime(2018, 12, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), 8, false, "E", 6 },
                    { 126, false, new DateTime(2019, 7, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), 8, false, "E", 7 },
                    { 127, false, new DateTime(2019, 10, 26, 12, 0, 0, 0, DateTimeKind.Unspecified), 8, true, "E", 8 },
                    { 128, false, new DateTime(2019, 11, 17, 13, 0, 0, 0, DateTimeKind.Unspecified), 8, true, "E", 9 },
                    { 129, true, new DateTime(2018, 11, 21, 7, 0, 0, 0, DateTimeKind.Unspecified), 8, false, "E", 10 },
                    { 130, true, new DateTime(2017, 4, 26, 13, 0, 0, 0, DateTimeKind.Unspecified), 8, false, "E", 11 },
                    { 131, true, new DateTime(2016, 11, 21, 15, 0, 0, 0, DateTimeKind.Unspecified), 8, true, "E", 12 },
                    { 132, true, new DateTime(2018, 12, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), 8, false, "E", 13 },
                    { 133, true, new DateTime(2017, 5, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), 8, true, "E", 14 },
                    { 134, true, new DateTime(2017, 12, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), 8, true, "E", 15 },
                    { 135, false, new DateTime(2017, 10, 20, 14, 0, 0, 0, DateTimeKind.Unspecified), 8, false, "E", 16 },
                    { 136, false, new DateTime(2018, 4, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 8, false, "E", 17 },
                    { 324, false, new DateTime(2019, 9, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), 20, true, "E", 1 },
                    { 325, true, new DateTime(2017, 10, 8, 14, 0, 0, 0, DateTimeKind.Unspecified), 20, false, "E", 2 },
                    { 326, true, new DateTime(2018, 2, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 20, true, "E", 3 },
                    { 327, true, new DateTime(2017, 11, 20, 7, 0, 0, 0, DateTimeKind.Unspecified), 20, true, "E", 4 },
                    { 328, false, new DateTime(2016, 9, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), 20, true, "E", 5 },
                    { 329, false, new DateTime(2018, 6, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 20, false, "E", 6 },
                    { 123, true, new DateTime(2017, 1, 27, 13, 0, 0, 0, DateTimeKind.Unspecified), 8, true, "E", 4 },
                    { 122, true, new DateTime(2018, 1, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 8, true, "E", 3 },
                    { 121, false, new DateTime(2018, 8, 16, 11, 0, 0, 0, DateTimeKind.Unspecified), 8, false, "E", 2 },
                    { 120, false, new DateTime(2017, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), 8, false, "E", 1 },
                    { 83, true, new DateTime(2017, 4, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), 5, true, "E", 15 },
                    { 84, true, new DateTime(2018, 7, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), 5, false, "E", 16 },
                    { 85, true, new DateTime(2016, 11, 8, 9, 0, 0, 0, DateTimeKind.Unspecified), 5, false, "E", 17 },
                    { 86, true, new DateTime(2017, 7, 6, 9, 0, 0, 0, DateTimeKind.Unspecified), 6, true, "E", 1 },
                    { 87, true, new DateTime(2016, 2, 22, 17, 0, 0, 0, DateTimeKind.Unspecified), 6, false, "E", 2 },
                    { 88, true, new DateTime(2019, 12, 20, 13, 0, 0, 0, DateTimeKind.Unspecified), 6, true, "E", 3 },
                    { 89, false, new DateTime(2017, 12, 12, 7, 0, 0, 0, DateTimeKind.Unspecified), 6, true, "E", 4 },
                    { 90, false, new DateTime(2017, 1, 13, 13, 0, 0, 0, DateTimeKind.Unspecified), 6, false, "E", 5 },
                    { 91, true, new DateTime(2019, 9, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), 6, true, "E", 6 },
                    { 81, true, new DateTime(2018, 4, 18, 9, 0, 0, 0, DateTimeKind.Unspecified), 5, true, "E", 13 },
                    { 92, false, new DateTime(2017, 2, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), 6, true, "E", 7 },
                    { 94, true, new DateTime(2017, 9, 18, 14, 0, 0, 0, DateTimeKind.Unspecified), 6, true, "E", 9 },
                    { 95, true, new DateTime(2018, 5, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 6, false, "E", 10 },
                    { 96, true, new DateTime(2019, 8, 4, 18, 0, 0, 0, DateTimeKind.Unspecified), 6, true, "E", 11 },
                    { 97, false, new DateTime(2016, 1, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 6, true, "E", 12 },
                    { 98, false, new DateTime(2019, 10, 18, 18, 0, 0, 0, DateTimeKind.Unspecified), 6, false, "E", 13 },
                    { 99, true, new DateTime(2017, 12, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), 6, false, "E", 14 },
                    { 100, false, new DateTime(2016, 3, 20, 15, 0, 0, 0, DateTimeKind.Unspecified), 6, false, "E", 15 },
                    { 101, false, new DateTime(2017, 8, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 6, false, "E", 16 },
                    { 102, true, new DateTime(2017, 7, 16, 7, 0, 0, 0, DateTimeKind.Unspecified), 6, true, "E", 17 },
                    { 93, false, new DateTime(2018, 8, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, false, "E", 8 },
                    { 255, true, new DateTime(2017, 12, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 15, true, "E", 17 }
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
