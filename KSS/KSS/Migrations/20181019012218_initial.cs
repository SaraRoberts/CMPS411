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
                    BookPrice = table.Column<double>(nullable: true),
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
                    BookPrice = table.Column<double>(nullable: true)
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
                    { 15, "student14@student.com", "Amanda", "Catalonato", "7UXzXXBYzmkoUSVF1yF5qGdJfE08IXM48Bl7qHX+MRE=", "1112223333", "User", new byte[] { 91, 186, 92, 45, 166, 216, 1, 140, 227, 186, 159, 207, 212, 9, 61, 152 } },
                    { 14, "student13@student.com", "Tom", "Avers", "7UXzXXBYzmkoUSVF1yF5qGdJfE08IXM48Bl7qHX+MRE=", "1112223333", "User", new byte[] { 91, 186, 92, 45, 166, 216, 1, 140, 227, 186, 159, 207, 212, 9, 61, 152 } },
                    { 13, "student12@student.com", "Lucy", "Vilardo", "7UXzXXBYzmkoUSVF1yF5qGdJfE08IXM48Bl7qHX+MRE=", "1112223333", "User", new byte[] { 91, 186, 92, 45, 166, 216, 1, 140, 227, 186, 159, 207, 212, 9, 61, 152 } },
                    { 12, "student11@student.com", "Gary", "Aimes", "7UXzXXBYzmkoUSVF1yF5qGdJfE08IXM48Bl7qHX+MRE=", "1112223333", "User", new byte[] { 91, 186, 92, 45, 166, 216, 1, 140, 227, 186, 159, 207, 212, 9, 61, 152 } },
                    { 11, "student10@student.com", "Tim", "Hammond", "7UXzXXBYzmkoUSVF1yF5qGdJfE08IXM48Bl7qHX+MRE=", "1112223333", "User", new byte[] { 91, 186, 92, 45, 166, 216, 1, 140, 227, 186, 159, 207, 212, 9, 61, 152 } },
                    { 10, "student9@student.com", "Babe", "Ruth", "7UXzXXBYzmkoUSVF1yF5qGdJfE08IXM48Bl7qHX+MRE=", "1112223333", "User", new byte[] { 91, 186, 92, 45, 166, 216, 1, 140, 227, 186, 159, 207, 212, 9, 61, 152 } },
                    { 9, "student8@student.com", "Colin", "Livers", "7UXzXXBYzmkoUSVF1yF5qGdJfE08IXM48Bl7qHX+MRE=", "1112223333", "User", new byte[] { 91, 186, 92, 45, 166, 216, 1, 140, 227, 186, 159, 207, 212, 9, 61, 152 } },
                    { 5, "student4@student.com", "Sharon", "Manino", "7UXzXXBYzmkoUSVF1yF5qGdJfE08IXM48Bl7qHX+MRE=", "1112223333", "Staff", new byte[] { 91, 186, 92, 45, 166, 216, 1, 140, 227, 186, 159, 207, 212, 9, 61, 152 } },
                    { 7, "student6@student.com", "Bill", "Everet", "7UXzXXBYzmkoUSVF1yF5qGdJfE08IXM48Bl7qHX+MRE=", "1112223333", "User", new byte[] { 91, 186, 92, 45, 166, 216, 1, 140, 227, 186, 159, 207, 212, 9, 61, 152 } },
                    { 6, "student5@student.com", "Amy", "Hillbond", "7UXzXXBYzmkoUSVF1yF5qGdJfE08IXM48Bl7qHX+MRE=", "1112223333", "Staff", new byte[] { 91, 186, 92, 45, 166, 216, 1, 140, 227, 186, 159, 207, 212, 9, 61, 152 } },
                    { 16, "student15@student.com", "Donald", "Hill", "7UXzXXBYzmkoUSVF1yF5qGdJfE08IXM48Bl7qHX+MRE=", "1112223333", "User", new byte[] { 91, 186, 92, 45, 166, 216, 1, 140, 227, 186, 159, 207, 212, 9, 61, 152 } },
                    { 4, "student3@student.com", "Russel", "Chavers", "7UXzXXBYzmkoUSVF1yF5qGdJfE08IXM48Bl7qHX+MRE=", "1112223333", "Staff", new byte[] { 91, 186, 92, 45, 166, 216, 1, 140, 227, 186, 159, 207, 212, 9, 61, 152 } },
                    { 3, "student2@student.com", "Mike", "Waters", "7UXzXXBYzmkoUSVF1yF5qGdJfE08IXM48Bl7qHX+MRE=", "1112223333", "Staff", new byte[] { 91, 186, 92, 45, 166, 216, 1, 140, 227, 186, 159, 207, 212, 9, 61, 152 } },
                    { 2, "student1@student.com", "Paul", "Dig", "7UXzXXBYzmkoUSVF1yF5qGdJfE08IXM48Bl7qHX+MRE=", "1112223333", "Staff", new byte[] { 91, 186, 92, 45, 166, 216, 1, 140, 227, 186, 159, 207, 212, 9, 61, 152 } },
                    { 1, "admin@admin.com", "Becky", "Smith", "Y83/1zYFQjqvnszDAJwPRl5rHw+En5gZvfi8Az7wPFw=", "1112223333", "Admin", new byte[] { 45, 94, 70, 13, 81, 87, 239, 193, 161, 242, 224, 254, 70, 220, 185, 92 } },
                    { 8, "student7@student.com", "Trenton", "Hillsong", "7UXzXXBYzmkoUSVF1yF5qGdJfE08IXM48Bl7qHX+MRE=", "1112223333", "User", new byte[] { 91, 186, 92, 45, 166, 216, 1, 140, 227, 186, 159, 207, 212, 9, 61, 152 } },
                    { 17, "student16@student.com", "Richard", "Newman", "7UXzXXBYzmkoUSVF1yF5qGdJfE08IXM48Bl7qHX+MRE=", "1112223333", "User", new byte[] { 91, 186, 92, 45, 166, 216, 1, 140, 227, 186, 159, 207, 212, 9, 61, 152 } }
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
                    { 1, true, 25.0, 1, "A 4 ½ hour initial course designed for Healthcare Professionals.  The course covers Adult, Child, and Infant one-rescuer CPR AED, as well as a new focused emphasis on teamwork with the adult, child, and infant two-person rescue.  Topics also include Rescue Breathing and Foreign Body Airway Obstruction. Cost includes the use of a textbook, written and practical exams, and a course completion certification(good for 2 years).New 2015 Guidelines!", "Basic Life Support", null, 50 },
                    { 6, false, 0.0, 1, "A 6-8 hour First Aid course designed for childcare workers whose job requires a pediatric-specific first aid completion card.  This course provides the skills to effectively asses and maintain a child’s life in the critical minutes following an emergency until the arrival of emergency personnel.  This course covers all State of Louisiana required modules including Child Care specific topics, General Principles, Medical Emergencies, Injury Emergencies, and Environmental Emergencies.  Also includes CPR and AED training for Adult, Children, and Infants. Cost includes use of a textbook, skills, and course completion certification(good for 2 years).New 2015 Guidelines!", "Heartsaver Pediatric First Aid", null, 50 },
                    { 2, false, 0.0, 2, "A 4 hour refresher course for the Healthcare Professional; this course offers guidelines in one and two-rescuer adult, child, and infant CPR, Foreign Body Airway Obstruction, and AED training. Cost includes the use of a students’ textbook, written and practical exams, and course completion certification(good for 2 years).New 2015 Guidelines!", "Basic Life Support w/ CPR Refr", null, 50 },
                    { 5, true, 15.0, 2, "A 4 hour course designed for the general public or lay rescuer whose job requires a first aid course completion card.  The course provides the skills to effectively asses and maintain life from the critical minutes of an emergency until the arrival of emergency service personnel.  Depending on which modules the candidate wishes to take, the basic first aid course consists of General Principles, Medical Emergencies, and Injury Emergencies.  Also includes CPR and AED training, and Environmental Emergencies. Cost includes use of a textbook, practice exam, and course completion certificate(good for 2 years).New 2015 Guidelines!", "Heartsaver First Aid ", null, 50 },
                    { 7, false, 0.0, 2, "A 2 ½ hour entry level awareness program designed for the general public, parents, babysitters, grandparents, churches, clubs, etc.  The course covers American Heart Association guidelines for the one-rescuer adult including Pediatric CPR, relief of Foreign Body Airway Obstructions, the chain of survival, Basic First Aid, and recognizing the signs of a heart attack and stroke. Cost includes a student textbook.New 2016 Guidelines!", "Family and Friends CPR", null, 50 },
                    { 3, false, 0.0, 3, "For those who have successfully completed the online portion of either BLS course.  Students MUST provide a copy of the online course completion certificate. Cost includes practice time, exam, and course completion certificate(good for 2 years)", "BLS Online Recert – Part 2", 3, 0 },
                    { 4, true, 15.0, 4, "A 2-3 hour course designed to teach the lay rescuer (security guards, personal trainers, church organization teachers, etc.) how to recognize and treat life-threatening emergencies whose job requires a course completion card documenting one-rescuer adult and/or pediatric CPR, Foreign Body Airway Obstruction, and AED training. Cost includes the use of a textbook, practice exam, and course completion certificate(good for 2 years).New 2015 Guidelines!", "Heartsaver CPR/AED ", null, 50 }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "BookAvailable", "BookPrice", "CategoryId", "Description", "Name", "PrereqId", "TypicalPrice" },
                values: new object[,]
                {
                    { 8, false, 0.0, 2, "This is a 16 - 20 hour course for those who wish to become AHA Instructor Candidates able to teach various levels of American Heart Association CPR.  Course is taught over 2 or 3 days. Successful completion of AHA BLS for Healthcare Providers Course, as well as each module instructor candidates wish to teach(Heartsaver First Aid, Heartsaver CPR / AED, etc.), and scoring 90 % or better on written examination(within 90 days of the instructor course) is required for completion. A letter of recommendation and completion of Core Instructor Course is required before applying. Cost includes all student level books, instructor manuals, practical exams, and test.New 2015 Guidelines!", "BLS CPR, Instructor Course", 1, 50 },
                    { 9, false, 0.0, 1, "For those who have successfully completed the online portion of the Heartsaver CPR/AED course.  Students MUST provide a copy of the online course completion certificate. Cost includes practice time, exam, and course completion certificate(good for 2 years)", "CPR/AED Online Recert 2", 4, 50 },
                    { 10, false, 0.0, 2, "For those who have successfully completed the online portion of the Heartsaver First Aid course.  Students MUST provide a copy of the online course completion certificate. Cost includes practice time, exam, and course completion certificate(good for 2 years)", "First Aid Online Recert 2", 5, 50 }
                });

            migrationBuilder.InsertData(
                table: "Instance",
                columns: new[] { "InstanceId", "BookAvailable", "BookPrice", "CourseId", "Graded", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[,]
                {
                    { 10, true, 30.0, 4, false, 4, 2, 67.0, 27, new DateTimeOffset(new DateTime(2019, 4, 2, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 6, true, 51.0, 4, false, 5, 3, 87.0, 28, new DateTimeOffset(new DateTime(2016, 9, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 15, true, 22.0, 3, false, 5, 1, 122.0, 19, new DateTimeOffset(new DateTime(2019, 1, 22, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 2, true, 46.0, 3, false, 1, 3, 138.0, 28, new DateTimeOffset(new DateTime(2018, 4, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 1, true, 40.0, 3, false, 4, 2, 62.0, 28, new DateTimeOffset(new DateTime(2016, 4, 6, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 29, true, 32.0, 7, false, 1, 2, 148.0, 18, new DateTimeOffset(new DateTime(2016, 10, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 26, true, 46.0, 7, false, 6, 1, 95.0, 21, new DateTimeOffset(new DateTime(2019, 11, 27, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 25, true, 33.0, 7, false, 4, 1, 82.0, 21, new DateTimeOffset(new DateTime(2018, 2, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 18, true, 18.0, 7, false, 2, 3, 139.0, 22, new DateTimeOffset(new DateTime(2019, 4, 8, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 8, true, 50.0, 7, false, 3, 2, 128.0, 16, new DateTimeOffset(new DateTime(2019, 1, 17, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 27, true, 25.0, 5, false, 6, 1, 102.0, 27, new DateTimeOffset(new DateTime(2019, 1, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 13, true, 24.0, 5, false, 4, 1, 128.0, 23, new DateTimeOffset(new DateTime(2017, 3, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 24, true, 21.0, 2, false, 4, 1, 117.0, 23, new DateTimeOffset(new DateTime(2017, 10, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 22, true, 38.0, 2, false, 4, 1, 92.0, 10, new DateTimeOffset(new DateTime(2019, 7, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 9, true, 30.0, 2, false, 5, 2, 77.0, 18, new DateTimeOffset(new DateTime(2017, 12, 17, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 12, true, 31.0, 6, false, 4, 2, 50.0, 27, new DateTimeOffset(new DateTime(2016, 4, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 11, true, 52.0, 6, false, 3, 1, 83.0, 19, new DateTimeOffset(new DateTime(2016, 12, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 5, true, 27.0, 6, false, 5, 2, 76.0, 16, new DateTimeOffset(new DateTime(2018, 5, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 4, true, 45.0, 6, false, 4, 3, 87.0, 12, new DateTimeOffset(new DateTime(2018, 3, 10, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 20, true, 27.0, 1, false, 5, 1, 144.0, 27, new DateTimeOffset(new DateTime(2017, 1, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 19, true, 24.0, 4, false, 1, 1, 109.0, 24, new DateTimeOffset(new DateTime(2019, 4, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 28, true, 42.0, 4, false, 5, 1, 73.0, 15, new DateTimeOffset(new DateTime(2018, 3, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "EnrollmentId", "BookBought", "Confirmed", "InstanceId", "Paid", "Status", "UserId" },
                values: new object[,]
                {
                    { 135, true, null, 8, false, "E", 16 },
                    { 491, false, null, 29, true, "E", 15 },
                    { 490, false, null, 29, true, "E", 14 },
                    { 489, true, null, 29, false, "E", 13 },
                    { 488, true, null, 29, false, "E", 12 },
                    { 487, true, null, 29, false, "E", 11 },
                    { 486, true, null, 29, true, "E", 10 },
                    { 485, false, null, 29, true, "E", 9 },
                    { 484, true, null, 29, true, "E", 8 },
                    { 483, true, null, 29, false, "E", 7 },
                    { 482, false, null, 29, false, "E", 6 },
                    { 481, true, null, 29, false, "E", 5 },
                    { 480, true, null, 29, false, "E", 4 },
                    { 479, true, null, 29, false, "E", 3 },
                    { 478, false, null, 29, true, "E", 2 },
                    { 477, true, null, 29, false, "E", 1 },
                    { 442, true, null, 26, false, "E", 17 },
                    { 441, true, null, 26, true, "E", 16 },
                    { 440, true, null, 26, false, "E", 15 },
                    { 439, false, null, 26, false, "E", 14 },
                    { 492, false, null, 29, true, "E", 16 },
                    { 493, true, null, 29, true, "E", 17 },
                    { 1, false, null, 1, false, "E", 1 },
                    { 2, false, null, 1, false, "E", 2 },
                    { 22, true, null, 2, true, "E", 5 },
                    { 21, false, null, 2, false, "E", 4 },
                    { 20, false, null, 2, false, "E", 3 },
                    { 19, false, null, 2, true, "E", 2 },
                    { 18, false, null, 2, false, "E", 1 },
                    { 17, true, null, 1, true, "E", 17 },
                    { 16, false, null, 1, false, "E", 16 },
                    { 15, true, null, 1, false, "E", 15 },
                    { 14, false, null, 1, false, "E", 14 },
                    { 438, false, null, 26, true, "E", 13 },
                    { 13, true, null, 1, false, "E", 13 },
                    { 11, true, null, 1, true, "E", 11 },
                    { 10, false, null, 1, false, "E", 10 },
                    { 9, true, null, 1, false, "E", 9 },
                    { 8, false, null, 1, true, "E", 8 },
                    { 7, false, null, 1, true, "E", 7 },
                    { 6, false, null, 1, false, "E", 6 },
                    { 5, true, null, 1, true, "E", 5 },
                    { 4, true, null, 1, true, "E", 4 },
                    { 3, false, null, 1, false, "E", 3 },
                    { 12, false, null, 1, true, "E", 12 },
                    { 437, false, null, 26, true, "E", 12 },
                    { 436, true, null, 26, true, "E", 11 },
                    { 435, true, null, 26, false, "E", 10 },
                    { 410, true, null, 25, true, "E", 2 },
                    { 409, true, null, 25, true, "E", 1 },
                    { 306, true, null, 18, true, "E", 17 },
                    { 305, true, null, 18, false, "E", 16 },
                    { 304, false, null, 18, true, "E", 15 },
                    { 303, false, null, 18, false, "E", 14 },
                    { 302, false, null, 18, true, "E", 13 },
                    { 301, true, null, 18, false, "E", 12 },
                    { 300, true, null, 18, false, "E", 11 },
                    { 411, true, null, 25, false, "E", 3 },
                    { 299, true, null, 18, true, "E", 10 },
                    { 297, true, null, 18, false, "E", 8 },
                    { 296, false, null, 18, false, "E", 7 },
                    { 295, false, null, 18, false, "E", 6 },
                    { 294, true, null, 18, false, "E", 5 },
                    { 293, false, null, 18, true, "E", 4 },
                    { 292, false, null, 18, true, "E", 3 },
                    { 291, true, null, 18, true, "E", 2 },
                    { 290, true, null, 18, true, "E", 1 },
                    { 136, false, null, 8, false, "E", 17 },
                    { 298, true, null, 18, false, "E", 9 },
                    { 23, true, null, 2, false, "E", 6 },
                    { 412, false, null, 25, false, "E", 4 },
                    { 414, false, null, 25, false, "E", 6 },
                    { 434, true, null, 26, false, "E", 9 },
                    { 433, false, null, 26, false, "E", 8 },
                    { 432, true, null, 26, true, "E", 7 },
                    { 431, true, null, 26, true, "E", 6 },
                    { 430, true, null, 26, false, "E", 5 },
                    { 429, false, null, 26, true, "E", 4 },
                    { 428, false, null, 26, false, "E", 3 },
                    { 427, true, null, 26, true, "E", 2 },
                    { 426, true, null, 26, false, "E", 1 },
                    { 413, true, null, 25, false, "E", 5 },
                    { 425, true, null, 25, true, "E", 17 },
                    { 423, false, null, 25, false, "E", 15 },
                    { 422, false, null, 25, false, "E", 14 },
                    { 421, false, null, 25, true, "E", 13 },
                    { 420, false, null, 25, true, "E", 12 },
                    { 419, true, null, 25, false, "E", 11 },
                    { 418, false, null, 25, true, "E", 10 },
                    { 417, true, null, 25, true, "E", 9 },
                    { 416, false, null, 25, false, "E", 8 },
                    { 415, true, null, 25, false, "E", 7 },
                    { 424, true, null, 25, false, "E", 16 },
                    { 475, true, null, 28, true, "E", 16 },
                    { 24, true, null, 2, false, "E", 7 },
                    { 26, true, null, 2, false, "E", 9 },
                    { 314, true, null, 19, false, "E", 8 },
                    { 313, true, null, 19, false, "E", 7 },
                    { 312, false, null, 19, true, "E", 6 },
                    { 311, false, null, 19, false, "E", 5 },
                    { 310, false, null, 19, false, "E", 4 },
                    { 309, true, null, 19, true, "E", 3 },
                    { 308, true, null, 19, false, "E", 2 },
                    { 307, true, null, 19, true, "E", 1 },
                    { 170, false, null, 10, true, "E", 17 },
                    { 169, false, null, 10, true, "E", 16 },
                    { 168, true, null, 10, false, "E", 15 },
                    { 167, true, null, 10, true, "E", 14 },
                    { 166, false, null, 10, false, "E", 13 },
                    { 165, true, null, 10, true, "E", 12 },
                    { 164, true, null, 10, false, "E", 11 },
                    { 163, true, null, 10, false, "E", 10 },
                    { 162, true, null, 10, true, "E", 9 },
                    { 161, false, null, 10, false, "E", 8 },
                    { 160, false, null, 10, true, "E", 7 },
                    { 315, true, null, 19, false, "E", 9 },
                    { 316, false, null, 19, false, "E", 10 },
                    { 317, false, null, 19, false, "E", 11 },
                    { 318, true, null, 19, false, "E", 12 },
                    { 474, true, null, 28, true, "E", 15 },
                    { 473, true, null, 28, false, "E", 14 },
                    { 472, true, null, 28, true, "E", 13 },
                    { 471, false, null, 28, true, "E", 12 },
                    { 470, false, null, 28, false, "E", 11 },
                    { 469, true, null, 28, false, "E", 10 },
                    { 468, true, null, 28, true, "E", 9 },
                    { 467, true, null, 28, false, "E", 8 },
                    { 466, true, null, 28, true, "E", 7 },
                    { 159, false, null, 10, true, "E", 6 },
                    { 465, false, null, 28, false, "E", 6 },
                    { 463, true, null, 28, false, "E", 4 },
                    { 462, true, null, 28, false, "E", 3 },
                    { 461, false, null, 28, true, "E", 2 },
                    { 460, false, null, 28, true, "E", 1 },
                    { 323, false, null, 19, false, "E", 17 },
                    { 322, false, null, 19, true, "E", 16 },
                    { 321, true, null, 19, true, "E", 15 },
                    { 320, false, null, 19, false, "E", 14 },
                    { 319, false, null, 19, true, "E", 13 },
                    { 464, true, null, 28, true, "E", 5 },
                    { 158, false, null, 10, true, "E", 5 },
                    { 157, false, null, 10, true, "E", 4 },
                    { 156, true, null, 10, false, "E", 3 },
                    { 250, true, null, 15, false, "E", 12 },
                    { 249, true, null, 15, false, "E", 11 },
                    { 248, true, null, 15, false, "E", 10 },
                    { 247, true, null, 15, true, "E", 9 },
                    { 246, false, null, 15, false, "E", 8 },
                    { 245, true, null, 15, false, "E", 7 },
                    { 244, false, null, 15, true, "E", 6 },
                    { 243, false, null, 15, true, "E", 5 },
                    { 242, false, null, 15, false, "E", 4 },
                    { 251, false, null, 15, true, "E", 13 },
                    { 241, false, null, 15, false, "E", 3 },
                    { 239, false, null, 15, false, "E", 1 },
                    { 34, true, null, 2, false, "E", 17 },
                    { 33, false, null, 2, true, "E", 16 },
                    { 32, false, null, 2, false, "E", 15 },
                    { 31, false, null, 2, false, "E", 14 },
                    { 30, false, null, 2, true, "E", 13 },
                    { 29, false, null, 2, true, "E", 12 },
                    { 28, false, null, 2, false, "E", 11 },
                    { 27, false, null, 2, true, "E", 10 },
                    { 240, true, null, 15, false, "E", 2 },
                    { 25, false, null, 2, false, "E", 8 },
                    { 252, true, null, 15, false, "E", 14 },
                    { 254, false, null, 15, false, "E", 16 },
                    { 155, false, null, 10, true, "E", 2 },
                    { 154, true, null, 10, true, "E", 1 },
                    { 102, true, null, 6, true, "E", 17 },
                    { 101, false, null, 6, false, "E", 16 },
                    { 100, false, null, 6, true, "E", 15 },
                    { 99, true, null, 6, false, "E", 14 },
                    { 98, false, null, 6, true, "E", 13 },
                    { 97, false, null, 6, false, "E", 12 },
                    { 96, true, null, 6, false, "E", 11 },
                    { 253, true, null, 15, true, "E", 15 },
                    { 95, false, null, 6, true, "E", 10 },
                    { 93, false, null, 6, false, "E", 8 },
                    { 92, false, null, 6, true, "E", 7 },
                    { 91, true, null, 6, true, "E", 6 },
                    { 90, true, null, 6, true, "E", 5 },
                    { 89, false, null, 6, true, "E", 4 },
                    { 88, false, null, 6, false, "E", 3 },
                    { 87, true, null, 6, true, "E", 2 },
                    { 86, false, null, 6, true, "E", 1 },
                    { 255, false, null, 15, true, "E", 17 },
                    { 94, false, null, 6, false, "E", 9 },
                    { 134, true, null, 8, false, "E", 15 },
                    { 476, true, null, 28, false, "E", 17 },
                    { 132, true, null, 8, false, "E", 13 },
                    { 185, false, null, 11, true, "E", 15 },
                    { 184, false, null, 11, false, "E", 14 },
                    { 183, false, null, 11, true, "E", 13 },
                    { 182, false, null, 11, false, "E", 12 },
                    { 181, false, null, 11, true, "E", 11 },
                    { 180, true, null, 11, false, "E", 10 },
                    { 179, true, null, 11, true, "E", 9 },
                    { 178, false, null, 11, false, "E", 8 },
                    { 177, false, null, 11, false, "E", 7 },
                    { 176, false, null, 11, true, "E", 6 },
                    { 175, false, null, 11, false, "E", 5 },
                    { 174, false, null, 11, false, "E", 4 },
                    { 173, true, null, 11, true, "E", 3 },
                    { 172, false, null, 11, true, "E", 2 },
                    { 171, false, null, 11, true, "E", 1 },
                    { 85, false, null, 5, false, "E", 17 },
                    { 84, false, null, 5, true, "E", 16 },
                    { 83, true, null, 5, true, "E", 15 },
                    { 82, false, null, 5, false, "E", 14 },
                    { 186, true, null, 11, false, "E", 16 },
                    { 81, true, null, 5, true, "E", 13 },
                    { 187, true, null, 11, false, "E", 17 },
                    { 189, false, null, 12, true, "E", 2 },
                    { 133, true, null, 8, false, "E", 14 },
                    { 139, true, null, 9, true, "E", 3 },
                    { 138, false, null, 9, true, "E", 2 },
                    { 137, true, null, 9, true, "E", 1 },
                    { 204, false, null, 12, true, "E", 17 },
                    { 203, true, null, 12, true, "E", 16 },
                    { 202, false, null, 12, true, "E", 15 },
                    { 201, true, null, 12, true, "E", 14 },
                    { 200, true, null, 12, true, "E", 13 },
                    { 199, true, null, 12, false, "E", 12 },
                    { 198, true, null, 12, false, "E", 11 },
                    { 197, false, null, 12, false, "E", 10 },
                    { 196, true, null, 12, false, "E", 9 },
                    { 195, false, null, 12, true, "E", 8 },
                    { 194, false, null, 12, true, "E", 7 },
                    { 193, true, null, 12, false, "E", 6 },
                    { 192, true, null, 12, false, "E", 5 },
                    { 191, false, null, 12, false, "E", 4 },
                    { 190, false, null, 12, false, "E", 3 },
                    { 188, true, null, 12, false, "E", 1 },
                    { 80, true, null, 5, false, "E", 12 },
                    { 79, true, null, 5, false, "E", 11 },
                    { 78, false, null, 5, false, "E", 10 },
                    { 53, true, null, 4, true, "E", 2 },
                    { 52, true, null, 4, false, "E", 1 },
                    { 340, false, null, 20, false, "E", 17 },
                    { 339, true, null, 20, false, "E", 16 },
                    { 338, true, null, 20, true, "E", 15 },
                    { 337, false, null, 20, false, "E", 14 },
                    { 336, false, null, 20, false, "E", 13 },
                    { 335, true, null, 20, false, "E", 12 },
                    { 334, false, null, 20, true, "E", 11 },
                    { 333, true, null, 20, true, "E", 10 },
                    { 332, false, null, 20, false, "E", 9 },
                    { 331, true, null, 20, true, "E", 8 },
                    { 330, false, null, 20, false, "E", 7 },
                    { 329, true, null, 20, true, "E", 6 },
                    { 328, true, null, 20, true, "E", 5 },
                    { 327, false, null, 20, false, "E", 4 },
                    { 326, true, null, 20, true, "E", 3 },
                    { 325, true, null, 20, false, "E", 2 },
                    { 324, false, null, 20, true, "E", 1 },
                    { 54, false, null, 4, false, "E", 3 },
                    { 55, true, null, 4, true, "E", 4 },
                    { 56, false, null, 4, true, "E", 5 },
                    { 57, true, null, 4, false, "E", 6 },
                    { 77, false, null, 5, false, "E", 9 },
                    { 76, true, null, 5, true, "E", 8 },
                    { 75, false, null, 5, true, "E", 7 },
                    { 74, true, null, 5, true, "E", 6 },
                    { 73, true, null, 5, false, "E", 5 },
                    { 72, true, null, 5, true, "E", 4 },
                    { 71, false, null, 5, false, "E", 3 },
                    { 70, false, null, 5, false, "E", 2 },
                    { 69, false, null, 5, false, "E", 1 },
                    { 141, true, null, 9, true, "E", 5 },
                    { 68, false, null, 4, true, "E", 17 },
                    { 66, true, null, 4, true, "E", 15 },
                    { 65, false, null, 4, false, "E", 14 },
                    { 64, true, null, 4, false, "E", 13 },
                    { 63, false, null, 4, true, "E", 12 },
                    { 62, true, null, 4, true, "E", 11 },
                    { 61, false, null, 4, false, "E", 10 },
                    { 60, true, null, 4, true, "E", 9 },
                    { 59, true, null, 4, false, "E", 8 },
                    { 58, true, null, 4, true, "E", 7 },
                    { 67, true, null, 4, false, "E", 16 },
                    { 142, true, null, 9, true, "E", 6 },
                    { 140, false, null, 9, false, "E", 4 },
                    { 144, false, null, 9, false, "E", 8 },
                    { 447, false, null, 27, false, "E", 5 },
                    { 446, false, null, 27, true, "E", 4 },
                    { 445, false, null, 27, true, "E", 3 },
                    { 444, true, null, 27, false, "E", 2 },
                    { 443, false, null, 27, false, "E", 1 },
                    { 221, false, null, 13, false, "E", 17 },
                    { 220, false, null, 13, true, "E", 16 },
                    { 219, false, null, 13, false, "E", 15 },
                    { 218, false, null, 13, false, "E", 14 },
                    { 448, false, null, 27, true, "E", 6 },
                    { 217, false, null, 13, false, "E", 13 },
                    { 215, false, null, 13, false, "E", 11 },
                    { 214, true, null, 13, false, "E", 10 },
                    { 213, false, null, 13, false, "E", 9 },
                    { 212, true, null, 13, false, "E", 8 }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "EnrollmentId", "BookBought", "Confirmed", "InstanceId", "Paid", "Status", "UserId" },
                values: new object[,]
                {
                    { 211, true, null, 13, false, "E", 7 },
                    { 210, false, null, 13, false, "E", 6 },
                    { 209, true, null, 13, true, "E", 5 },
                    { 208, false, null, 13, true, "E", 4 },
                    { 207, false, null, 13, true, "E", 3 },
                    { 216, true, null, 13, true, "E", 12 },
                    { 143, true, null, 9, true, "E", 7 },
                    { 449, true, null, 27, false, "E", 7 },
                    { 451, true, null, 27, true, "E", 9 },
                    { 131, false, null, 8, true, "E", 12 },
                    { 130, false, null, 8, false, "E", 11 },
                    { 129, false, null, 8, true, "E", 10 },
                    { 128, false, null, 8, true, "E", 9 },
                    { 127, false, null, 8, false, "E", 8 },
                    { 126, true, null, 8, false, "E", 7 },
                    { 125, true, null, 8, true, "E", 6 },
                    { 124, false, null, 8, false, "E", 5 },
                    { 123, true, null, 8, false, "E", 4 },
                    { 450, false, null, 27, false, "E", 8 },
                    { 122, true, null, 8, false, "E", 3 },
                    { 120, true, null, 8, false, "E", 1 },
                    { 459, true, null, 27, true, "E", 17 },
                    { 458, true, null, 27, true, "E", 16 },
                    { 457, false, null, 27, false, "E", 15 },
                    { 456, false, null, 27, false, "E", 14 },
                    { 455, true, null, 27, false, "E", 13 },
                    { 454, false, null, 27, true, "E", 12 },
                    { 453, true, null, 27, false, "E", 11 },
                    { 452, false, null, 27, false, "E", 10 },
                    { 121, true, null, 8, true, "E", 2 },
                    { 205, true, null, 13, false, "E", 1 },
                    { 206, false, null, 13, true, "E", 2 },
                    { 408, true, null, 24, true, "E", 17 },
                    { 367, false, null, 22, true, "E", 10 },
                    { 366, false, null, 22, true, "E", 9 },
                    { 365, true, null, 22, false, "E", 8 },
                    { 364, true, null, 22, false, "E", 7 },
                    { 363, true, null, 22, true, "E", 6 },
                    { 362, false, null, 22, true, "E", 5 },
                    { 361, true, null, 22, false, "E", 4 },
                    { 360, false, null, 22, false, "E", 3 },
                    { 359, false, null, 22, true, "E", 2 },
                    { 358, true, null, 22, false, "E", 1 },
                    { 153, false, null, 9, true, "E", 17 },
                    { 152, true, null, 9, true, "E", 16 },
                    { 151, true, null, 9, false, "E", 15 },
                    { 150, true, null, 9, false, "E", 14 },
                    { 149, true, null, 9, true, "E", 13 },
                    { 148, false, null, 9, false, "E", 12 },
                    { 147, false, null, 9, true, "E", 11 },
                    { 146, false, null, 9, false, "E", 10 },
                    { 145, false, null, 9, true, "E", 9 },
                    { 368, true, null, 22, true, "E", 11 },
                    { 370, true, null, 22, true, "E", 13 },
                    { 369, true, null, 22, true, "E", 12 },
                    { 372, false, null, 22, false, "E", 15 },
                    { 407, true, null, 24, true, "E", 16 },
                    { 406, false, null, 24, true, "E", 15 },
                    { 405, false, null, 24, false, "E", 14 },
                    { 404, true, null, 24, true, "E", 13 },
                    { 403, false, null, 24, true, "E", 12 },
                    { 402, false, null, 24, true, "E", 11 },
                    { 401, true, null, 24, true, "E", 10 },
                    { 400, false, null, 24, false, "E", 9 },
                    { 371, false, null, 22, false, "E", 14 },
                    { 398, false, null, 24, true, "E", 7 },
                    { 399, true, null, 24, false, "E", 8 },
                    { 396, false, null, 24, false, "E", 5 },
                    { 395, true, null, 24, true, "E", 4 },
                    { 394, false, null, 24, false, "E", 3 },
                    { 393, true, null, 24, false, "E", 2 },
                    { 392, true, null, 24, true, "E", 1 },
                    { 374, false, null, 22, false, "E", 17 },
                    { 373, false, null, 22, true, "E", 16 },
                    { 397, false, null, 24, true, "E", 6 }
                });

            migrationBuilder.InsertData(
                table: "Instance",
                columns: new[] { "InstanceId", "BookAvailable", "BookPrice", "CourseId", "Graded", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[,]
                {
                    { 21, true, 47.0, 9, false, 2, 1, 66.0, 18, new DateTimeOffset(new DateTime(2018, 7, 24, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 7, true, 23.0, 9, false, 6, 2, 73.0, 13, new DateTimeOffset(new DateTime(2016, 8, 3, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 3, true, 34.0, 10, false, 5, 1, 139.0, 27, new DateTimeOffset(new DateTime(2018, 10, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 23, true, 19.0, 8, false, 3, 3, 62.0, 17, new DateTimeOffset(new DateTime(2018, 11, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 17, true, 18.0, 8, false, 2, 2, 64.0, 11, new DateTimeOffset(new DateTime(2019, 4, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 16, true, 35.0, 8, false, 5, 3, 86.0, 16, new DateTimeOffset(new DateTime(2018, 6, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 14, true, 35.0, 8, false, 2, 3, 129.0, 17, new DateTimeOffset(new DateTime(2019, 12, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "EnrollmentId", "BookBought", "Confirmed", "InstanceId", "Paid", "Status", "UserId" },
                values: new object[,]
                {
                    { 222, false, null, 14, false, "E", 1 },
                    { 104, false, null, 7, true, "E", 2 },
                    { 103, false, null, 7, false, "E", 1 },
                    { 51, false, null, 3, false, "E", 17 },
                    { 50, true, null, 3, false, "E", 16 },
                    { 49, true, null, 3, false, "E", 15 },
                    { 48, false, null, 3, true, "E", 14 },
                    { 47, false, null, 3, true, "E", 13 },
                    { 46, false, null, 3, true, "E", 12 },
                    { 45, true, null, 3, true, "E", 11 },
                    { 44, false, null, 3, true, "E", 10 },
                    { 43, true, null, 3, false, "E", 9 },
                    { 42, false, null, 3, false, "E", 8 },
                    { 105, true, null, 7, true, "E", 3 },
                    { 41, true, null, 3, false, "E", 7 },
                    { 39, true, null, 3, false, "E", 5 },
                    { 38, false, null, 3, true, "E", 4 },
                    { 37, false, null, 3, true, "E", 3 },
                    { 36, true, null, 3, false, "E", 2 },
                    { 35, false, null, 3, false, "E", 1 },
                    { 391, true, null, 23, true, "E", 17 },
                    { 390, true, null, 23, true, "E", 16 },
                    { 389, true, null, 23, false, "E", 15 },
                    { 388, false, null, 23, false, "E", 14 },
                    { 387, true, null, 23, true, "E", 13 },
                    { 386, true, null, 23, false, "E", 12 },
                    { 385, false, null, 23, true, "E", 11 },
                    { 40, true, null, 3, true, "E", 6 },
                    { 384, false, null, 23, false, "E", 10 },
                    { 106, false, null, 7, false, "E", 4 },
                    { 108, false, null, 7, false, "E", 6 },
                    { 355, true, null, 21, false, "E", 15 },
                    { 354, true, null, 21, false, "E", 14 },
                    { 353, false, null, 21, false, "E", 13 },
                    { 352, false, null, 21, true, "E", 12 },
                    { 351, false, null, 21, false, "E", 11 },
                    { 350, false, null, 21, true, "E", 10 },
                    { 349, true, null, 21, true, "E", 9 },
                    { 348, false, null, 21, false, "E", 8 },
                    { 347, false, null, 21, false, "E", 7 },
                    { 346, false, null, 21, false, "E", 6 },
                    { 345, false, null, 21, false, "E", 5 },
                    { 344, true, null, 21, false, "E", 4 },
                    { 107, false, null, 7, false, "E", 5 },
                    { 343, true, null, 21, true, "E", 3 },
                    { 341, false, null, 21, true, "E", 1 },
                    { 119, true, null, 7, false, "E", 17 },
                    { 118, false, null, 7, false, "E", 16 },
                    { 117, true, null, 7, true, "E", 15 },
                    { 116, false, null, 7, true, "E", 14 },
                    { 115, true, null, 7, true, "E", 13 },
                    { 114, true, null, 7, false, "E", 12 },
                    { 113, true, null, 7, false, "E", 11 },
                    { 112, false, null, 7, false, "E", 10 },
                    { 111, true, null, 7, true, "E", 9 },
                    { 110, false, null, 7, true, "E", 8 },
                    { 109, true, null, 7, false, "E", 7 },
                    { 342, true, null, 21, false, "E", 2 },
                    { 356, true, null, 21, false, "E", 16 },
                    { 383, true, null, 23, false, "E", 9 },
                    { 381, false, null, 23, false, "E", 7 },
                    { 265, true, null, 16, true, "E", 10 },
                    { 264, true, null, 16, true, "E", 9 },
                    { 263, false, null, 16, true, "E", 8 },
                    { 262, false, null, 16, true, "E", 7 },
                    { 261, false, null, 16, false, "E", 6 },
                    { 260, false, null, 16, false, "E", 5 },
                    { 259, true, null, 16, false, "E", 4 },
                    { 258, false, null, 16, true, "E", 3 },
                    { 257, false, null, 16, false, "E", 2 },
                    { 256, true, null, 16, true, "E", 1 },
                    { 238, true, null, 14, false, "E", 17 },
                    { 237, true, null, 14, true, "E", 16 },
                    { 266, true, null, 16, true, "E", 11 },
                    { 236, true, null, 14, true, "E", 15 },
                    { 234, true, null, 14, false, "E", 13 },
                    { 233, false, null, 14, false, "E", 12 },
                    { 232, false, null, 14, true, "E", 11 },
                    { 231, false, null, 14, true, "E", 10 },
                    { 230, false, null, 14, true, "E", 9 },
                    { 229, false, null, 14, true, "E", 8 },
                    { 228, false, null, 14, false, "E", 7 },
                    { 227, true, null, 14, false, "E", 6 },
                    { 226, true, null, 14, true, "E", 5 },
                    { 225, false, null, 14, false, "E", 4 },
                    { 224, true, null, 14, true, "E", 3 },
                    { 223, true, null, 14, true, "E", 2 },
                    { 235, false, null, 14, true, "E", 14 },
                    { 382, true, null, 23, false, "E", 8 },
                    { 267, true, null, 16, true, "E", 12 },
                    { 269, true, null, 16, true, "E", 14 },
                    { 380, true, null, 23, false, "E", 6 },
                    { 379, true, null, 23, false, "E", 5 },
                    { 378, true, null, 23, false, "E", 4 },
                    { 377, false, null, 23, false, "E", 3 },
                    { 376, true, null, 23, true, "E", 2 },
                    { 375, false, null, 23, false, "E", 1 },
                    { 289, true, null, 17, false, "E", 17 },
                    { 288, true, null, 17, false, "E", 16 },
                    { 287, true, null, 17, true, "E", 15 },
                    { 286, false, null, 17, false, "E", 14 },
                    { 285, false, null, 17, true, "E", 13 },
                    { 284, false, null, 17, true, "E", 12 },
                    { 268, false, null, 16, true, "E", 13 },
                    { 283, false, null, 17, false, "E", 11 },
                    { 281, true, null, 17, false, "E", 9 },
                    { 280, false, null, 17, false, "E", 8 },
                    { 279, true, null, 17, true, "E", 7 },
                    { 278, false, null, 17, true, "E", 6 },
                    { 277, false, null, 17, false, "E", 5 },
                    { 276, false, null, 17, true, "E", 4 },
                    { 275, false, null, 17, true, "E", 3 },
                    { 274, true, null, 17, false, "E", 2 },
                    { 273, false, null, 17, true, "E", 1 },
                    { 272, false, null, 16, false, "E", 17 },
                    { 271, true, null, 16, false, "E", 16 },
                    { 270, true, null, 16, true, "E", 15 },
                    { 282, false, null, 17, true, "E", 10 },
                    { 357, false, null, 21, false, "E", 17 }
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
