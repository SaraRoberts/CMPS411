using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KSS.Migrations
{
    public partial class initialproduction : Migration
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
                    { 3, "Independence", "Independence Fire", "LA", "12044 Hwy 40", 70443 },
                    { 4, "Mandeville", "Mandeville Fire Department", "LA", "24301 Highway 190", 70448 },
                    { 1, "Covington", "St. Tammany Fire District 12", "LA", "19375 LA-36", 70433 },
                    { 2, "Husser", "Husser Fire Department", "LA", "56298 LA-445", 70442 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "FirstName", "LastName", "Password", "Phone", "Role", "Salt" },
                values: new object[,]
                {
                    { 6, "savannah@keepingsafetysmart.com", "Savannah", "Rachel", "D6L5boApNKVodbrG0LH0XuqdFMCKw4N+x62PrtbfvVg=", "1112223333", "Staff", new byte[] { 97, 193, 27, 49, 22, 32, 200, 15, 59, 17, 251, 161, 22, 134, 92, 166 } },
                    { 10, "webmaster@keepingsafetysmart.com", "Developer", "Developer", "+PpaorYj4pAwGReVIzSFOFZ1ngFhvW9p1okX0em3gLw=", "1112223333", "Admin", new byte[] { 56, 77, 183, 92, 241, 31, 235, 88, 132, 22, 169, 143, 163, 190, 6, 206 } },
                    { 1, "bsmithsafety@hotmail.com", "Beckey", "Smith", "+PpaorYj4pAwGReVIzSFOFZ1ngFhvW9p1okX0em3gLw=", "9855029425", "Admin", new byte[] { 56, 77, 183, 92, 241, 31, 235, 88, 132, 22, 169, 143, 163, 190, 6, 206 } },
                    { 2, "nicoledufrene0301@gmail.com", "Nicole", "Dufrene", "D6L5boApNKVodbrG0LH0XuqdFMCKw4N+x62PrtbfvVg=", "1112223333", "Staff", new byte[] { 97, 193, 27, 49, 22, 32, 200, 15, 59, 17, 251, 161, 22, 134, 92, 166 } },
                    { 3, "dennis@keepingsafetysmart.com", "Dennis", "Pitts", "D6L5boApNKVodbrG0LH0XuqdFMCKw4N+x62PrtbfvVg=", "1112223333", "Staff", new byte[] { 97, 193, 27, 49, 22, 32, 200, 15, 59, 17, 251, 161, 22, 134, 92, 166 } },
                    { 4, "clayton@keepingsafetysmart.com", "Clayton", "Cawyer", "D6L5boApNKVodbrG0LH0XuqdFMCKw4N+x62PrtbfvVg=", "1112223333", "Staff", new byte[] { 97, 193, 27, 49, 22, 32, 200, 15, 59, 17, 251, 161, 22, 134, 92, 166 } },
                    { 5, "jodi@keepingsafetysmart.com", "Jodi", "Toliver", "D6L5boApNKVodbrG0LH0XuqdFMCKw4N+x62PrtbfvVg=", "1112223333", "Staff", new byte[] { 97, 193, 27, 49, 22, 32, 200, 15, 59, 17, 251, 161, 22, 134, 92, 166 } },
                    { 7, "jackie@keepingsafetysmart.com", "Jackie", "Smith", "D6L5boApNKVodbrG0LH0XuqdFMCKw4N+x62PrtbfvVg=", "1112223333", "Staff", new byte[] { 97, 193, 27, 49, 22, 32, 200, 15, 59, 17, 251, 161, 22, 134, 92, 166 } }
                });

            migrationBuilder.InsertData(
                table: "Bio",
                columns: new[] { "StaffBioId", "Bio", "Picture", "UserId" },
                values: new object[,]
                {
                    { 7, "Jackie Smith BSN is finish her Masters degree in Nursing education she is a current cardiac nurse.  She will be teaching the ACLS classes.", "https://image.ibb.co/jkKE2A/user-placeholder.png", 7 },
                    { 5, "Jodi Toliver MS is an instructor train the trainer and has been teach water classes for over 25 years.  She will also be helping to teach the American Red Cross babysitters class.", "https://i.ibb.co/G33Vh31/jodit.png", 5 },
                    { 4, "Clayton Cawyer NREMT has been teaching for several years in the CPR, first aid and Bureau of EMS classes as well as a fire fighter in the St. Tammany area. ", "https://i.ibb.co/GJdjzDw/claytoncawyer.png", 4 },
                    { 3, "Dennis Pitts NREMT is a seasoned fire fighter in the Tangipahoa Parish area.  He teaches all the CPR, first aid, and bureau of EM S classes.", "https://i.ibb.co/JBxJPv6/dennispitts.jpg", 3 },
                    { 2, "Nicole Dufrene EMR has a passion to help protect our littles one from the number one cause of children's death motor vehicle accidents.  She is driven to help educate about how to properly install a car seat and make sure your little ones are safe and secured.", "https://i.ibb.co/dt0W5kH/nicoledufrene.jpg", 2 },
                    { 1, "Beckey Smith is the owner of Keeping Safety Smart. With over 20 years of emergency/life saver teaching experience, Ms. Smith founded Keeping Safety Smart in 2015.", "https://i.ibb.co/KVjPPp7/beckeysmith.jpg", 1 },
                    { 6, "Savannah Rachel RN started her career as an EMT and has continued her education in the healthcare field.  She is currently working at East Jefferson Hospital and will be teaching the ACLS classes.", "https://i.ibb.co/nB1N37X/savannah-rachel.jpg", 6 }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "BookAvailable", "BookPrice", "CategoryId", "Description", "Name", "PrereqId", "TypicalPrice" },
                values: new object[,]
                {
                    { 15, false, 0.0, 6, "This 14 hour, 2 day class following American Red Cross standards will educate the babysitter on skills necessary to provide quality care to children of all ages.  Participants must be ages 11 and older and will learn Adult/Child/Infant CPR and AED, basic first aid, child behavior, age-appropriate activities, basic child care (including bottling, feeding, and diapering), and professionalism.  This courses teaches techniques necessary for all babysitters.", "ARC Babysitting  BOOT CAMP", null, 50 },
                    { 20, false, 0.0, 5, "This is a free service by certified child passenger safety technicians to lower childhood deaths and injuries.  To stay informed of events and education, please follow Buckle Up Louisiana on Facebook.  Nicole Dufrene can assist anyone who has questions concerning car safety seat information FREE of charge. Her email is: nicoledufrene0301@gmail.com.  Additional information can be found at The National Highway and Traffic Safety website https://www.nhtsa.gov/.  Also visit https://www.safekids.org/child-passenger-safety to learn more about the organization that regulates the  curriculum for our classes and also has a find a fitting station near you.", "Car Seat Safety", null, 0 },
                    { 16, false, 0.0, 4, "The purpose of the American Red Cross Lifeguard Course is to provide entry-level lifeguard participants with knowledge and skills to prevent, recognize, and respond to aquatic emergencies.  The lifeguard will also learn care for breathing and cardiac emergencies, as well as first aid skills.  This is a 25 hour course taught by a certified ARC instructor.  Students must be 15 years or older and able to swim 300 yards continuously demonstrating breath control and rhythmic breating.  Candidates may swim using front crawl, breaststroke, or combination only; side or back swimming is not allowed. Goggles may be worn for this portion.  Candidates must also be able to tread water for 2 minutes using only legs (arms will be placed under armpits) and complete a timed event within 1 minute 40 seconds.  Candidates will be required to swim 20 yards without goggles and surface dive (feet or head first) to a depth of 7 to 10 feet to retrieve a 10 pound object.  Candidates must also exit the water without using a ladder or steps.", "ARC Initial Lifeguard", null, 50 },
                    { 3, false, 0.0, 2, "The Emergency Medical Technician (EMT) 160-hour program is designed to train the lay person in emergency care in the pre-hospital environment. This is the entry level in the Emergency Medical Services (EMS) field.  The program follows the current Department of Transportation (DOT) EMT curriculum. The program instructs the student in medical practices available to prehospital personnel, patient assessment and management of trauma and medical emergencies, airway management, resuscitation and pharmacological interventions. This program will develop the student’s confidence, knowledge and skills in performing critical assessment and management of patients with medical and trauma elated life threats.", "Emergency Medical Technician", null, 0 },
                    { 11, false, 0.0, 1, "A 2 ½ hour entry level awareness program designed for the general public, parents, babysitters, grandparents, churches, clubs, etc.  The course covers American Heart Association guidelines for the one-rescuer adult including Pediatric CPR, relief of Foreign Body Airway Obstructions, the chain of survival, Basic First Aid, and recognizing the signs of a heart attack and stroke. Cost includes a student textbook.New 2016 Guidelines!", "Family and Friends CPR", null, 50 },
                    { 10, false, 0.0, 1, "A 6-8 hour First Aid course designed for childcare workers whose job requires a pediatric-specific first aid completion card.  This course provides the skills to effectively asses and maintain a child’s life in the critical minutes following an emergency until the arrival of emergency personnel.  This course covers all State of Louisiana required modules including Child Care specific topics, General Principles, Medical Emergencies, Injury Emergencies, and Environmental Emergencies.  Also includes CPR and AED training for Adult, Children, and Infants. Cost includes use of a textbook, skills, and course completion certification(good for 2 years).New 2015 Guidelines!", "Heartsaver Pediatric First Aid", null, 50 },
                    { 9, true, 15.0, 1, "A 4 hour course designed for the general public or lay rescuer whose job requires a first aid course completion card.  The course provides the skills to effectively asses and maintain life from the critical minutes of an emergency until the arrival of emergency service personnel.  Depending on which modules the candidate wishes to take, the basic first aid course consists of General Principles, Medical Emergencies, and Injury Emergencies.  Also includes CPR and AED training, and Environmental Emergencies. Cost includes use of a textbook, practice exam, and course completion certificate(good for 2 years).New 2015 Guidelines!", "Heartsaver First Aid ", null, 50 },
                    { 8, true, 15.0, 1, "A 2-3 hour course designed to teach the lay rescuer (security guards, personal trainers, church organization teachers, etc.) how to recognize and treat life-threatening emergencies whose job requires a course completion card documenting one-rescuer adult and/or pediatric CPR, Foreign Body Airway Obstruction, and AED training. Cost includes the use of a textbook, practice exam, and course completion certificate(good for 2 years).New 2015 Guidelines!", "Heartsaver CPR/AED ", null, 50 },
                    { 6, false, 0.0, 1, "A 4 hour refresher course for the Healthcare Professional; this course offers guidelines in one and two-rescuer adult, child, and infant CPR, Foreign Body Airway Obstruction, and AED training. Cost includes the use of a students’ textbook, written and practical exams, and course completion certification(good for 2 years).New 2015 Guidelines!", "Basic Life Support w/ CPR Refr", null, 50 },
                    { 1, false, 0.0, 3, "Emergency Medical Responder 60-hour course will prepare the EMR student to provide prehospital assessment and care for patients of all ages with a variety of medical conditions and traumatic injuries. Area of study includes an introduction to emergency medical systems, roles and responsibilities of EMR’s, anatomy and physiology, medical emergencies, trauma, and special considerations for working in the prehospital setting. EMR students will be able to do the following: describe the roles of EMS in the healthcare system, demonstrate the professional attributes expected of the EMRs, perform the roles and responsibilities of an EMR with regards to personal safety as well as safety of others, perform the duties of an EMR with regard to medical - legal and ethical issues, identify and perform lifesaving intervention ns to manage a patient’s airway, breathing and circulation, assess and manage medical and traumatic issues, and apply principles of emergency medical services.", "Emergency Medical Responder", null, 0 },
                    { 5, true, 25.0, 1, "A 4 ½ hour initial course designed for Healthcare Professionals.  The course covers Adult, Child, and Infant one-rescuer CPR AED, as well as a new focused emphasis on teamwork with the adult, child, and infant two-person rescue.  Topics also include Rescue Breathing and Foreign Body Airway Obstruction. Cost includes the use of a textbook, written and practical exams, and a course completion certification(good for 2 years).New 2015 Guidelines!", "Basic Life Support", null, 50 }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "BookAvailable", "BookPrice", "CategoryId", "Description", "Name", "PrereqId", "TypicalPrice" },
                values: new object[,]
                {
                    { 7, false, 0.0, 1, "For those who have successfully completed the online portion of either BLS course.  Students MUST provide a copy of the online course completion certificate. Cost includes practice time, exam, and course completion certificate(good for 2 years)", "BLS Online Recert – Part 2", 5, 0 },
                    { 12, false, 0.0, 1, "This is a 16 - 20 hour course for those who wish to become AHA Instructor Candidates able to teach various levels of American Heart Association CPR.  Course is taught over 2 or 3 days. Successful completion of AHA BLS for Healthcare Providers Course, as well as each module instructor candidates wish to teach(Heartsaver First Aid, Heartsaver CPR / AED, etc.), and scoring 90 % or better on written examination(within 90 days of the instructor course) is required for completion. A letter of recommendation and completion of Core Instructor Course is required before applying. Cost includes all student level books, instructor manuals, practical exams, and test.New 2015 Guidelines!", "BLS & CPR, Instructor", 5, 50 },
                    { 13, false, 0.0, 1, "For those who have successfully completed the online portion of the Heartsaver CPR/AED course.  Students MUST provide a copy of the online course completion certificate. Cost includes practice time, exam, and course completion certificate(good for 2 years)", "CPR/AED Online Recert 2", 8, 50 },
                    { 14, false, 0.0, 1, "For those who have successfully completed the online portion of the Heartsaver First Aid course.  Students MUST provide a copy of the online course completion certificate. Cost includes practice time, exam, and course completion certificate(good for 2 years)", "First Aid Online Recert 2", 9, 50 },
                    { 4, false, 0.0, 2, "An EMT 20-hour recertification course for those with preexisting EMT certification. This program is designed to train the lay person in emergency care in the pre-hospital environment. This is the entry level in the Emergency Medical Services (EMS) field.  The program follows the current Department of Transportation (DOT) EMT curriculum. The program instructs the student in medical practices available to prehospital personnel, patient assessment and management of trauma and medical emergencies, airway management, resuscitation and pharmacological interventions. This program will develop the student’s confidence, knowledge and skills in performing critical assessment and management of patients with medical and trauma elated life threats.", "EMT Recertification", 3, 0 },
                    { 2, false, 0.0, 3, "An EMR 16-hour recertification course for those with preexisting EMR certification.  This course will prepare the EMR student to provide prehospital assessment and care for patients of all ages with a variety of medical conditions and traumatic injuries. Area of study includes an introduction to emergency medical systems, roles and responsibilities of EMR’s, anatomy and physiology, medical emergencies, trauma, and special considerations for working in the prehospital setting. EMR students will be able to do the following: describe the roles of EMS in the healthcare system, demonstrate the professional attributes expected of the EMRs, perform the roles and responsibilities of an EMR with regards to personal safety as well as safety of others, perform the duties of an EMR with regard to medical - legal and ethical issues, identify and perform lifesaving intervention ns to manage a patient’s airway, breathing and circulation, assess and manage medical and traumatic issues, and apply principles of emergency medical services.", "EMR Recertification", 1, 0 },
                    { 17, false, 0.0, 4, "Current certified lifeguards with valid American Red Cross Lifeguarding/CPR/AED/First aid certification who have expired more than 30 days.  Students must bring proof of valid ARC Lifeguarding, First Aid, and CPR/AED for the Professional Rescuer certification.  Students will be required to swim 300 yards, tread water using legs only for 2 minutes, and retrieve a 10 pound weird from a 7-10 foot depth, swim 20 yards wihth the weight, and exit the pool without using ladder or steps within 100 seconds.  Students will recieve a 2 year ARC certification in Lifeguard, First Aid, and CPR/AED", "ARC Lifeguard Recert", 16, 50 },
                    { 18, false, 0.0, 4, "The purpose of this instructor course is to ttrain candidates to teach courses and presentation in the American Red Cross Swimming and Water Safety program including Parent and Child Aquatics, Preschool Aquatics, Learn-to-Swim, Adult Swim, Private Lessons, Water Safety Courses (including Safety Training for Swim Coaches) and Water Safety Presentations.  Candidates must be at least 16 years old and demonstrate the ability to perform the following swimming skills: Front Crawl, Back Crawl, Breaststroke, Elementary Backstroke, Sidestroke, and Butterfly, all for 25 yards.  Candidates must be able to maintain position on back for 1 minute in deep water (floating or sculling) and must tread water for 1 minute.  The instructor-lead course is 31 hours.  To be certified, candidates must successfully complete the online Intro to the ARC Water Safety Course, complete the Precourse Skills Session, attend and participate in all course sessions, complete class activities including the four practice-teaching assignments, demonstrate instructor-level skill competency in all scenarios, and score a minimum of 80 percent on the instructor course final written exam.", "ARC Water Safety Instructor", 16, 50 },
                    { 19, false, 0.0, 4, "The purpose of the American Red Cross Lifeguard Instructor course is to train candidates to teach the American Red Cross Lifeguarding, Lifeguard Blending Learning, Shallow Water Lifeguard, Water Park Skills, CPR/AED for the Professional Rescuers and Health Care Providers, Administering Emergency Oxygen and Bloodborne Pathogens Training courses and modules.  Candidates must be at least 17 years old, possess current ARC Lifeguarding/CPR/AED/First Aid certification, complete the online Orientation to the ARC and Orientation to the Lifeguard Instructor course and Precourse Exam, successfully complete the Precourse session, and Obtain the Lifeguard Instructor's Manual and Lifeguarding Manual.  To be certified, candidates must successfully complete the online Intro to the ARC Lifeguard Instructor Course, complete the Precourse Skills Session, attend and participate in all course sessions, complete class activities including the four practice-teaching assignments, demonstrate instructor-level skill competency in all scenarios, and score a minimum of 80 percent on the instructor course final written exam.", "ARC Lifeguard Instructor", 16, 50 }
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
