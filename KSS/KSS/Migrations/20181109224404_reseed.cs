using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KSS.Migrations
{
    public partial class reseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Category",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Category",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Bio",
                keyColumn: "StaffBioId",
                keyValue: 1,
                column: "Bio",
                value: "Becky Smith is the owner of Keeping Safety Smart. With over 20 years of emergency/life saver teaching experience, Ms. Smith founded Keeping Safety Smart in 2015.");

            migrationBuilder.UpdateData(
                table: "Bio",
                keyColumn: "StaffBioId",
                keyValue: 2,
                column: "Bio",
                value: "Nicole Dufrene is our certified child passenger safety technician in the regional area.  Contact her via email at nicoledufrene0301@gmail.com to schedule a free car seat fitting.");

            migrationBuilder.InsertData(
                table: "Bio",
                columns: new[] { "StaffBioId", "Bio", "Picture", "UserId" },
                values: new object[,]
                {
                    { 7, "I am Staff 6!", "Placeholder", 7 },
                    { 8, "I am Staff 6!", "Placeholder", 8 },
                    { 9, "I am Staff 6!", "Placeholder", 9 },
                    { 10, "I am Staff 6!", "Placeholder", 10 }
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Learn CPR, a medical procedure involving specific compression of a patient's chest, performed in an attempt to bring back the blood circulation and breathing of a person who has suffered cardiac arrest.", "CPR, Life Support, and First Aid" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "Description", "Name", "Title" },
                values: new object[] { "Interested in becoming an EMT? An EMT is a specially trained technician certified to provide basic emergency services before and during transportation to a hospital.", "EMT", "Emergency Medical Technician" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "Description", "Name", "Title" },
                values: new object[] { "In case of a medical emergency, learn techniques and procedures for helping others in need of immediate attention and treating minor wounds.", "EMR", "Emergency Medical Responder" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "Description", "Name", "Title" },
                values: new object[] { "These courses teach applicable safety practices for individuals such as swim coaches, lifeguard instructors, and even professional rescuers.", "AQU", "Aquatic Rescue" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Description", "Name", "Title" },
                values: new object[,]
                {
                    { 5, "Learn how to properly conduct child safety seat checks and be informed on the best way to utilize and understand seat belts and child restraint systems while in motorized vehicles.", "CAR", "Car Seat Safety" },
                    { 6, "Babysitting can sometimes be difficult, but our courses teach babysitting skills, such as leadership, keeping children safe, and helping kids to behave, to anyone who wants to learn or even grow a babysitting business.", "BBS", "Babysitting Safety" }
                });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 2,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 3,
                columns: new[] { "CategoryId", "PrereqId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 4,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 5,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 7,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 8,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 1, "BLS & CPR, Instructor" });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 10,
                column: "CategoryId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "BookAvailable", "BookPrice", "CategoryId", "Description", "Name", "PrereqId", "TypicalPrice" },
                values: new object[] { 12, false, 0.0, 4, "The purpose of the American Red Cross Lifeguard Course is to provide entry-level lifeguard participants with knowledge and skills to prevent, recognize, and respond to aquatic emergencies.  The lifeguard will also learn care for breathing and cardiac emergencies, as well as first aid skills.  This is a 25 hour course taught by a certified ARC instructor.  Students must be 15 years or older and able to swim 300 yards continuously demonstrating breath control and rhythmic breating.  Candidates may swim using front crawl, breaststroke, or combination only; side or back swimming is not allowed. Goggles may be worn for this portion.  Candidates must also be able to tread water for 2 minutes using only legs (arms will be placed under armpits) and complete a timed event within 1 minute 40 seconds.  Candidates will be required to swim 20 yards without goggles and surface dive (feet or head first) to a depth of 7 to 10 feet to retrieve a 10 pound object.  Candidates must also exit the water without using a ladder or steps.", "ARC Initial Lifeguard", null, 50 });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 1,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

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
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 5,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 6,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 7,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

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
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

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
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 12,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 13,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

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
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 16,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 17,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 18,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 19,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 20,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

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
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 23,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

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
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 28,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 29,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 30,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 31,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 32,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 33,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 34,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 35,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 36,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 37,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 38,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 39,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 40,
                columns: new[] { "BookBought", "Status" },
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
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 43,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 44,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 45,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 46,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 47,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 48,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 49,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 50,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 51,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 52,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 53,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 54,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 55,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 56,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 57,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 58,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 59,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 60,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 61,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 62,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 63,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 64,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

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
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 67,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 68,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 69,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 70,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 71,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 72,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 73,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 74,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 75,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 76,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 77,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 78,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 79,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 80,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 81,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 82,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 83,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 84,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 85,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 86,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 87,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 88,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 89,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 90,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 91,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 92,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 93,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 94,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 95,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 96,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 97,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 98,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 99,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 100,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 101,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 102,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 103,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 104,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 105,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 106,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 107,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 108,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 109,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 110,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 111,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 112,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 113,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 114,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 115,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 116,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 117,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 118,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 119,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 120,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 121,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 122,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 123,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 124,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 125,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 126,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 127,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 128,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 129,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 130,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 131,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 132,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 133,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 134,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 135,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 136,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 137,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 138,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 139,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 140,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 141,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 142,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 143,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 144,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 145,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 146,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 147,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 148,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 149,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 150,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 151,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 152,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 153,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 154,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 155,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 156,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 157,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 158,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 159,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 160,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 161,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 162,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 163,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 164,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 165,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 166,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 167,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 168,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 169,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 170,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 171,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 172,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 173,
                columns: new[] { "Paid", "Status" },
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
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

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
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 178,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 179,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 180,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 181,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 182,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 183,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 184,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 185,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 186,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 187,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 188,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 189,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 190,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 191,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 192,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 193,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 194,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 195,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 196,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 197,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 198,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 199,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 200,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 201,
                column: "Status",
                value: "E");

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
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 204,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 205,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 206,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 207,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

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
                columns: new[] { "BookBought", "Status" },
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
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 212,
                column: "Status",
                value: "E");

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
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 215,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 216,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

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
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 219,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 220,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 221,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 222,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 223,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 224,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 225,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 226,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 227,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 228,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 229,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 230,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 231,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 232,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 233,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 234,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 235,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 236,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 237,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

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
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 240,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 241,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 242,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 243,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 244,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 245,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 246,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 247,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 248,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 249,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 250,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 251,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 252,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 253,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 254,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 255,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 256,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 257,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 258,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 259,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 260,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 261,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 262,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 263,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 264,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 265,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 266,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 267,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 268,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 269,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 270,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 271,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 272,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

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
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 275,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 276,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 277,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 278,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 279,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 280,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 281,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 282,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 283,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 284,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 285,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 286,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 287,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 288,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 289,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 290,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 291,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 292,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 293,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 294,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 295,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 296,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 297,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 298,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 299,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 300,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 301,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 302,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 303,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 304,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 305,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 306,
                columns: new[] { "BookBought", "Status" },
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
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 309,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 310,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 311,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

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
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 314,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 315,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 316,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 317,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 318,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

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
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 321,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 322,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 323,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 324,
                column: "Status",
                value: "E");

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
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 327,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 328,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 329,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

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
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 332,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 333,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 334,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 335,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 336,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 337,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 338,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 339,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 340,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 341,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 342,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 343,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 344,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 345,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 346,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 347,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 348,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 349,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 350,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 351,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 352,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 353,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 354,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 355,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 356,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 357,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 358,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 359,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 360,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 361,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 362,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 363,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 364,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 365,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 366,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 367,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 368,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 369,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 370,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 371,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 372,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 373,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 374,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 375,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 376,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 377,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 378,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 379,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 380,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 381,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

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
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 384,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 385,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 386,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 387,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 388,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 389,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 390,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 391,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 392,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

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
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 395,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 396,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 397,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 398,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 399,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 400,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 401,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 402,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 403,
                column: "Status",
                value: "E");

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
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 407,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 408,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 409,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 410,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 411,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 412,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 413,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 414,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 415,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 416,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 417,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 418,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 419,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 420,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 421,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 422,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 423,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 424,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 425,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 426,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 427,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 428,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 429,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 430,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

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
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

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
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 435,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 436,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 437,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

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
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 440,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 441,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 442,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 443,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 444,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 445,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

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
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 448,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 449,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 450,
                columns: new[] { "Paid", "Status" },
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
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 453,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 454,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 455,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 456,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 457,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 458,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 459,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 460,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 461,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 462,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 463,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 464,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 465,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 466,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 467,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 468,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 469,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 470,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 471,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 472,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 473,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 474,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 475,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 476,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 477,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 478,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 479,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 480,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 481,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 482,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 483,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 484,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 485,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 486,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 487,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 488,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 489,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 490,
                column: "Status",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 491,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 492,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, "E" });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 493,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, "E" });

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
                columns: new[] { "BookPrice", "CourseId", "Price", "Seats", "StartDate" },
                values: new object[] { 30.0, 5, 70.0, 24, new DateTimeOffset(new DateTime(2018, 7, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 3,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 39.0, 7, 6, 136.0, 23, new DateTimeOffset(new DateTime(2019, 8, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

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
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 46.0, 5, 4, 3, 78.0, 24, new DateTimeOffset(new DateTime(2016, 6, 28, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 6,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 34.0, 10, 3, 2, 123.0, 20, new DateTimeOffset(new DateTime(2016, 2, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 7,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 45.0, 5, 4, 3, 136.0, 25, new DateTimeOffset(new DateTime(2016, 3, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 8,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 29.0, 3, 2, 3, 65.0, 26, new DateTimeOffset(new DateTime(2019, 7, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

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
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 37.0, 6, 6, 146.0, 25, new DateTimeOffset(new DateTime(2018, 5, 22, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 11,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 27.0, 9, 5, 45.0, 25, new DateTimeOffset(new DateTime(2017, 3, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 12,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 40.0, 10, 3, 3, 68.0, 26, new DateTimeOffset(new DateTime(2018, 8, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

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
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 17.0, 7, 3, 48.0, 22, new DateTimeOffset(new DateTime(2018, 10, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 17,
                columns: new[] { "BookPrice", "CourseId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 23.0, 2, 3, 125.0, 23, new DateTimeOffset(new DateTime(2019, 8, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 18,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 32.0, 5, 5, 118.0, 27, new DateTimeOffset(new DateTime(2016, 8, 18, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 19,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 36.0, 10, 2, 2, 93.0, 17, new DateTimeOffset(new DateTime(2016, 2, 7, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 20,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 25.0, 7, 3, 2, 119.0, 26, new DateTimeOffset(new DateTime(2016, 9, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

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
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 22.0, 7, 6, 105.0, 12, new DateTimeOffset(new DateTime(2018, 7, 17, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 23,
                columns: new[] { "BookPrice", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 35.0, 6, 1, 143.0, 18, new DateTimeOffset(new DateTime(2018, 6, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 24,
                columns: new[] { "BookPrice", "CourseId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 35.0, 8, 2, 123.0, 12, new DateTimeOffset(new DateTime(2019, 9, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 25,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 50.0, 1, 3, 3, 129.0, 26, new DateTimeOffset(new DateTime(2017, 2, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 26,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 24.0, 10, 1, 2, 137.0, 22, new DateTimeOffset(new DateTime(2017, 2, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 27,
                columns: new[] { "BookPrice", "CourseId", "Price", "Seats", "StartDate" },
                values: new object[] { 43.0, 9, 148.0, 20, new DateTimeOffset(new DateTime(2016, 9, 25, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 28,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 37.0, 10, 1, 125.0, 23, new DateTimeOffset(new DateTime(2016, 2, 21, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 29,
                columns: new[] { "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 9, 6, 143.0, 23, new DateTimeOffset(new DateTime(2019, 5, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 1,
                column: "Street",
                value: "405 S. Oak Street");

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "LocationId", "City", "Name", "State", "Street", "Zipcode" },
                values: new object[,]
                {
                    { 4, "Mandeville", "Mandeville Fire Department", "LA", "24301 Highway 190", 70448 },
                    { 5, "Slidell", "Slidell Fire Department", "LA", "375 Bouscaren St", 70458 }
                });

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
                columns: new[] { "Email", "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "nicoledufrene0301@gmail.com", "Nicole", "Dufrene", "IRXQ4FTd36XLPxC54HZBqDuqgPDrefDe7tdrQjo07N8=", new byte[] { 188, 13, 44, 118, 107, 96, 127, 169, 245, 144, 114, 111, 228, 115, 15, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "IRXQ4FTd36XLPxC54HZBqDuqgPDrefDe7tdrQjo07N8=", new byte[] { 188, 13, 44, 118, 107, 96, 127, 169, 245, 144, 114, 111, 228, 115, 15, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "IRXQ4FTd36XLPxC54HZBqDuqgPDrefDe7tdrQjo07N8=", new byte[] { 188, 13, 44, 118, 107, 96, 127, 169, 245, 144, 114, 111, 228, 115, 15, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "IRXQ4FTd36XLPxC54HZBqDuqgPDrefDe7tdrQjo07N8=", new byte[] { 188, 13, 44, 118, 107, 96, 127, 169, 245, 144, 114, 111, 228, 115, 15, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "IRXQ4FTd36XLPxC54HZBqDuqgPDrefDe7tdrQjo07N8=", new byte[] { 188, 13, 44, 118, 107, 96, 127, 169, 245, 144, 114, 111, 228, 115, 15, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "IRXQ4FTd36XLPxC54HZBqDuqgPDrefDe7tdrQjo07N8=", new byte[] { 188, 13, 44, 118, 107, 96, 127, 169, 245, 144, 114, 111, 228, 115, 15, 33 } });

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

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "BookAvailable", "BookPrice", "CategoryId", "Description", "Name", "PrereqId", "TypicalPrice" },
                values: new object[,]
                {
                    { 16, false, 0.0, 5, "This is a free service by certified child passenger safety technicians to lower childhood deaths and injuries.  To stay informed of events and education, please follow Buckle Up Louisiana on Facebook.  Nicole Dufrene can assist anyone who has questions concerning car safety seat information FREE of charge. Her email is: nicoledufrene0301@gmail.com.  Additional information can be found at The National Highway and Traffic Safety website https://www.nhtsa.gov/.  Also visit https://www.safekids.org/child-passenger-safety to learn more about the organization that regulates the  curriculum for our classes and also has a find a fitting station near you.", "Car Seat Safety", null, 0 },
                    { 11, false, 0.0, 6, "This 14 hour, 2 day class following American Red Cross standards will educate the babysitter on skills necessary to provide quality care to children of all ages.  Participants must be ages 11 and older and will learn Adult/Child/Infant CPR and AED, basic first aid, child behavior, age-appropriate activities, basic child care (including bottling, feeding, and diapering), and professionalism.  This courses teaches techniques necessary for all babysitters.", "ARC Babysitting  BOOT CAMP", null, 50 },
                    { 13, false, 0.0, 4, "Current certified lifeguards with valid American Red Cross Lifeguarding/CPR/AED/First aid certification who have expired more than 30 days.  Students must bring proof of valid ARC Lifeguarding, First Aid, and CPR/AED for the Professional Rescuer certification.  Students will be required to swim 300 yards, tread water using legs only for 2 minutes, and retrieve a 10 pound weird from a 7-10 foot depth, swim 20 yards wihth the weight, and exit the pool without using ladder or steps within 100 seconds.  Students will recieve a 2 year ARC certification in Lifeguard, First Aid, and CPR/AED", "ARC Lifeguard Recert", 12, 50 },
                    { 14, false, 0.0, 4, "The purpose of this instructor course is to ttrain candidates to teach courses and presentation in the American Red Cross Swimming and Water Safety program including Parent and Child Aquatics, Preschool Aquatics, Learn-to-Swim, Adult Swim, Private Lessons, Water Safety Courses (including Safety Training for Swim Coaches) and Water Safety Presentations.  Candidates must be at least 16 years old and demonstrate the ability to perform the following swimming skills: Front Crawl, Back Crawl, Breaststroke, Elementary Backstroke, Sidestroke, and Butterfly, all for 25 yards.  Candidates must be able to maintain position on back for 1 minute in deep water (floating or sculling) and must tread water for 1 minute.  The instructor-lead course is 31 hours.  To be certified, candidates must successfully complete the online Intro to the ARC Water Safety Course, complete the Precourse Skills Session, attend and participate in all course sessions, complete class activities including the four practice-teaching assignments, demonstrate instructor-level skill competency in all scenarios, and score a minimum of 80 percent on the instructor course final written exam.", "ARC Water Safety Instructor", 12, 50 },
                    { 15, false, 0.0, 4, "The purpose of the American Red Cross Lifeguard Instructor course is to train candidates to teach the American Red Cross Lifeguarding, Lifeguard Blending Learning, Shallow Water Lifeguard, Water Park Skills, CPR/AED for the Professional Rescuers and Health Care Providers, Administering Emergency Oxygen and Bloodborne Pathogens Training courses and modules.  Candidates must be at least 17 years old, possess current ARC Lifeguarding/CPR/AED/First Aid certification, complete the online Orientation to the ARC and Orientation to the Lifeguard Instructor course and Precourse Exam, successfully complete the Precourse session, and Obtain the Lifeguard Instructor's Manual and Lifeguarding Manual.  To be certified, candidates must successfully complete the online Intro to the ARC Lifeguard Instructor Course, complete the Precourse Skills Session, attend and participate in all course sessions, complete class activities including the four practice-teaching assignments, demonstrate instructor-level skill competency in all scenarios, and score a minimum of 80 percent on the instructor course final written exam.", "ARC Lifeguard Instructor", 12, 50 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bio",
                keyColumn: "StaffBioId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Bio",
                keyColumn: "StaffBioId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Bio",
                keyColumn: "StaffBioId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Bio",
                keyColumn: "StaffBioId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 12);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Category");

            migrationBuilder.UpdateData(
                table: "Bio",
                keyColumn: "StaffBioId",
                keyValue: 1,
                column: "Bio",
                value: "I am Staff 1!");

            migrationBuilder.UpdateData(
                table: "Bio",
                keyColumn: "StaffBioId",
                keyValue: 2,
                column: "Bio",
                value: "I am Staff 2!");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "Name",
                value: "BLS");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "Name",
                value: "AED");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "Name",
                value: "EMT");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 2,
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 3,
                columns: new[] { "CategoryId", "PrereqId" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 4,
                column: "CategoryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 5,
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 7,
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 8,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 2, "BLS CPR, Instructor Course" });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 10,
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 1,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

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
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 5,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 6,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 7,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

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
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

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
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 12,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 13,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

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
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 16,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 17,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 18,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 19,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 20,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

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
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 23,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

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
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 28,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 29,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 30,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 31,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 32,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 33,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 34,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 35,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 36,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 37,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 38,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 39,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 40,
                columns: new[] { "BookBought", "Status" },
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
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 43,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 44,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 45,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 46,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 47,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 48,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 49,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 50,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 51,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 52,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 53,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 54,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 55,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 56,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 57,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 58,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 59,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 60,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 61,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 62,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 63,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 64,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

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
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 67,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 68,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 69,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 70,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 71,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 72,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 73,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 74,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 75,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 76,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 77,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 78,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 79,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 80,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 81,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 82,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 83,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 84,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 85,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 86,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 87,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 88,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 89,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 90,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 91,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 92,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 93,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 94,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 95,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 96,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 97,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 98,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 99,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 100,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 101,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 102,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 103,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 104,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 105,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 106,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 107,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 108,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 109,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 110,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 111,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 112,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 113,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 114,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 115,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 116,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 117,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 118,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 119,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 120,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 121,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 122,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 123,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 124,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 125,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 126,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 127,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 128,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 129,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 130,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 131,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 132,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 133,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 134,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 135,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 136,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 137,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 138,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 139,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 140,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 141,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 142,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 143,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 144,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 145,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 146,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 147,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 148,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 149,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 150,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 151,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 152,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 153,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 154,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 155,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 156,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 157,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 158,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 159,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 160,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 161,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 162,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 163,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 164,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 165,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 166,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 167,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 168,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 169,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 170,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 171,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 172,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 173,
                columns: new[] { "Paid", "Status" },
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
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

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
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 178,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 179,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 180,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 181,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 182,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 183,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 184,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 185,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 186,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 187,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 188,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 189,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 190,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 191,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 192,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 193,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 194,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 195,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 196,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 197,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 198,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 199,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 200,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 201,
                column: "Status",
                value: null);

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
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 204,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 205,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 206,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 207,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

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
                columns: new[] { "BookBought", "Status" },
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
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 212,
                column: "Status",
                value: null);

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
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 215,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 216,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

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
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 219,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 220,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 221,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 222,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 223,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 224,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 225,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 226,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 227,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 228,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 229,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 230,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 231,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 232,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 233,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 234,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 235,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 236,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 237,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

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
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 240,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 241,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 242,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 243,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 244,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 245,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 246,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 247,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 248,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 249,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 250,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 251,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 252,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 253,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 254,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 255,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 256,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 257,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 258,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 259,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 260,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 261,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 262,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 263,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 264,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 265,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 266,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 267,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 268,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 269,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 270,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 271,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 272,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

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
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 275,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 276,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 277,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 278,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 279,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 280,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 281,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 282,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 283,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 284,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 285,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 286,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 287,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 288,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 289,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 290,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 291,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 292,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 293,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 294,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 295,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 296,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 297,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 298,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 299,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 300,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 301,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 302,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 303,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 304,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 305,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 306,
                columns: new[] { "BookBought", "Status" },
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
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 309,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 310,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 311,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

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
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 314,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 315,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 316,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 317,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 318,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

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
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 321,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 322,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 323,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 324,
                column: "Status",
                value: null);

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
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 327,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 328,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 329,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

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
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 332,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 333,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 334,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 335,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 336,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 337,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 338,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 339,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 340,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 341,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 342,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 343,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 344,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 345,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 346,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 347,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 348,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 349,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 350,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 351,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 352,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 353,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 354,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 355,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 356,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 357,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 358,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 359,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 360,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 361,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 362,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 363,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 364,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 365,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 366,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 367,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 368,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 369,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 370,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 371,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 372,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 373,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 374,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 375,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 376,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 377,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 378,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 379,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 380,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 381,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

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
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 384,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 385,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 386,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 387,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 388,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 389,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 390,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 391,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 392,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

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
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 395,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 396,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 397,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 398,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 399,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 400,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 401,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 402,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 403,
                column: "Status",
                value: null);

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
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 407,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 408,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 409,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 410,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 411,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 412,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 413,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 414,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 415,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 416,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 417,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 418,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 419,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 420,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 421,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 422,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 423,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 424,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 425,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 426,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 427,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 428,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 429,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 430,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

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
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

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
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 435,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 436,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 437,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

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
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 440,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 441,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 442,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 443,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 444,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 445,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

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
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 448,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 449,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 450,
                columns: new[] { "Paid", "Status" },
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
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 453,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 454,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 455,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 456,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 457,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 458,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 459,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 460,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 461,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 462,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 463,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 464,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 465,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 466,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 467,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 468,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 469,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 470,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 471,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 472,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 473,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 474,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 475,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 476,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 477,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 478,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 479,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 480,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 481,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 482,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 483,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 484,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 485,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 486,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 487,
                columns: new[] { "Paid", "Status" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 488,
                columns: new[] { "BookBought", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 489,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, false, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 490,
                column: "Status",
                value: null);

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 491,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { false, true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 492,
                columns: new[] { "Paid", "Status" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 493,
                columns: new[] { "BookBought", "Paid", "Status" },
                values: new object[] { true, true, null });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 1,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 40.0, 3, 4, 2, 62.0, 28, new DateTimeOffset(new DateTime(2016, 4, 6, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 2,
                columns: new[] { "BookPrice", "CourseId", "Price", "Seats", "StartDate" },
                values: new object[] { 46.0, 3, 138.0, 28, new DateTimeOffset(new DateTime(2018, 4, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 3,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 34.0, 10, 5, 139.0, 27, new DateTimeOffset(new DateTime(2018, 10, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 4,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 45.0, 6, 4, 87.0, 12, new DateTimeOffset(new DateTime(2018, 3, 10, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 5,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 27.0, 6, 5, 2, 76.0, 16, new DateTimeOffset(new DateTime(2018, 5, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 6,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 51.0, 4, 5, 3, 87.0, 28, new DateTimeOffset(new DateTime(2016, 9, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 7,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 23.0, 9, 6, 2, 73.0, 13, new DateTimeOffset(new DateTime(2016, 8, 3, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 8,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 50.0, 7, 3, 2, 128.0, 16, new DateTimeOffset(new DateTime(2019, 1, 17, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 9,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 30.0, 2, 5, 2, 77.0, 18, new DateTimeOffset(new DateTime(2017, 12, 17, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 10,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 30.0, 4, 4, 67.0, 27, new DateTimeOffset(new DateTime(2019, 4, 2, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 11,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 52.0, 6, 3, 83.0, 19, new DateTimeOffset(new DateTime(2016, 12, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 12,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 31.0, 6, 4, 2, 50.0, 27, new DateTimeOffset(new DateTime(2016, 4, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 13,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 24.0, 5, 4, 128.0, 23, new DateTimeOffset(new DateTime(2017, 3, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 14,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 35.0, 8, 2, 3, 129.0, 17, new DateTimeOffset(new DateTime(2019, 12, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 15,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 22.0, 3, 5, 1, 122.0, 19, new DateTimeOffset(new DateTime(2019, 1, 22, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 16,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 35.0, 8, 5, 86.0, 16, new DateTimeOffset(new DateTime(2018, 6, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 17,
                columns: new[] { "BookPrice", "CourseId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 18.0, 8, 2, 64.0, 11, new DateTimeOffset(new DateTime(2019, 4, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 18,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 18.0, 7, 2, 139.0, 22, new DateTimeOffset(new DateTime(2019, 4, 8, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 19,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 24.0, 4, 1, 1, 109.0, 24, new DateTimeOffset(new DateTime(2019, 4, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 20,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 27.0, 1, 5, 1, 144.0, 27, new DateTimeOffset(new DateTime(2017, 1, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 21,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 47.0, 9, 2, 66.0, 18, new DateTimeOffset(new DateTime(2018, 7, 24, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 22,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 38.0, 2, 4, 92.0, 10, new DateTimeOffset(new DateTime(2019, 7, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 23,
                columns: new[] { "BookPrice", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 19.0, 3, 3, 62.0, 17, new DateTimeOffset(new DateTime(2018, 11, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 24,
                columns: new[] { "BookPrice", "CourseId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 21.0, 2, 1, 117.0, 23, new DateTimeOffset(new DateTime(2017, 10, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 25,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 33.0, 7, 4, 1, 82.0, 21, new DateTimeOffset(new DateTime(2018, 2, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 26,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[] { 46.0, 7, 6, 1, 95.0, 21, new DateTimeOffset(new DateTime(2019, 11, 27, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 27,
                columns: new[] { "BookPrice", "CourseId", "Price", "Seats", "StartDate" },
                values: new object[] { 25.0, 5, 102.0, 27, new DateTimeOffset(new DateTime(2019, 1, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 28,
                columns: new[] { "BookPrice", "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 42.0, 4, 5, 73.0, 15, new DateTimeOffset(new DateTime(2018, 3, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 29,
                columns: new[] { "CourseId", "InstructorId", "Price", "Seats", "StartDate" },
                values: new object[] { 7, 1, 148.0, 18, new DateTimeOffset(new DateTime(2016, 10, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 1,
                column: "Street",
                value: "104 Smith Street");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "Y83/1zYFQjqvnszDAJwPRl5rHw+En5gZvfi8Az7wPFw=", new byte[] { 45, 94, 70, 13, 81, 87, 239, 193, 161, 242, 224, 254, 70, 220, 185, 92 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "student1@student.com", "Paul", "Dig", "7UXzXXBYzmkoUSVF1yF5qGdJfE08IXM48Bl7qHX+MRE=", new byte[] { 91, 186, 92, 45, 166, 216, 1, 140, 227, 186, 159, 207, 212, 9, 61, 152 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "7UXzXXBYzmkoUSVF1yF5qGdJfE08IXM48Bl7qHX+MRE=", new byte[] { 91, 186, 92, 45, 166, 216, 1, 140, 227, 186, 159, 207, 212, 9, 61, 152 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "7UXzXXBYzmkoUSVF1yF5qGdJfE08IXM48Bl7qHX+MRE=", new byte[] { 91, 186, 92, 45, 166, 216, 1, 140, 227, 186, 159, 207, 212, 9, 61, 152 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "7UXzXXBYzmkoUSVF1yF5qGdJfE08IXM48Bl7qHX+MRE=", new byte[] { 91, 186, 92, 45, 166, 216, 1, 140, 227, 186, 159, 207, 212, 9, 61, 152 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "7UXzXXBYzmkoUSVF1yF5qGdJfE08IXM48Bl7qHX+MRE=", new byte[] { 91, 186, 92, 45, 166, 216, 1, 140, 227, 186, 159, 207, 212, 9, 61, 152 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "7UXzXXBYzmkoUSVF1yF5qGdJfE08IXM48Bl7qHX+MRE=", new byte[] { 91, 186, 92, 45, 166, 216, 1, 140, 227, 186, 159, 207, 212, 9, 61, 152 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "7UXzXXBYzmkoUSVF1yF5qGdJfE08IXM48Bl7qHX+MRE=", new byte[] { 91, 186, 92, 45, 166, 216, 1, 140, 227, 186, 159, 207, 212, 9, 61, 152 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "7UXzXXBYzmkoUSVF1yF5qGdJfE08IXM48Bl7qHX+MRE=", new byte[] { 91, 186, 92, 45, 166, 216, 1, 140, 227, 186, 159, 207, 212, 9, 61, 152 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "7UXzXXBYzmkoUSVF1yF5qGdJfE08IXM48Bl7qHX+MRE=", new byte[] { 91, 186, 92, 45, 166, 216, 1, 140, 227, 186, 159, 207, 212, 9, 61, 152 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "7UXzXXBYzmkoUSVF1yF5qGdJfE08IXM48Bl7qHX+MRE=", new byte[] { 91, 186, 92, 45, 166, 216, 1, 140, 227, 186, 159, 207, 212, 9, 61, 152 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "7UXzXXBYzmkoUSVF1yF5qGdJfE08IXM48Bl7qHX+MRE=", new byte[] { 91, 186, 92, 45, 166, 216, 1, 140, 227, 186, 159, 207, 212, 9, 61, 152 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "7UXzXXBYzmkoUSVF1yF5qGdJfE08IXM48Bl7qHX+MRE=", new byte[] { 91, 186, 92, 45, 166, 216, 1, 140, 227, 186, 159, 207, 212, 9, 61, 152 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "7UXzXXBYzmkoUSVF1yF5qGdJfE08IXM48Bl7qHX+MRE=", new byte[] { 91, 186, 92, 45, 166, 216, 1, 140, 227, 186, 159, 207, 212, 9, 61, 152 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "7UXzXXBYzmkoUSVF1yF5qGdJfE08IXM48Bl7qHX+MRE=", new byte[] { 91, 186, 92, 45, 166, 216, 1, 140, 227, 186, 159, 207, 212, 9, 61, 152 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "7UXzXXBYzmkoUSVF1yF5qGdJfE08IXM48Bl7qHX+MRE=", new byte[] { 91, 186, 92, 45, 166, 216, 1, 140, 227, 186, 159, 207, 212, 9, 61, 152 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "7UXzXXBYzmkoUSVF1yF5qGdJfE08IXM48Bl7qHX+MRE=", new byte[] { 91, 186, 92, 45, 166, 216, 1, 140, 227, 186, 159, 207, 212, 9, 61, 152 } });
        }
    }
}
