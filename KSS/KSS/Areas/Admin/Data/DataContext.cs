using KSS.Areas.Admin.Models;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace KSS.Areas.Admin.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.SetCommandTimeout(9000);
            this.Database.Migrate();
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }
        public DbSet<Instance> Instance { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<StaffBio> Bio { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //StaffBio
            modelBuilder.Entity<StaffBio>()
                .HasOne(e => e.User)
                .WithMany(e => e.StaffBio)
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            //Course
            modelBuilder.Entity<Course>()
                .HasOne(e => e.Prereq)
                .WithMany(e => e.Courses)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Course>()
                .HasOne(e => e.CourseCategory)
                .WithMany(e => e.Courses)
                .HasForeignKey(e => e.CategoryId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            //Instance
            modelBuilder.Entity<Instance>()
                .HasOne(e => e.Course)
                .WithMany(e => e.Instances)
                .HasForeignKey(e => e.CourseId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            modelBuilder.Entity<Instance>()
                .HasOne(e => e.Location)
                .WithMany(e => e.Instances)
                .HasForeignKey(e => e.LocationId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            modelBuilder.Entity<Instance>()
                .HasOne(e => e.Instructor)
                .WithMany(e => e.Instances)
                .HasForeignKey(e => e.InstructorId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            //Enrollment
            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.User)
                .WithMany(e => e.Enrollments)
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Instance)
                .WithMany(e => e.Enrollments)
                .HasForeignKey(e => e.InstanceId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            Random random = new Random();

            // Seeding database
            modelBuilder.Entity<Course>().HasData
            (
                new Course { CourseId = 1, Name = "Emergency Medical Responder", Description = "Emergency Medical Responder 60-hour course will prepare the EMR student to provide prehospital assessment and care for patients of all ages with a variety of medical conditions and traumatic injuries. Area of study includes an introduction to emergency medical systems, roles and responsibilities of EMR’s, anatomy and physiology, medical emergencies, trauma, and special considerations for working in the prehospital setting. EMR students will be able to do the following: describe the roles of EMS in the healthcare system, demonstrate the professional attributes expected of the EMRs, perform the roles and responsibilities of an EMR with regards to personal safety as well as safety of others, perform the duties of an EMR with regard to medical - legal and ethical issues, identify and perform lifesaving intervention ns to manage a patient’s airway, breathing and circulation, assess and manage medical and traumatic issues, and apply principles of emergency medical services.", TypicalPrice = 0, BookAvailable = false, BookPrice = 0, PrereqId = null, CategoryId = 3 },
                new Course { CourseId = 2, Name = "EMR Recertification", Description = "An EMR 16-hour recertification course for those with preexisting EMR certification.  This course will prepare the EMR student to provide prehospital assessment and care for patients of all ages with a variety of medical conditions and traumatic injuries. Area of study includes an introduction to emergency medical systems, roles and responsibilities of EMR’s, anatomy and physiology, medical emergencies, trauma, and special considerations for working in the prehospital setting. EMR students will be able to do the following: describe the roles of EMS in the healthcare system, demonstrate the professional attributes expected of the EMRs, perform the roles and responsibilities of an EMR with regards to personal safety as well as safety of others, perform the duties of an EMR with regard to medical - legal and ethical issues, identify and perform lifesaving intervention ns to manage a patient’s airway, breathing and circulation, assess and manage medical and traumatic issues, and apply principles of emergency medical services.", TypicalPrice = 0, BookAvailable = false, BookPrice = 0, PrereqId = 1, CategoryId = 3 },
                new Course { CourseId = 3, Name = "Emergency Medical Technician", Description = "The Emergency Medical Technician (EMT) 160-hour program is designed to train the lay person in emergency care in the pre-hospital environment. This is the entry level in the Emergency Medical Services (EMS) field.  The program follows the current Department of Transportation (DOT) EMT curriculum. The program instructs the student in medical practices available to prehospital personnel, patient assessment and management of trauma and medical emergencies, airway management, resuscitation and pharmacological interventions. This program will develop the student’s confidence, knowledge and skills in performing critical assessment and management of patients with medical and trauma elated life threats.", TypicalPrice = 0, BookAvailable = false, BookPrice = 0, PrereqId = null, CategoryId = 2 },
                new Course { CourseId = 4, Name = "EMT Recertification", Description = "An EMT 20-hour recertification course for those with preexisting EMT certification. This program is designed to train the lay person in emergency care in the pre-hospital environment. This is the entry level in the Emergency Medical Services (EMS) field.  The program follows the current Department of Transportation (DOT) EMT curriculum. The program instructs the student in medical practices available to prehospital personnel, patient assessment and management of trauma and medical emergencies, airway management, resuscitation and pharmacological interventions. This program will develop the student’s confidence, knowledge and skills in performing critical assessment and management of patients with medical and trauma elated life threats.", TypicalPrice = 0, BookAvailable = false, BookPrice = 0, PrereqId = 3, CategoryId = 2 },
                new Course { CourseId = 5, Name = "Basic Life Support", Description = "A 4 ½ hour initial course designed for Healthcare Professionals.  The course covers Adult, Child, and Infant one-rescuer CPR AED, as well as a new focused emphasis on teamwork with the adult, child, and infant two-person rescue.  Topics also include Rescue Breathing and Foreign Body Airway Obstruction. Cost includes the use of a textbook, written and practical exams, and a course completion certification(good for 2 years).New 2015 Guidelines!", TypicalPrice = 50, BookAvailable = true, BookPrice = 25, PrereqId = null, CategoryId = 1},
                new Course { CourseId = 6, Name = "Basic Life Support w/ CPR Refr", Description = "A 4 hour refresher course for the Healthcare Professional; this course offers guidelines in one and two-rescuer adult, child, and infant CPR, Foreign Body Airway Obstruction, and AED training. Cost includes the use of a students’ textbook, written and practical exams, and course completion certification(good for 2 years).New 2015 Guidelines!", TypicalPrice = 50, BookAvailable = false, BookPrice = 0, PrereqId = null, CategoryId = 1 },
                new Course { CourseId = 7, Name = "BLS Online Recert – Part 2", Description = "For those who have successfully completed the online portion of either BLS course.  Students MUST provide a copy of the online course completion certificate. Cost includes practice time, exam, and course completion certificate(good for 2 years)", BookAvailable = false, BookPrice = 0, PrereqId = 5, CategoryId = 1 },
                new Course { CourseId = 8, Name = "Heartsaver CPR/AED ", Description = "A 2-3 hour course designed to teach the lay rescuer (security guards, personal trainers, church organization teachers, etc.) how to recognize and treat life-threatening emergencies whose job requires a course completion card documenting one-rescuer adult and/or pediatric CPR, Foreign Body Airway Obstruction, and AED training. Cost includes the use of a textbook, practice exam, and course completion certificate(good for 2 years).New 2015 Guidelines!", TypicalPrice = 50, BookAvailable = true, BookPrice = 15, PrereqId = null, CategoryId = 1 },
                new Course { CourseId = 9, Name = "Heartsaver First Aid ", Description = "A 4 hour course designed for the general public or lay rescuer whose job requires a first aid course completion card.  The course provides the skills to effectively asses and maintain life from the critical minutes of an emergency until the arrival of emergency service personnel.  Depending on which modules the candidate wishes to take, the basic first aid course consists of General Principles, Medical Emergencies, and Injury Emergencies.  Also includes CPR and AED training, and Environmental Emergencies. Cost includes use of a textbook, practice exam, and course completion certificate(good for 2 years).New 2015 Guidelines!", TypicalPrice = 50, BookAvailable = true, BookPrice = 15, PrereqId = null, CategoryId = 1 },
                new Course { CourseId = 10, Name = "Heartsaver Pediatric First Aid", Description = "A 6-8 hour First Aid course designed for childcare workers whose job requires a pediatric-specific first aid completion card.  This course provides the skills to effectively asses and maintain a child’s life in the critical minutes following an emergency until the arrival of emergency personnel.  This course covers all State of Louisiana required modules including Child Care specific topics, General Principles, Medical Emergencies, Injury Emergencies, and Environmental Emergencies.  Also includes CPR and AED training for Adult, Children, and Infants. Cost includes use of a textbook, skills, and course completion certification(good for 2 years).New 2015 Guidelines!", TypicalPrice = 50, BookAvailable = false, BookPrice = 0, PrereqId = null, CategoryId = 1 },
                new Course { CourseId = 11, Name = "Family and Friends CPR", Description = "A 2 ½ hour entry level awareness program designed for the general public, parents, babysitters, grandparents, churches, clubs, etc.  The course covers American Heart Association guidelines for the one-rescuer adult including Pediatric CPR, relief of Foreign Body Airway Obstructions, the chain of survival, Basic First Aid, and recognizing the signs of a heart attack and stroke. Cost includes a student textbook.New 2016 Guidelines!", TypicalPrice = 50, BookAvailable = false, BookPrice = 0, PrereqId = null, CategoryId = 1 },
                new Course { CourseId = 12, Name = "BLS & CPR, Instructor", Description = "This is a 16 - 20 hour course for those who wish to become AHA Instructor Candidates able to teach various levels of American Heart Association CPR.  Course is taught over 2 or 3 days. Successful completion of AHA BLS for Healthcare Providers Course, as well as each module instructor candidates wish to teach(Heartsaver First Aid, Heartsaver CPR / AED, etc.), and scoring 90 % or better on written examination(within 90 days of the instructor course) is required for completion. A letter of recommendation and completion of Core Instructor Course is required before applying. Cost includes all student level books, instructor manuals, practical exams, and test.New 2015 Guidelines!", TypicalPrice = 50, BookAvailable = false, BookPrice = 0, PrereqId = 5, CategoryId = 1 },
                new Course { CourseId = 13, Name = "CPR/AED Online Recert 2", Description = "For those who have successfully completed the online portion of the Heartsaver CPR/AED course.  Students MUST provide a copy of the online course completion certificate. Cost includes practice time, exam, and course completion certificate(good for 2 years)", TypicalPrice = 50, BookAvailable = false, BookPrice = 0, PrereqId = 8, CategoryId = 1 },
                new Course { CourseId = 14, Name = "First Aid Online Recert 2", Description = "For those who have successfully completed the online portion of the Heartsaver First Aid course.  Students MUST provide a copy of the online course completion certificate. Cost includes practice time, exam, and course completion certificate(good for 2 years)", TypicalPrice = 50, BookAvailable = false, BookPrice = 0, PrereqId = 9, CategoryId = 1 },
                new Course { CourseId = 15, Name = "ARC Babysitting  BOOT CAMP", Description = "This 14 hour, 2 day class following American Red Cross standards will educate the babysitter on skills necessary to provide quality care to children of all ages.  Participants must be ages 11 and older and will learn Adult/Child/Infant CPR and AED, basic first aid, child behavior, age-appropriate activities, basic child care (including bottling, feeding, and diapering), and professionalism.  This courses teaches techniques necessary for all babysitters.", TypicalPrice = 50, BookAvailable = false, BookPrice = 0, PrereqId = null, CategoryId = 6 },
                new Course { CourseId = 16, Name = "ARC Initial Lifeguard", Description = "The purpose of the American Red Cross Lifeguard Course is to provide entry-level lifeguard participants with knowledge and skills to prevent, recognize, and respond to aquatic emergencies.  The lifeguard will also learn care for breathing and cardiac emergencies, as well as first aid skills.  This is a 25 hour course taught by a certified ARC instructor.  Students must be 15 years or older and able to swim 300 yards continuously demonstrating breath control and rhythmic breating.  Candidates may swim using front crawl, breaststroke, or combination only; side or back swimming is not allowed. Goggles may be worn for this portion.  Candidates must also be able to tread water for 2 minutes using only legs (arms will be placed under armpits) and complete a timed event within 1 minute 40 seconds.  Candidates will be required to swim 20 yards without goggles and surface dive (feet or head first) to a depth of 7 to 10 feet to retrieve a 10 pound object.  Candidates must also exit the water without using a ladder or steps.", TypicalPrice = 50, BookAvailable = false, BookPrice = 0, PrereqId = null, CategoryId = 4 },
                new Course { CourseId = 17, Name = "ARC Lifeguard Recert", Description = "Current certified lifeguards with valid American Red Cross Lifeguarding/CPR/AED/First aid certification who have expired more than 30 days.  Students must bring proof of valid ARC Lifeguarding, First Aid, and CPR/AED for the Professional Rescuer certification.  Students will be required to swim 300 yards, tread water using legs only for 2 minutes, and retrieve a 10 pound weird from a 7-10 foot depth, swim 20 yards wihth the weight, and exit the pool without using ladder or steps within 100 seconds.  Students will recieve a 2 year ARC certification in Lifeguard, First Aid, and CPR/AED", TypicalPrice = 50, BookAvailable = false, BookPrice = 0, PrereqId = 16, CategoryId = 4 },
                new Course { CourseId = 18, Name = "ARC Water Safety Instructor", Description = "The purpose of this instructor course is to ttrain candidates to teach courses and presentation in the American Red Cross Swimming and Water Safety program including Parent and Child Aquatics, Preschool Aquatics, Learn-to-Swim, Adult Swim, Private Lessons, Water Safety Courses (including Safety Training for Swim Coaches) and Water Safety Presentations.  Candidates must be at least 16 years old and demonstrate the ability to perform the following swimming skills: Front Crawl, Back Crawl, Breaststroke, Elementary Backstroke, Sidestroke, and Butterfly, all for 25 yards.  Candidates must be able to maintain position on back for 1 minute in deep water (floating or sculling) and must tread water for 1 minute.  The instructor-lead course is 31 hours.  To be certified, candidates must successfully complete the online Intro to the ARC Water Safety Course, complete the Precourse Skills Session, attend and participate in all course sessions, complete class activities including the four practice-teaching assignments, demonstrate instructor-level skill competency in all scenarios, and score a minimum of 80 percent on the instructor course final written exam.", TypicalPrice = 50, BookAvailable = false, BookPrice = 0, PrereqId = 16, CategoryId = 4 },
                new Course { CourseId = 19, Name = "ARC Lifeguard Instructor", Description = "The purpose of the American Red Cross Lifeguard Instructor course is to train candidates to teach the American Red Cross Lifeguarding, Lifeguard Blending Learning, Shallow Water Lifeguard, Water Park Skills, CPR/AED for the Professional Rescuers and Health Care Providers, Administering Emergency Oxygen and Bloodborne Pathogens Training courses and modules.  Candidates must be at least 17 years old, possess current ARC Lifeguarding/CPR/AED/First Aid certification, complete the online Orientation to the ARC and Orientation to the Lifeguard Instructor course and Precourse Exam, successfully complete the Precourse session, and Obtain the Lifeguard Instructor's Manual and Lifeguarding Manual.  To be certified, candidates must successfully complete the online Intro to the ARC Lifeguard Instructor Course, complete the Precourse Skills Session, attend and participate in all course sessions, complete class activities including the four practice-teaching assignments, demonstrate instructor-level skill competency in all scenarios, and score a minimum of 80 percent on the instructor course final written exam.", TypicalPrice = 50, BookAvailable = false, BookPrice = 0, PrereqId = 16, CategoryId = 4 },
                new Course { CourseId = 20, Name = "Car Seat Safety", Description = "This is a free service by certified child passenger safety technicians to lower childhood deaths and injuries.  To stay informed of events and education, please follow Buckle Up Louisiana on Facebook.  Nicole Dufrene can assist anyone who has questions concerning car safety seat information FREE of charge. Her email is: nicoledufrene0301@gmail.com.  Additional information can be found at The National Highway and Traffic Safety website https://www.nhtsa.gov/.  Also visit https://www.safekids.org/child-passenger-safety to learn more about the organization that regulates the  curriculum for our classes and also has a find a fitting station near you.", TypicalPrice = 0, BookAvailable = false, BookPrice = 0, PrereqId = null, CategoryId = 5 }

            );

            modelBuilder.Entity<Category>().HasData
            (
                new Category { CategoryId = 1, Name = "CPR", Title = "CPR, Life Support, and First Aid", Description = "Learn CPR, a medical procedure involving specific compression of a patient's chest, performed in an attempt to bring back the blood circulation and breathing of a person who has suffered cardiac arrest." },
                new Category { CategoryId = 2, Name = "EMT", Title = "Emergency Medical Technician", Description = "Interested in becoming an EMT? An EMT is a specially trained technician certified to provide basic emergency services before and during transportation to a hospital." },
                new Category { CategoryId = 3, Name = "EMR", Title = "Emergency Medical Responder", Description = "In case of a medical emergency, learn techniques and procedures for helping others in need of immediate attention and treating minor wounds." },
                new Category { CategoryId = 4, Name = "AQU", Title = "Aquatic Rescue", Description = "These courses teach applicable safety practices for individuals such as swim coaches, lifeguard instructors, and even professional rescuers." },
                new Category { CategoryId = 5, Name = "CAR", Title = "Car Seat Safety", Description = "Learn how to properly conduct child safety seat checks and be informed on the best way to utilize and understand seat belts and child restraint systems while in motorized vehicles." },
                new Category { CategoryId = 6, Name = "BBS", Title = "Babysitting Safety", Description = "Babysitting can sometimes be difficult, but our courses teach babysitting skills, such as leadership, keeping children safe, and helping kids to behave, to anyone who wants to learn or even grow a babysitting business." }
            );

            modelBuilder.Entity<StaffBio>().HasData(
                new StaffBio { StaffBioId = 1, Picture = "https://image.ibb.co/jkKE2A/user-placeholder.png", Bio = "Becky Smith is the owner of Keeping Safety Smart. With over 20 years of emergency/life saver teaching experience, Ms. Smith founded Keeping Safety Smart in 2015.", UserId = 1 },
                new StaffBio { StaffBioId = 2, Picture = "https://image.ibb.co/jkKE2A/user-placeholder.png", Bio = "Nicole Dufrene EMR has a passion to help protect our littles one from the number one cause of children's death motor vehicle accidents.  She is driven to help educate about how to properly install a car seat and make sure your little ones are safe and secured.", UserId = 2 },
                new StaffBio { StaffBioId = 3, Picture = "https://image.ibb.co/jkKE2A/user-placeholder.png", Bio = "Dennis Pitts NREMT is a seasoned fire fighter in the Tangipahoa Parish area.  He teaches all the CPR, first aid, and bureau of EM S classes.", UserId = 3 },
                new StaffBio { StaffBioId = 4, Picture = "https://image.ibb.co/jkKE2A/user-placeholder.png", Bio = "Clayton Cawyer NREMT has been teaching for several years in the CPR, first aid and Bureau of EMS classes as well as a fire fighter in the St. Tammany area. ", UserId = 4 },
                new StaffBio { StaffBioId = 5, Picture = "https://image.ibb.co/jkKE2A/user-placeholder.png", Bio = "Jodi Toliver MS is an instructor train the trainer and has been teach water classes for over 25 years.  She will also be helping to teach the American Red Cross babysitters class.", UserId = 5 },
                new StaffBio { StaffBioId = 6, Picture = "https://image.ibb.co/jkKE2A/user-placeholder.png", Bio = "Savannah Rachel RN started her career as an EMT and has continued her education in the healthcare field.  She is currently working at East Jefferson Hospital and will be teaching the ACLS classes.", UserId = 6 },
                new StaffBio { StaffBioId = 7, Picture = "https://image.ibb.co/jkKE2A/user-placeholder.png", Bio = "Jackie Smith BSN is finish her Masters degree in Nursing education she is a current cardiac nurse.  She will be teaching the ACLS classes.", UserId = 7 },
                new StaffBio { StaffBioId = 8, Picture = "https://image.ibb.co/jkKE2A/user-placeholder.png", Bio = "I am Staff 6!", UserId = 8 },
                new StaffBio { StaffBioId = 9, Picture = "https://image.ibb.co/jkKE2A/user-placeholder.png", Bio = "I am Staff 6!", UserId = 9 },
                new StaffBio { StaffBioId = 10, Picture = "https://image.ibb.co/jkKE2A/user-placeholder.png", Bio = "I am Staff 6!", UserId = 10 }
            );
            
            //Enrollments
            for(int i=1,j=1; j < 30 && i<510; j++)
            {
                for(int k = 1; k < 18; k++)
                {
                    modelBuilder.Entity<Enrollment>().HasData
                    (
                        new Enrollment { EnrollmentId = i++, InstanceId = j, UserId = k, Status = 'E', BookBought = 0 < random.Next(0, 2), Paid = 0 < random.Next(0, 2) }
                    );
                }
            }

            //Instances
            for(int i = 1; i < 30; i++)
            {
                modelBuilder.Entity<Instance>().HasData
                (
                        new Instance { InstanceId = i, StartDate = new DateTimeOffset(random.Next(2016,2020), random.Next(1,13), random.Next(1, 29), random.Next(7, 19), 00, 00, new TimeSpan(-6, 0, 0)), Price = (double)random.Next(45,150), CourseId = random.Next(1,11), LocationId = random.Next(1, 4), Seats = random.Next(10, 31), InstructorId = random.Next(1, 7), BookAvailable = 0<random.Next(1, 3), BookPrice = random.Next(15, 56) }
                );
            }
            
            modelBuilder.Entity<Location>().HasData
            (
                new Location { LocationId = 1, Name = "Hammond Fire Department", Street = "405 S. Oak Street", City = "Hammond", State = "LA", Zipcode = 70403 },
                new Location { LocationId = 2, Name = "Tickfaw Emergency Care", Street = "92 Hill Street", City = "Tickfaw", State = "LA", Zipcode = 70442 },
                new Location { LocationId = 3, Name = "Independence Fire", Street = "12044 Hwy 40", City = "Independence", State = "LA", Zipcode = 70443 },
                new Location { LocationId = 4, Name = "Mandeville Fire Department", Street = "24301 Highway 190", City = "Mandeville", State = "LA", Zipcode = 70448 },
                new Location { LocationId = 5, Name = "Slidell Fire Department", Street = "375 Bouscaren St", City = "Slidell", State = "LA", Zipcode = 70458 }
            );
            
            //------admin password/salt
            byte[] saltAdmin = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltAdmin);
            }
            string hashedAdmin = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: "admin",
                salt: saltAdmin,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));

            //------student password/salt
            byte[] saltStudent = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltStudent);
            }
            string hashedStudent = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: "student",
                salt: saltStudent,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));

            modelBuilder.Entity<User>().HasData
            (
                // admin
                new User { UserId = 1, FirstName = "Becky", LastName = "Smith", Phone = "1112223333", Email = "admin@admin.com", Password = hashedAdmin, Salt = saltAdmin, Role = "Admin" },
                // actual staff
                new User { UserId = 2, FirstName = "Nicole", LastName = "Dufrene", Phone = "1112223333", Email = "nicoledufrene0301@gmail.com", Password = hashedStudent, Salt = saltStudent, Role = "Staff"},
                new User { UserId = 3, FirstName = "Dennis", LastName = "Pitts", Phone = "1112223333", Email = "student2@student.com", Password = hashedStudent, Salt = saltStudent, Role = "Staff" },
                new User { UserId = 4, FirstName = "Clayton", LastName = "Cawyer", Phone = "1112223333", Email = "student3@student.com", Password = hashedStudent, Salt = saltStudent, Role = "Staff" },
                new User { UserId = 5, FirstName = "Jodi", LastName = "Toliver", Phone = "1112223333", Email = "student4@student.com", Password = hashedStudent, Salt = saltStudent, Role = "Staff" },
                new User { UserId = 6, FirstName = "Savannah", LastName = "Rachel", Phone = "1112223333", Email = "student5@student.com", Password = hashedStudent, Salt = saltStudent, Role = "Staff" },
                new User { UserId = 7, FirstName = "Jackie", LastName = "Smith", Phone = "1112223333", Email = "student6@student.com", Password = hashedStudent, Salt = saltStudent, Role = "Staff"},
                //students / seed data
                new User { UserId = 8, FirstName = "Trenton", LastName = "Hillsong", Phone = "1112223333", Email = "student7@student.com", Password = hashedStudent, Salt = saltStudent, Role = "User" },
                new User { UserId = 9, FirstName = "Colin", LastName = "Livers", Phone = "1112223333", Email = "student8@student.com", Password = hashedStudent, Salt = saltStudent, Role = "User"},
                new User { UserId = 10, FirstName = "Babe", LastName = "Ruth", Phone = "1112223333", Email = "student9@student.com", Password = hashedStudent, Salt = saltStudent, Role = "User"},
                new User { UserId = 11, FirstName = "Tim", LastName = "Hammond", Phone = "1112223333", Email = "student10@student.com", Password = hashedStudent, Salt = saltStudent, Role = "User" },
                new User { UserId = 12, FirstName = "Gary", LastName = "Aimes", Phone = "1112223333", Email = "student11@student.com", Password = hashedStudent, Salt = saltStudent, Role = "User"},
                new User { UserId = 13, FirstName = "Lucy", LastName = "Vilardo", Phone = "1112223333", Email = "student12@student.com", Password = hashedStudent, Salt = saltStudent, Role = "User" },
                new User { UserId = 14, FirstName = "Tom", LastName = "Avers", Phone = "1112223333", Email = "student13@student.com", Password = hashedStudent, Salt = saltStudent, Role = "User" },
                new User { UserId = 15, FirstName = "Amanda", LastName = "Catalonato", Phone = "1112223333", Email = "student14@student.com", Password = hashedStudent, Salt = saltStudent, Role = "User"},
                new User { UserId = 16, FirstName = "Donald", LastName = "Hill", Phone = "1112223333", Email = "student15@student.com", Password = hashedStudent, Salt = saltStudent, Role = "User" },
                new User { UserId = 17, FirstName = "Richard", LastName = "Newman", Phone = "1112223333", Email = "student16@student.com", Password = hashedStudent, Salt = saltStudent, Role = "User"}
            );
        }
    }
}
