using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KSS.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "Book", "Description", "Name", "PrereqId" },
                values: new object[,]
                {
                    { 1, false, "CPR ", "CPR 101", null },
                    { 2, false, "Hammond", "CPR 201", null },
                    { 3, false, "Hammond", "CPR 301", null },
                    { 4, false, "Hammond", "EMT 101", null },
                    { 5, false, "Hammond", "EMT 201", null },
                    { 6, false, "Hammond", "EMT 301", null }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "LocationId", "City", "State", "Street", "Zipcode" },
                values: new object[,]
                {
                    { 1, "Hammond", "LA", "104 Smith Street", 70403 },
                    { 2, "Tickfaw", "LA", "92 Hill Street", 70442 },
                    { 3, "Independence", "LA", "12044 Hwy 40", 70443 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "FirstName", "LastName", "Password", "Phone", "Role", "Salt" },
                values: new object[,]
                {
                    { 15, "student14@student.com", "Smith", "Hammond", "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", "1112223333", "User", new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } },
                    { 14, "student13@student.com", "Smith", "Hammond", "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", "1112223333", "User", new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } },
                    { 13, "student12@student.com", "Smith", "Hammond", "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", "1112223333", "User", new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } },
                    { 12, "student11@student.com", "Smith", "Hammond", "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", "1112223333", "User", new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } },
                    { 11, "student10@student.com", "Smith", "Hammond", "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", "1112223333", "User", new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } },
                    { 10, "student9@student.com", "Smith", "Hammond", "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", "1112223333", "User", new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } },
                    { 9, "student8@student.com", "Smith", "Hammond", "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", "1112223333", "User", new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } },
                    { 4, "student3@student.com", "Smith", "Hammond", "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", "1112223333", "User", new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } },
                    { 7, "student6@student.com", "Smith", "Hammond", "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", "1112223333", "User", new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } },
                    { 6, "student5@student.com", "Smith", "Hammond", "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", "1112223333", "User", new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } },
                    { 5, "student4@student.com", "Smith", "Hammond", "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", "1112223333", "User", new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } },
                    { 16, "student15@student.com", "Smith", "Hammond", "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", "1112223333", "User", new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } },
                    { 3, "student2@student.com", "Smith", "Hammond", "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", "1112223333", "User", new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } },
                    { 2, "student1@student.com", "Smith", "Hammond", "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", "1112223333", "User", new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } },
                    { 1, "admin@admin.com", "Smith", "Hammond", "YpMFOfOxVxnZBqHd6ahEPRNyeG8BHtmwtZYXqC99ydQ=", "1112223333", "Admin", new byte[] { 51, 80, 51, 12, 169, 93, 189, 143, 52, 28, 99, 109, 215, 250, 219, 8 } },
                    { 8, "student7@student.com", "Smith", "Hammond", "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", "1112223333", "User", new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } },
                    { 17, "student16@student.com", "Smith", "Hammond", "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", "1112223333", "User", new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } }
                });

            migrationBuilder.InsertData(
                table: "Instance",
                columns: new[] { "InstanceId", "CourseId", "LocationId", "Price", "Seats", "StartDate" },
                values: new object[,]
                {
                    { 1, 1, 1, 45.0, 25, new DateTimeOffset(new DateTime(2018, 7, 1, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 4, 2, 1, 45.0, 10, new DateTimeOffset(new DateTime(2018, 8, 12, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 7, 3, 1, 45.0, 12, new DateTimeOffset(new DateTime(2018, 9, 30, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 10, 4, 1, 45.0, 25, new DateTimeOffset(new DateTime(2018, 10, 24, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 11, 4, 1, 45.0, 25, new DateTimeOffset(new DateTime(2018, 10, 25, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 12, 5, 1, 45.0, 15, new DateTimeOffset(new DateTime(2018, 11, 1, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 2, 1, 2, 45.0, 10, new DateTimeOffset(new DateTime(2018, 7, 22, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 5, 2, 2, 45.0, 30, new DateTimeOffset(new DateTime(2018, 9, 12, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 8, 3, 2, 45.0, 10, new DateTimeOffset(new DateTime(2018, 9, 29, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 13, 5, 2, 45.0, 25, new DateTimeOffset(new DateTime(2018, 11, 11, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 14, 5, 2, 45.0, 25, new DateTimeOffset(new DateTime(2018, 11, 13, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 15, 5, 2, 45.0, 25, new DateTimeOffset(new DateTime(2018, 11, 14, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 3, 1, 3, 45.0, 30, new DateTimeOffset(new DateTime(2018, 8, 2, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 6, 2, 3, 45.0, 10, new DateTimeOffset(new DateTime(2018, 9, 21, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { 9, 3, 3, 45.0, 10, new DateTimeOffset(new DateTime(2018, 10, 1, 8, 6, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "EnrollmentId", "InstanceId", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "E", 12 },
                    { 22, 9, "E", 13 },
                    { 16, 6, "E", 8 },
                    { 15, 6, "E", 7 },
                    { 14, 6, "E", 6 },
                    { 9, 3, "E", 13 },
                    { 8, 3, "E", 8 },
                    { 7, 3, "E", 7 },
                    { 32, 13, "E", 3 },
                    { 31, 13, "E", 2 },
                    { 21, 8, "E", 12 },
                    { 20, 8, "E", 11 },
                    { 19, 8, "E", 10 },
                    { 13, 5, "E", 5 },
                    { 12, 5, "E", 4 },
                    { 6, 2, "E", 6 },
                    { 5, 2, "E", 5 },
                    { 4, 2, "E", 4 },
                    { 30, 12, "E", 17 },
                    { 29, 12, "E", 3 },
                    { 28, 11, "E", 17 },
                    { 27, 10, "E", 16 },
                    { 26, 10, "E", 15 },
                    { 25, 10, "E", 14 },
                    { 18, 7, "E", 10 },
                    { 17, 7, "E", 9 },
                    { 11, 4, "E", 3 },
                    { 10, 4, "E", 2 },
                    { 3, 1, "E", 3 },
                    { 2, 1, "E", 2 },
                    { 23, 9, "E", 14 },
                    { 24, 9, "E", 14 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Instance",
                keyColumn: "InstanceId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 3);
        }
    }
}
