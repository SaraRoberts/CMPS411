using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KSS.Migrations
{
    public partial class BookUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Book",
                table: "Course",
                newName: "BookAvailable");

            migrationBuilder.AddColumn<bool>(
                name: "BookBought",
                table: "Enrollment",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "BookPrice",
                table: "Course",
                nullable: false,
                defaultValue: 0m);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookBought",
                table: "Enrollment");

            migrationBuilder.DropColumn(
                name: "BookPrice",
                table: "Course");

            migrationBuilder.RenameColumn(
                name: "BookAvailable",
                table: "Course",
                newName: "Book");

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
                values: new object[] { "7oCz8BO1gO6z++/ixBB0yzos4mJDz34oPYH1Dy5qY40=", new byte[] { 243, 155, 200, 132, 242, 144, 69, 25, 1, 236, 23, 60, 64, 219, 160, 26 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "MMni4J9zvCBm09F93PfFxB+A6djU650hfrsDMJ/n9sA=", new byte[] { 169, 14, 240, 243, 197, 2, 224, 41, 97, 33, 220, 174, 255, 67, 99, 193 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "MMni4J9zvCBm09F93PfFxB+A6djU650hfrsDMJ/n9sA=", new byte[] { 169, 14, 240, 243, 197, 2, 224, 41, 97, 33, 220, 174, 255, 67, 99, 193 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "MMni4J9zvCBm09F93PfFxB+A6djU650hfrsDMJ/n9sA=", new byte[] { 169, 14, 240, 243, 197, 2, 224, 41, 97, 33, 220, 174, 255, 67, 99, 193 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "MMni4J9zvCBm09F93PfFxB+A6djU650hfrsDMJ/n9sA=", new byte[] { 169, 14, 240, 243, 197, 2, 224, 41, 97, 33, 220, 174, 255, 67, 99, 193 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "MMni4J9zvCBm09F93PfFxB+A6djU650hfrsDMJ/n9sA=", new byte[] { 169, 14, 240, 243, 197, 2, 224, 41, 97, 33, 220, 174, 255, 67, 99, 193 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "MMni4J9zvCBm09F93PfFxB+A6djU650hfrsDMJ/n9sA=", new byte[] { 169, 14, 240, 243, 197, 2, 224, 41, 97, 33, 220, 174, 255, 67, 99, 193 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "MMni4J9zvCBm09F93PfFxB+A6djU650hfrsDMJ/n9sA=", new byte[] { 169, 14, 240, 243, 197, 2, 224, 41, 97, 33, 220, 174, 255, 67, 99, 193 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "MMni4J9zvCBm09F93PfFxB+A6djU650hfrsDMJ/n9sA=", new byte[] { 169, 14, 240, 243, 197, 2, 224, 41, 97, 33, 220, 174, 255, 67, 99, 193 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "MMni4J9zvCBm09F93PfFxB+A6djU650hfrsDMJ/n9sA=", new byte[] { 169, 14, 240, 243, 197, 2, 224, 41, 97, 33, 220, 174, 255, 67, 99, 193 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "MMni4J9zvCBm09F93PfFxB+A6djU650hfrsDMJ/n9sA=", new byte[] { 169, 14, 240, 243, 197, 2, 224, 41, 97, 33, 220, 174, 255, 67, 99, 193 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "MMni4J9zvCBm09F93PfFxB+A6djU650hfrsDMJ/n9sA=", new byte[] { 169, 14, 240, 243, 197, 2, 224, 41, 97, 33, 220, 174, 255, 67, 99, 193 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "MMni4J9zvCBm09F93PfFxB+A6djU650hfrsDMJ/n9sA=", new byte[] { 169, 14, 240, 243, 197, 2, 224, 41, 97, 33, 220, 174, 255, 67, 99, 193 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "MMni4J9zvCBm09F93PfFxB+A6djU650hfrsDMJ/n9sA=", new byte[] { 169, 14, 240, 243, 197, 2, 224, 41, 97, 33, 220, 174, 255, 67, 99, 193 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "MMni4J9zvCBm09F93PfFxB+A6djU650hfrsDMJ/n9sA=", new byte[] { 169, 14, 240, 243, 197, 2, 224, 41, 97, 33, 220, 174, 255, 67, 99, 193 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "MMni4J9zvCBm09F93PfFxB+A6djU650hfrsDMJ/n9sA=", new byte[] { 169, 14, 240, 243, 197, 2, 224, 41, 97, 33, 220, 174, 255, 67, 99, 193 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "MMni4J9zvCBm09F93PfFxB+A6djU650hfrsDMJ/n9sA=", new byte[] { 169, 14, 240, 243, 197, 2, 224, 41, 97, 33, 220, 174, 255, 67, 99, 193 } });
        }
    }
}
