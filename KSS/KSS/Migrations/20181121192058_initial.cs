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
                    Name = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
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
                columns: new[] { "CategoryId", "Description", "Name", "Title" },
                values: new object[,]
                {
                    { 1, "Learn CPR, a medical procedure involving specific compression of a patient's chest, performed in an attempt to bring back the blood circulation and breathing of a person who has suffered cardiac arrest.", "CPR", "CPR, Life Support, and First Aid" },
                    { 2, "Interested in becoming an EMT? An EMT is a specially trained technician certified to provide basic emergency services before and during transportation to a hospital.", "EMT", "Emergency Medical Technician" },
                    { 3, "In case of a medical emergency, learn techniques and procedures for helping others in need of immediate attention and treating minor wounds.", "EMR", "Emergency Medical Responder" },
                    { 4, "These courses teach applicable safety practices for individuals such as swim coaches, lifeguard instructors, and even professional rescuers.", "AQU", "Aquatic Rescue" },
                    { 5, "Learn how to properly conduct child safety seat checks and be informed on the best way to utilize and understand seat belts and child restraint systems while in motorized vehicles.", "CAR", "Car Seat Safety" },
                    { 6, "Babysitting can sometimes be difficult, but our courses teach babysitting skills, such as leadership, keeping children safe, and helping kids to behave, to anyone who wants to learn or even grow a babysitting business.", "BBS", "Babysitting Safety" }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "LocationId", "City", "Name", "State", "Street", "Zipcode" },
                values: new object[,]
                {
                    { 5, "Slidell", "Slidell Fire Department", "LA", "375 Bouscaren St", 70458 },
                    { 4, "Mandeville", "Mandeville Fire Department", "LA", "24301 Highway 190", 70448 },
                    { 3, "Independence", "Independence Fire", "LA", "12044 Hwy 40", 70443 },
                    { 2, "Tickfaw", "Tickfaw Emergency Care", "LA", "92 Hill Street", 70442 },
                    { 1, "Hammond", "Hammond Fire Department", "LA", "405 S. Oak Street", 70403 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "FirstName", "LastName", "Password", "Phone", "Role", "Salt" },
                values: new object[,]
                {
                    { 15, "student14@student.com", "Amanda", "Catalonato", "tTGoGl9PIPS9YSEu/c9LkazCnUrfXHw/mtJkKB20N9E=", "1112223333", "User", new byte[] { 88, 212, 89, 176, 181, 249, 18, 55, 27, 255, 40, 10, 197, 150, 173, 162 } },
                    { 14, "student13@student.com", "Tom", "Avers", "tTGoGl9PIPS9YSEu/c9LkazCnUrfXHw/mtJkKB20N9E=", "1112223333", "User", new byte[] { 88, 212, 89, 176, 181, 249, 18, 55, 27, 255, 40, 10, 197, 150, 173, 162 } },
                    { 13, "student12@student.com", "Lucy", "Vilardo", "tTGoGl9PIPS9YSEu/c9LkazCnUrfXHw/mtJkKB20N9E=", "1112223333", "User", new byte[] { 88, 212, 89, 176, 181, 249, 18, 55, 27, 255, 40, 10, 197, 150, 173, 162 } },
                    { 12, "student11@student.com", "Gary", "Aimes", "tTGoGl9PIPS9YSEu/c9LkazCnUrfXHw/mtJkKB20N9E=", "1112223333", "User", new byte[] { 88, 212, 89, 176, 181, 249, 18, 55, 27, 255, 40, 10, 197, 150, 173, 162 } },
                    { 11, "student10@student.com", "Tim", "Hammond", "tTGoGl9PIPS9YSEu/c9LkazCnUrfXHw/mtJkKB20N9E=", "1112223333", "User", new byte[] { 88, 212, 89, 176, 181, 249, 18, 55, 27, 255, 40, 10, 197, 150, 173, 162 } },
                    { 10, "student9@student.com", "Babe", "Ruth", "tTGoGl9PIPS9YSEu/c9LkazCnUrfXHw/mtJkKB20N9E=", "1112223333", "User", new byte[] { 88, 212, 89, 176, 181, 249, 18, 55, 27, 255, 40, 10, 197, 150, 173, 162 } },
                    { 9, "student8@student.com", "Colin", "Livers", "tTGoGl9PIPS9YSEu/c9LkazCnUrfXHw/mtJkKB20N9E=", "1112223333", "User", new byte[] { 88, 212, 89, 176, 181, 249, 18, 55, 27, 255, 40, 10, 197, 150, 173, 162 } },
                    { 3, "student2@student.com", "Dennis", "Pitts", "tTGoGl9PIPS9YSEu/c9LkazCnUrfXHw/mtJkKB20N9E=", "1112223333", "Staff", new byte[] { 88, 212, 89, 176, 181, 249, 18, 55, 27, 255, 40, 10, 197, 150, 173, 162 } },
                    { 7, "student6@student.com", "Jackie", "Smith", "tTGoGl9PIPS9YSEu/c9LkazCnUrfXHw/mtJkKB20N9E=", "1112223333", "Staff", new byte[] { 88, 212, 89, 176, 181, 249, 18, 55, 27, 255, 40, 10, 197, 150, 173, 162 } },
                    { 6, "student5@student.com", "Savannah", "Rachel", "tTGoGl9PIPS9YSEu/c9LkazCnUrfXHw/mtJkKB20N9E=", "1112223333", "Staff", new byte[] { 88, 212, 89, 176, 181, 249, 18, 55, 27, 255, 40, 10, 197, 150, 173, 162 } },
                    { 5, "student4@student.com", "Jodi", "Toliver", "tTGoGl9PIPS9YSEu/c9LkazCnUrfXHw/mtJkKB20N9E=", "1112223333", "Staff", new byte[] { 88, 212, 89, 176, 181, 249, 18, 55, 27, 255, 40, 10, 197, 150, 173, 162 } },
                    { 4, "student3@student.com", "Clayton", "Cawyer", "tTGoGl9PIPS9YSEu/c9LkazCnUrfXHw/mtJkKB20N9E=", "1112223333", "Staff", new byte[] { 88, 212, 89, 176, 181, 249, 18, 55, 27, 255, 40, 10, 197, 150, 173, 162 } },
                    { 16, "student15@student.com", "Donald", "Hill", "tTGoGl9PIPS9YSEu/c9LkazCnUrfXHw/mtJkKB20N9E=", "1112223333", "User", new byte[] { 88, 212, 89, 176, 181, 249, 18, 55, 27, 255, 40, 10, 197, 150, 173, 162 } },
                    { 2, "nicoledufrene0301@gmail.com", "Nicole", "Dufrene", "tTGoGl9PIPS9YSEu/c9LkazCnUrfXHw/mtJkKB20N9E=", "1112223333", "Staff", new byte[] { 88, 212, 89, 176, 181, 249, 18, 55, 27, 255, 40, 10, 197, 150, 173, 162 } },
                    { 1, "admin@admin.com", "Becky", "Smith", "UtpmeOIg0Pm9Qp9poyZEMqKfdEIF8mkLCUOL9cAat4c=", "1112223333", "Admin", new byte[] { 220, 149, 65, 225, 50, 23, 98, 18, 87, 236, 19, 118, 232, 152, 132, 83 } },
                    { 8, "student7@student.com", "Trenton", "Hillsong", "tTGoGl9PIPS9YSEu/c9LkazCnUrfXHw/mtJkKB20N9E=", "1112223333", "User", new byte[] { 88, 212, 89, 176, 181, 249, 18, 55, 27, 255, 40, 10, 197, 150, 173, 162 } },
                    { 17, "student16@student.com", "Richard", "Newman", "tTGoGl9PIPS9YSEu/c9LkazCnUrfXHw/mtJkKB20N9E=", "1112223333", "User", new byte[] { 88, 212, 89, 176, 181, 249, 18, 55, 27, 255, 40, 10, 197, 150, 173, 162 } }
                });

            migrationBuilder.InsertData(
                table: "Bio",
                columns: new[] { "StaffBioId", "Bio", "Picture", "UserId" },
                values: new object[,]
                {
                    { 10, "I am Staff 6!", "https://image.ibb.co/jkKE2A/user-placeholder.png", 10 },
                    { 8, "I am Staff 6!", "https://image.ibb.co/jkKE2A/user-placeholder.png", 8 },
                    { 7, "Jackie Smith BSN is finish her Masters degree in Nursing education she is a current cardiac nurse.  She will be teaching the ACLS classes.", "https://image.ibb.co/jkKE2A/user-placeholder.png", 7 },
                    { 6, "Savannah Rachel RN started her career as an EMT and has continued her education in the healthcare field.  She is currently working at East Jefferson Hospital and will be teaching the ACLS classes.", "https://image.ibb.co/jkKE2A/user-placeholder.png", 6 },
                    { 5, "Jodi Toliver MS is an instructor train the trainer and has been teach water classes for over 25 years.  She will also be helping to teach the American Red Cross babysitters class.", "https://image.ibb.co/jkKE2A/user-placeholder.png", 5 },
                    { 4, "Clayton Cawyer NREMT has been teaching for several years in the CPR, first aid and Bureau of EMS classes as well as a fire fighter in the St. Tammany area. ", "https://image.ibb.co/jkKE2A/user-placeholder.png", 4 },
                    { 3, "Dennis Pitts NREMT is a seasoned fire fighter in the Tangipahoa Parish area.  He teaches all the CPR, first aid, and bureau of EM S classes.", "https://image.ibb.co/jkKE2A/user-placeholder.png", 3 },
                    { 2, "Nicole Dufrene EMR has a passion to help protect our littles one from the number one cause of children's death motor vehicle accidents.  She is driven to help educate about how to properly install a car seat and make sure your little ones are safe and secured.", "https://image.ibb.co/jkKE2A/user-placeholder.png", 2 },
                    { 1, "Becky Smith is the owner of Keeping Safety Smart. With over 20 years of emergency/life saver teaching experience, Ms. Smith founded Keeping Safety Smart in 2015.", "https://image.ibb.co/jkKE2A/user-placeholder.png", 1 },
                    { 9, "I am Staff 6!", "https://image.ibb.co/jkKE2A/user-placeholder.png", 9 }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "BookAvailable", "BookPrice", "CategoryId", "Description", "Name", "PrereqId", "TypicalPrice" },
                values: new object[,]
                {
                    { 15, false, 0.0, 6, "This 14 hour, 2 day class following American Red Cross standards will educate the babysitter on skills necessary to provide quality care to children of all ages.  Participants must be ages 11 and older and will learn Adult/Child/Infant CPR and AED, basic first aid, child behavior, age-appropriate activities, basic child care (including bottling, feeding, and diapering), and professionalism.  This courses teaches techniques necessary for all babysitters.", "ARC Babysitting  BOOT CAMP", null, 50 },
                    { 16, false, 0.0, 4, "The purpose of the American Red Cross Lifeguard Course is to provide entry-level lifeguard participants with knowledge and skills to prevent, recognize, and respond to aquatic emergencies.  The lifeguard will also learn care for breathing and cardiac emergencies, as well as first aid skills.  This is a 25 hour course taught by a certified ARC instructor.  Students must be 15 years or older and able to swim 300 yards continuously demonstrating breath control and rhythmic breating.  Candidates may swim using front crawl, breaststroke, or combination only; side or back swimming is not allowed. Goggles may be worn for this portion.  Candidates must also be able to tread water for 2 minutes using only legs (arms will be placed under armpits) and complete a timed event within 1 minute 40 seconds.  Candidates will be required to swim 20 yards without goggles and surface dive (feet or head first) to a depth of 7 to 10 feet to retrieve a 10 pound object.  Candidates must also exit the water without using a ladder or steps.", "ARC Initial Lifeguard", null, 50 },
                    { 1, false, 0.0, 3, "Emergency Medical Responder 60-hour course will prepare the EMR student to provide prehospital assessment and care for patients of all ages with a variety of medical conditions and traumatic injuries. Area of study includes an introduction to emergency medical systems, roles and responsibilities of EMR’s, anatomy and physiology, medical emergencies, trauma, and special considerations for working in the prehospital setting. EMR students will be able to do the following: describe the roles of EMS in the healthcare system, demonstrate the professional attributes expected of the EMRs, perform the roles and responsibilities of an EMR with regards to personal safety as well as safety of others, perform the duties of an EMR with regard to medical - legal and ethical issues, identify and perform lifesaving intervention ns to manage a patient’s airway, breathing and circulation, assess and manage medical and traumatic issues, and apply principles of emergency medical services.", "Emergency Medical Responder", null, 0 },
                    { 3, false, 0.0, 2, "The Emergency Medical Technician (EMT) 160-hour program is designed to train the lay person in emergency care in the pre-hospital environment. This is the entry level in the Emergency Medical Services (EMS) field.  The program follows the current Department of Transportation (DOT) EMT curriculum. The program instructs the student in medical practices available to prehospital personnel, patient assessment and management of trauma and medical emergencies, airway management, resuscitation and pharmacological interventions. This program will develop the student’s confidence, knowledge and skills in performing critical assessment and management of patients with medical and trauma elated life threats.", "Emergency Medical Technician", null, 0 },
                    { 11, false, 0.0, 1, "A 2 ½ hour entry level awareness program designed for the general public, parents, babysitters, grandparents, churches, clubs, etc.  The course covers American Heart Association guidelines for the one-rescuer adult including Pediatric CPR, relief of Foreign Body Airway Obstructions, the chain of survival, Basic First Aid, and recognizing the signs of a heart attack and stroke. Cost includes a student textbook.New 2016 Guidelines!", "Family and Friends CPR", null, 50 },
                    { 10, false, 0.0, 1, "A 6-8 hour First Aid course designed for childcare workers whose job requires a pediatric-specific first aid completion card.  This course provides the skills to effectively asses and maintain a child’s life in the critical minutes following an emergency until the arrival of emergency personnel.  This course covers all State of Louisiana required modules including Child Care specific topics, General Principles, Medical Emergencies, Injury Emergencies, and Environmental Emergencies.  Also includes CPR and AED training for Adult, Children, and Infants. Cost includes use of a textbook, skills, and course completion certification(good for 2 years).New 2015 Guidelines!", "Heartsaver Pediatric First Aid", null, 50 },
                    { 9, true, 15.0, 1, "A 4 hour course designed for the general public or lay rescuer whose job requires a first aid course completion card.  The course provides the skills to effectively asses and maintain life from the critical minutes of an emergency until the arrival of emergency service personnel.  Depending on which modules the candidate wishes to take, the basic first aid course consists of General Principles, Medical Emergencies, and Injury Emergencies.  Also includes CPR and AED training, and Environmental Emergencies. Cost includes use of a textbook, practice exam, and course completion certificate(good for 2 years).New 2015 Guidelines!", "Heartsaver First Aid ", null, 50 },
                    { 8, true, 15.0, 1, "A 2-3 hour course designed to teach the lay rescuer (security guards, personal trainers, church organization teachers, etc.) how to recognize and treat life-threatening emergencies whose job requires a course completion card documenting one-rescuer adult and/or pediatric CPR, Foreign Body Airway Obstruction, and AED training. Cost includes the use of a textbook, practice exam, and course completion certificate(good for 2 years).New 2015 Guidelines!", "Heartsaver CPR/AED ", null, 50 },
                    { 6, false, 0.0, 1, "A 4 hour refresher course for the Healthcare Professional; this course offers guidelines in one and two-rescuer adult, child, and infant CPR, Foreign Body Airway Obstruction, and AED training. Cost includes the use of a students’ textbook, written and practical exams, and course completion certification(good for 2 years).New 2015 Guidelines!", "Basic Life Support w/ CPR Refr", null, 50 },
                    { 20, false, 0.0, 5, "This is a free service by certified child passenger safety technicians to lower childhood deaths and injuries.  To stay informed of events and education, please follow Buckle Up Louisiana on Facebook.  Nicole Dufrene can assist anyone who has questions concerning car safety seat information FREE of charge. Her email is: nicoledufrene0301@gmail.com.  Additional information can be found at The National Highway and Traffic Safety website https://www.nhtsa.gov/.  Also visit https://www.safekids.org/child-passenger-safety to learn more about the organization that regulates the  curriculum for our classes and also has a find a fitting station near you.", "Car Seat Safety", null, 0 },
                    { 5, true, 25.0, 1, "A 4 ½ hour initial course designed for Healthcare Professionals.  The course covers Adult, Child, and Infant one-rescuer CPR AED, as well as a new focused emphasis on teamwork with the adult, child, and infant two-person rescue.  Topics also include Rescue Breathing and Foreign Body Airway Obstruction. Cost includes the use of a textbook, written and practical exams, and a course completion certification(good for 2 years).New 2015 Guidelines!", "Basic Life Support", null, 50 }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "BookAvailable", "BookPrice", "CategoryId", "Description", "Name", "PrereqId", "TypicalPrice" },
                values: new object[,]
                {
                    { 7, false, 0.0, 1, "For those who have successfully completed the online portion of either BLS course.  Students MUST provide a copy of the online course completion certificate. Cost includes practice time, exam, and course completion certificate(good for 2 years)", "BLS Online Recert – Part 2", 5, 0 },
                    { 17, false, 0.0, 4, "Current certified lifeguards with valid American Red Cross Lifeguarding/CPR/AED/First aid certification who have expired more than 30 days.  Students must bring proof of valid ARC Lifeguarding, First Aid, and CPR/AED for the Professional Rescuer certification.  Students will be required to swim 300 yards, tread water using legs only for 2 minutes, and retrieve a 10 pound weird from a 7-10 foot depth, swim 20 yards wihth the weight, and exit the pool without using ladder or steps within 100 seconds.  Students will recieve a 2 year ARC certification in Lifeguard, First Aid, and CPR/AED", "ARC Lifeguard Recert", 16, 50 },
                    { 2, false, 0.0, 3, "An EMR 16-hour recertification course for those with preexisting EMR certification.  This course will prepare the EMR student to provide prehospital assessment and care for patients of all ages with a variety of medical conditions and traumatic injuries. Area of study includes an introduction to emergency medical systems, roles and responsibilities of EMR’s, anatomy and physiology, medical emergencies, trauma, and special considerations for working in the prehospital setting. EMR students will be able to do the following: describe the roles of EMS in the healthcare system, demonstrate the professional attributes expected of the EMRs, perform the roles and responsibilities of an EMR with regards to personal safety as well as safety of others, perform the duties of an EMR with regard to medical - legal and ethical issues, identify and perform lifesaving intervention ns to manage a patient’s airway, breathing and circulation, assess and manage medical and traumatic issues, and apply principles of emergency medical services.", "EMR Recertification", 1, 0 },
                    { 4, false, 0.0, 2, "An EMT 20-hour recertification course for those with preexisting EMT certification. This program is designed to train the lay person in emergency care in the pre-hospital environment. This is the entry level in the Emergency Medical Services (EMS) field.  The program follows the current Department of Transportation (DOT) EMT curriculum. The program instructs the student in medical practices available to prehospital personnel, patient assessment and management of trauma and medical emergencies, airway management, resuscitation and pharmacological interventions. This program will develop the student’s confidence, knowledge and skills in performing critical assessment and management of patients with medical and trauma elated life threats.", "EMT Recertification", 3, 0 },
                    { 18, false, 0.0, 4, "The purpose of this instructor course is to ttrain candidates to teach courses and presentation in the American Red Cross Swimming and Water Safety program including Parent and Child Aquatics, Preschool Aquatics, Learn-to-Swim, Adult Swim, Private Lessons, Water Safety Courses (including Safety Training for Swim Coaches) and Water Safety Presentations.  Candidates must be at least 16 years old and demonstrate the ability to perform the following swimming skills: Front Crawl, Back Crawl, Breaststroke, Elementary Backstroke, Sidestroke, and Butterfly, all for 25 yards.  Candidates must be able to maintain position on back for 1 minute in deep water (floating or sculling) and must tread water for 1 minute.  The instructor-lead course is 31 hours.  To be certified, candidates must successfully complete the online Intro to the ARC Water Safety Course, complete the Precourse Skills Session, attend and participate in all course sessions, complete class activities including the four practice-teaching assignments, demonstrate instructor-level skill competency in all scenarios, and score a minimum of 80 percent on the instructor course final written exam.", "ARC Water Safety Instructor", 16, 50 },
                    { 14, false, 0.0, 1, "For those who have successfully completed the online portion of the Heartsaver First Aid course.  Students MUST provide a copy of the online course completion certificate. Cost includes practice time, exam, and course completion certificate(good for 2 years)", "First Aid Online Recert 2", 9, 50 },
                    { 13, false, 0.0, 1, "For those who have successfully completed the online portion of the Heartsaver CPR/AED course.  Students MUST provide a copy of the online course completion certificate. Cost includes practice time, exam, and course completion certificate(good for 2 years)", "CPR/AED Online Recert 2", 8, 50 },
                    { 19, false, 0.0, 4, "The purpose of the American Red Cross Lifeguard Instructor course is to train candidates to teach the American Red Cross Lifeguarding, Lifeguard Blending Learning, Shallow Water Lifeguard, Water Park Skills, CPR/AED for the Professional Rescuers and Health Care Providers, Administering Emergency Oxygen and Bloodborne Pathogens Training courses and modules.  Candidates must be at least 17 years old, possess current ARC Lifeguarding/CPR/AED/First Aid certification, complete the online Orientation to the ARC and Orientation to the Lifeguard Instructor course and Precourse Exam, successfully complete the Precourse session, and Obtain the Lifeguard Instructor's Manual and Lifeguarding Manual.  To be certified, candidates must successfully complete the online Intro to the ARC Lifeguard Instructor Course, complete the Precourse Skills Session, attend and participate in all course sessions, complete class activities including the four practice-teaching assignments, demonstrate instructor-level skill competency in all scenarios, and score a minimum of 80 percent on the instructor course final written exam.", "ARC Lifeguard Instructor", 16, 50 },
                    { 12, false, 0.0, 1, "This is a 16 - 20 hour course for those who wish to become AHA Instructor Candidates able to teach various levels of American Heart Association CPR.  Course is taught over 2 or 3 days. Successful completion of AHA BLS for Healthcare Providers Course, as well as each module instructor candidates wish to teach(Heartsaver First Aid, Heartsaver CPR / AED, etc.), and scoring 90 % or better on written examination(within 90 days of the instructor course) is required for completion. A letter of recommendation and completion of Core Instructor Course is required before applying. Cost includes all student level books, instructor manuals, practical exams, and test.New 2015 Guidelines!", "BLS & CPR, Instructor", 5, 50 }
                });

            migrationBuilder.InsertData(
                table: "Instance",
                columns: new[] { "InstanceId", "BookAvailable", "BookPrice", "CourseId", "Graded", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[,]
                {
                    { 21, true, 54.0, 6, false, 3, 2, 69.0, 14, new DateTimeOffset(new DateTime(2019, 4, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 22, true, 48.0, 1, false, 5, 1, 81.0, 19, new DateTimeOffset(new DateTime(2016, 9, 4, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 17, true, 18.0, 1, false, 1, 3, 92.0, 14, new DateTimeOffset(new DateTime(2019, 3, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 10, true, 32.0, 1, false, 2, 3, 109.0, 30, new DateTimeOffset(new DateTime(2018, 9, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 7, true, 45.0, 1, false, 3, 1, 89.0, 26, new DateTimeOffset(new DateTime(2018, 10, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 5, true, 53.0, 5, false, 1, 3, 86.0, 14, new DateTimeOffset(new DateTime(2019, 4, 16, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 18, true, 48.0, 3, false, 6, 1, 132.0, 15, new DateTimeOffset(new DateTime(2016, 12, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 11, true, 28.0, 3, false, 5, 3, 135.0, 18, new DateTimeOffset(new DateTime(2019, 12, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 4, true, 30.0, 3, false, 1, 2, 130.0, 15, new DateTimeOffset(new DateTime(2017, 11, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 9, true, 24.0, 6, false, 4, 2, 65.0, 10, new DateTimeOffset(new DateTime(2018, 3, 25, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 20, true, 48.0, 5, false, 4, 3, 120.0, 15, new DateTimeOffset(new DateTime(2018, 2, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 13, true, 43.0, 10, false, 2, 1, 140.0, 11, new DateTimeOffset(new DateTime(2017, 3, 15, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 6, true, 23.0, 10, false, 4, 1, 112.0, 21, new DateTimeOffset(new DateTime(2018, 8, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 23, true, 18.0, 5, false, 5, 2, 66.0, 20, new DateTimeOffset(new DateTime(2018, 5, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 19, true, 38.0, 9, false, 6, 3, 149.0, 19, new DateTimeOffset(new DateTime(2018, 4, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 12, true, 16.0, 9, false, 3, 3, 53.0, 17, new DateTimeOffset(new DateTime(2018, 4, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 2, true, 15.0, 9, false, 5, 2, 68.0, 13, new DateTimeOffset(new DateTime(2017, 4, 21, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 27, true, 55.0, 5, false, 6, 2, 133.0, 14, new DateTimeOffset(new DateTime(2016, 12, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 29, true, 51.0, 8, false, 1, 3, 98.0, 25, new DateTimeOffset(new DateTime(2019, 6, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 8, true, 54.0, 6, false, 2, 1, 113.0, 26, new DateTimeOffset(new DateTime(2018, 10, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 15, true, 36.0, 10, false, 6, 3, 119.0, 15, new DateTimeOffset(new DateTime(2016, 2, 13, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 3, true, 42.0, 10, false, 3, 2, 70.0, 21, new DateTimeOffset(new DateTime(2016, 7, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "EnrollmentId", "BookBought", "Confirmed", "InstanceId", "Paid", "Status", "UserId" },
                values: new object[,]
                {
                    { 36, true, null, 3, false, "E", 2 },
                    { 254, false, null, 15, false, "E", 16 },
                    { 253, false, null, 15, false, "E", 15 },
                    { 252, true, null, 15, false, "E", 14 },
                    { 251, false, null, 15, true, "E", 13 },
                    { 250, true, null, 15, false, "E", 12 },
                    { 249, false, null, 15, true, "E", 11 },
                    { 248, false, null, 15, true, "E", 10 },
                    { 247, false, null, 15, true, "E", 9 },
                    { 246, false, null, 15, false, "E", 8 },
                    { 245, true, null, 15, true, "E", 7 },
                    { 244, false, null, 15, false, "E", 6 },
                    { 243, false, null, 15, true, "E", 5 },
                    { 242, true, null, 15, false, "E", 4 },
                    { 241, true, null, 15, false, "E", 3 },
                    { 240, true, null, 15, false, "E", 2 },
                    { 239, true, null, 15, false, "E", 1 },
                    { 221, false, null, 13, false, "E", 17 },
                    { 220, true, null, 13, false, "E", 16 },
                    { 219, false, null, 13, false, "E", 15 },
                    { 255, true, null, 15, false, "E", 17 },
                    { 52, false, null, 4, true, "E", 1 },
                    { 53, false, null, 4, false, "E", 2 },
                    { 54, false, null, 4, false, "E", 3 },
                    { 176, false, null, 11, false, "E", 6 },
                    { 175, false, null, 11, true, "E", 5 },
                    { 174, true, null, 11, false, "E", 4 },
                    { 173, true, null, 11, false, "E", 3 },
                    { 172, true, null, 11, true, "E", 2 },
                    { 171, false, null, 11, true, "E", 1 },
                    { 68, true, null, 4, true, "E", 17 },
                    { 67, false, null, 4, true, "E", 16 },
                    { 66, false, null, 4, true, "E", 15 },
                    { 218, true, null, 13, true, "E", 14 },
                    { 65, true, null, 4, true, "E", 14 },
                    { 63, true, null, 4, false, "E", 12 },
                    { 62, true, null, 4, false, "E", 11 },
                    { 61, false, null, 4, true, "E", 10 },
                    { 60, false, null, 4, false, "E", 9 },
                    { 59, true, null, 4, false, "E", 8 },
                    { 58, true, null, 4, false, "E", 7 },
                    { 57, false, null, 4, true, "E", 6 },
                    { 56, false, null, 4, true, "E", 5 },
                    { 55, true, null, 4, false, "E", 4 },
                    { 64, false, null, 4, false, "E", 13 },
                    { 177, false, null, 11, false, "E", 7 },
                    { 217, true, null, 13, true, "E", 13 },
                    { 215, false, null, 13, false, "E", 11 },
                    { 88, true, null, 6, false, "E", 3 },
                    { 87, false, null, 6, false, "E", 2 },
                    { 86, true, null, 6, false, "E", 1 },
                    { 51, false, null, 3, false, "E", 17 },
                    { 50, false, null, 3, false, "E", 16 },
                    { 49, true, null, 3, false, "E", 15 },
                    { 48, true, null, 3, true, "E", 14 },
                    { 47, true, null, 3, true, "E", 13 },
                    { 46, false, null, 3, true, "E", 12 },
                    { 45, false, null, 3, true, "E", 11 },
                    { 44, false, null, 3, true, "E", 10 },
                    { 43, true, null, 3, true, "E", 9 },
                    { 42, false, null, 3, true, "E", 8 },
                    { 41, true, null, 3, true, "E", 7 },
                    { 40, true, null, 3, false, "E", 6 },
                    { 39, true, null, 3, false, "E", 5 },
                    { 38, false, null, 3, true, "E", 4 },
                    { 37, false, null, 3, true, "E", 3 },
                    { 373, false, null, 22, true, "E", 16 },
                    { 89, false, null, 6, false, "E", 4 },
                    { 90, true, null, 6, false, "E", 5 },
                    { 91, true, null, 6, true, "E", 6 },
                    { 92, false, null, 6, true, "E", 7 },
                    { 214, true, null, 13, false, "E", 10 },
                    { 213, true, null, 13, true, "E", 9 },
                    { 212, true, null, 13, false, "E", 8 },
                    { 211, false, null, 13, true, "E", 7 },
                    { 210, false, null, 13, true, "E", 6 },
                    { 209, true, null, 13, false, "E", 5 },
                    { 208, false, null, 13, true, "E", 4 },
                    { 207, false, null, 13, true, "E", 3 },
                    { 206, false, null, 13, true, "E", 2 },
                    { 216, true, null, 13, true, "E", 12 },
                    { 205, false, null, 13, true, "E", 1 },
                    { 101, false, null, 6, true, "E", 16 },
                    { 100, true, null, 6, true, "E", 15 },
                    { 99, true, null, 6, false, "E", 14 },
                    { 98, false, null, 6, true, "E", 13 },
                    { 97, false, null, 6, true, "E", 12 },
                    { 96, false, null, 6, false, "E", 11 },
                    { 95, true, null, 6, false, "E", 10 },
                    { 94, false, null, 6, true, "E", 9 },
                    { 93, true, null, 6, true, "E", 8 },
                    { 102, true, null, 6, true, "E", 17 },
                    { 35, false, null, 3, false, "E", 1 },
                    { 178, false, null, 11, false, "E", 8 },
                    { 180, true, null, 11, true, "E", 10 },
                    { 280, false, null, 17, false, "E", 8 },
                    { 279, true, null, 17, true, "E", 7 },
                    { 278, true, null, 17, true, "E", 6 },
                    { 277, true, null, 17, false, "E", 5 },
                    { 276, true, null, 17, false, "E", 4 },
                    { 275, false, null, 17, false, "E", 3 },
                    { 274, false, null, 17, true, "E", 2 },
                    { 273, false, null, 17, false, "E", 1 },
                    { 170, true, null, 10, false, "E", 17 },
                    { 169, false, null, 10, false, "E", 16 },
                    { 168, true, null, 10, false, "E", 15 },
                    { 167, false, null, 10, true, "E", 14 },
                    { 166, true, null, 10, true, "E", 13 },
                    { 165, true, null, 10, true, "E", 12 },
                    { 164, false, null, 10, true, "E", 11 },
                    { 163, false, null, 10, true, "E", 10 },
                    { 162, true, null, 10, true, "E", 9 },
                    { 161, false, null, 10, true, "E", 8 },
                    { 160, false, null, 10, true, "E", 7 },
                    { 281, true, null, 17, false, "E", 9 },
                    { 282, true, null, 17, false, "E", 10 },
                    { 283, true, null, 17, false, "E", 11 },
                    { 284, true, null, 17, true, "E", 12 },
                    { 372, false, null, 22, true, "E", 15 },
                    { 371, false, null, 22, true, "E", 14 },
                    { 370, false, null, 22, false, "E", 13 },
                    { 369, false, null, 22, true, "E", 12 },
                    { 368, false, null, 22, false, "E", 11 },
                    { 367, false, null, 22, true, "E", 10 },
                    { 366, true, null, 22, true, "E", 9 },
                    { 365, true, null, 22, true, "E", 8 },
                    { 364, true, null, 22, false, "E", 7 },
                    { 159, true, null, 10, false, "E", 6 },
                    { 363, false, null, 22, false, "E", 6 },
                    { 361, false, null, 22, true, "E", 4 },
                    { 360, true, null, 22, true, "E", 3 },
                    { 359, false, null, 22, false, "E", 2 },
                    { 358, true, null, 22, true, "E", 1 },
                    { 289, false, null, 17, true, "E", 17 },
                    { 288, true, null, 17, true, "E", 16 },
                    { 287, true, null, 17, true, "E", 15 },
                    { 286, true, null, 17, true, "E", 14 },
                    { 285, false, null, 17, false, "E", 13 },
                    { 362, false, null, 22, true, "E", 5 },
                    { 179, false, null, 11, true, "E", 9 },
                    { 158, false, null, 10, false, "E", 5 },
                    { 156, true, null, 10, false, "E", 3 },
                    { 301, false, null, 18, true, "E", 12 },
                    { 300, true, null, 18, true, "E", 11 },
                    { 299, true, null, 18, false, "E", 10 },
                    { 298, false, null, 18, false, "E", 9 },
                    { 297, false, null, 18, true, "E", 8 },
                    { 296, true, null, 18, false, "E", 7 },
                    { 295, true, null, 18, false, "E", 6 },
                    { 294, false, null, 18, false, "E", 5 },
                    { 293, false, null, 18, false, "E", 4 },
                    { 292, true, null, 18, false, "E", 3 },
                    { 291, false, null, 18, false, "E", 2 },
                    { 290, true, null, 18, false, "E", 1 },
                    { 187, false, null, 11, true, "E", 17 },
                    { 186, true, null, 11, false, "E", 16 },
                    { 185, true, null, 11, false, "E", 15 },
                    { 184, true, null, 11, true, "E", 14 },
                    { 183, false, null, 11, true, "E", 13 },
                    { 182, true, null, 11, true, "E", 12 },
                    { 181, true, null, 11, false, "E", 11 },
                    { 302, true, null, 18, true, "E", 13 },
                    { 303, false, null, 18, true, "E", 14 },
                    { 304, true, null, 18, true, "E", 15 },
                    { 305, false, null, 18, true, "E", 16 },
                    { 155, false, null, 10, false, "E", 2 },
                    { 154, false, null, 10, false, "E", 1 },
                    { 119, false, null, 7, false, "E", 17 },
                    { 118, false, null, 7, false, "E", 16 },
                    { 117, true, null, 7, true, "E", 15 },
                    { 116, false, null, 7, true, "E", 14 },
                    { 115, true, null, 7, true, "E", 13 },
                    { 114, true, null, 7, false, "E", 12 },
                    { 113, true, null, 7, true, "E", 11 },
                    { 157, false, null, 10, true, "E", 4 },
                    { 112, true, null, 7, false, "E", 10 },
                    { 110, false, null, 7, true, "E", 8 },
                    { 109, true, null, 7, true, "E", 7 },
                    { 108, false, null, 7, false, "E", 6 },
                    { 107, false, null, 7, true, "E", 5 },
                    { 106, false, null, 7, false, "E", 4 },
                    { 105, true, null, 7, true, "E", 3 },
                    { 104, false, null, 7, true, "E", 2 },
                    { 103, false, null, 7, true, "E", 1 },
                    { 306, true, null, 18, true, "E", 17 },
                    { 111, true, null, 7, true, "E", 9 },
                    { 323, false, null, 19, false, "E", 17 },
                    { 374, true, null, 22, true, "E", 17 },
                    { 321, true, null, 19, false, "E", 15 },
                    { 458, false, null, 27, false, "E", 16 },
                    { 457, false, null, 27, false, "E", 15 },
                    { 456, true, null, 27, false, "E", 14 },
                    { 455, true, null, 27, true, "E", 13 },
                    { 454, false, null, 27, false, "E", 12 },
                    { 453, true, null, 27, true, "E", 11 },
                    { 452, false, null, 27, true, "E", 10 },
                    { 451, false, null, 27, false, "E", 9 },
                    { 450, true, null, 27, true, "E", 8 },
                    { 449, true, null, 27, false, "E", 7 },
                    { 448, true, null, 27, true, "E", 6 },
                    { 447, false, null, 27, false, "E", 5 },
                    { 446, true, null, 27, false, "E", 4 },
                    { 445, false, null, 27, true, "E", 3 },
                    { 444, false, null, 27, false, "E", 2 },
                    { 443, false, null, 27, true, "E", 1 },
                    { 391, false, null, 23, false, "E", 17 },
                    { 390, false, null, 23, false, "E", 16 },
                    { 389, false, null, 23, false, "E", 15 },
                    { 459, false, null, 27, true, "E", 17 },
                    { 120, false, null, 8, true, "E", 1 },
                    { 121, false, null, 8, false, "E", 2 },
                    { 122, false, null, 8, false, "E", 3 },
                    { 142, false, null, 9, true, "E", 6 },
                    { 141, false, null, 9, true, "E", 5 },
                    { 140, false, null, 9, false, "E", 4 },
                    { 139, false, null, 9, true, "E", 3 },
                    { 138, true, null, 9, false, "E", 2 },
                    { 137, false, null, 9, true, "E", 1 },
                    { 136, false, null, 8, false, "E", 17 },
                    { 135, false, null, 8, true, "E", 16 },
                    { 134, true, null, 8, false, "E", 15 },
                    { 388, true, null, 23, false, "E", 14 },
                    { 133, false, null, 8, false, "E", 14 },
                    { 131, true, null, 8, false, "E", 12 },
                    { 130, true, null, 8, true, "E", 11 },
                    { 129, true, null, 8, true, "E", 10 },
                    { 128, false, null, 8, false, "E", 9 },
                    { 127, true, null, 8, true, "E", 8 },
                    { 126, false, null, 8, false, "E", 7 },
                    { 125, true, null, 8, false, "E", 6 },
                    { 124, false, null, 8, true, "E", 5 },
                    { 123, false, null, 8, true, "E", 4 },
                    { 132, true, null, 8, true, "E", 13 },
                    { 387, true, null, 23, false, "E", 13 },
                    { 386, true, null, 23, false, "E", 12 },
                    { 385, true, null, 23, true, "E", 11 },
                    { 326, true, null, 20, false, "E", 3 },
                    { 325, true, null, 20, true, "E", 2 },
                    { 324, false, null, 20, false, "E", 1 },
                    { 85, true, null, 5, false, "E", 17 },
                    { 84, true, null, 5, true, "E", 16 },
                    { 83, false, null, 5, true, "E", 15 },
                    { 82, false, null, 5, false, "E", 14 },
                    { 81, false, null, 5, true, "E", 13 },
                    { 80, true, null, 5, true, "E", 12 },
                    { 327, true, null, 20, false, "E", 4 },
                    { 79, false, null, 5, false, "E", 11 },
                    { 77, true, null, 5, false, "E", 9 },
                    { 76, true, null, 5, true, "E", 8 },
                    { 75, false, null, 5, false, "E", 7 },
                    { 74, false, null, 5, false, "E", 6 },
                    { 73, true, null, 5, true, "E", 5 },
                    { 72, false, null, 5, true, "E", 4 },
                    { 71, true, null, 5, false, "E", 3 },
                    { 70, true, null, 5, false, "E", 2 },
                    { 69, false, null, 5, false, "E", 1 },
                    { 78, true, null, 5, true, "E", 10 },
                    { 322, true, null, 19, false, "E", 16 },
                    { 328, true, null, 20, true, "E", 5 },
                    { 330, false, null, 20, true, "E", 7 },
                    { 384, false, null, 23, true, "E", 10 },
                    { 383, false, null, 23, false, "E", 9 },
                    { 382, false, null, 23, true, "E", 8 },
                    { 381, true, null, 23, false, "E", 7 },
                    { 380, false, null, 23, true, "E", 6 },
                    { 379, false, null, 23, false, "E", 5 },
                    { 378, true, null, 23, false, "E", 4 },
                    { 377, false, null, 23, true, "E", 3 },
                    { 376, true, null, 23, false, "E", 2 },
                    { 329, true, null, 20, true, "E", 6 },
                    { 375, false, null, 23, true, "E", 1 },
                    { 339, true, null, 20, true, "E", 16 },
                    { 338, true, null, 20, false, "E", 15 },
                    { 337, true, null, 20, true, "E", 14 },
                    { 336, true, null, 20, true, "E", 13 },
                    { 335, false, null, 20, true, "E", 12 },
                    { 334, true, null, 20, false, "E", 11 },
                    { 333, true, null, 20, false, "E", 10 },
                    { 332, false, null, 20, true, "E", 9 },
                    { 331, false, null, 20, false, "E", 8 },
                    { 340, true, null, 20, false, "E", 17 },
                    { 144, false, null, 9, true, "E", 8 },
                    { 143, true, null, 9, false, "E", 7 },
                    { 146, false, null, 9, false, "E", 10 },
                    { 193, false, null, 12, false, "E", 6 },
                    { 192, false, null, 12, true, "E", 5 },
                    { 191, true, null, 12, false, "E", 4 },
                    { 190, true, null, 12, false, "E", 3 },
                    { 189, false, null, 12, true, "E", 2 },
                    { 188, true, null, 12, false, "E", 1 },
                    { 34, true, null, 2, false, "E", 17 },
                    { 33, true, null, 2, true, "E", 16 },
                    { 32, false, null, 2, false, "E", 15 },
                    { 194, true, null, 12, false, "E", 7 },
                    { 31, false, null, 2, true, "E", 14 },
                    { 29, false, null, 2, false, "E", 12 },
                    { 28, false, null, 2, false, "E", 11 },
                    { 27, true, null, 2, true, "E", 10 },
                    { 26, true, null, 2, false, "E", 9 }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "EnrollmentId", "BookBought", "Confirmed", "InstanceId", "Paid", "Status", "UserId" },
                values: new object[,]
                {
                    { 25, false, null, 2, true, "E", 8 },
                    { 24, false, null, 2, true, "E", 7 },
                    { 23, true, null, 2, true, "E", 6 },
                    { 22, false, null, 2, false, "E", 5 },
                    { 21, false, null, 2, true, "E", 4 },
                    { 30, true, null, 2, true, "E", 13 },
                    { 195, false, null, 12, true, "E", 8 },
                    { 196, true, null, 12, false, "E", 9 },
                    { 197, false, null, 12, true, "E", 10 },
                    { 320, false, null, 19, false, "E", 14 },
                    { 319, true, null, 19, false, "E", 13 },
                    { 318, true, null, 19, false, "E", 12 },
                    { 317, false, null, 19, true, "E", 11 },
                    { 316, true, null, 19, true, "E", 10 },
                    { 315, true, null, 19, true, "E", 9 },
                    { 314, true, null, 19, false, "E", 8 },
                    { 313, false, null, 19, false, "E", 7 },
                    { 312, true, null, 19, false, "E", 6 },
                    { 311, false, null, 19, true, "E", 5 },
                    { 310, true, null, 19, false, "E", 4 },
                    { 309, true, null, 19, true, "E", 3 },
                    { 308, true, null, 19, false, "E", 2 },
                    { 307, false, null, 19, true, "E", 1 },
                    { 204, false, null, 12, false, "E", 17 },
                    { 203, false, null, 12, false, "E", 16 },
                    { 202, false, null, 12, true, "E", 15 },
                    { 201, false, null, 12, false, "E", 14 },
                    { 200, false, null, 12, false, "E", 13 },
                    { 199, true, null, 12, false, "E", 12 },
                    { 198, true, null, 12, true, "E", 11 },
                    { 20, true, null, 2, false, "E", 3 },
                    { 145, true, null, 9, true, "E", 9 },
                    { 19, true, null, 2, true, "E", 2 },
                    { 493, false, null, 29, true, "E", 17 },
                    { 149, true, null, 9, false, "E", 13 },
                    { 18, false, null, 2, true, "E", 1 },
                    { 354, true, null, 21, true, "E", 14 },
                    { 353, true, null, 21, true, "E", 13 },
                    { 352, false, null, 21, false, "E", 12 },
                    { 351, true, null, 21, false, "E", 11 },
                    { 350, false, null, 21, true, "E", 10 },
                    { 349, false, null, 21, false, "E", 9 },
                    { 148, true, null, 9, false, "E", 12 },
                    { 348, true, null, 21, false, "E", 8 },
                    { 346, false, null, 21, true, "E", 6 },
                    { 345, false, null, 21, false, "E", 5 },
                    { 344, true, null, 21, true, "E", 4 },
                    { 343, false, null, 21, true, "E", 3 },
                    { 342, false, null, 21, false, "E", 2 },
                    { 341, false, null, 21, false, "E", 1 },
                    { 153, true, null, 9, false, "E", 17 },
                    { 152, true, null, 9, false, "E", 16 },
                    { 347, true, null, 21, false, "E", 7 },
                    { 151, false, null, 9, false, "E", 15 },
                    { 355, false, null, 21, false, "E", 15 },
                    { 357, true, null, 21, false, "E", 17 },
                    { 492, true, null, 29, false, "E", 16 },
                    { 491, true, null, 29, true, "E", 15 },
                    { 490, false, null, 29, true, "E", 14 },
                    { 489, true, null, 29, true, "E", 13 },
                    { 488, true, null, 29, true, "E", 12 },
                    { 487, false, null, 29, false, "E", 11 },
                    { 486, true, null, 29, false, "E", 10 },
                    { 485, false, null, 29, false, "E", 9 },
                    { 356, true, null, 21, false, "E", 16 },
                    { 484, false, null, 29, true, "E", 8 },
                    { 482, false, null, 29, false, "E", 6 },
                    { 481, false, null, 29, false, "E", 5 },
                    { 480, true, null, 29, false, "E", 4 },
                    { 479, false, null, 29, true, "E", 3 },
                    { 478, false, null, 29, false, "E", 2 },
                    { 477, false, null, 29, false, "E", 1 },
                    { 147, true, null, 9, true, "E", 11 },
                    { 483, false, null, 29, true, "E", 7 },
                    { 150, false, null, 9, true, "E", 14 }
                });

            migrationBuilder.InsertData(
                table: "Instance",
                columns: new[] { "InstanceId", "BookAvailable", "BookPrice", "CourseId", "Graded", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[,]
                {
                    { 24, true, 50.0, 7, false, 4, 1, 108.0, 27, new DateTimeOffset(new DateTime(2018, 6, 5, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 28, true, 18.0, 4, false, 4, 2, 116.0, 27, new DateTimeOffset(new DateTime(2018, 10, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 16, true, 43.0, 4, false, 5, 3, 132.0, 17, new DateTimeOffset(new DateTime(2019, 6, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 1, true, 21.0, 2, false, 1, 1, 149.0, 12, new DateTimeOffset(new DateTime(2018, 9, 28, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 25, true, 54.0, 2, false, 2, 3, 64.0, 12, new DateTimeOffset(new DateTime(2018, 1, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 26, true, 51.0, 4, false, 6, 1, 133.0, 21, new DateTimeOffset(new DateTime(2016, 9, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 14, true, 26.0, 7, false, 2, 1, 131.0, 15, new DateTimeOffset(new DateTime(2016, 3, 26, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "EnrollmentId", "BookBought", "Confirmed", "InstanceId", "Paid", "Status", "UserId" },
                values: new object[,]
                {
                    { 222, true, null, 14, false, "E", 1 },
                    { 2, true, null, 1, true, "E", 2 },
                    { 1, false, null, 1, true, "E", 1 },
                    { 476, false, null, 28, true, "E", 17 },
                    { 475, true, null, 28, true, "E", 16 },
                    { 474, false, null, 28, true, "E", 15 },
                    { 473, false, null, 28, true, "E", 14 },
                    { 472, false, null, 28, false, "E", 13 },
                    { 471, true, null, 28, false, "E", 12 },
                    { 470, false, null, 28, false, "E", 11 },
                    { 469, true, null, 28, true, "E", 10 },
                    { 468, false, null, 28, false, "E", 9 },
                    { 467, true, null, 28, false, "E", 8 },
                    { 3, false, null, 1, true, "E", 3 },
                    { 466, true, null, 28, false, "E", 7 },
                    { 464, true, null, 28, false, "E", 5 },
                    { 463, false, null, 28, true, "E", 4 },
                    { 462, false, null, 28, true, "E", 3 },
                    { 461, false, null, 28, true, "E", 2 },
                    { 460, true, null, 28, true, "E", 1 },
                    { 442, true, null, 26, false, "E", 17 },
                    { 441, true, null, 26, true, "E", 16 },
                    { 440, false, null, 26, true, "E", 15 },
                    { 439, false, null, 26, false, "E", 14 },
                    { 438, false, null, 26, false, "E", 13 },
                    { 437, false, null, 26, true, "E", 12 },
                    { 436, true, null, 26, true, "E", 11 },
                    { 465, true, null, 28, true, "E", 6 },
                    { 435, true, null, 26, true, "E", 10 },
                    { 4, true, null, 1, true, "E", 4 },
                    { 6, false, null, 1, false, "E", 6 },
                    { 423, false, null, 25, false, "E", 15 },
                    { 422, true, null, 25, false, "E", 14 },
                    { 421, true, null, 25, false, "E", 13 },
                    { 420, true, null, 25, false, "E", 12 },
                    { 419, true, null, 25, false, "E", 11 },
                    { 418, true, null, 25, true, "E", 10 },
                    { 417, true, null, 25, true, "E", 9 },
                    { 416, true, null, 25, false, "E", 8 },
                    { 415, false, null, 25, true, "E", 7 },
                    { 414, true, null, 25, false, "E", 6 },
                    { 413, true, null, 25, false, "E", 5 },
                    { 412, true, null, 25, false, "E", 4 },
                    { 5, true, null, 1, true, "E", 5 },
                    { 411, true, null, 25, true, "E", 3 },
                    { 409, false, null, 25, false, "E", 1 },
                    { 17, true, null, 1, true, "E", 17 },
                    { 16, true, null, 1, true, "E", 16 },
                    { 15, true, null, 1, false, "E", 15 },
                    { 14, true, null, 1, false, "E", 14 },
                    { 13, false, null, 1, false, "E", 13 },
                    { 12, false, null, 1, true, "E", 12 },
                    { 11, true, null, 1, false, "E", 11 },
                    { 10, true, null, 1, false, "E", 10 },
                    { 9, false, null, 1, false, "E", 9 },
                    { 8, true, null, 1, false, "E", 8 },
                    { 7, true, null, 1, false, "E", 7 },
                    { 410, true, null, 25, true, "E", 2 },
                    { 424, true, null, 25, true, "E", 16 },
                    { 434, false, null, 26, false, "E", 9 },
                    { 432, true, null, 26, true, "E", 7 },
                    { 401, true, null, 24, false, "E", 10 },
                    { 400, false, null, 24, false, "E", 9 },
                    { 399, true, null, 24, true, "E", 8 },
                    { 398, false, null, 24, true, "E", 7 },
                    { 397, true, null, 24, false, "E", 6 },
                    { 396, false, null, 24, true, "E", 5 },
                    { 395, false, null, 24, false, "E", 4 },
                    { 394, false, null, 24, true, "E", 3 },
                    { 393, true, null, 24, true, "E", 2 },
                    { 392, true, null, 24, true, "E", 1 },
                    { 238, true, null, 14, true, "E", 17 },
                    { 237, true, null, 14, false, "E", 16 },
                    { 402, true, null, 24, true, "E", 11 },
                    { 236, true, null, 14, false, "E", 15 },
                    { 234, true, null, 14, true, "E", 13 },
                    { 233, false, null, 14, false, "E", 12 },
                    { 232, false, null, 14, false, "E", 11 },
                    { 231, false, null, 14, true, "E", 10 },
                    { 230, false, null, 14, true, "E", 9 },
                    { 229, true, null, 14, true, "E", 8 },
                    { 228, true, null, 14, true, "E", 7 },
                    { 227, true, null, 14, false, "E", 6 },
                    { 226, true, null, 14, true, "E", 5 },
                    { 225, true, null, 14, true, "E", 4 },
                    { 224, true, null, 14, true, "E", 3 },
                    { 223, false, null, 14, false, "E", 2 },
                    { 235, true, null, 14, false, "E", 14 },
                    { 433, true, null, 26, true, "E", 8 },
                    { 403, false, null, 24, true, "E", 12 },
                    { 405, true, null, 24, false, "E", 14 },
                    { 431, false, null, 26, true, "E", 6 },
                    { 430, true, null, 26, true, "E", 5 },
                    { 429, false, null, 26, false, "E", 4 },
                    { 428, true, null, 26, true, "E", 3 },
                    { 427, true, null, 26, true, "E", 2 },
                    { 426, true, null, 26, true, "E", 1 },
                    { 272, false, null, 16, false, "E", 17 },
                    { 271, true, null, 16, true, "E", 16 },
                    { 270, true, null, 16, false, "E", 15 },
                    { 269, false, null, 16, false, "E", 14 },
                    { 268, true, null, 16, true, "E", 13 },
                    { 267, false, null, 16, false, "E", 12 },
                    { 404, false, null, 24, true, "E", 13 },
                    { 266, true, null, 16, true, "E", 11 },
                    { 264, false, null, 16, true, "E", 9 },
                    { 263, false, null, 16, false, "E", 8 },
                    { 262, false, null, 16, false, "E", 7 },
                    { 261, true, null, 16, true, "E", 6 },
                    { 260, true, null, 16, true, "E", 5 },
                    { 259, false, null, 16, true, "E", 4 },
                    { 258, true, null, 16, true, "E", 3 },
                    { 257, true, null, 16, false, "E", 2 },
                    { 256, false, null, 16, false, "E", 1 },
                    { 408, true, null, 24, false, "E", 17 },
                    { 407, false, null, 24, false, "E", 16 },
                    { 406, true, null, 24, true, "E", 15 },
                    { 265, false, null, 16, true, "E", 10 },
                    { 425, true, null, 25, true, "E", 17 }
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
