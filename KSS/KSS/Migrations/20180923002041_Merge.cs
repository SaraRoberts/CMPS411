using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KSS.Migrations
{
    public partial class Merge : Migration
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
                    { 15, "student14@student.com", "Amanda", "Catalonato", "ODoH3ODbRHRcijKi0X8ccDkjp+GuhxfKNowIWUnfNUE=", "1112223333", "User", new byte[] { 177, 217, 22, 240, 143, 70, 20, 241, 10, 38, 114, 216, 209, 207, 198, 79 }, null },
                    { 1, "admin@admin.com", "Becky", "Smith", "eCzDXOA9NgZOOz05TYiG9WMC6vFkgJ2SCunYYCOjyWs=", "1112223333", "Admin", new byte[] { 31, 248, 207, 94, 23, 129, 106, 191, 248, 69, 186, 216, 234, 113, 106, 63 }, null },
                    { 3, "student2@student.com", "Mike", "Waters", "ODoH3ODbRHRcijKi0X8ccDkjp+GuhxfKNowIWUnfNUE=", "1112223333", "User", new byte[] { 177, 217, 22, 240, 143, 70, 20, 241, 10, 38, 114, 216, 209, 207, 198, 79 }, null },
                    { 4, "student3@student.com", "Russel", "Chavers", "ODoH3ODbRHRcijKi0X8ccDkjp+GuhxfKNowIWUnfNUE=", "1112223333", "User", new byte[] { 177, 217, 22, 240, 143, 70, 20, 241, 10, 38, 114, 216, 209, 207, 198, 79 }, null },
                    { 5, "student4@student.com", "Sharon", "Manino", "ODoH3ODbRHRcijKi0X8ccDkjp+GuhxfKNowIWUnfNUE=", "1112223333", "User", new byte[] { 177, 217, 22, 240, 143, 70, 20, 241, 10, 38, 114, 216, 209, 207, 198, 79 }, null },
                    { 7, "student6@student.com", "Bill", "Everet", "ODoH3ODbRHRcijKi0X8ccDkjp+GuhxfKNowIWUnfNUE=", "1112223333", "User", new byte[] { 177, 217, 22, 240, 143, 70, 20, 241, 10, 38, 114, 216, 209, 207, 198, 79 }, null },
                    { 9, "student8@student.com", "Colin", "Livers", "ODoH3ODbRHRcijKi0X8ccDkjp+GuhxfKNowIWUnfNUE=", "1112223333", "User", new byte[] { 177, 217, 22, 240, 143, 70, 20, 241, 10, 38, 114, 216, 209, 207, 198, 79 }, null },
                    { 10, "student9@student.com", "Babe", "Ruth", "ODoH3ODbRHRcijKi0X8ccDkjp+GuhxfKNowIWUnfNUE=", "1112223333", "User", new byte[] { 177, 217, 22, 240, 143, 70, 20, 241, 10, 38, 114, 216, 209, 207, 198, 79 }, null },
                    { 12, "student11@student.com", "Gary", "Aimes", "ODoH3ODbRHRcijKi0X8ccDkjp+GuhxfKNowIWUnfNUE=", "1112223333", "User", new byte[] { 177, 217, 22, 240, 143, 70, 20, 241, 10, 38, 114, 216, 209, 207, 198, 79 }, null },
                    { 17, "student16@student.com", "Richard", "Newman", "ODoH3ODbRHRcijKi0X8ccDkjp+GuhxfKNowIWUnfNUE=", "1112223333", "User", new byte[] { 177, 217, 22, 240, 143, 70, 20, 241, 10, 38, 114, 216, 209, 207, 198, 79 }, null }
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
                    { 2, "student1@student.com", "Paul", "Dig", "ODoH3ODbRHRcijKi0X8ccDkjp+GuhxfKNowIWUnfNUE=", "1112223333", "Staff", new byte[] { 177, 217, 22, 240, 143, 70, 20, 241, 10, 38, 114, 216, 209, 207, 198, 79 }, 1 },
                    { 6, "student5@student.com", "Amy", "Hillbond", "ODoH3ODbRHRcijKi0X8ccDkjp+GuhxfKNowIWUnfNUE=", "1112223333", "Staff", new byte[] { 177, 217, 22, 240, 143, 70, 20, 241, 10, 38, 114, 216, 209, 207, 198, 79 }, 2 },
                    { 8, "student7@student.com", "Trenton", "Hillsong", "ODoH3ODbRHRcijKi0X8ccDkjp+GuhxfKNowIWUnfNUE=", "1112223333", "Staff", new byte[] { 177, 217, 22, 240, 143, 70, 20, 241, 10, 38, 114, 216, 209, 207, 198, 79 }, 3 },
                    { 11, "student10@student.com", "Tim", "Hammond", "ODoH3ODbRHRcijKi0X8ccDkjp+GuhxfKNowIWUnfNUE=", "1112223333", "Staff", new byte[] { 177, 217, 22, 240, 143, 70, 20, 241, 10, 38, 114, 216, 209, 207, 198, 79 }, 4 },
                    { 13, "student12@student.com", "Lucy", "Vilardo", "ODoH3ODbRHRcijKi0X8ccDkjp+GuhxfKNowIWUnfNUE=", "1112223333", "Staff", new byte[] { 177, 217, 22, 240, 143, 70, 20, 241, 10, 38, 114, 216, 209, 207, 198, 79 }, 5 },
                    { 14, "student13@student.com", "Tom", "Avers", "ODoH3ODbRHRcijKi0X8ccDkjp+GuhxfKNowIWUnfNUE=", "1112223333", "Staff", new byte[] { 177, 217, 22, 240, 143, 70, 20, 241, 10, 38, 114, 216, 209, 207, 198, 79 }, 6 },
                    { 16, "student15@student.com", "Donald", "Hill", "ODoH3ODbRHRcijKi0X8ccDkjp+GuhxfKNowIWUnfNUE=", "1112223333", "Staff", new byte[] { 177, 217, 22, 240, 143, 70, 20, 241, 10, 38, 114, 216, 209, 207, 198, 79 }, 7 }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "BookAvailable", "BookPrice", "CategoryId", "Description", "Name", "PrereqId", "TypicalPrice" },
                values: new object[,]
                {
                    { 8, false, 0m, 2, "This is a 16 - 20 hour course for those who wish to become AHA Instructor Candidates able to teach various levels of American Heart Association CPR.  Course is taught over 2 or 3 days. Successful completion of AHA BLS for Healthcare Providers Course, as well as each module instructor candidates wish to teach(Heartsaver First Aid, Heartsaver CPR / AED, etc.), and scoring 90 % or better on written examination(within 90 days of the instructor course) is required for completion. A letter of recommendation and completion of Core Instructor Course is required before applying. Cost includes all student level books, instructor manuals, practical exams, and test.New 2015 Guidelines!", "BLS CPR for Healthcare Providers, Instructor Course", 1, 50 },
                    { 9, false, 0m, 1, "For those who have successfully completed the online portion of the Heartsaver CPR/AED course.  Students MUST provide a copy of the online course completion certificate. Cost includes practice time, exam, and course completion certificate(good for 2 years)", "CPR/AED Online Recertification – Part 2", 4, 50 },
                    { 10, false, 0m, 2, "For those who have successfully completed the online portion of the Heartsaver First Aid course.  Students MUST provide a copy of the online course completion certificate. Cost includes practice time, exam, and course completion certificate(good for 2 years)", "First Aid Online Recertification – Part 2", 5, 50 }
                });

            migrationBuilder.InsertData(
                table: "Instance",
                columns: new[] { "InstanceId", "BookAvailable", "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[,]
                {
                    { 22, true, 30.0, 5, 2, 3, 82.0, 28, new DateTimeOffset(new DateTime(2016, 11, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 10, true, 41.0, 6, 2, 3, 81.0, 26, new DateTimeOffset(new DateTime(2019, 1, 22, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 6, true, 46.0, 1, 2, 3, 112.0, 26, new DateTimeOffset(new DateTime(2016, 7, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 9, true, 35.0, 4, 4, 3, 143.0, 26, new DateTimeOffset(new DateTime(2016, 7, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 5, true, 18.0, 4, 5, 2, 118.0, 26, new DateTimeOffset(new DateTime(2018, 2, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 20, true, 41.0, 3, 5, 3, 117.0, 28, new DateTimeOffset(new DateTime(2019, 6, 28, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 17, true, 20.0, 3, 4, 1, 70.0, 10, new DateTimeOffset(new DateTime(2018, 8, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 23, true, 38.0, 5, 3, 2, 110.0, 10, new DateTimeOffset(new DateTime(2018, 10, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 15, true, 46.0, 5, 5, 3, 90.0, 12, new DateTimeOffset(new DateTime(2017, 2, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 14, true, 44.0, 5, 5, 2, 104.0, 26, new DateTimeOffset(new DateTime(2018, 8, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 11, true, 35.0, 5, 5, 3, 139.0, 26, new DateTimeOffset(new DateTime(2019, 4, 26, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 26, true, 42.0, 2, 1, 3, 59.0, 29, new DateTimeOffset(new DateTime(2017, 12, 16, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 18, true, 40.0, 2, 3, 3, 108.0, 26, new DateTimeOffset(new DateTime(2016, 8, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 19, true, 33.0, 6, 3, 1, 121.0, 17, new DateTimeOffset(new DateTime(2019, 9, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 13, true, 24.0, 6, 4, 2, 49.0, 26, new DateTimeOffset(new DateTime(2018, 12, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 3, true, 28.0, 6, 1, 2, 127.0, 10, new DateTimeOffset(new DateTime(2019, 5, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 2, true, 20.0, 6, 5, 3, 70.0, 18, new DateTimeOffset(new DateTime(2017, 7, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 27, true, 46.0, 2, 2, 3, 126.0, 20, new DateTimeOffset(new DateTime(2017, 10, 28, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 16, true, 35.0, 4, 6, 2, 141.0, 19, new DateTimeOffset(new DateTime(2019, 7, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "EnrollmentId", "BookBought", "Confirmed", "InstanceId", "Paid", "Status", "UserId" },
                values: new object[,]
                {
                    { 35, true, new DateTime(2017, 10, 28, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 1 },
                    { 34, true, new DateTime(2017, 2, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 17 },
                    { 36, true, new DateTime(2017, 7, 26, 7, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 2 },
                    { 37, true, new DateTime(2017, 12, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 3 },
                    { 38, false, new DateTime(2017, 3, 26, 11, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 4 },
                    { 39, false, new DateTime(2018, 3, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 5 },
                    { 40, false, new DateTime(2016, 7, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 6 },
                    { 41, false, new DateTime(2017, 10, 16, 11, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 7 },
                    { 42, false, new DateTime(2016, 11, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 8 },
                    { 43, true, new DateTime(2019, 10, 2, 7, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 9 },
                    { 44, false, new DateTime(2019, 11, 20, 15, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 10 },
                    { 45, false, new DateTime(2019, 1, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 11 },
                    { 46, true, new DateTime(2017, 8, 21, 9, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 12 },
                    { 47, false, new DateTime(2018, 12, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 13 },
                    { 48, false, new DateTime(2016, 1, 8, 13, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 14 },
                    { 49, false, new DateTime(2018, 2, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 15 },
                    { 33, true, new DateTime(2019, 12, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 16 },
                    { 50, true, new DateTime(2018, 8, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 16 },
                    { 32, false, new DateTime(2019, 5, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 15 },
                    { 30, false, new DateTime(2018, 2, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 13 },
                    { 18, false, new DateTime(2019, 5, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 1 },
                    { 19, false, new DateTime(2017, 7, 23, 9, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 2 },
                    { 20, true, new DateTime(2017, 7, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 3 },
                    { 21, true, new DateTime(2017, 4, 5, 7, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 4 },
                    { 31, true, new DateTime(2016, 3, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 14 },
                    { 23, true, new DateTime(2018, 9, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 6 },
                    { 22, true, new DateTime(2018, 2, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 5 },
                    { 25, true, new DateTime(2016, 9, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 8 },
                    { 26, false, new DateTime(2019, 4, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 9 },
                    { 27, false, new DateTime(2017, 11, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 10 },
                    { 28, false, new DateTime(2017, 7, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 11 },
                    { 29, true, new DateTime(2018, 7, 15, 7, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 12 },
                    { 24, false, new DateTime(2019, 8, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 7 },
                    { 51, true, new DateTime(2018, 2, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 17 }
                });

            migrationBuilder.InsertData(
                table: "Instance",
                columns: new[] { "InstanceId", "BookAvailable", "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[,]
                {
                    { 4, true, 39.0, 10, 3, 3, 136.0, 23, new DateTimeOffset(new DateTime(2016, 9, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 24, true, 36.0, 10, 5, 2, 80.0, 10, new DateTimeOffset(new DateTime(2016, 10, 4, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 8, true, 23.0, 9, 2, 3, 108.0, 21, new DateTimeOffset(new DateTime(2016, 10, 16, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 25, true, 51.0, 9, 5, 1, 107.0, 13, new DateTimeOffset(new DateTime(2018, 5, 3, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 1, true, 46.0, 8, 3, 2, 90.0, 12, new DateTimeOffset(new DateTime(2017, 5, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 21, true, 24.0, 8, 1, 2, 101.0, 21, new DateTimeOffset(new DateTime(2019, 7, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 12, true, 49.0, 8, 3, 2, 53.0, 21, new DateTimeOffset(new DateTime(2019, 2, 4, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 7, true, 28.0, 8, 1, 3, 130.0, 19, new DateTimeOffset(new DateTime(2016, 4, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 28, true, 45.0, 9, 2, 3, 89.0, 25, new DateTimeOffset(new DateTime(2016, 2, 19, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 29, true, 17.0, 9, 6, 1, 146.0, 12, new DateTimeOffset(new DateTime(2016, 4, 6, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "EnrollmentId", "BookBought", "Confirmed", "InstanceId", "Paid", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, false, new DateTime(2017, 7, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 1 },
                    { 15, true, new DateTime(2017, 6, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 15 },
                    { 14, true, new DateTime(2017, 5, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 14 },
                    { 13, false, new DateTime(2016, 9, 28, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 13 },
                    { 12, false, new DateTime(2017, 2, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 12 },
                    { 11, false, new DateTime(2017, 11, 5, 7, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 11 },
                    { 10, false, new DateTime(2017, 8, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 10 },
                    { 16, true, new DateTime(2019, 11, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 16 },
                    { 9, true, new DateTime(2016, 6, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 9 },
                    { 7, false, new DateTime(2019, 7, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 7 },
                    { 6, false, new DateTime(2018, 7, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 6 },
                    { 5, false, new DateTime(2019, 11, 18, 17, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 5 },
                    { 4, false, new DateTime(2017, 12, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 4 },
                    { 3, false, new DateTime(2018, 4, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 3 },
                    { 2, true, new DateTime(2018, 8, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 2 },
                    { 8, true, new DateTime(2019, 7, 5, 13, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 8 },
                    { 17, false, new DateTime(2017, 11, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 17 }
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
