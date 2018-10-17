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
                    Confirmed = table.Column<DateTime>(nullable: true)
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
                    { 15, "student14@student.com", "Amanda", "Catalonato", "0jJszm6brC0yT+UrJV++9V0ehv4424C3pSHZXTQ7iTU=", "1112223333", "User", new byte[] { 111, 216, 36, 85, 111, 128, 75, 181, 169, 232, 108, 7, 251, 84, 112, 30 } },
                    { 14, "student13@student.com", "Tom", "Avers", "0jJszm6brC0yT+UrJV++9V0ehv4424C3pSHZXTQ7iTU=", "1112223333", "User", new byte[] { 111, 216, 36, 85, 111, 128, 75, 181, 169, 232, 108, 7, 251, 84, 112, 30 } },
                    { 13, "student12@student.com", "Lucy", "Vilardo", "0jJszm6brC0yT+UrJV++9V0ehv4424C3pSHZXTQ7iTU=", "1112223333", "User", new byte[] { 111, 216, 36, 85, 111, 128, 75, 181, 169, 232, 108, 7, 251, 84, 112, 30 } },
                    { 12, "student11@student.com", "Gary", "Aimes", "0jJszm6brC0yT+UrJV++9V0ehv4424C3pSHZXTQ7iTU=", "1112223333", "User", new byte[] { 111, 216, 36, 85, 111, 128, 75, 181, 169, 232, 108, 7, 251, 84, 112, 30 } },
                    { 11, "student10@student.com", "Tim", "Hammond", "0jJszm6brC0yT+UrJV++9V0ehv4424C3pSHZXTQ7iTU=", "1112223333", "User", new byte[] { 111, 216, 36, 85, 111, 128, 75, 181, 169, 232, 108, 7, 251, 84, 112, 30 } },
                    { 10, "student9@student.com", "Babe", "Ruth", "0jJszm6brC0yT+UrJV++9V0ehv4424C3pSHZXTQ7iTU=", "1112223333", "User", new byte[] { 111, 216, 36, 85, 111, 128, 75, 181, 169, 232, 108, 7, 251, 84, 112, 30 } },
                    { 9, "student8@student.com", "Colin", "Livers", "0jJszm6brC0yT+UrJV++9V0ehv4424C3pSHZXTQ7iTU=", "1112223333", "User", new byte[] { 111, 216, 36, 85, 111, 128, 75, 181, 169, 232, 108, 7, 251, 84, 112, 30 } },
                    { 5, "student4@student.com", "Sharon", "Manino", "0jJszm6brC0yT+UrJV++9V0ehv4424C3pSHZXTQ7iTU=", "1112223333", "Staff", new byte[] { 111, 216, 36, 85, 111, 128, 75, 181, 169, 232, 108, 7, 251, 84, 112, 30 } },
                    { 7, "student6@student.com", "Bill", "Everet", "0jJszm6brC0yT+UrJV++9V0ehv4424C3pSHZXTQ7iTU=", "1112223333", "User", new byte[] { 111, 216, 36, 85, 111, 128, 75, 181, 169, 232, 108, 7, 251, 84, 112, 30 } },
                    { 6, "student5@student.com", "Amy", "Hillbond", "0jJszm6brC0yT+UrJV++9V0ehv4424C3pSHZXTQ7iTU=", "1112223333", "Staff", new byte[] { 111, 216, 36, 85, 111, 128, 75, 181, 169, 232, 108, 7, 251, 84, 112, 30 } },
                    { 16, "student15@student.com", "Donald", "Hill", "0jJszm6brC0yT+UrJV++9V0ehv4424C3pSHZXTQ7iTU=", "1112223333", "User", new byte[] { 111, 216, 36, 85, 111, 128, 75, 181, 169, 232, 108, 7, 251, 84, 112, 30 } },
                    { 4, "student3@student.com", "Russel", "Chavers", "0jJszm6brC0yT+UrJV++9V0ehv4424C3pSHZXTQ7iTU=", "1112223333", "Staff", new byte[] { 111, 216, 36, 85, 111, 128, 75, 181, 169, 232, 108, 7, 251, 84, 112, 30 } },
                    { 3, "student2@student.com", "Mike", "Waters", "0jJszm6brC0yT+UrJV++9V0ehv4424C3pSHZXTQ7iTU=", "1112223333", "Staff", new byte[] { 111, 216, 36, 85, 111, 128, 75, 181, 169, 232, 108, 7, 251, 84, 112, 30 } },
                    { 2, "student1@student.com", "Paul", "Dig", "0jJszm6brC0yT+UrJV++9V0ehv4424C3pSHZXTQ7iTU=", "1112223333", "Staff", new byte[] { 111, 216, 36, 85, 111, 128, 75, 181, 169, 232, 108, 7, 251, 84, 112, 30 } },
                    { 1, "admin@admin.com", "Becky", "Smith", "bq3cQpUMzlx0CxO1rGnPKT4+fsh+TE++FBA7PMKrEYE=", "1112223333", "Admin", new byte[] { 180, 32, 204, 26, 2, 255, 133, 107, 7, 196, 238, 214, 123, 47, 7, 77 } },
                    { 8, "student7@student.com", "Trenton", "Hillsong", "0jJszm6brC0yT+UrJV++9V0ehv4424C3pSHZXTQ7iTU=", "1112223333", "User", new byte[] { 111, 216, 36, 85, 111, 128, 75, 181, 169, 232, 108, 7, 251, 84, 112, 30 } },
                    { 17, "student16@student.com", "Richard", "Newman", "0jJszm6brC0yT+UrJV++9V0ehv4424C3pSHZXTQ7iTU=", "1112223333", "User", new byte[] { 111, 216, 36, 85, 111, 128, 75, 181, 169, 232, 108, 7, 251, 84, 112, 30 } }
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
                    { 10, false, 0m, 2, "For those who have successfully completed the online portion of the Heartsaver First Aid course.  Students MUST provide a copy of the online course completion certificate. Cost includes practice time, exam, and course completion certificate(good for 2 years)", "First Aid Online Recert 2", 5, 50 },
                    { 9, false, 0m, 1, "For those who have successfully completed the online portion of the Heartsaver CPR/AED course.  Students MUST provide a copy of the online course completion certificate. Cost includes practice time, exam, and course completion certificate(good for 2 years)", "CPR/AED Online Recert 2", 4, 50 }
                });

            migrationBuilder.InsertData(
                table: "Instance",
                columns: new[] { "InstanceId", "BookAvailable", "BookPrice", "CourseId", "Graded", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[,]
                {
                    { 29, true, 53.0, 3, false, 6, 3, 111.0, 30, new DateTimeOffset(new DateTime(2017, 12, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 26, true, 30.0, 3, false, 6, 1, 87.0, 12, new DateTimeOffset(new DateTime(2019, 5, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 15, true, 52.0, 3, false, 1, 3, 56.0, 17, new DateTimeOffset(new DateTime(2017, 7, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 7, true, 22.0, 3, false, 1, 3, 126.0, 15, new DateTimeOffset(new DateTime(2016, 6, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 24, true, 16.0, 7, false, 6, 1, 123.0, 15, new DateTimeOffset(new DateTime(2019, 10, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 18, true, 30.0, 7, false, 6, 3, 102.0, 26, new DateTimeOffset(new DateTime(2017, 12, 23, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 11, true, 25.0, 7, false, 5, 3, 102.0, 16, new DateTimeOffset(new DateTime(2016, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 3, true, 37.0, 7, false, 5, 1, 79.0, 22, new DateTimeOffset(new DateTime(2018, 8, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 27, true, 27.0, 5, false, 3, 1, 144.0, 10, new DateTimeOffset(new DateTime(2017, 7, 20, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 17, true, 16.0, 5, false, 1, 1, 91.0, 11, new DateTimeOffset(new DateTime(2016, 12, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 10, true, 38.0, 2, false, 3, 3, 47.0, 14, new DateTimeOffset(new DateTime(2018, 3, 27, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 9, true, 24.0, 2, false, 4, 3, 70.0, 17, new DateTimeOffset(new DateTime(2016, 9, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 4, true, 18.0, 2, false, 2, 3, 97.0, 29, new DateTimeOffset(new DateTime(2019, 1, 23, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 1, true, 15.0, 2, false, 6, 1, 48.0, 29, new DateTimeOffset(new DateTime(2017, 7, 24, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 28, true, 50.0, 6, false, 4, 2, 46.0, 11, new DateTimeOffset(new DateTime(2017, 8, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 19, true, 55.0, 6, false, 2, 3, 70.0, 21, new DateTimeOffset(new DateTime(2018, 3, 10, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 14, true, 53.0, 6, false, 2, 1, 104.0, 21, new DateTimeOffset(new DateTime(2017, 8, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 23, true, 28.0, 1, false, 6, 1, 100.0, 17, new DateTimeOffset(new DateTime(2017, 4, 11, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 22, true, 36.0, 2, false, 4, 3, 56.0, 13, new DateTimeOffset(new DateTime(2018, 6, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 16, true, 40.0, 4, false, 1, 3, 148.0, 12, new DateTimeOffset(new DateTime(2017, 2, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "EnrollmentId", "BookBought", "Confirmed", "InstanceId", "Paid", "Status", "UserId" },
                values: new object[,]
                {
                    { 289, false, null, 17, true, "E", 17 },
                    { 297, false, null, 18, true, "E", 8 },
                    { 296, false, null, 18, false, "E", 7 },
                    { 295, false, null, 18, false, "E", 6 },
                    { 294, false, null, 18, false, "E", 5 },
                    { 293, true, null, 18, false, "E", 4 },
                    { 292, false, null, 18, true, "E", 3 },
                    { 291, false, null, 18, false, "E", 2 },
                    { 290, true, null, 18, true, "E", 1 },
                    { 187, true, null, 11, true, "E", 17 },
                    { 186, false, null, 11, true, "E", 16 },
                    { 185, true, null, 11, true, "E", 15 },
                    { 184, true, null, 11, false, "E", 14 },
                    { 183, true, null, 11, true, "E", 13 },
                    { 182, false, null, 11, true, "E", 12 },
                    { 181, true, null, 11, false, "E", 11 },
                    { 180, true, null, 11, true, "E", 10 },
                    { 179, true, null, 11, false, "E", 9 },
                    { 298, true, null, 18, true, "E", 9 },
                    { 299, false, null, 18, false, "E", 10 },
                    { 300, false, null, 18, false, "E", 11 },
                    { 301, false, null, 18, false, "E", 12 },
                    { 404, false, null, 24, false, "E", 13 },
                    { 403, false, null, 24, false, "E", 12 },
                    { 402, false, null, 24, false, "E", 11 },
                    { 401, false, null, 24, false, "E", 10 },
                    { 400, true, null, 24, true, "E", 9 },
                    { 399, false, null, 24, false, "E", 8 },
                    { 398, false, null, 24, false, "E", 7 },
                    { 397, true, null, 24, false, "E", 6 },
                    { 178, true, null, 11, false, "E", 8 },
                    { 396, false, null, 24, false, "E", 5 },
                    { 394, true, null, 24, true, "E", 3 },
                    { 393, false, null, 24, true, "E", 2 },
                    { 392, false, null, 24, true, "E", 1 },
                    { 306, false, null, 18, false, "E", 17 },
                    { 305, true, null, 18, false, "E", 16 },
                    { 304, true, null, 18, true, "E", 15 },
                    { 303, false, null, 18, false, "E", 14 },
                    { 302, true, null, 18, false, "E", 13 },
                    { 395, true, null, 24, true, "E", 4 },
                    { 405, false, null, 24, false, "E", 14 },
                    { 177, true, null, 11, true, "E", 7 },
                    { 175, true, null, 11, true, "E", 5 },
                    { 458, true, null, 27, true, "E", 16 },
                    { 457, false, null, 27, false, "E", 15 },
                    { 456, false, null, 27, false, "E", 14 },
                    { 455, true, null, 27, false, "E", 13 },
                    { 454, true, null, 27, false, "E", 12 },
                    { 453, true, null, 27, true, "E", 11 },
                    { 452, false, null, 27, false, "E", 10 },
                    { 451, true, null, 27, true, "E", 9 },
                    { 450, true, null, 27, true, "E", 8 },
                    { 449, true, null, 27, true, "E", 7 },
                    { 448, true, null, 27, true, "E", 6 },
                    { 447, true, null, 27, false, "E", 5 },
                    { 446, false, null, 27, true, "E", 4 },
                    { 445, false, null, 27, true, "E", 3 },
                    { 444, true, null, 27, false, "E", 2 },
                    { 443, false, null, 27, false, "E", 1 },
                    { 271, true, null, 16, true, "E", 16 },
                    { 459, false, null, 27, false, "E", 17 },
                    { 35, false, null, 3, false, "E", 1 },
                    { 36, false, null, 3, true, "E", 2 },
                    { 37, false, null, 3, false, "E", 3 },
                    { 174, true, null, 11, true, "E", 4 },
                    { 173, false, null, 11, false, "E", 3 },
                    { 172, true, null, 11, true, "E", 2 },
                    { 171, false, null, 11, false, "E", 1 },
                    { 51, false, null, 3, false, "E", 17 },
                    { 50, true, null, 3, false, "E", 16 },
                    { 49, false, null, 3, false, "E", 15 },
                    { 48, false, null, 3, false, "E", 14 },
                    { 176, true, null, 11, true, "E", 6 },
                    { 47, false, null, 3, true, "E", 13 },
                    { 45, false, null, 3, false, "E", 11 },
                    { 44, false, null, 3, false, "E", 10 },
                    { 43, false, null, 3, false, "E", 9 },
                    { 42, false, null, 3, false, "E", 8 },
                    { 41, false, null, 3, true, "E", 7 },
                    { 40, false, null, 3, false, "E", 6 },
                    { 39, true, null, 3, true, "E", 5 },
                    { 38, true, null, 3, false, "E", 4 },
                    { 46, false, null, 3, true, "E", 12 },
                    { 406, true, null, 24, true, "E", 15 },
                    { 407, true, null, 24, false, "E", 16 },
                    { 408, false, null, 24, true, "E", 17 },
                    { 486, true, null, 29, false, "E", 10 },
                    { 485, true, null, 29, false, "E", 9 },
                    { 484, false, null, 29, true, "E", 8 },
                    { 483, false, null, 29, false, "E", 7 },
                    { 482, false, null, 29, true, "E", 6 },
                    { 481, false, null, 29, false, "E", 5 },
                    { 480, true, null, 29, false, "E", 4 },
                    { 479, true, null, 29, true, "E", 3 },
                    { 478, true, null, 29, false, "E", 2 },
                    { 477, true, null, 29, false, "E", 1 },
                    { 442, true, null, 26, true, "E", 17 },
                    { 441, false, null, 26, true, "E", 16 },
                    { 440, false, null, 26, true, "E", 15 },
                    { 439, true, null, 26, false, "E", 14 },
                    { 438, true, null, 26, true, "E", 13 },
                    { 437, true, null, 26, false, "E", 12 },
                    { 436, true, null, 26, false, "E", 11 },
                    { 487, false, null, 29, true, "E", 11 },
                    { 488, true, null, 29, true, "E", 12 },
                    { 489, false, null, 29, true, "E", 13 },
                    { 490, false, null, 29, false, "E", 14 },
                    { 270, true, null, 16, true, "E", 15 },
                    { 269, true, null, 16, true, "E", 14 },
                    { 268, true, null, 16, false, "E", 13 },
                    { 267, true, null, 16, true, "E", 12 },
                    { 266, true, null, 16, false, "E", 11 },
                    { 265, false, null, 16, false, "E", 10 },
                    { 264, false, null, 16, false, "E", 9 },
                    { 263, true, null, 16, true, "E", 8 },
                    { 435, false, null, 26, false, "E", 10 },
                    { 262, true, null, 16, true, "E", 7 },
                    { 260, false, null, 16, true, "E", 5 },
                    { 259, true, null, 16, true, "E", 4 },
                    { 258, true, null, 16, false, "E", 3 },
                    { 257, true, null, 16, true, "E", 2 },
                    { 256, true, null, 16, false, "E", 1 },
                    { 493, false, null, 29, false, "E", 17 },
                    { 492, false, null, 29, true, "E", 16 },
                    { 491, true, null, 29, true, "E", 15 },
                    { 261, false, null, 16, true, "E", 6 },
                    { 434, true, null, 26, true, "E", 9 },
                    { 433, true, null, 26, true, "E", 8 },
                    { 432, true, null, 26, false, "E", 7 },
                    { 239, true, null, 15, true, "E", 1 },
                    { 119, true, null, 7, true, "E", 17 },
                    { 118, false, null, 7, false, "E", 16 },
                    { 117, false, null, 7, false, "E", 15 },
                    { 116, false, null, 7, true, "E", 14 },
                    { 115, true, null, 7, false, "E", 13 },
                    { 114, true, null, 7, false, "E", 12 },
                    { 113, false, null, 7, false, "E", 11 },
                    { 240, false, null, 15, true, "E", 2 },
                    { 112, false, null, 7, true, "E", 10 },
                    { 110, false, null, 7, true, "E", 8 },
                    { 109, true, null, 7, true, "E", 7 },
                    { 108, false, null, 7, true, "E", 6 },
                    { 107, true, null, 7, true, "E", 5 },
                    { 106, false, null, 7, true, "E", 4 },
                    { 105, false, null, 7, true, "E", 3 },
                    { 104, false, null, 7, true, "E", 2 },
                    { 103, true, null, 7, true, "E", 1 },
                    { 111, false, null, 7, true, "E", 9 },
                    { 288, false, null, 17, false, "E", 16 },
                    { 241, false, null, 15, true, "E", 3 },
                    { 243, false, null, 15, true, "E", 5 },
                    { 431, true, null, 26, true, "E", 6 },
                    { 430, true, null, 26, false, "E", 5 },
                    { 429, true, null, 26, false, "E", 4 },
                    { 428, true, null, 26, false, "E", 3 },
                    { 427, false, null, 26, true, "E", 2 },
                    { 426, true, null, 26, true, "E", 1 },
                    { 255, true, null, 15, true, "E", 17 },
                    { 254, true, null, 15, false, "E", 16 },
                    { 242, false, null, 15, false, "E", 4 },
                    { 253, true, null, 15, false, "E", 15 },
                    { 251, false, null, 15, true, "E", 13 },
                    { 250, false, null, 15, true, "E", 12 },
                    { 249, true, null, 15, true, "E", 11 },
                    { 248, true, null, 15, false, "E", 10 },
                    { 247, false, null, 15, true, "E", 9 },
                    { 246, true, null, 15, false, "E", 8 },
                    { 245, true, null, 15, true, "E", 7 },
                    { 244, true, null, 15, false, "E", 6 },
                    { 252, true, null, 15, false, "E", 14 },
                    { 287, true, null, 17, false, "E", 15 },
                    { 272, true, null, 16, false, "E", 17 },
                    { 285, true, null, 17, false, "E", 13 },
                    { 468, true, null, 28, true, "E", 9 },
                    { 467, true, null, 28, false, "E", 8 },
                    { 466, true, null, 28, true, "E", 7 },
                    { 465, true, null, 28, false, "E", 6 },
                    { 464, false, null, 28, true, "E", 5 },
                    { 463, false, null, 28, true, "E", 4 },
                    { 462, false, null, 28, true, "E", 3 },
                    { 461, false, null, 28, true, "E", 2 },
                    { 460, false, null, 28, false, "E", 1 },
                    { 323, false, null, 19, true, "E", 17 },
                    { 322, true, null, 19, true, "E", 16 },
                    { 321, true, null, 19, true, "E", 15 },
                    { 320, false, null, 19, false, "E", 14 },
                    { 319, false, null, 19, true, "E", 13 },
                    { 318, true, null, 19, true, "E", 12 },
                    { 317, false, null, 19, false, "E", 11 },
                    { 316, true, null, 19, true, "E", 10 },
                    { 469, true, null, 28, false, "E", 10 },
                    { 315, true, null, 19, true, "E", 9 },
                    { 470, true, null, 28, false, "E", 11 },
                    { 472, false, null, 28, false, "E", 13 },
                    { 286, false, null, 17, true, "E", 14 },
                    { 12, true, null, 1, false, "E", 12 },
                    { 11, false, null, 1, false, "E", 11 },
                    { 10, false, null, 1, true, "E", 10 },
                    { 9, false, null, 1, true, "E", 9 },
                    { 8, false, null, 1, true, "E", 8 },
                    { 7, true, null, 1, false, "E", 7 },
                    { 6, false, null, 1, false, "E", 6 },
                    { 5, false, null, 1, true, "E", 5 },
                    { 4, false, null, 1, false, "E", 4 },
                    { 3, false, null, 1, true, "E", 3 },
                    { 2, false, null, 1, false, "E", 2 },
                    { 1, true, null, 1, false, "E", 1 },
                    { 476, false, null, 28, true, "E", 17 },
                    { 475, false, null, 28, true, "E", 16 },
                    { 474, true, null, 28, true, "E", 15 },
                    { 473, false, null, 28, true, "E", 14 },
                    { 471, true, null, 28, false, "E", 12 },
                    { 314, true, null, 19, true, "E", 8 },
                    { 313, false, null, 19, false, "E", 7 },
                    { 312, false, null, 19, false, "E", 6 },
                    { 391, false, null, 23, true, "E", 17 },
                    { 390, true, null, 23, false, "E", 16 },
                    { 389, false, null, 23, true, "E", 15 },
                    { 388, false, null, 23, true, "E", 14 },
                    { 387, false, null, 23, true, "E", 13 },
                    { 386, true, null, 23, false, "E", 12 },
                    { 385, false, null, 23, true, "E", 11 },
                    { 384, false, null, 23, false, "E", 10 },
                    { 383, true, null, 23, true, "E", 9 },
                    { 382, false, null, 23, true, "E", 8 },
                    { 381, true, null, 23, false, "E", 7 },
                    { 380, true, null, 23, true, "E", 6 },
                    { 379, false, null, 23, true, "E", 5 },
                    { 378, false, null, 23, true, "E", 4 },
                    { 377, false, null, 23, false, "E", 3 },
                    { 376, false, null, 23, true, "E", 2 },
                    { 375, true, null, 23, false, "E", 1 },
                    { 222, false, null, 14, true, "E", 1 },
                    { 223, true, null, 14, false, "E", 2 },
                    { 224, true, null, 14, true, "E", 3 },
                    { 225, true, null, 14, true, "E", 4 },
                    { 311, false, null, 19, false, "E", 5 },
                    { 310, true, null, 19, false, "E", 4 },
                    { 309, true, null, 19, true, "E", 3 },
                    { 308, true, null, 19, true, "E", 2 },
                    { 307, true, null, 19, true, "E", 1 },
                    { 238, true, null, 14, true, "E", 17 },
                    { 237, true, null, 14, false, "E", 16 },
                    { 236, false, null, 14, false, "E", 15 },
                    { 14, false, null, 1, false, "E", 14 },
                    { 235, true, null, 14, true, "E", 14 },
                    { 233, false, null, 14, false, "E", 12 },
                    { 232, true, null, 14, true, "E", 11 },
                    { 231, true, null, 14, false, "E", 10 },
                    { 230, true, null, 14, true, "E", 9 },
                    { 229, false, null, 14, false, "E", 8 },
                    { 228, true, null, 14, true, "E", 7 },
                    { 227, false, null, 14, false, "E", 6 },
                    { 226, true, null, 14, true, "E", 5 },
                    { 234, false, null, 14, true, "E", 13 },
                    { 15, false, null, 1, true, "E", 15 },
                    { 13, false, null, 1, true, "E", 13 },
                    { 17, true, null, 1, true, "E", 17 },
                    { 365, true, null, 22, true, "E", 8 },
                    { 364, false, null, 22, true, "E", 7 },
                    { 363, false, null, 22, true, "E", 6 },
                    { 362, true, null, 22, true, "E", 5 },
                    { 361, false, null, 22, true, "E", 4 },
                    { 360, false, null, 22, false, "E", 3 },
                    { 359, true, null, 22, false, "E", 2 },
                    { 358, false, null, 22, true, "E", 1 },
                    { 170, false, null, 10, false, "E", 17 },
                    { 169, true, null, 10, false, "E", 16 },
                    { 168, true, null, 10, false, "E", 15 },
                    { 167, true, null, 10, false, "E", 14 },
                    { 166, false, null, 10, false, "E", 13 },
                    { 165, true, null, 10, true, "E", 12 },
                    { 16, true, null, 1, true, "E", 16 },
                    { 163, true, null, 10, true, "E", 10 },
                    { 162, true, null, 10, false, "E", 9 },
                    { 366, false, null, 22, true, "E", 9 },
                    { 161, false, null, 10, false, "E", 8 },
                    { 367, true, null, 22, true, "E", 10 },
                    { 369, true, null, 22, false, "E", 12 },
                    { 284, true, null, 17, false, "E", 12 },
                    { 283, true, null, 17, true, "E", 11 },
                    { 282, true, null, 17, true, "E", 10 },
                    { 281, false, null, 17, true, "E", 9 },
                    { 280, true, null, 17, true, "E", 8 },
                    { 279, true, null, 17, false, "E", 7 },
                    { 278, true, null, 17, false, "E", 6 },
                    { 277, false, null, 17, false, "E", 5 },
                    { 276, false, null, 17, false, "E", 4 },
                    { 275, true, null, 17, true, "E", 3 },
                    { 274, true, null, 17, true, "E", 2 },
                    { 273, false, null, 17, true, "E", 1 },
                    { 374, true, null, 22, true, "E", 17 },
                    { 373, true, null, 22, true, "E", 16 },
                    { 372, true, null, 22, true, "E", 15 },
                    { 371, false, null, 22, false, "E", 14 },
                    { 370, true, null, 22, true, "E", 13 },
                    { 368, false, null, 22, true, "E", 11 },
                    { 160, true, null, 10, true, "E", 7 }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "EnrollmentId", "BookBought", "Confirmed", "InstanceId", "Paid", "Status", "UserId" },
                values: new object[,]
                {
                    { 164, true, null, 10, false, "E", 11 },
                    { 158, true, null, 10, false, "E", 5 },
                    { 68, false, null, 4, false, "E", 17 },
                    { 67, true, null, 4, true, "E", 16 },
                    { 159, false, null, 10, true, "E", 6 },
                    { 65, true, null, 4, true, "E", 14 },
                    { 64, true, null, 4, false, "E", 13 },
                    { 63, false, null, 4, true, "E", 12 },
                    { 62, true, null, 4, true, "E", 11 },
                    { 61, true, null, 4, false, "E", 10 },
                    { 60, true, null, 4, false, "E", 9 },
                    { 59, false, null, 4, true, "E", 8 },
                    { 58, false, null, 4, true, "E", 7 },
                    { 57, true, null, 4, false, "E", 6 },
                    { 56, true, null, 4, false, "E", 5 },
                    { 55, true, null, 4, false, "E", 4 },
                    { 54, true, null, 4, false, "E", 3 },
                    { 53, false, null, 4, true, "E", 2 },
                    { 52, true, null, 4, true, "E", 1 },
                    { 137, true, null, 9, true, "E", 1 },
                    { 138, false, null, 9, true, "E", 2 },
                    { 66, false, null, 4, true, "E", 15 },
                    { 140, false, null, 9, false, "E", 4 },
                    { 157, false, null, 10, false, "E", 4 },
                    { 156, false, null, 10, false, "E", 3 },
                    { 155, true, null, 10, true, "E", 2 },
                    { 154, true, null, 10, true, "E", 1 },
                    { 153, true, null, 9, true, "E", 17 },
                    { 152, false, null, 9, false, "E", 16 },
                    { 151, false, null, 9, false, "E", 15 },
                    { 150, false, null, 9, false, "E", 14 },
                    { 149, true, null, 9, true, "E", 13 },
                    { 148, false, null, 9, true, "E", 12 },
                    { 139, true, null, 9, false, "E", 3 },
                    { 147, true, null, 9, true, "E", 11 },
                    { 145, true, null, 9, false, "E", 9 },
                    { 144, false, null, 9, false, "E", 8 },
                    { 143, false, null, 9, true, "E", 7 },
                    { 142, true, null, 9, false, "E", 6 },
                    { 141, true, null, 9, true, "E", 5 },
                    { 146, true, null, 9, false, "E", 10 }
                });

            migrationBuilder.InsertData(
                table: "Instance",
                columns: new[] { "InstanceId", "BookAvailable", "BookPrice", "CourseId", "Graded", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[,]
                {
                    { 12, true, 44.0, 10, false, 5, 3, 141.0, 17, new DateTimeOffset(new DateTime(2018, 6, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 21, true, 15.0, 9, false, 2, 1, 142.0, 14, new DateTimeOffset(new DateTime(2017, 9, 5, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 20, true, 39.0, 9, false, 6, 2, 111.0, 11, new DateTimeOffset(new DateTime(2018, 6, 15, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 8, true, 37.0, 9, false, 4, 2, 72.0, 20, new DateTimeOffset(new DateTime(2018, 10, 17, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 6, true, 27.0, 9, false, 2, 2, 53.0, 23, new DateTimeOffset(new DateTime(2017, 12, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 5, true, 48.0, 10, false, 5, 1, 129.0, 13, new DateTimeOffset(new DateTime(2019, 6, 12, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 25, true, 34.0, 8, false, 5, 1, 97.0, 17, new DateTimeOffset(new DateTime(2018, 9, 2, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 13, true, 39.0, 8, false, 3, 1, 71.0, 24, new DateTimeOffset(new DateTime(2017, 4, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 2, true, 54.0, 8, false, 1, 1, 132.0, 10, new DateTimeOffset(new DateTime(2019, 4, 4, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "EnrollmentId", "BookBought", "Confirmed", "InstanceId", "Paid", "Status", "UserId" },
                values: new object[,]
                {
                    { 18, true, null, 2, false, "E", 1 },
                    { 98, false, null, 6, false, "E", 13 },
                    { 99, false, null, 6, true, "E", 14 },
                    { 100, true, null, 6, true, "E", 15 },
                    { 101, true, null, 6, true, "E", 16 },
                    { 102, false, null, 6, true, "E", 17 },
                    { 120, true, null, 8, false, "E", 1 },
                    { 121, false, null, 8, true, "E", 2 },
                    { 122, false, null, 8, true, "E", 3 },
                    { 123, false, null, 8, false, "E", 4 },
                    { 124, true, null, 8, true, "E", 5 },
                    { 125, true, null, 8, true, "E", 6 },
                    { 126, true, null, 8, true, "E", 7 },
                    { 127, true, null, 8, true, "E", 8 },
                    { 128, true, null, 8, true, "E", 9 },
                    { 129, true, null, 8, false, "E", 10 },
                    { 97, false, null, 6, false, "E", 12 },
                    { 130, true, null, 8, false, "E", 11 },
                    { 96, true, null, 6, false, "E", 11 },
                    { 94, true, null, 6, false, "E", 9 },
                    { 198, false, null, 12, false, "E", 11 },
                    { 199, true, null, 12, true, "E", 12 },
                    { 200, false, null, 12, false, "E", 13 },
                    { 201, true, null, 12, true, "E", 14 },
                    { 202, true, null, 12, true, "E", 15 },
                    { 203, false, null, 12, true, "E", 16 },
                    { 204, false, null, 12, false, "E", 17 },
                    { 86, true, null, 6, false, "E", 1 },
                    { 87, true, null, 6, false, "E", 2 },
                    { 88, false, null, 6, true, "E", 3 },
                    { 89, true, null, 6, true, "E", 4 },
                    { 90, false, null, 6, false, "E", 5 },
                    { 91, false, null, 6, true, "E", 6 },
                    { 92, true, null, 6, true, "E", 7 },
                    { 93, true, null, 6, false, "E", 8 },
                    { 95, true, null, 6, false, "E", 10 },
                    { 131, false, null, 8, true, "E", 12 },
                    { 132, false, null, 8, false, "E", 13 },
                    { 133, true, null, 8, false, "E", 14 },
                    { 341, true, null, 21, false, "E", 1 },
                    { 342, false, null, 21, true, "E", 2 },
                    { 343, true, null, 21, false, "E", 3 },
                    { 344, false, null, 21, false, "E", 4 },
                    { 345, false, null, 21, false, "E", 5 },
                    { 346, false, null, 21, true, "E", 6 },
                    { 347, true, null, 21, false, "E", 7 },
                    { 348, true, null, 21, false, "E", 8 },
                    { 349, true, null, 21, true, "E", 9 },
                    { 350, false, null, 21, false, "E", 10 },
                    { 351, true, null, 21, true, "E", 11 },
                    { 352, false, null, 21, true, "E", 12 },
                    { 353, false, null, 21, false, "E", 13 },
                    { 354, false, null, 21, false, "E", 14 },
                    { 355, false, null, 21, false, "E", 15 },
                    { 340, false, null, 20, false, "E", 17 },
                    { 339, false, null, 20, false, "E", 16 },
                    { 338, true, null, 20, true, "E", 15 },
                    { 337, false, null, 20, false, "E", 14 },
                    { 134, true, null, 8, false, "E", 15 },
                    { 135, true, null, 8, true, "E", 16 },
                    { 136, false, null, 8, true, "E", 17 },
                    { 324, true, null, 20, true, "E", 1 },
                    { 325, true, null, 20, true, "E", 2 },
                    { 326, true, null, 20, true, "E", 3 },
                    { 327, false, null, 20, false, "E", 4 },
                    { 197, true, null, 12, true, "E", 10 },
                    { 328, false, null, 20, false, "E", 5 },
                    { 330, false, null, 20, false, "E", 7 },
                    { 331, true, null, 20, true, "E", 8 },
                    { 332, true, null, 20, false, "E", 9 },
                    { 333, true, null, 20, true, "E", 10 },
                    { 334, false, null, 20, true, "E", 11 },
                    { 335, false, null, 20, false, "E", 12 },
                    { 336, true, null, 20, true, "E", 13 },
                    { 329, false, null, 20, true, "E", 6 },
                    { 356, true, null, 21, false, "E", 16 },
                    { 196, false, null, 12, true, "E", 9 },
                    { 194, false, null, 12, true, "E", 7 },
                    { 208, true, null, 13, true, "E", 4 },
                    { 209, false, null, 13, false, "E", 5 },
                    { 210, true, null, 13, false, "E", 6 },
                    { 211, true, null, 13, true, "E", 7 },
                    { 212, true, null, 13, true, "E", 8 },
                    { 213, false, null, 13, true, "E", 9 },
                    { 214, false, null, 13, true, "E", 10 },
                    { 215, false, null, 13, false, "E", 11 },
                    { 216, false, null, 13, false, "E", 12 },
                    { 217, true, null, 13, false, "E", 13 },
                    { 218, true, null, 13, false, "E", 14 },
                    { 219, false, null, 13, true, "E", 15 },
                    { 220, false, null, 13, false, "E", 16 },
                    { 221, true, null, 13, true, "E", 17 },
                    { 409, false, null, 25, false, "E", 1 },
                    { 207, false, null, 13, false, "E", 3 },
                    { 410, true, null, 25, false, "E", 2 },
                    { 206, false, null, 13, true, "E", 2 },
                    { 34, true, null, 2, false, "E", 17 },
                    { 19, false, null, 2, false, "E", 2 },
                    { 20, false, null, 2, true, "E", 3 },
                    { 21, false, null, 2, true, "E", 4 },
                    { 22, true, null, 2, true, "E", 5 },
                    { 23, false, null, 2, true, "E", 6 },
                    { 24, false, null, 2, false, "E", 7 },
                    { 25, false, null, 2, true, "E", 8 },
                    { 26, false, null, 2, true, "E", 9 },
                    { 27, false, null, 2, false, "E", 10 },
                    { 28, true, null, 2, false, "E", 11 },
                    { 29, true, null, 2, true, "E", 12 },
                    { 30, false, null, 2, false, "E", 13 },
                    { 31, true, null, 2, false, "E", 14 },
                    { 32, false, null, 2, false, "E", 15 },
                    { 33, false, null, 2, true, "E", 16 },
                    { 205, true, null, 13, true, "E", 1 },
                    { 411, false, null, 25, false, "E", 3 },
                    { 412, true, null, 25, true, "E", 4 },
                    { 413, false, null, 25, true, "E", 5 },
                    { 77, false, null, 5, true, "E", 9 },
                    { 78, true, null, 5, true, "E", 10 },
                    { 79, false, null, 5, true, "E", 11 },
                    { 80, true, null, 5, false, "E", 12 },
                    { 81, false, null, 5, false, "E", 13 },
                    { 82, false, null, 5, true, "E", 14 },
                    { 83, false, null, 5, true, "E", 15 },
                    { 84, false, null, 5, false, "E", 16 },
                    { 85, true, null, 5, true, "E", 17 },
                    { 188, false, null, 12, false, "E", 1 },
                    { 189, true, null, 12, true, "E", 2 },
                    { 190, true, null, 12, false, "E", 3 },
                    { 191, false, null, 12, false, "E", 4 },
                    { 192, true, null, 12, true, "E", 5 },
                    { 193, false, null, 12, true, "E", 6 },
                    { 76, true, null, 5, true, "E", 8 },
                    { 75, true, null, 5, false, "E", 7 },
                    { 74, true, null, 5, true, "E", 6 },
                    { 73, true, null, 5, true, "E", 5 },
                    { 414, false, null, 25, false, "E", 6 },
                    { 415, true, null, 25, true, "E", 7 },
                    { 416, true, null, 25, false, "E", 8 },
                    { 417, true, null, 25, false, "E", 9 },
                    { 418, true, null, 25, true, "E", 10 },
                    { 419, false, null, 25, true, "E", 11 },
                    { 420, true, null, 25, false, "E", 12 },
                    { 195, false, null, 12, true, "E", 8 },
                    { 421, false, null, 25, false, "E", 13 },
                    { 423, true, null, 25, true, "E", 15 },
                    { 424, false, null, 25, true, "E", 16 },
                    { 425, true, null, 25, false, "E", 17 },
                    { 69, false, null, 5, false, "E", 1 },
                    { 70, false, null, 5, true, "E", 2 },
                    { 71, true, null, 5, true, "E", 3 },
                    { 72, true, null, 5, true, "E", 4 },
                    { 422, true, null, 25, false, "E", 14 },
                    { 357, false, null, 21, true, "E", 17 }
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
