using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KSS.Migrations
{
    public partial class finalseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bio",
                keyColumn: "StaffBioId",
                keyValue: 1,
                column: "Picture",
                value: "https://image.ibb.co/jkKE2A/user-placeholder.png");

            migrationBuilder.UpdateData(
                table: "Bio",
                keyColumn: "StaffBioId",
                keyValue: 2,
                columns: new[] { "Bio", "Picture" },
                values: new object[] { "Nicole Dufrene EMR has a passion to help protect our littles one from the number one cause of children's death motor vehicle accidents.  She is driven to help educate about how to properly install a car seat and make sure your little ones are safe and secured.", "https://image.ibb.co/jkKE2A/user-placeholder.png" });

            migrationBuilder.UpdateData(
                table: "Bio",
                keyColumn: "StaffBioId",
                keyValue: 3,
                columns: new[] { "Bio", "Picture" },
                values: new object[] { "Dennis Pitts NREMT is a seasoned fire fighter in the Tangipahoa Parish area.  He teaches all the CPR, first aid, and bureau of EM S classes.", "https://image.ibb.co/jkKE2A/user-placeholder.png" });

            migrationBuilder.UpdateData(
                table: "Bio",
                keyColumn: "StaffBioId",
                keyValue: 4,
                columns: new[] { "Bio", "Picture" },
                values: new object[] { "Clayton Cawyer NREMT has been teaching for several years in the CPR, first aid and Bureau of EMS classes as well as a fire fighter in the St. Tammany area. ", "https://image.ibb.co/jkKE2A/user-placeholder.png" });

            migrationBuilder.UpdateData(
                table: "Bio",
                keyColumn: "StaffBioId",
                keyValue: 5,
                columns: new[] { "Bio", "Picture" },
                values: new object[] { "Jodi Toliver MS is an instructor train the trainer and has been teach water classes for over 25 years.  She will also be helping to teach the American Red Cross babysitters class.", "https://image.ibb.co/jkKE2A/user-placeholder.png" });

            migrationBuilder.UpdateData(
                table: "Bio",
                keyColumn: "StaffBioId",
                keyValue: 6,
                columns: new[] { "Bio", "Picture" },
                values: new object[] { "Savannah Rachel RN started her career as an EMT and has continued her education in the healthcare field.  She is currently working at East Jefferson Hospital and will be teaching the ACLS classes.", "https://image.ibb.co/jkKE2A/user-placeholder.png" });

            migrationBuilder.UpdateData(
                table: "Bio",
                keyColumn: "StaffBioId",
                keyValue: 7,
                columns: new[] { "Bio", "Picture" },
                values: new object[] { "Jackie Smith BSN is finish her Masters degree in Nursing education she is a current cardiac nurse.  She will be teaching the ACLS classes.", "https://image.ibb.co/jkKE2A/user-placeholder.png" });

            migrationBuilder.UpdateData(
                table: "Bio",
                keyColumn: "StaffBioId",
                keyValue: 8,
                column: "Picture",
                value: "https://image.ibb.co/jkKE2A/user-placeholder.png");

            migrationBuilder.UpdateData(
                table: "Bio",
                keyColumn: "StaffBioId",
                keyValue: 9,
                column: "Picture",
                value: "https://image.ibb.co/jkKE2A/user-placeholder.png");

            migrationBuilder.UpdateData(
                table: "Bio",
                keyColumn: "StaffBioId",
                keyValue: 10,
                column: "Picture",
                value: "https://image.ibb.co/jkKE2A/user-placeholder.png");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "BookAvailable", "BookPrice", "CategoryId", "Description", "Name", "TypicalPrice" },
                values: new object[] { false, 0.0, 3, "Emergency Medical Responder 60-hour course will prepare the EMR student to provide prehospital assessment and care for patients of all ages with a variety of medical conditions and traumatic injuries. Area of study includes an introduction to emergency medical systems, roles and responsibilities of EMR’s, anatomy and physiology, medical emergencies, trauma, and special considerations for working in the prehospital setting. EMR students will be able to do the following: describe the roles of EMS in the healthcare system, demonstrate the professional attributes expected of the EMRs, perform the roles and responsibilities of an EMR with regards to personal safety as well as safety of others, perform the duties of an EMR with regard to medical - legal and ethical issues, identify and perform lifesaving intervention ns to manage a patient’s airway, breathing and circulation, assess and manage medical and traumatic issues, and apply principles of emergency medical services.", "Emergency Medical Responder (EMR)", 0 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "Name", "PrereqId", "TypicalPrice" },
                values: new object[] { 3, "An EMR 16-hour recertification course for those with preexisting EMR certification.  This course will prepare the EMR student to provide prehospital assessment and care for patients of all ages with a variety of medical conditions and traumatic injuries. Area of study includes an introduction to emergency medical systems, roles and responsibilities of EMR’s, anatomy and physiology, medical emergencies, trauma, and special considerations for working in the prehospital setting. EMR students will be able to do the following: describe the roles of EMS in the healthcare system, demonstrate the professional attributes expected of the EMRs, perform the roles and responsibilities of an EMR with regards to personal safety as well as safety of others, perform the duties of an EMR with regard to medical - legal and ethical issues, identify and perform lifesaving intervention ns to manage a patient’s airway, breathing and circulation, assess and manage medical and traumatic issues, and apply principles of emergency medical services.", "EMR Recertification", 1, 0 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 3,
                columns: new[] { "CategoryId", "Description", "Name", "PrereqId" },
                values: new object[] { 2, "The Emergency Medical Technician (EMT) 160-hour program is designed to train the lay person in emergency care in the pre-hospital environment. This is the entry level in the Emergency Medical Services (EMS) field.  The program follows the current Department of Transportation (DOT) EMT curriculum. The program instructs the student in medical practices available to prehospital personnel, patient assessment and management of trauma and medical emergencies, airway management, resuscitation and pharmacological interventions. This program will develop the student’s confidence, knowledge and skills in performing critical assessment and management of patients with medical and trauma elated life threats.", "Emergency Medical Technician (EMT)", null });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 4,
                columns: new[] { "BookAvailable", "BookPrice", "CategoryId", "Description", "Name", "PrereqId", "TypicalPrice" },
                values: new object[] { false, 0.0, 2, "An EMT 20-hour recertification course for those with preexisting EMT certification. This program is designed to train the lay person in emergency care in the pre-hospital environment. This is the entry level in the Emergency Medical Services (EMS) field.  The program follows the current Department of Transportation (DOT) EMT curriculum. The program instructs the student in medical practices available to prehospital personnel, patient assessment and management of trauma and medical emergencies, airway management, resuscitation and pharmacological interventions. This program will develop the student’s confidence, knowledge and skills in performing critical assessment and management of patients with medical and trauma elated life threats.", "EMT Recertification", 3, 0 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 5,
                columns: new[] { "BookPrice", "Description", "Name" },
                values: new object[] { 25.0, "A 4 ½ hour initial course designed for Healthcare Professionals.  The course covers Adult, Child, and Infant one-rescuer CPR AED, as well as a new focused emphasis on teamwork with the adult, child, and infant two-person rescue.  Topics also include Rescue Breathing and Foreign Body Airway Obstruction. Cost includes the use of a textbook, written and practical exams, and a course completion certification(good for 2 years).New 2015 Guidelines!", "Basic Life Support" });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 6,
                columns: new[] { "Description", "Name" },
                values: new object[] { "A 4 hour refresher course for the Healthcare Professional; this course offers guidelines in one and two-rescuer adult, child, and infant CPR, Foreign Body Airway Obstruction, and AED training. Cost includes the use of a students’ textbook, written and practical exams, and course completion certification(good for 2 years).New 2015 Guidelines!", "Basic Life Support w/ CPR Refr" });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 7,
                columns: new[] { "Description", "Name", "PrereqId", "TypicalPrice" },
                values: new object[] { "For those who have successfully completed the online portion of either BLS course.  Students MUST provide a copy of the online course completion certificate. Cost includes practice time, exam, and course completion certificate(good for 2 years)", "BLS Online Recert – Part 2", 5, 0 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 8,
                columns: new[] { "BookAvailable", "BookPrice", "Description", "Name", "PrereqId" },
                values: new object[] { true, 15.0, "A 2-3 hour course designed to teach the lay rescuer (security guards, personal trainers, church organization teachers, etc.) how to recognize and treat life-threatening emergencies whose job requires a course completion card documenting one-rescuer adult and/or pediatric CPR, Foreign Body Airway Obstruction, and AED training. Cost includes the use of a textbook, practice exam, and course completion certificate(good for 2 years).New 2015 Guidelines!", "Heartsaver CPR/AED ", null });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 9,
                columns: new[] { "BookAvailable", "BookPrice", "Description", "Name", "PrereqId" },
                values: new object[] { true, 15.0, "A 4 hour course designed for the general public or lay rescuer whose job requires a first aid course completion card.  The course provides the skills to effectively asses and maintain life from the critical minutes of an emergency until the arrival of emergency service personnel.  Depending on which modules the candidate wishes to take, the basic first aid course consists of General Principles, Medical Emergencies, and Injury Emergencies.  Also includes CPR and AED training, and Environmental Emergencies. Cost includes use of a textbook, practice exam, and course completion certificate(good for 2 years).New 2015 Guidelines!", "Heartsaver First Aid ", null });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 10,
                columns: new[] { "Description", "Name", "PrereqId" },
                values: new object[] { "A 6-8 hour First Aid course designed for childcare workers whose job requires a pediatric-specific first aid completion card.  This course provides the skills to effectively asses and maintain a child’s life in the critical minutes following an emergency until the arrival of emergency personnel.  This course covers all State of Louisiana required modules including Child Care specific topics, General Principles, Medical Emergencies, Injury Emergencies, and Environmental Emergencies.  Also includes CPR and AED training for Adult, Children, and Infants. Cost includes use of a textbook, skills, and course completion certification(good for 2 years).New 2015 Guidelines!", "Heartsaver Pediatric First Aid", null });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 11,
                columns: new[] { "CategoryId", "Description", "Name" },
                values: new object[] { 1, "A 2 ½ hour entry level awareness program designed for the general public, parents, babysitters, grandparents, churches, clubs, etc.  The course covers American Heart Association guidelines for the one-rescuer adult including Pediatric CPR, relief of Foreign Body Airway Obstructions, the chain of survival, Basic First Aid, and recognizing the signs of a heart attack and stroke. Cost includes a student textbook.New 2016 Guidelines!", "Family and Friends CPR" });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 12,
                columns: new[] { "CategoryId", "Description", "Name", "PrereqId" },
                values: new object[] { 1, "This is a 16 - 20 hour course for those who wish to become AHA Instructor Candidates able to teach various levels of American Heart Association CPR.  Course is taught over 2 or 3 days. Successful completion of AHA BLS for Healthcare Providers Course, as well as each module instructor candidates wish to teach(Heartsaver First Aid, Heartsaver CPR / AED, etc.), and scoring 90 % or better on written examination(within 90 days of the instructor course) is required for completion. A letter of recommendation and completion of Core Instructor Course is required before applying. Cost includes all student level books, instructor manuals, practical exams, and test.New 2015 Guidelines!", "BLS & CPR, Instructor", 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 13,
                columns: new[] { "CategoryId", "Description", "Name", "PrereqId" },
                values: new object[] { 1, "For those who have successfully completed the online portion of the Heartsaver CPR/AED course.  Students MUST provide a copy of the online course completion certificate. Cost includes practice time, exam, and course completion certificate(good for 2 years)", "CPR/AED Online Recert 2", 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 14,
                columns: new[] { "CategoryId", "Description", "Name", "PrereqId" },
                values: new object[] { 1, "For those who have successfully completed the online portion of the Heartsaver First Aid course.  Students MUST provide a copy of the online course completion certificate. Cost includes practice time, exam, and course completion certificate(good for 2 years)", "First Aid Online Recert 2", 9 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 15,
                columns: new[] { "CategoryId", "Description", "Name", "PrereqId" },
                values: new object[] { 6, "This 14 hour, 2 day class following American Red Cross standards will educate the babysitter on skills necessary to provide quality care to children of all ages.  Participants must be ages 11 and older and will learn Adult/Child/Infant CPR and AED, basic first aid, child behavior, age-appropriate activities, basic child care (including bottling, feeding, and diapering), and professionalism.  This courses teaches techniques necessary for all babysitters.", "ARC Babysitting  BOOT CAMP", null });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 16,
                columns: new[] { "CategoryId", "Description", "Name", "TypicalPrice" },
                values: new object[] { 4, "The purpose of the American Red Cross Lifeguard Course is to provide entry-level lifeguard participants with knowledge and skills to prevent, recognize, and respond to aquatic emergencies.  The lifeguard will also learn care for breathing and cardiac emergencies, as well as first aid skills.  This is a 25 hour course taught by a certified ARC instructor.  Students must be 15 years or older and able to swim 300 yards continuously demonstrating breath control and rhythmic breating.  Candidates may swim using front crawl, breaststroke, or combination only; side or back swimming is not allowed. Goggles may be worn for this portion.  Candidates must also be able to tread water for 2 minutes using only legs (arms will be placed under armpits) and complete a timed event within 1 minute 40 seconds.  Candidates will be required to swim 20 yards without goggles and surface dive (feet or head first) to a depth of 7 to 10 feet to retrieve a 10 pound object.  Candidates must also exit the water without using a ladder or steps.", "ARC Initial Lifeguard", 50 });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "BookAvailable", "BookPrice", "CategoryId", "Description", "Name", "PrereqId", "TypicalPrice" },
                values: new object[,]
                {
                    { 20, false, 0.0, 5, "This is a free service by certified child passenger safety technicians to lower childhood deaths and injuries.  To stay informed of events and education, please follow Buckle Up Louisiana on Facebook.  Nicole Dufrene can assist anyone who has questions concerning car safety seat information FREE of charge. Her email is: nicoledufrene0301@gmail.com.  Additional information can be found at The National Highway and Traffic Safety website https://www.nhtsa.gov/.  Also visit https://www.safekids.org/child-passenger-safety to learn more about the organization that regulates the  curriculum for our classes and also has a find a fitting station near you.", "Car Seat Safety", null, 0 },
                    { 18, false, 0.0, 4, "The purpose of this instructor course is to ttrain candidates to teach courses and presentation in the American Red Cross Swimming and Water Safety program including Parent and Child Aquatics, Preschool Aquatics, Learn-to-Swim, Adult Swim, Private Lessons, Water Safety Courses (including Safety Training for Swim Coaches) and Water Safety Presentations.  Candidates must be at least 16 years old and demonstrate the ability to perform the following swimming skills: Front Crawl, Back Crawl, Breaststroke, Elementary Backstroke, Sidestroke, and Butterfly, all for 25 yards.  Candidates must be able to maintain position on back for 1 minute in deep water (floating or sculling) and must tread water for 1 minute.  The instructor-lead course is 31 hours.  To be certified, candidates must successfully complete the online Intro to the ARC Water Safety Course, complete the Precourse Skills Session, attend and participate in all course sessions, complete class activities including the four practice-teaching assignments, demonstrate instructor-level skill competency in all scenarios, and score a minimum of 80 percent on the instructor course final written exam.", "ARC Water Safety Instructor", 16, 50 },
                    { 17, false, 0.0, 4, "Current certified lifeguards with valid American Red Cross Lifeguarding/CPR/AED/First aid certification who have expired more than 30 days.  Students must bring proof of valid ARC Lifeguarding, First Aid, and CPR/AED for the Professional Rescuer certification.  Students will be required to swim 300 yards, tread water using legs only for 2 minutes, and retrieve a 10 pound weird from a 7-10 foot depth, swim 20 yards wihth the weight, and exit the pool without using ladder or steps within 100 seconds.  Students will recieve a 2 year ARC certification in Lifeguard, First Aid, and CPR/AED", "ARC Lifeguard Recert", 16, 50 },
                    { 19, false, 0.0, 4, "The purpose of the American Red Cross Lifeguard Instructor course is to train candidates to teach the American Red Cross Lifeguarding, Lifeguard Blending Learning, Shallow Water Lifeguard, Water Park Skills, CPR/AED for the Professional Rescuers and Health Care Providers, Administering Emergency Oxygen and Bloodborne Pathogens Training courses and modules.  Candidates must be at least 17 years old, possess current ARC Lifeguarding/CPR/AED/First Aid certification, complete the online Orientation to the ARC and Orientation to the Lifeguard Instructor course and Precourse Exam, successfully complete the Precourse session, and Obtain the Lifeguard Instructor's Manual and Lifeguarding Manual.  To be certified, candidates must successfully complete the online Intro to the ARC Lifeguard Instructor Course, complete the Precourse Skills Session, attend and participate in all course sessions, complete class activities including the four practice-teaching assignments, demonstrate instructor-level skill competency in all scenarios, and score a minimum of 80 percent on the instructor course final written exam.", "ARC Lifeguard Instructor", 16, 50 }
                });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 1,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 2,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 3,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 4,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 5,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 6,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 7,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 8,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 9,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 10,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 11,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 12,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 13,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 14,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 15,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 16,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 17,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 18,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 19,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 20,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 21,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 22,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 23,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 24,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 25,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 26,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 27,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 28,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 29,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 30,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 31,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 32,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 33,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 34,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 35,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 36,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 37,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 38,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 39,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 40,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 41,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 42,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 43,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 44,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 45,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 46,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 47,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 48,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 49,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 50,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 51,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 52,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 53,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 54,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 55,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 56,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 57,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 58,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 59,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 60,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 61,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 62,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 63,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 64,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 65,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 66,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 67,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 68,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 69,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 70,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 71,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 72,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 73,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 74,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 75,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 76,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 77,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 78,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 79,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 80,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 81,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 82,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 83,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 84,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 85,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 86,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 87,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 88,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 89,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 90,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 91,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 92,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 93,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 94,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 95,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 96,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 97,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 98,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 99,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 100,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 101,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 102,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 103,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 104,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 105,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 106,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 107,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 108,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 109,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 110,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 111,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 112,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 113,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 114,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 115,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 116,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 117,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 118,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 119,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 120,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 121,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 122,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 123,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 124,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 125,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 126,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 127,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 128,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 129,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 130,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 131,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 132,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 133,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 134,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 135,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 136,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 137,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 138,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 139,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 140,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 141,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 142,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 143,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 144,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 145,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 146,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 147,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 148,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 149,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 150,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 151,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 152,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 153,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 154,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 155,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 156,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 157,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 158,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 159,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 160,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 161,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 162,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 163,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 164,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 165,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 166,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 167,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 168,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 169,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 170,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 171,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 172,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 173,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 174,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 175,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 176,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 177,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 178,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 179,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 180,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 181,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 182,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 183,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 184,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 185,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 186,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 187,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 188,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 189,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 190,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 191,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 192,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 193,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 194,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 195,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 196,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 197,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 198,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 199,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 200,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 201,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 202,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 203,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 204,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 205,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 206,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 207,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 208,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 209,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 210,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 211,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 212,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 213,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 214,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 215,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 216,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 217,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 218,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 219,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 220,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 221,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 222,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 223,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 224,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 225,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 226,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 227,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 228,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 229,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 230,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 231,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 232,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 233,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 234,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 235,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 236,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 237,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 238,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 239,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 240,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 241,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 242,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 243,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 244,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 245,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 246,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 247,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 248,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 249,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 250,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 251,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 252,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 253,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 254,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 255,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 256,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 257,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 258,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 259,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 260,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 261,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 262,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 263,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 264,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 265,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 266,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 267,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 268,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 269,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 270,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 271,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 272,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 273,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 274,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 275,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 276,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 277,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 278,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 279,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 280,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 281,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 282,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 283,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 284,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 285,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 286,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 287,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 288,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 289,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 290,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 291,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 292,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 293,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 294,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 295,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 296,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 297,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 298,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 299,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 300,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 301,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 302,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 303,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 304,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 305,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 306,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 307,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 308,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 309,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 310,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 311,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 312,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 313,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 314,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 315,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 316,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 317,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 318,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 319,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 320,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 321,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 322,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 323,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 324,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 325,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 326,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 327,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 328,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 329,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 330,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 331,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 332,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 333,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 334,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 335,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 336,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 337,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 338,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 339,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 340,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 341,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 342,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 343,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 344,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 345,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 346,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 347,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 348,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 349,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 350,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 351,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 352,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 353,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 354,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 355,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 356,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 357,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 358,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 359,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 360,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 361,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 362,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 363,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 364,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 365,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 366,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 367,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 368,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 369,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 370,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 371,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 372,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 373,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 374,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 375,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 376,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 377,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 378,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 379,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 380,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 381,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 382,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 383,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 384,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 385,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 386,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 387,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 388,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 389,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 390,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 391,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 392,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 393,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 394,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 395,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 396,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 397,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 398,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 399,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 400,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 401,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 402,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 403,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 404,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 405,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 406,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 407,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 408,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 409,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 410,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 411,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 412,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 413,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 414,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 415,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 416,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 417,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 418,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 419,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 420,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 421,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 422,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 423,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 424,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 425,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 426,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 427,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 428,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 429,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 430,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 431,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 432,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 433,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 434,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 435,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 436,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 437,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 438,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 439,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 440,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 441,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 442,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 443,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 444,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 445,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 446,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 447,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 448,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 449,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 450,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 451,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 452,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 453,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 454,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 455,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 456,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 457,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 458,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 459,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 460,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 461,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 462,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 463,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 464,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 465,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 466,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 467,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 468,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 469,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 470,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 471,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 472,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 473,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 474,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 475,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 476,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 477,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 478,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 479,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 480,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 481,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 482,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 483,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 484,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 485,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 486,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 487,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 488,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 489,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 490,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 491,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 492,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 493,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 1,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 54.0, 6, 6, 2, 123.0, 17, new DateTimeOffset(new DateTime(2018, 6, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 2,
                columns: new[] { "BookPrice", "CourseId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 52.0, 4, 2, 114.0, 10, new DateTimeOffset(new DateTime(2016, 6, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 3,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 51.0, 3, 4, 3, 59.0, 18, new DateTimeOffset(new DateTime(2019, 6, 6, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 4,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 34.0, 5, 5, 46.0, 26, new DateTimeOffset(new DateTime(2017, 2, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 5,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 24.0, 9, 6, 96.0, 15, new DateTimeOffset(new DateTime(2019, 12, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 6,
                columns: new[] { "BookPrice", "CourseId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 25.0, 4, 1, 121.0, 21, new DateTimeOffset(new DateTime(2018, 8, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 7,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Seats", "StartDate" },
                values: new object[] { 15.0, 4, 2, 1, 12, new DateTimeOffset(new DateTime(2017, 2, 10, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 8,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 49.0, 9, 3, 110.0, 21, new DateTimeOffset(new DateTime(2017, 9, 6, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 9,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 29.0, 8, 2, 2, 108.0, 22, new DateTimeOffset(new DateTime(2016, 7, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 10,
                columns: new[] { "BookPrice", "CourseId", "Price", "Seats", "StartDate" },
                values: new object[] { 31.0, 10, 136.0, 12, new DateTimeOffset(new DateTime(2018, 8, 13, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 11,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 35.0, 8, 6, 2, 74.0, 21, new DateTimeOffset(new DateTime(2018, 3, 18, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 12,
                columns: new[] { "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 8, 4, 2, 86.0, 22, new DateTimeOffset(new DateTime(2017, 1, 23, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 13,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 55.0, 10, 2, 90.0, 10, new DateTimeOffset(new DateTime(2016, 3, 15, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 14,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 40.0, 5, 4, 3, 87.0, 13, new DateTimeOffset(new DateTime(2018, 12, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 15,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 47.0, 6, 2, 3, 114.0, 24, new DateTimeOffset(new DateTime(2016, 2, 12, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 16,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 39.0, 4, 6, 2, 73.0, 20, new DateTimeOffset(new DateTime(2019, 3, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 17,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 22.0, 4, 3, 101.0, 27, new DateTimeOffset(new DateTime(2018, 5, 23, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 18,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 46.0, 3, 4, 2, 48.0, 15, new DateTimeOffset(new DateTime(2017, 2, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 19,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 21.0, 3, 1, 121.0, 24, new DateTimeOffset(new DateTime(2019, 1, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 20,
                columns: new[] { "BookPrice", "CourseId", "Price", "StartDate" },
                values: new object[] { 49.0, 1, 107.0, new DateTimeOffset(new DateTime(2017, 8, 2, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 21,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 53.0, 3, 5, 116.0, 10, new DateTimeOffset(new DateTime(2019, 10, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 22,
                columns: new[] { "BookPrice", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 41.0, 5, 3, 56.0, 17, new DateTimeOffset(new DateTime(2018, 6, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 23,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 16.0, 7, 5, 2, 92.0, 27, new DateTimeOffset(new DateTime(2016, 9, 20, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 24,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 25.0, 6, 1, 1, 88.0, 21, new DateTimeOffset(new DateTime(2016, 3, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 25,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 16.0, 10, 1, 94.0, 11, new DateTimeOffset(new DateTime(2018, 11, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 26,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 45.0, 9, 6, 58.0, 20, new DateTimeOffset(new DateTime(2016, 7, 18, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 27,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 47.0, 3, 2, 147.0, 13, new DateTimeOffset(new DateTime(2018, 6, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 28,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 16.0, 3, 5, 2, 115.0, 10, new DateTimeOffset(new DateTime(2016, 3, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 29,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 19.0, 5, 4, 131.0, 10, new DateTimeOffset(new DateTime(2016, 2, 17, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "mY010LSLgnyWQDRJ1KAyIwUsSt/7zro2l0HNBQTElTk=", new byte[] { 205, 114, 73, 76, 21, 76, 96, 86, 143, 142, 169, 82, 57, 239, 199, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "qQ3EWMe6Vw/HmjUFJqGj7UR0nwWFw3kngoQIFSu3sI0=", new byte[] { 159, 92, 234, 218, 237, 128, 49, 184, 90, 22, 89, 103, 72, 44, 195, 167 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Dennis", "Pitts", "qQ3EWMe6Vw/HmjUFJqGj7UR0nwWFw3kngoQIFSu3sI0=", new byte[] { 159, 92, 234, 218, 237, 128, 49, 184, 90, 22, 89, 103, 72, 44, 195, 167 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Clayton", "Cawyer", "qQ3EWMe6Vw/HmjUFJqGj7UR0nwWFw3kngoQIFSu3sI0=", new byte[] { 159, 92, 234, 218, 237, 128, 49, 184, 90, 22, 89, 103, 72, 44, 195, 167 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Jodi", "Toliver", "qQ3EWMe6Vw/HmjUFJqGj7UR0nwWFw3kngoQIFSu3sI0=", new byte[] { 159, 92, 234, 218, 237, 128, 49, 184, 90, 22, 89, 103, 72, 44, 195, 167 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Savannah", "Rachel", "qQ3EWMe6Vw/HmjUFJqGj7UR0nwWFw3kngoQIFSu3sI0=", new byte[] { 159, 92, 234, 218, 237, 128, 49, 184, 90, 22, 89, 103, 72, 44, 195, 167 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "FirstName", "LastName", "Password", "Role", "Salt" },
                values: new object[] { "Jackie", "Smith", "qQ3EWMe6Vw/HmjUFJqGj7UR0nwWFw3kngoQIFSu3sI0=", "Staff", new byte[] { 159, 92, 234, 218, 237, 128, 49, 184, 90, 22, 89, 103, 72, 44, 195, 167 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "qQ3EWMe6Vw/HmjUFJqGj7UR0nwWFw3kngoQIFSu3sI0=", new byte[] { 159, 92, 234, 218, 237, 128, 49, 184, 90, 22, 89, 103, 72, 44, 195, 167 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "qQ3EWMe6Vw/HmjUFJqGj7UR0nwWFw3kngoQIFSu3sI0=", new byte[] { 159, 92, 234, 218, 237, 128, 49, 184, 90, 22, 89, 103, 72, 44, 195, 167 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "qQ3EWMe6Vw/HmjUFJqGj7UR0nwWFw3kngoQIFSu3sI0=", new byte[] { 159, 92, 234, 218, 237, 128, 49, 184, 90, 22, 89, 103, 72, 44, 195, 167 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "qQ3EWMe6Vw/HmjUFJqGj7UR0nwWFw3kngoQIFSu3sI0=", new byte[] { 159, 92, 234, 218, 237, 128, 49, 184, 90, 22, 89, 103, 72, 44, 195, 167 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "qQ3EWMe6Vw/HmjUFJqGj7UR0nwWFw3kngoQIFSu3sI0=", new byte[] { 159, 92, 234, 218, 237, 128, 49, 184, 90, 22, 89, 103, 72, 44, 195, 167 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "qQ3EWMe6Vw/HmjUFJqGj7UR0nwWFw3kngoQIFSu3sI0=", new byte[] { 159, 92, 234, 218, 237, 128, 49, 184, 90, 22, 89, 103, 72, 44, 195, 167 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "qQ3EWMe6Vw/HmjUFJqGj7UR0nwWFw3kngoQIFSu3sI0=", new byte[] { 159, 92, 234, 218, 237, 128, 49, 184, 90, 22, 89, 103, 72, 44, 195, 167 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "qQ3EWMe6Vw/HmjUFJqGj7UR0nwWFw3kngoQIFSu3sI0=", new byte[] { 159, 92, 234, 218, 237, 128, 49, 184, 90, 22, 89, 103, 72, 44, 195, 167 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "qQ3EWMe6Vw/HmjUFJqGj7UR0nwWFw3kngoQIFSu3sI0=", new byte[] { 159, 92, 234, 218, 237, 128, 49, 184, 90, 22, 89, 103, 72, 44, 195, 167 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "qQ3EWMe6Vw/HmjUFJqGj7UR0nwWFw3kngoQIFSu3sI0=", new byte[] { 159, 92, 234, 218, 237, 128, 49, 184, 90, 22, 89, 103, 72, 44, 195, 167 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Bio",
                keyColumn: "StaffBioId",
                keyValue: 1,
                column: "Picture",
                value: "Placeholder");

            migrationBuilder.UpdateData(
                table: "Bio",
                keyColumn: "StaffBioId",
                keyValue: 2,
                columns: new[] { "Bio", "Picture" },
                values: new object[] { "Nicole Dufrene is our certified child passenger safety technician in the regional area.  Contact her via email at nicoledufrene0301@gmail.com to schedule a free car seat fitting.", "Placeholder" });

            migrationBuilder.UpdateData(
                table: "Bio",
                keyColumn: "StaffBioId",
                keyValue: 3,
                columns: new[] { "Bio", "Picture" },
                values: new object[] { "I am Staff 3!", "Placeholder" });

            migrationBuilder.UpdateData(
                table: "Bio",
                keyColumn: "StaffBioId",
                keyValue: 4,
                columns: new[] { "Bio", "Picture" },
                values: new object[] { "I am Staff 4!", "Placeholder" });

            migrationBuilder.UpdateData(
                table: "Bio",
                keyColumn: "StaffBioId",
                keyValue: 5,
                columns: new[] { "Bio", "Picture" },
                values: new object[] { "I am Staff 5!", "Placeholder" });

            migrationBuilder.UpdateData(
                table: "Bio",
                keyColumn: "StaffBioId",
                keyValue: 6,
                columns: new[] { "Bio", "Picture" },
                values: new object[] { "I am Staff 6!", "Placeholder" });

            migrationBuilder.UpdateData(
                table: "Bio",
                keyColumn: "StaffBioId",
                keyValue: 7,
                columns: new[] { "Bio", "Picture" },
                values: new object[] { "I am Staff 6!", "Placeholder" });

            migrationBuilder.UpdateData(
                table: "Bio",
                keyColumn: "StaffBioId",
                keyValue: 8,
                column: "Picture",
                value: "Placeholder");

            migrationBuilder.UpdateData(
                table: "Bio",
                keyColumn: "StaffBioId",
                keyValue: 9,
                column: "Picture",
                value: "Placeholder");

            migrationBuilder.UpdateData(
                table: "Bio",
                keyColumn: "StaffBioId",
                keyValue: 10,
                column: "Picture",
                value: "Placeholder");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "BookAvailable", "BookPrice", "CategoryId", "Description", "Name", "TypicalPrice" },
                values: new object[] { true, 25.0, 1, "A 4 ½ hour initial course designed for Healthcare Professionals.  The course covers Adult, Child, and Infant one-rescuer CPR AED, as well as a new focused emphasis on teamwork with the adult, child, and infant two-person rescue.  Topics also include Rescue Breathing and Foreign Body Airway Obstruction. Cost includes the use of a textbook, written and practical exams, and a course completion certification(good for 2 years).New 2015 Guidelines!", "Basic Life Support", 50 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "Name", "PrereqId", "TypicalPrice" },
                values: new object[] { 1, "A 4 hour refresher course for the Healthcare Professional; this course offers guidelines in one and two-rescuer adult, child, and infant CPR, Foreign Body Airway Obstruction, and AED training. Cost includes the use of a students’ textbook, written and practical exams, and course completion certification(good for 2 years).New 2015 Guidelines!", "Basic Life Support w/ CPR Refr", null, 50 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 3,
                columns: new[] { "CategoryId", "Description", "Name", "PrereqId" },
                values: new object[] { 1, "For those who have successfully completed the online portion of either BLS course.  Students MUST provide a copy of the online course completion certificate. Cost includes practice time, exam, and course completion certificate(good for 2 years)", "BLS Online Recert – Part 2", 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 4,
                columns: new[] { "BookAvailable", "BookPrice", "CategoryId", "Description", "Name", "PrereqId", "TypicalPrice" },
                values: new object[] { true, 15.0, 1, "A 2-3 hour course designed to teach the lay rescuer (security guards, personal trainers, church organization teachers, etc.) how to recognize and treat life-threatening emergencies whose job requires a course completion card documenting one-rescuer adult and/or pediatric CPR, Foreign Body Airway Obstruction, and AED training. Cost includes the use of a textbook, practice exam, and course completion certificate(good for 2 years).New 2015 Guidelines!", "Heartsaver CPR/AED ", null, 50 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 5,
                columns: new[] { "BookPrice", "Description", "Name" },
                values: new object[] { 15.0, "A 4 hour course designed for the general public or lay rescuer whose job requires a first aid course completion card.  The course provides the skills to effectively asses and maintain life from the critical minutes of an emergency until the arrival of emergency service personnel.  Depending on which modules the candidate wishes to take, the basic first aid course consists of General Principles, Medical Emergencies, and Injury Emergencies.  Also includes CPR and AED training, and Environmental Emergencies. Cost includes use of a textbook, practice exam, and course completion certificate(good for 2 years).New 2015 Guidelines!", "Heartsaver First Aid " });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 6,
                columns: new[] { "Description", "Name" },
                values: new object[] { "A 6-8 hour First Aid course designed for childcare workers whose job requires a pediatric-specific first aid completion card.  This course provides the skills to effectively asses and maintain a child’s life in the critical minutes following an emergency until the arrival of emergency personnel.  This course covers all State of Louisiana required modules including Child Care specific topics, General Principles, Medical Emergencies, Injury Emergencies, and Environmental Emergencies.  Also includes CPR and AED training for Adult, Children, and Infants. Cost includes use of a textbook, skills, and course completion certification(good for 2 years).New 2015 Guidelines!", "Heartsaver Pediatric First Aid" });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 7,
                columns: new[] { "Description", "Name", "PrereqId", "TypicalPrice" },
                values: new object[] { "A 2 ½ hour entry level awareness program designed for the general public, parents, babysitters, grandparents, churches, clubs, etc.  The course covers American Heart Association guidelines for the one-rescuer adult including Pediatric CPR, relief of Foreign Body Airway Obstructions, the chain of survival, Basic First Aid, and recognizing the signs of a heart attack and stroke. Cost includes a student textbook.New 2016 Guidelines!", "Family and Friends CPR", null, 50 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 8,
                columns: new[] { "BookAvailable", "BookPrice", "Description", "Name", "PrereqId" },
                values: new object[] { false, 0.0, "This is a 16 - 20 hour course for those who wish to become AHA Instructor Candidates able to teach various levels of American Heart Association CPR.  Course is taught over 2 or 3 days. Successful completion of AHA BLS for Healthcare Providers Course, as well as each module instructor candidates wish to teach(Heartsaver First Aid, Heartsaver CPR / AED, etc.), and scoring 90 % or better on written examination(within 90 days of the instructor course) is required for completion. A letter of recommendation and completion of Core Instructor Course is required before applying. Cost includes all student level books, instructor manuals, practical exams, and test.New 2015 Guidelines!", "BLS & CPR, Instructor", 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 9,
                columns: new[] { "BookAvailable", "BookPrice", "Description", "Name", "PrereqId" },
                values: new object[] { false, 0.0, "For those who have successfully completed the online portion of the Heartsaver CPR/AED course.  Students MUST provide a copy of the online course completion certificate. Cost includes practice time, exam, and course completion certificate(good for 2 years)", "CPR/AED Online Recert 2", 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 10,
                columns: new[] { "Description", "Name", "PrereqId" },
                values: new object[] { "For those who have successfully completed the online portion of the Heartsaver First Aid course.  Students MUST provide a copy of the online course completion certificate. Cost includes practice time, exam, and course completion certificate(good for 2 years)", "First Aid Online Recert 2", 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 11,
                columns: new[] { "CategoryId", "Description", "Name" },
                values: new object[] { 6, "This 14 hour, 2 day class following American Red Cross standards will educate the babysitter on skills necessary to provide quality care to children of all ages.  Participants must be ages 11 and older and will learn Adult/Child/Infant CPR and AED, basic first aid, child behavior, age-appropriate activities, basic child care (including bottling, feeding, and diapering), and professionalism.  This courses teaches techniques necessary for all babysitters.", "ARC Babysitting  BOOT CAMP" });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 12,
                columns: new[] { "CategoryId", "Description", "Name", "PrereqId" },
                values: new object[] { 4, "The purpose of the American Red Cross Lifeguard Course is to provide entry-level lifeguard participants with knowledge and skills to prevent, recognize, and respond to aquatic emergencies.  The lifeguard will also learn care for breathing and cardiac emergencies, as well as first aid skills.  This is a 25 hour course taught by a certified ARC instructor.  Students must be 15 years or older and able to swim 300 yards continuously demonstrating breath control and rhythmic breating.  Candidates may swim using front crawl, breaststroke, or combination only; side or back swimming is not allowed. Goggles may be worn for this portion.  Candidates must also be able to tread water for 2 minutes using only legs (arms will be placed under armpits) and complete a timed event within 1 minute 40 seconds.  Candidates will be required to swim 20 yards without goggles and surface dive (feet or head first) to a depth of 7 to 10 feet to retrieve a 10 pound object.  Candidates must also exit the water without using a ladder or steps.", "ARC Initial Lifeguard", null });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 13,
                columns: new[] { "CategoryId", "Description", "Name", "PrereqId" },
                values: new object[] { 4, "Current certified lifeguards with valid American Red Cross Lifeguarding/CPR/AED/First aid certification who have expired more than 30 days.  Students must bring proof of valid ARC Lifeguarding, First Aid, and CPR/AED for the Professional Rescuer certification.  Students will be required to swim 300 yards, tread water using legs only for 2 minutes, and retrieve a 10 pound weird from a 7-10 foot depth, swim 20 yards wihth the weight, and exit the pool without using ladder or steps within 100 seconds.  Students will recieve a 2 year ARC certification in Lifeguard, First Aid, and CPR/AED", "ARC Lifeguard Recert", 12 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 14,
                columns: new[] { "CategoryId", "Description", "Name", "PrereqId" },
                values: new object[] { 4, "The purpose of this instructor course is to ttrain candidates to teach courses and presentation in the American Red Cross Swimming and Water Safety program including Parent and Child Aquatics, Preschool Aquatics, Learn-to-Swim, Adult Swim, Private Lessons, Water Safety Courses (including Safety Training for Swim Coaches) and Water Safety Presentations.  Candidates must be at least 16 years old and demonstrate the ability to perform the following swimming skills: Front Crawl, Back Crawl, Breaststroke, Elementary Backstroke, Sidestroke, and Butterfly, all for 25 yards.  Candidates must be able to maintain position on back for 1 minute in deep water (floating or sculling) and must tread water for 1 minute.  The instructor-lead course is 31 hours.  To be certified, candidates must successfully complete the online Intro to the ARC Water Safety Course, complete the Precourse Skills Session, attend and participate in all course sessions, complete class activities including the four practice-teaching assignments, demonstrate instructor-level skill competency in all scenarios, and score a minimum of 80 percent on the instructor course final written exam.", "ARC Water Safety Instructor", 12 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 15,
                columns: new[] { "CategoryId", "Description", "Name", "PrereqId" },
                values: new object[] { 4, "The purpose of the American Red Cross Lifeguard Instructor course is to train candidates to teach the American Red Cross Lifeguarding, Lifeguard Blending Learning, Shallow Water Lifeguard, Water Park Skills, CPR/AED for the Professional Rescuers and Health Care Providers, Administering Emergency Oxygen and Bloodborne Pathogens Training courses and modules.  Candidates must be at least 17 years old, possess current ARC Lifeguarding/CPR/AED/First Aid certification, complete the online Orientation to the ARC and Orientation to the Lifeguard Instructor course and Precourse Exam, successfully complete the Precourse session, and Obtain the Lifeguard Instructor's Manual and Lifeguarding Manual.  To be certified, candidates must successfully complete the online Intro to the ARC Lifeguard Instructor Course, complete the Precourse Skills Session, attend and participate in all course sessions, complete class activities including the four practice-teaching assignments, demonstrate instructor-level skill competency in all scenarios, and score a minimum of 80 percent on the instructor course final written exam.", "ARC Lifeguard Instructor", 12 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 16,
                columns: new[] { "CategoryId", "Description", "Name", "TypicalPrice" },
                values: new object[] { 5, "This is a free service by certified child passenger safety technicians to lower childhood deaths and injuries.  To stay informed of events and education, please follow Buckle Up Louisiana on Facebook.  Nicole Dufrene can assist anyone who has questions concerning car safety seat information FREE of charge. Her email is: nicoledufrene0301@gmail.com.  Additional information can be found at The National Highway and Traffic Safety website https://www.nhtsa.gov/.  Also visit https://www.safekids.org/child-passenger-safety to learn more about the organization that regulates the  curriculum for our classes and also has a find a fitting station near you.", "Car Seat Safety", 0 });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 1,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 2,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 3,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 4,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 5,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 6,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 7,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 8,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 9,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 10,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 11,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 12,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 13,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 14,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 15,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 16,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 17,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 18,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 19,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 20,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 21,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 22,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 23,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 24,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 25,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 26,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 27,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 28,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 29,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 30,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 31,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 32,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 33,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 34,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 35,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 36,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 37,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 38,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 39,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 40,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 41,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 42,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 43,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 44,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 45,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 46,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 47,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 48,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 49,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 50,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 51,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 52,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 53,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 54,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 55,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 56,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 57,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 58,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 59,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 60,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 61,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 62,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 63,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 64,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 65,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 66,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 67,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 68,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 69,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 70,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 71,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 72,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 73,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 74,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 75,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 76,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 77,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 78,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 79,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 80,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 81,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 82,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 83,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 84,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 85,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 86,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 87,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 88,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 89,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 90,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 91,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 92,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 93,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 94,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 95,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 96,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 97,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 98,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 99,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 100,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 101,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 102,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 103,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 104,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 105,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 106,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 107,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 108,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 109,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 110,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 111,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 112,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 113,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 114,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 115,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 116,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 117,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 118,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 119,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 120,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 121,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 122,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 123,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 124,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 125,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 126,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 127,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 128,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 129,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 130,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 131,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 132,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 133,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 134,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 135,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 136,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 137,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 138,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 139,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 140,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 141,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 142,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 143,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 144,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 145,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 146,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 147,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 148,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 149,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 150,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 151,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 152,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 153,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 154,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 155,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 156,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 157,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 158,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 159,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 160,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 161,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 162,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 163,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 164,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 165,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 166,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 167,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 168,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 169,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 170,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 171,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 172,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 173,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 174,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 175,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 176,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 177,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 178,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 179,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 180,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 181,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 182,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 183,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 184,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 185,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 186,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 187,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 188,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 189,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 190,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 191,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 192,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 193,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 194,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 195,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 196,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 197,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 198,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 199,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 200,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 201,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 202,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 203,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 204,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 205,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 206,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 207,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 208,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 209,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 210,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 211,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 212,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 213,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 214,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 215,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 216,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 217,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 218,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 219,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 220,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 221,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 222,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 223,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 224,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 225,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 226,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 227,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 228,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 229,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 230,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 231,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 232,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 233,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 234,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 235,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 236,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 237,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 238,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 239,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 240,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 241,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 242,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 243,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 244,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 245,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 246,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 247,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 248,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 249,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 250,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 251,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 252,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 253,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 254,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 255,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 256,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 257,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 258,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 259,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 260,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 261,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 262,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 263,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 264,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 265,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 266,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 267,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 268,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 269,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 270,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 271,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 272,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 273,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 274,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 275,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 276,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 277,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 278,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 279,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 280,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 281,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 282,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 283,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 284,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 285,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 286,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 287,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 288,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 289,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 290,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 291,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 292,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 293,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 294,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 295,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 296,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 297,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 298,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 299,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 300,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 301,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 302,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 303,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 304,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 305,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 306,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 307,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 308,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 309,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 310,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 311,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 312,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 313,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 314,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 315,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 316,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 317,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 318,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 319,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 320,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 321,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 322,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 323,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 324,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 325,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 326,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 327,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 328,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 329,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 330,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 331,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 332,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 333,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 334,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 335,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 336,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 337,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 338,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 339,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 340,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 341,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 342,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 343,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 344,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 345,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 346,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 347,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 348,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 349,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 350,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 351,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 352,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 353,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 354,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 355,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 356,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 357,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 358,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 359,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 360,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 361,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 362,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 363,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 364,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 365,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 366,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 367,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 368,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 369,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 370,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 371,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 372,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 373,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 374,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 375,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 376,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 377,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 378,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 379,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 380,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 381,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 382,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 383,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 384,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 385,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 386,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 387,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 388,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 389,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 390,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 391,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 392,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 393,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 394,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 395,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 396,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 397,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 398,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 399,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 400,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 401,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 402,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 403,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 404,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 405,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 406,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 407,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 408,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 409,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 410,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 411,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 412,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 413,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 414,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 415,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 416,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 417,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 418,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 419,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 420,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 421,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 422,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 423,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 424,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 425,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 426,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 427,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 428,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 429,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 430,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 431,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 432,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 433,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 434,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 435,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 436,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 437,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 438,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 439,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 440,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 441,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 442,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 443,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 444,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 445,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 446,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 447,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 448,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 449,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 450,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 451,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 452,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 453,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 454,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 455,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 456,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 457,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 458,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 459,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 460,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 461,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 462,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 463,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 464,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 465,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 466,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 467,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 468,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 469,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 470,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 471,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 472,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 473,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 474,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 475,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 476,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 477,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 478,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 479,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 480,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 481,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 482,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 483,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 484,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 485,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 486,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 487,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 488,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 489,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 490,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 491,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 492,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 493,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 1,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 26.0, 9, 1, 3, 94.0, 24, new DateTimeOffset(new DateTime(2017, 12, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 2,
                columns: new[] { "BookPrice", "CourseId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 30.0, 5, 3, 70.0, 24, new DateTimeOffset(new DateTime(2018, 7, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 3,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 39.0, 7, 6, 1, 136.0, 23, new DateTimeOffset(new DateTime(2019, 8, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 4,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 54.0, 8, 1, 148.0, 20, new DateTimeOffset(new DateTime(2017, 2, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 5,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 46.0, 5, 4, 78.0, 24, new DateTimeOffset(new DateTime(2016, 6, 28, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 6,
                columns: new[] { "BookPrice", "CourseId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 34.0, 10, 2, 123.0, 20, new DateTimeOffset(new DateTime(2016, 2, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 7,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Seats", "StartDate" },
                values: new object[] { 45.0, 5, 4, 3, 25, new DateTimeOffset(new DateTime(2016, 3, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 8,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 29.0, 3, 2, 65.0, 26, new DateTimeOffset(new DateTime(2019, 7, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 9,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 36.0, 10, 4, 3, 99.0, 12, new DateTimeOffset(new DateTime(2018, 2, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 10,
                columns: new[] { "BookPrice", "CourseId", "Price", "Seats", "StartDate" },
                values: new object[] { 37.0, 6, 146.0, 25, new DateTimeOffset(new DateTime(2018, 5, 22, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 11,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 27.0, 9, 5, 1, 45.0, 25, new DateTimeOffset(new DateTime(2017, 3, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 12,
                columns: new[] { "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 10, 3, 3, 68.0, 26, new DateTimeOffset(new DateTime(2018, 8, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 13,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 42.0, 4, 3, 63.0, 17, new DateTimeOffset(new DateTime(2017, 12, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 14,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 26.0, 10, 6, 1, 130.0, 11, new DateTimeOffset(new DateTime(2016, 10, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 15,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 54.0, 4, 1, 2, 131.0, 25, new DateTimeOffset(new DateTime(2017, 9, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 16,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 17.0, 7, 3, 3, 48.0, 22, new DateTimeOffset(new DateTime(2018, 10, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 17,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 23.0, 2, 2, 125.0, 23, new DateTimeOffset(new DateTime(2019, 8, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 18,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 32.0, 5, 5, 3, 118.0, 27, new DateTimeOffset(new DateTime(2016, 8, 18, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 19,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 36.0, 10, 2, 93.0, 17, new DateTimeOffset(new DateTime(2016, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 20,
                columns: new[] { "BookPrice", "CourseId", "Price", "StartDate" },
                values: new object[] { 25.0, 7, 119.0, new DateTimeOffset(new DateTime(2016, 9, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 21,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 51.0, 10, 4, 65.0, 26, new DateTimeOffset(new DateTime(2017, 9, 17, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 22,
                columns: new[] { "BookPrice", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 22.0, 6, 1, 105.0, 12, new DateTimeOffset(new DateTime(2018, 7, 17, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 23,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 35.0, 8, 6, 1, 143.0, 18, new DateTimeOffset(new DateTime(2018, 6, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 24,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 35.0, 8, 4, 2, 123.0, 12, new DateTimeOffset(new DateTime(2019, 9, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 25,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 50.0, 1, 3, 129.0, 26, new DateTimeOffset(new DateTime(2017, 2, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 26,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 24.0, 10, 1, 137.0, 22, new DateTimeOffset(new DateTime(2017, 2, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 27,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 43.0, 9, 6, 148.0, 20, new DateTimeOffset(new DateTime(2016, 9, 25, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 28,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 37.0, 10, 1, 1, 125.0, 23, new DateTimeOffset(new DateTime(2016, 2, 21, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 29,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 32.0, 9, 6, 143.0, 23, new DateTimeOffset(new DateTime(2019, 5, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "Im4Y9Sgi9FzPBDjm8Xf9Vk+OZzkzW2OO+joWHDDF+MI=", new byte[] { 113, 104, 125, 138, 25, 79, 146, 48, 200, 35, 177, 127, 249, 248, 147, 96 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "IRXQ4FTd36XLPxC54HZBqDuqgPDrefDe7tdrQjo07N8=", new byte[] { 188, 13, 44, 118, 107, 96, 127, 169, 245, 144, 114, 111, 228, 115, 15, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Mike", "Waters", "IRXQ4FTd36XLPxC54HZBqDuqgPDrefDe7tdrQjo07N8=", new byte[] { 188, 13, 44, 118, 107, 96, 127, 169, 245, 144, 114, 111, 228, 115, 15, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Russel", "Chavers", "IRXQ4FTd36XLPxC54HZBqDuqgPDrefDe7tdrQjo07N8=", new byte[] { 188, 13, 44, 118, 107, 96, 127, 169, 245, 144, 114, 111, 228, 115, 15, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Sharon", "Manino", "IRXQ4FTd36XLPxC54HZBqDuqgPDrefDe7tdrQjo07N8=", new byte[] { 188, 13, 44, 118, 107, 96, 127, 169, 245, 144, 114, 111, 228, 115, 15, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Amy", "Hillbond", "IRXQ4FTd36XLPxC54HZBqDuqgPDrefDe7tdrQjo07N8=", new byte[] { 188, 13, 44, 118, 107, 96, 127, 169, 245, 144, 114, 111, 228, 115, 15, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "FirstName", "LastName", "Password", "Role", "Salt" },
                values: new object[] { "Bill", "Everet", "IRXQ4FTd36XLPxC54HZBqDuqgPDrefDe7tdrQjo07N8=", "User", new byte[] { 188, 13, 44, 118, 107, 96, 127, 169, 245, 144, 114, 111, 228, 115, 15, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "IRXQ4FTd36XLPxC54HZBqDuqgPDrefDe7tdrQjo07N8=", new byte[] { 188, 13, 44, 118, 107, 96, 127, 169, 245, 144, 114, 111, 228, 115, 15, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "IRXQ4FTd36XLPxC54HZBqDuqgPDrefDe7tdrQjo07N8=", new byte[] { 188, 13, 44, 118, 107, 96, 127, 169, 245, 144, 114, 111, 228, 115, 15, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "IRXQ4FTd36XLPxC54HZBqDuqgPDrefDe7tdrQjo07N8=", new byte[] { 188, 13, 44, 118, 107, 96, 127, 169, 245, 144, 114, 111, 228, 115, 15, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "IRXQ4FTd36XLPxC54HZBqDuqgPDrefDe7tdrQjo07N8=", new byte[] { 188, 13, 44, 118, 107, 96, 127, 169, 245, 144, 114, 111, 228, 115, 15, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "IRXQ4FTd36XLPxC54HZBqDuqgPDrefDe7tdrQjo07N8=", new byte[] { 188, 13, 44, 118, 107, 96, 127, 169, 245, 144, 114, 111, 228, 115, 15, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "IRXQ4FTd36XLPxC54HZBqDuqgPDrefDe7tdrQjo07N8=", new byte[] { 188, 13, 44, 118, 107, 96, 127, 169, 245, 144, 114, 111, 228, 115, 15, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "IRXQ4FTd36XLPxC54HZBqDuqgPDrefDe7tdrQjo07N8=", new byte[] { 188, 13, 44, 118, 107, 96, 127, 169, 245, 144, 114, 111, 228, 115, 15, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "IRXQ4FTd36XLPxC54HZBqDuqgPDrefDe7tdrQjo07N8=", new byte[] { 188, 13, 44, 118, 107, 96, 127, 169, 245, 144, 114, 111, 228, 115, 15, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "IRXQ4FTd36XLPxC54HZBqDuqgPDrefDe7tdrQjo07N8=", new byte[] { 188, 13, 44, 118, 107, 96, 127, 169, 245, 144, 114, 111, 228, 115, 15, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "IRXQ4FTd36XLPxC54HZBqDuqgPDrefDe7tdrQjo07N8=", new byte[] { 188, 13, 44, 118, 107, 96, 127, 169, 245, 144, 114, 111, 228, 115, 15, 33 } });
        }
    }
}
