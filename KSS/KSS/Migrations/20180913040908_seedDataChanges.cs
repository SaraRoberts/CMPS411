using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KSS.Migrations
{
    public partial class seedDataChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 1,
                column: "Description",
                value: "CPR beginner class");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 2,
                columns: new[] { "Description", "PrereqId" },
                values: new object[] { "CPR advanced techniques", 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 3,
                columns: new[] { "Description", "PrereqId" },
                values: new object[] { "CPR master class", 2 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 4,
                column: "Description",
                value: "EMT beginner class");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 5,
                columns: new[] { "Description", "PrereqId" },
                values: new object[] { "EMT advanced techniques", 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 6,
                columns: new[] { "Description", "PrereqId" },
                values: new object[] { "EMT master class", 5 });

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
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Becky", "Smith", "7oCz8BO1gO6z++/ixBB0yzos4mJDz34oPYH1Dy5qY40=", new byte[] { 243, 155, 200, 132, 242, 144, 69, 25, 1, 236, 23, 60, 64, 219, 160, 26 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Paul", "Dig", "MMni4J9zvCBm09F93PfFxB+A6djU650hfrsDMJ/n9sA=", new byte[] { 169, 14, 240, 243, 197, 2, 224, 41, 97, 33, 220, 174, 255, 67, 99, 193 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Mike", "Waters", "MMni4J9zvCBm09F93PfFxB+A6djU650hfrsDMJ/n9sA=", new byte[] { 169, 14, 240, 243, 197, 2, 224, 41, 97, 33, 220, 174, 255, 67, 99, 193 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Russel", "Chavers", "MMni4J9zvCBm09F93PfFxB+A6djU650hfrsDMJ/n9sA=", new byte[] { 169, 14, 240, 243, 197, 2, 224, 41, 97, 33, 220, 174, 255, 67, 99, 193 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Sharon", "Manino", "MMni4J9zvCBm09F93PfFxB+A6djU650hfrsDMJ/n9sA=", new byte[] { 169, 14, 240, 243, 197, 2, 224, 41, 97, 33, 220, 174, 255, 67, 99, 193 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Amy", "Hillbond", "MMni4J9zvCBm09F93PfFxB+A6djU650hfrsDMJ/n9sA=", new byte[] { 169, 14, 240, 243, 197, 2, 224, 41, 97, 33, 220, 174, 255, 67, 99, 193 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Bill", "Everet", "MMni4J9zvCBm09F93PfFxB+A6djU650hfrsDMJ/n9sA=", new byte[] { 169, 14, 240, 243, 197, 2, 224, 41, 97, 33, 220, 174, 255, 67, 99, 193 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Trenton", "Hillsong", "MMni4J9zvCBm09F93PfFxB+A6djU650hfrsDMJ/n9sA=", new byte[] { 169, 14, 240, 243, 197, 2, 224, 41, 97, 33, 220, 174, 255, 67, 99, 193 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Colin", "Livers", "MMni4J9zvCBm09F93PfFxB+A6djU650hfrsDMJ/n9sA=", new byte[] { 169, 14, 240, 243, 197, 2, 224, 41, 97, 33, 220, 174, 255, 67, 99, 193 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Babe", "Ruth", "MMni4J9zvCBm09F93PfFxB+A6djU650hfrsDMJ/n9sA=", new byte[] { 169, 14, 240, 243, 197, 2, 224, 41, 97, 33, 220, 174, 255, 67, 99, 193 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "FirstName", "Password", "Salt" },
                values: new object[] { "Tim", "MMni4J9zvCBm09F93PfFxB+A6djU650hfrsDMJ/n9sA=", new byte[] { 169, 14, 240, 243, 197, 2, 224, 41, 97, 33, 220, 174, 255, 67, 99, 193 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Gary", "Aimes", "MMni4J9zvCBm09F93PfFxB+A6djU650hfrsDMJ/n9sA=", new byte[] { 169, 14, 240, 243, 197, 2, 224, 41, 97, 33, 220, 174, 255, 67, 99, 193 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Lucy", "Vilardo", "MMni4J9zvCBm09F93PfFxB+A6djU650hfrsDMJ/n9sA=", new byte[] { 169, 14, 240, 243, 197, 2, 224, 41, 97, 33, 220, 174, 255, 67, 99, 193 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Tom", "Avers", "MMni4J9zvCBm09F93PfFxB+A6djU650hfrsDMJ/n9sA=", new byte[] { 169, 14, 240, 243, 197, 2, 224, 41, 97, 33, 220, 174, 255, 67, 99, 193 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Amanda", "Catalonato", "MMni4J9zvCBm09F93PfFxB+A6djU650hfrsDMJ/n9sA=", new byte[] { 169, 14, 240, 243, 197, 2, 224, 41, 97, 33, 220, 174, 255, 67, 99, 193 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Donald", "Hill", "MMni4J9zvCBm09F93PfFxB+A6djU650hfrsDMJ/n9sA=", new byte[] { 169, 14, 240, 243, 197, 2, 224, 41, 97, 33, 220, 174, 255, 67, 99, 193 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Richard", "Newman", "MMni4J9zvCBm09F93PfFxB+A6djU650hfrsDMJ/n9sA=", new byte[] { 169, 14, 240, 243, 197, 2, 224, 41, 97, 33, 220, 174, 255, 67, 99, 193 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 1,
                column: "Description",
                value: "CPR ");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 2,
                columns: new[] { "Description", "PrereqId" },
                values: new object[] { "Hammond", null });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 3,
                columns: new[] { "Description", "PrereqId" },
                values: new object[] { "Hammond", null });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 4,
                column: "Description",
                value: "Hammond");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 5,
                columns: new[] { "Description", "PrereqId" },
                values: new object[] { "Hammond", null });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 6,
                columns: new[] { "Description", "PrereqId" },
                values: new object[] { "Hammond", null });

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
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Smith", "Hammond", "YpMFOfOxVxnZBqHd6ahEPRNyeG8BHtmwtZYXqC99ydQ=", new byte[] { 51, 80, 51, 12, 169, 93, 189, 143, 52, 28, 99, 109, 215, 250, 219, 8 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Smith", "Hammond", "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Smith", "Hammond", "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Smith", "Hammond", "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Smith", "Hammond", "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Smith", "Hammond", "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Smith", "Hammond", "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Smith", "Hammond", "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Smith", "Hammond", "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Smith", "Hammond", "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "FirstName", "Password", "Salt" },
                values: new object[] { "Smith", "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Smith", "Hammond", "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Smith", "Hammond", "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Smith", "Hammond", "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Smith", "Hammond", "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Smith", "Hammond", "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "FirstName", "LastName", "Password", "Salt" },
                values: new object[] { "Smith", "Hammond", "ePjP/Gt91T86vX8+ADOUXPksVlp76n39CR2ydVturJE=", new byte[] { 146, 174, 255, 33, 10, 8, 159, 109, 21, 87, 176, 96, 203, 168, 62, 25 } });
        }
    }
}
