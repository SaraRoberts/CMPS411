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
                    { 15, "student14@student.com", "Amanda", "Catalonato", "k+X5gSAuvJzdmx4Sc86NwFs4TL1o1DWLyq/Jni54SAs=", "1112223333", "User", new byte[] { 90, 103, 149, 120, 101, 174, 195, 27, 76, 250, 148, 136, 144, 153, 100, 201 } },
                    { 14, "student13@student.com", "Tom", "Avers", "k+X5gSAuvJzdmx4Sc86NwFs4TL1o1DWLyq/Jni54SAs=", "1112223333", "User", new byte[] { 90, 103, 149, 120, 101, 174, 195, 27, 76, 250, 148, 136, 144, 153, 100, 201 } },
                    { 13, "student12@student.com", "Lucy", "Vilardo", "k+X5gSAuvJzdmx4Sc86NwFs4TL1o1DWLyq/Jni54SAs=", "1112223333", "User", new byte[] { 90, 103, 149, 120, 101, 174, 195, 27, 76, 250, 148, 136, 144, 153, 100, 201 } },
                    { 12, "student11@student.com", "Gary", "Aimes", "k+X5gSAuvJzdmx4Sc86NwFs4TL1o1DWLyq/Jni54SAs=", "1112223333", "User", new byte[] { 90, 103, 149, 120, 101, 174, 195, 27, 76, 250, 148, 136, 144, 153, 100, 201 } },
                    { 11, "student10@student.com", "Tim", "Hammond", "k+X5gSAuvJzdmx4Sc86NwFs4TL1o1DWLyq/Jni54SAs=", "1112223333", "User", new byte[] { 90, 103, 149, 120, 101, 174, 195, 27, 76, 250, 148, 136, 144, 153, 100, 201 } },
                    { 10, "student9@student.com", "Babe", "Ruth", "k+X5gSAuvJzdmx4Sc86NwFs4TL1o1DWLyq/Jni54SAs=", "1112223333", "User", new byte[] { 90, 103, 149, 120, 101, 174, 195, 27, 76, 250, 148, 136, 144, 153, 100, 201 } },
                    { 9, "student8@student.com", "Colin", "Livers", "k+X5gSAuvJzdmx4Sc86NwFs4TL1o1DWLyq/Jni54SAs=", "1112223333", "User", new byte[] { 90, 103, 149, 120, 101, 174, 195, 27, 76, 250, 148, 136, 144, 153, 100, 201 } },
                    { 5, "student4@student.com", "Sharon", "Manino", "k+X5gSAuvJzdmx4Sc86NwFs4TL1o1DWLyq/Jni54SAs=", "1112223333", "Staff", new byte[] { 90, 103, 149, 120, 101, 174, 195, 27, 76, 250, 148, 136, 144, 153, 100, 201 } },
                    { 7, "student6@student.com", "Bill", "Everet", "k+X5gSAuvJzdmx4Sc86NwFs4TL1o1DWLyq/Jni54SAs=", "1112223333", "User", new byte[] { 90, 103, 149, 120, 101, 174, 195, 27, 76, 250, 148, 136, 144, 153, 100, 201 } },
                    { 6, "student5@student.com", "Amy", "Hillbond", "k+X5gSAuvJzdmx4Sc86NwFs4TL1o1DWLyq/Jni54SAs=", "1112223333", "Staff", new byte[] { 90, 103, 149, 120, 101, 174, 195, 27, 76, 250, 148, 136, 144, 153, 100, 201 } },
                    { 16, "student15@student.com", "Donald", "Hill", "k+X5gSAuvJzdmx4Sc86NwFs4TL1o1DWLyq/Jni54SAs=", "1112223333", "User", new byte[] { 90, 103, 149, 120, 101, 174, 195, 27, 76, 250, 148, 136, 144, 153, 100, 201 } },
                    { 4, "student3@student.com", "Russel", "Chavers", "k+X5gSAuvJzdmx4Sc86NwFs4TL1o1DWLyq/Jni54SAs=", "1112223333", "Staff", new byte[] { 90, 103, 149, 120, 101, 174, 195, 27, 76, 250, 148, 136, 144, 153, 100, 201 } },
                    { 3, "student2@student.com", "Mike", "Waters", "k+X5gSAuvJzdmx4Sc86NwFs4TL1o1DWLyq/Jni54SAs=", "1112223333", "Staff", new byte[] { 90, 103, 149, 120, 101, 174, 195, 27, 76, 250, 148, 136, 144, 153, 100, 201 } },
                    { 2, "student1@student.com", "Paul", "Dig", "k+X5gSAuvJzdmx4Sc86NwFs4TL1o1DWLyq/Jni54SAs=", "1112223333", "Staff", new byte[] { 90, 103, 149, 120, 101, 174, 195, 27, 76, 250, 148, 136, 144, 153, 100, 201 } },
                    { 1, "admin@admin.com", "Becky", "Smith", "F8lTMxvHrQB7ThRGFBRF9wbLKj/vwB8XgmeAFqW73K4=", "1112223333", "Admin", new byte[] { 208, 31, 90, 231, 5, 72, 177, 92, 203, 32, 225, 51, 97, 184, 11, 188 } },
                    { 8, "student7@student.com", "Trenton", "Hillsong", "k+X5gSAuvJzdmx4Sc86NwFs4TL1o1DWLyq/Jni54SAs=", "1112223333", "User", new byte[] { 90, 103, 149, 120, 101, 174, 195, 27, 76, 250, 148, 136, 144, 153, 100, 201 } },
                    { 17, "student16@student.com", "Richard", "Newman", "k+X5gSAuvJzdmx4Sc86NwFs4TL1o1DWLyq/Jni54SAs=", "1112223333", "User", new byte[] { 90, 103, 149, 120, 101, 174, 195, 27, 76, 250, 148, 136, 144, 153, 100, 201 } }
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
                    { 1, true, 25m, 1, "A 4 ½ hour initial course designed for Healthcare Professionals.  The course covers Adult, Child, and Infant one-rescuer CPR AED, as well as a new focused emphasis on teamwork with the adult, child, and infant two-person rescue.  Topics also include Rescue Breathing and Foreign Body Airway Obstruction. Cost includes the use of a textbook, written and practical exams, and a course completion certification(good for 2 years).New 2015 Guidelines!", "Basic Life Support (BLS) for Healthcare Professionals", null, 50 },
                    { 6, false, 0m, 1, "A 6-8 hour First Aid course designed for childcare workers whose job requires a pediatric-specific first aid completion card.  This course provides the skills to effectively asses and maintain a child’s life in the critical minutes following an emergency until the arrival of emergency personnel.  This course covers all State of Louisiana required modules including Child Care specific topics, General Principles, Medical Emergencies, Injury Emergencies, and Environmental Emergencies.  Also includes CPR and AED training for Adult, Children, and Infants. Cost includes use of a textbook, skills, and course completion certification(good for 2 years).New 2015 Guidelines!", "Heartsaver Pediatric First Aid Course (Daycare/Childcare Providers)", null, 50 },
                    { 2, false, 0m, 2, "A 4 hour refresher course for the Healthcare Professional; this course offers guidelines in one and two-rescuer adult, child, and infant CPR, Foreign Body Airway Obstruction, and AED training. Cost includes the use of a students’ textbook, written and practical exams, and course completion certification(good for 2 years).New 2015 Guidelines!", "Basic Life Support (BLS) with CPR for Healthcare Professionals -  Refresher", null, 50 },
                    { 5, true, 15m, 2, "A 4 hour course designed for the general public or lay rescuer whose job requires a first aid course completion card.  The course provides the skills to effectively asses and maintain life from the critical minutes of an emergency until the arrival of emergency service personnel.  Depending on which modules the candidate wishes to take, the basic first aid course consists of General Principles, Medical Emergencies, and Injury Emergencies.  Also includes CPR and AED training, and Environmental Emergencies. Cost includes use of a textbook, practice exam, and course completion certificate(good for 2 years).New 2015 Guidelines!", "Heartsaver First Aid ", null, 50 },
                    { 7, false, 0m, 2, "A 2 ½ hour entry level awareness program designed for the general public, parents, babysitters, grandparents, churches, clubs, etc.  The course covers American Heart Association guidelines for the one-rescuer adult including Pediatric CPR, relief of Foreign Body Airway Obstructions, the chain of survival, Basic First Aid, and recognizing the signs of a heart attack and stroke. Cost includes a student textbook.New 2016 Guidelines!", "Family and Friends CPR (course designed for general public; non-certification course)", null, 50 },
                    { 3, false, 0m, 3, "For those who have successfully completed the online portion of either BLS course.  Students MUST provide a copy of the online course completion certificate. Cost includes practice time, exam, and course completion certificate(good for 2 years)", "BLS Online Recertification – Part 2", 3, 0 },
                    { 4, true, 15m, 4, "A 2-3 hour course designed to teach the lay rescuer (security guards, personal trainers, church organization teachers, etc.) how to recognize and treat life-threatening emergencies whose job requires a course completion card documenting one-rescuer adult and/or pediatric CPR, Foreign Body Airway Obstruction, and AED training. Cost includes the use of a textbook, practice exam, and course completion certificate(good for 2 years).New 2015 Guidelines!", "Heartsaver CPR/AED ", null, 50 }
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
                columns: new[] { "InstanceId", "BookAvailable", "BookPrice", "CourseId", "Graded", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[,]
                {
                    { 9, true, 27.0, 6, false, 2, 3, 114.0, 19, new DateTimeOffset(new DateTime(2016, 8, 12, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 1, true, 42.0, 1, false, 2, 3, 146.0, 12, new DateTimeOffset(new DateTime(2019, 12, 11, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 21, true, 36.0, 3, false, 6, 2, 89.0, 10, new DateTimeOffset(new DateTime(2018, 4, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 16, true, 46.0, 3, false, 4, 1, 97.0, 10, new DateTimeOffset(new DateTime(2016, 3, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 15, true, 22.0, 3, false, 4, 1, 98.0, 26, new DateTimeOffset(new DateTime(2018, 5, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 18, true, 28.0, 7, false, 2, 1, 45.0, 25, new DateTimeOffset(new DateTime(2019, 2, 28, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 3, true, 37.0, 7, false, 5, 3, 66.0, 23, new DateTimeOffset(new DateTime(2019, 1, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 7, true, 44.0, 6, false, 1, 3, 52.0, 15, new DateTimeOffset(new DateTime(2018, 7, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 24, true, 20.0, 5, false, 6, 2, 130.0, 24, new DateTimeOffset(new DateTime(2017, 8, 27, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 14, true, 50.0, 4, false, 6, 3, 93.0, 13, new DateTimeOffset(new DateTime(2018, 7, 12, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 29, true, 17.0, 2, false, 2, 3, 46.0, 11, new DateTimeOffset(new DateTime(2017, 9, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 13, true, 27.0, 2, false, 6, 1, 134.0, 29, new DateTimeOffset(new DateTime(2019, 9, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 11, true, 35.0, 2, false, 4, 1, 71.0, 15, new DateTimeOffset(new DateTime(2016, 1, 14, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 26, true, 29.0, 6, false, 6, 2, 67.0, 25, new DateTimeOffset(new DateTime(2019, 9, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 25, true, 55.0, 6, false, 2, 1, 93.0, 29, new DateTimeOffset(new DateTime(2017, 10, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 17, true, 37.0, 5, false, 3, 3, 95.0, 19, new DateTimeOffset(new DateTime(2017, 10, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 28, true, 44.0, 4, false, 2, 3, 97.0, 28, new DateTimeOffset(new DateTime(2017, 12, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "EnrollmentId", "BookBought", "Confirmed", "InstanceId", "Paid", "Status", "UserId" },
                values: new object[,]
                {
                    { 14, false, new DateTime(2018, 7, 14, 9, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 14 },
                    { 17, false, new DateTime(2018, 10, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 17 },
                    { 50, true, new DateTime(2019, 12, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 16 },
                    { 49, false, new DateTime(2019, 2, 18, 13, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 15 },
                    { 35, true, new DateTime(2016, 8, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 1 },
                    { 36, true, new DateTime(2017, 10, 13, 9, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 2 },
                    { 37, true, new DateTime(2018, 2, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 3 },
                    { 38, true, new DateTime(2018, 3, 16, 15, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 4 },
                    { 39, true, new DateTime(2019, 3, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 5 },
                    { 40, false, new DateTime(2017, 5, 28, 17, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 6 },
                    { 41, false, new DateTime(2017, 12, 14, 7, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 7 },
                    { 42, false, new DateTime(2019, 11, 27, 13, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 8 },
                    { 43, true, new DateTime(2017, 9, 23, 11, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 9 },
                    { 44, true, new DateTime(2016, 5, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 10 },
                    { 45, false, new DateTime(2016, 6, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 11 },
                    { 46, true, new DateTime(2018, 8, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), 3, false, "E", 12 },
                    { 16, true, new DateTime(2017, 7, 18, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 16 },
                    { 15, false, new DateTime(2018, 8, 26, 11, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 15 },
                    { 48, true, new DateTime(2016, 4, 16, 10, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 14 },
                    { 13, false, new DateTime(2016, 12, 17, 14, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 13 },
                    { 51, true, new DateTime(2017, 2, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 17 },
                    { 1, true, new DateTime(2019, 6, 24, 13, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 1 },
                    { 2, true, new DateTime(2018, 9, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 2 },
                    { 3, true, new DateTime(2018, 2, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 3 },
                    { 47, true, new DateTime(2018, 8, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "E", 13 },
                    { 5, true, new DateTime(2017, 1, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 5 },
                    { 4, false, new DateTime(2018, 6, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 4 },
                    { 7, true, new DateTime(2019, 9, 23, 15, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 7 },
                    { 8, true, new DateTime(2019, 4, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 8 },
                    { 9, true, new DateTime(2016, 4, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 9 },
                    { 10, false, new DateTime(2017, 9, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 10 },
                    { 11, false, new DateTime(2017, 4, 25, 7, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 11 },
                    { 12, false, new DateTime(2017, 6, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "E", 12 },
                    { 6, true, new DateTime(2019, 12, 25, 7, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "E", 6 }
                });

            migrationBuilder.InsertData(
                table: "Instance",
                columns: new[] { "InstanceId", "BookAvailable", "BookPrice", "CourseId", "Graded", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[,]
                {
                    { 5, true, 40.0, 9, false, 1, 2, 146.0, 25, new DateTimeOffset(new DateTime(2016, 10, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 6, true, 17.0, 9, false, 4, 1, 67.0, 15, new DateTimeOffset(new DateTime(2019, 2, 10, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 12, true, 51.0, 9, false, 4, 1, 100.0, 16, new DateTimeOffset(new DateTime(2018, 7, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 4, true, 44.0, 8, false, 4, 3, 87.0, 19, new DateTimeOffset(new DateTime(2018, 6, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 2, true, 18.0, 10, false, 4, 2, 145.0, 10, new DateTimeOffset(new DateTime(2016, 3, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 19, true, 32.0, 9, false, 6, 2, 112.0, 11, new DateTimeOffset(new DateTime(2018, 4, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 22, true, 46.0, 8, false, 3, 1, 64.0, 28, new DateTimeOffset(new DateTime(2016, 4, 6, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 20, true, 18.0, 8, false, 1, 3, 137.0, 29, new DateTimeOffset(new DateTime(2019, 12, 25, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 10, true, 26.0, 8, false, 5, 1, 100.0, 30, new DateTimeOffset(new DateTime(2016, 2, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 8, true, 51.0, 8, false, 6, 1, 119.0, 10, new DateTimeOffset(new DateTime(2016, 11, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 27, true, 49.0, 10, false, 5, 2, 101.0, 21, new DateTimeOffset(new DateTime(2017, 10, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 23, true, 49.0, 9, false, 2, 1, 114.0, 29, new DateTimeOffset(new DateTime(2018, 4, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "EnrollmentId", "BookBought", "Confirmed", "InstanceId", "Paid", "Status", "UserId" },
                values: new object[,]
                {
                    { 18, true, new DateTime(2016, 12, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 1 },
                    { 32, true, new DateTime(2016, 3, 21, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 15 },
                    { 31, false, new DateTime(2019, 8, 16, 11, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 14 },
                    { 30, true, new DateTime(2017, 11, 13, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 13 },
                    { 29, false, new DateTime(2017, 12, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 12 },
                    { 28, false, new DateTime(2017, 11, 24, 18, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 11 },
                    { 27, true, new DateTime(2016, 7, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 10 },
                    { 33, false, new DateTime(2016, 10, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 16 },
                    { 26, true, new DateTime(2017, 4, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 9 },
                    { 24, false, new DateTime(2017, 6, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 7 },
                    { 23, false, new DateTime(2017, 4, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 6 },
                    { 22, true, new DateTime(2019, 2, 17, 7, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 5 },
                    { 21, false, new DateTime(2018, 11, 27, 14, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 4 },
                    { 20, true, new DateTime(2017, 2, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 3 },
                    { 19, false, new DateTime(2019, 11, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), 2, false, "E", 2 },
                    { 25, false, new DateTime(2017, 10, 23, 9, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 8 },
                    { 34, false, new DateTime(2019, 7, 14, 11, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "E", 17 }
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
