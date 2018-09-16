using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KSS.Migrations
{
    public partial class RealSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "BookAvailable", "BookPrice", "Description", "Name" },
                values: new object[] { true, 25m, "A 4 ½ hour initial course designed for Healthcare Professionals.  The course covers Adult, Child, and Infant one-rescuer CPR AED, as well as a new focused emphasis on teamwork with the adult, child, and infant two-person rescue.  Topics also include Rescue Breathing and Foreign Body Airway Obstruction. Cost includes the use of a textbook, written and practical exams, and a course completion certification(good for 2 years).New 2015 Guidelines!", "Basic Life Support (BLS) for Healthcare Professionals" });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 2,
                columns: new[] { "Description", "Name", "PrereqId" },
                values: new object[] { "A 4 hour refresher course for the Healthcare Professional; this course offers guidelines in one and two-rescuer adult, child, and infant CPR, Foreign Body Airway Obstruction, and AED training. Cost includes the use of a students’ textbook, written and practical exams, and course completion certification(good for 2 years).New 2015 Guidelines!", "Basic Life Support (BLS) with CPR for Healthcare Professionals -  Refresher", null });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 3,
                columns: new[] { "Description", "Name", "PrereqId" },
                values: new object[] { "For those who have successfully completed the online portion of either BLS course.  Students MUST provide a copy of the online course completion certificate. Cost includes practice time, exam, and course completion certificate(good for 2 years)", "BLS Online Recertification – Part 2", 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 4,
                columns: new[] { "BookAvailable", "BookPrice", "Description", "Name" },
                values: new object[] { true, 15m, "A 2-3 hour course designed to teach the lay rescuer (security guards, personal trainers, church organization teachers, etc.) how to recognize and treat life-threatening emergencies whose job requires a course completion card documenting one-rescuer adult and/or pediatric CPR, Foreign Body Airway Obstruction, and AED training. Cost includes the use of a textbook, practice exam, and course completion certificate(good for 2 years).New 2015 Guidelines!", "Heartsaver CPR/AED " });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 5,
                columns: new[] { "BookAvailable", "BookPrice", "Description", "Name", "PrereqId" },
                values: new object[] { true, 15m, "A 4 hour course designed for the general public or lay rescuer whose job requires a first aid course completion card.  The course provides the skills to effectively asses and maintain life from the critical minutes of an emergency until the arrival of emergency service personnel.  Depending on which modules the candidate wishes to take, the basic first aid course consists of General Principles, Medical Emergencies, and Injury Emergencies.  Also includes CPR and AED training, and Environmental Emergencies. Cost includes use of a textbook, practice exam, and course completion certificate(good for 2 years).New 2015 Guidelines!", "Heartsaver First Aid ", null });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 6,
                columns: new[] { "Description", "Name", "PrereqId" },
                values: new object[] { "A 6-8 hour First Aid course designed for childcare workers whose job requires a pediatric-specific first aid completion card.  This course provides the skills to effectively asses and maintain a child’s life in the critical minutes following an emergency until the arrival of emergency personnel.  This course covers all State of Louisiana required modules including Child Care specific topics, General Principles, Medical Emergencies, Injury Emergencies, and Environmental Emergencies.  Also includes CPR and AED training for Adult, Children, and Infants. Cost includes use of a textbook, skills, and course completion certification(good for 2 years).New 2015 Guidelines!", "Heartsaver Pediatric First Aid Course (Daycare/Childcare Providers)", null });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "BookAvailable", "BookPrice", "Description", "Name", "PrereqId" },
                values: new object[,]
                {
                    { 7, false, 0m, "A 2 ½ hour entry level awareness program designed for the general public, parents, babysitters, grandparents, churches, clubs, etc.  The course covers American Heart Association guidelines for the one-rescuer adult including Pediatric CPR, relief of Foreign Body Airway Obstructions, the chain of survival, Basic First Aid, and recognizing the signs of a heart attack and stroke. Cost includes a student textbook.New 2016 Guidelines!", "Family and Friends CPR (course designed for general public; non-certification course)", null },
                    { 8, false, 0m, "This is a 16 - 20 hour course for those who wish to become AHA Instructor Candidates able to teach various levels of American Heart Association CPR.  Course is taught over 2 or 3 days. Successful completion of AHA BLS for Healthcare Providers Course, as well as each module instructor candidates wish to teach(Heartsaver First Aid, Heartsaver CPR / AED, etc.), and scoring 90 % or better on written examination(within 90 days of the instructor course) is required for completion. A letter of recommendation and completion of Core Instructor Course is required before applying. Cost includes all student level books, instructor manuals, practical exams, and test.New 2015 Guidelines!", "BLS CPR for Healthcare Providers, Instructor Course", 1 },
                    { 9, false, 0m, "For those who have successfully completed the online portion of the Heartsaver CPR/AED course.  Students MUST provide a copy of the online course completion certificate. Cost includes practice time, exam, and course completion certificate(good for 2 years)", "CPR/AED Online Recertification – Part 2", 4 },
                    { 10, false, 0m, "For those who have successfully completed the online portion of the Heartsaver First Aid course.  Students MUST provide a copy of the online course completion certificate. Cost includes practice time, exam, and course completion certificate(good for 2 years)", "First Aid Online Recertification – Part 2", 5 }
                });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 1,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 2,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 3,
                column: "Status",
                value: "E");

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
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 6,
                column: "Status",
                value: "E");

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
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 9,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 10,
                column: "Status",
                value: "E");

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
                column: "Status",
                value: "E");

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
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 15,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 16,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 17,
                column: "Status",
                value: "E");

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
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 21,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 22,
                column: "Status",
                value: "E");

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
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 25,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 26,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 27,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 28,
                column: "Status",
                value: "E");

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
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 31,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 32,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "Nd9XFQEOi7NjW7DNTV7BKOOxi2RMVg/Bax91SHnNUUQ=", new byte[] { 63, 63, 138, 175, 101, 210, 92, 58, 143, 80, 44, 133, 6, 236, 219, 124 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "6vnzwonjVq93s9o+XsyGOTcA8rm+/NyOo0zbwrKcdrU=", new byte[] { 9, 176, 250, 81, 43, 63, 115, 221, 115, 131, 104, 11, 136, 253, 196, 119 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "6vnzwonjVq93s9o+XsyGOTcA8rm+/NyOo0zbwrKcdrU=", new byte[] { 9, 176, 250, 81, 43, 63, 115, 221, 115, 131, 104, 11, 136, 253, 196, 119 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "6vnzwonjVq93s9o+XsyGOTcA8rm+/NyOo0zbwrKcdrU=", new byte[] { 9, 176, 250, 81, 43, 63, 115, 221, 115, 131, 104, 11, 136, 253, 196, 119 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "6vnzwonjVq93s9o+XsyGOTcA8rm+/NyOo0zbwrKcdrU=", new byte[] { 9, 176, 250, 81, 43, 63, 115, 221, 115, 131, 104, 11, 136, 253, 196, 119 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "6vnzwonjVq93s9o+XsyGOTcA8rm+/NyOo0zbwrKcdrU=", new byte[] { 9, 176, 250, 81, 43, 63, 115, 221, 115, 131, 104, 11, 136, 253, 196, 119 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "6vnzwonjVq93s9o+XsyGOTcA8rm+/NyOo0zbwrKcdrU=", new byte[] { 9, 176, 250, 81, 43, 63, 115, 221, 115, 131, 104, 11, 136, 253, 196, 119 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "6vnzwonjVq93s9o+XsyGOTcA8rm+/NyOo0zbwrKcdrU=", new byte[] { 9, 176, 250, 81, 43, 63, 115, 221, 115, 131, 104, 11, 136, 253, 196, 119 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "6vnzwonjVq93s9o+XsyGOTcA8rm+/NyOo0zbwrKcdrU=", new byte[] { 9, 176, 250, 81, 43, 63, 115, 221, 115, 131, 104, 11, 136, 253, 196, 119 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "6vnzwonjVq93s9o+XsyGOTcA8rm+/NyOo0zbwrKcdrU=", new byte[] { 9, 176, 250, 81, 43, 63, 115, 221, 115, 131, 104, 11, 136, 253, 196, 119 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "6vnzwonjVq93s9o+XsyGOTcA8rm+/NyOo0zbwrKcdrU=", new byte[] { 9, 176, 250, 81, 43, 63, 115, 221, 115, 131, 104, 11, 136, 253, 196, 119 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "6vnzwonjVq93s9o+XsyGOTcA8rm+/NyOo0zbwrKcdrU=", new byte[] { 9, 176, 250, 81, 43, 63, 115, 221, 115, 131, 104, 11, 136, 253, 196, 119 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "6vnzwonjVq93s9o+XsyGOTcA8rm+/NyOo0zbwrKcdrU=", new byte[] { 9, 176, 250, 81, 43, 63, 115, 221, 115, 131, 104, 11, 136, 253, 196, 119 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "6vnzwonjVq93s9o+XsyGOTcA8rm+/NyOo0zbwrKcdrU=", new byte[] { 9, 176, 250, 81, 43, 63, 115, 221, 115, 131, 104, 11, 136, 253, 196, 119 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "6vnzwonjVq93s9o+XsyGOTcA8rm+/NyOo0zbwrKcdrU=", new byte[] { 9, 176, 250, 81, 43, 63, 115, 221, 115, 131, 104, 11, 136, 253, 196, 119 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "6vnzwonjVq93s9o+XsyGOTcA8rm+/NyOo0zbwrKcdrU=", new byte[] { 9, 176, 250, 81, 43, 63, 115, 221, 115, 131, 104, 11, 136, 253, 196, 119 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "6vnzwonjVq93s9o+XsyGOTcA8rm+/NyOo0zbwrKcdrU=", new byte[] { 9, 176, 250, 81, 43, 63, 115, 221, 115, 131, 104, 11, 136, 253, 196, 119 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "BookAvailable", "BookPrice", "Description", "Name" },
                values: new object[] { false, 0m, "CPR beginner class", "CPR 101" });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 2,
                columns: new[] { "Description", "Name", "PrereqId" },
                values: new object[] { "CPR advanced techniques", "CPR 201", 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 3,
                columns: new[] { "Description", "Name", "PrereqId" },
                values: new object[] { "CPR master class", "CPR 301", 2 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 4,
                columns: new[] { "BookAvailable", "BookPrice", "Description", "Name" },
                values: new object[] { false, 0m, "EMT beginner class", "EMT 101" });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 5,
                columns: new[] { "BookAvailable", "BookPrice", "Description", "Name", "PrereqId" },
                values: new object[] { false, 0m, "EMT advanced techniques", "EMT 201", 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 6,
                columns: new[] { "Description", "Name", "PrereqId" },
                values: new object[] { "EMT master class", "EMT 301", 5 });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 1,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 2,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 3,
                column: "Status",
                value: null);

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
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 6,
                column: "Status",
                value: null);

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
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 9,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 10,
                column: "Status",
                value: null);

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
                column: "Status",
                value: null);

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
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 15,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 16,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 17,
                column: "Status",
                value: null);

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
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 21,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 22,
                column: "Status",
                value: null);

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
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 25,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 26,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 27,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 28,
                column: "Status",
                value: null);

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
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 31,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 32,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "7wh+TO6NunhHhkrtXoBGhGqvT4Cgo5iVjSVgVGJjiGo=", new byte[] { 183, 99, 169, 114, 98, 176, 235, 178, 131, 211, 139, 195, 84, 116, 20, 238 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "N/Xrv6Kfw1G6qgD1vth3UoLVpys1K1CcQXh0YF/BjWg=", new byte[] { 59, 107, 119, 83, 5, 116, 232, 28, 173, 195, 236, 94, 150, 39, 148, 114 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "N/Xrv6Kfw1G6qgD1vth3UoLVpys1K1CcQXh0YF/BjWg=", new byte[] { 59, 107, 119, 83, 5, 116, 232, 28, 173, 195, 236, 94, 150, 39, 148, 114 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "N/Xrv6Kfw1G6qgD1vth3UoLVpys1K1CcQXh0YF/BjWg=", new byte[] { 59, 107, 119, 83, 5, 116, 232, 28, 173, 195, 236, 94, 150, 39, 148, 114 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "N/Xrv6Kfw1G6qgD1vth3UoLVpys1K1CcQXh0YF/BjWg=", new byte[] { 59, 107, 119, 83, 5, 116, 232, 28, 173, 195, 236, 94, 150, 39, 148, 114 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "N/Xrv6Kfw1G6qgD1vth3UoLVpys1K1CcQXh0YF/BjWg=", new byte[] { 59, 107, 119, 83, 5, 116, 232, 28, 173, 195, 236, 94, 150, 39, 148, 114 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "N/Xrv6Kfw1G6qgD1vth3UoLVpys1K1CcQXh0YF/BjWg=", new byte[] { 59, 107, 119, 83, 5, 116, 232, 28, 173, 195, 236, 94, 150, 39, 148, 114 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "N/Xrv6Kfw1G6qgD1vth3UoLVpys1K1CcQXh0YF/BjWg=", new byte[] { 59, 107, 119, 83, 5, 116, 232, 28, 173, 195, 236, 94, 150, 39, 148, 114 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "N/Xrv6Kfw1G6qgD1vth3UoLVpys1K1CcQXh0YF/BjWg=", new byte[] { 59, 107, 119, 83, 5, 116, 232, 28, 173, 195, 236, 94, 150, 39, 148, 114 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "N/Xrv6Kfw1G6qgD1vth3UoLVpys1K1CcQXh0YF/BjWg=", new byte[] { 59, 107, 119, 83, 5, 116, 232, 28, 173, 195, 236, 94, 150, 39, 148, 114 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "N/Xrv6Kfw1G6qgD1vth3UoLVpys1K1CcQXh0YF/BjWg=", new byte[] { 59, 107, 119, 83, 5, 116, 232, 28, 173, 195, 236, 94, 150, 39, 148, 114 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "N/Xrv6Kfw1G6qgD1vth3UoLVpys1K1CcQXh0YF/BjWg=", new byte[] { 59, 107, 119, 83, 5, 116, 232, 28, 173, 195, 236, 94, 150, 39, 148, 114 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "N/Xrv6Kfw1G6qgD1vth3UoLVpys1K1CcQXh0YF/BjWg=", new byte[] { 59, 107, 119, 83, 5, 116, 232, 28, 173, 195, 236, 94, 150, 39, 148, 114 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "N/Xrv6Kfw1G6qgD1vth3UoLVpys1K1CcQXh0YF/BjWg=", new byte[] { 59, 107, 119, 83, 5, 116, 232, 28, 173, 195, 236, 94, 150, 39, 148, 114 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "N/Xrv6Kfw1G6qgD1vth3UoLVpys1K1CcQXh0YF/BjWg=", new byte[] { 59, 107, 119, 83, 5, 116, 232, 28, 173, 195, 236, 94, 150, 39, 148, 114 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "N/Xrv6Kfw1G6qgD1vth3UoLVpys1K1CcQXh0YF/BjWg=", new byte[] { 59, 107, 119, 83, 5, 116, 232, 28, 173, 195, 236, 94, 150, 39, 148, 114 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "N/Xrv6Kfw1G6qgD1vth3UoLVpys1K1CcQXh0YF/BjWg=", new byte[] { 59, 107, 119, 83, 5, 116, 232, 28, 173, 195, 236, 94, 150, 39, 148, 114 } });
        }
    }
}
