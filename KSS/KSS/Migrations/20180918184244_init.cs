using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KSS.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
                name: "Staff",
                columns: table => new
                {
                    StaffId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Picture = table.Column<string>(nullable: true),
                    Bio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffId);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    CourseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TypicalPrice = table.Column<int>(nullable: false),
                    BookAvailable = table.Column<bool>(nullable: false),
                    BookPrice = table.Column<decimal>(nullable: false),
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
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Salt = table.Column<byte[]>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    StaffId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "StaffId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Instance",
                columns: table => new
                {
                    InstanceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StartDate = table.Column<DateTimeOffset>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    CourseId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false),
                    Seats = table.Column<int>(nullable: false),
                    Instructor = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: true),
                    BookAvailable = table.Column<bool>(nullable: false),
                    BookPrice = table.Column<double>(nullable: false)
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
                        name: "FK_Instance_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Instance_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Enrollment",
                columns: table => new
                {
                    EnrollmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InstanceId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: false),
                    BookBought = table.Column<bool>(nullable: false),
                    Paid = table.Column<bool>(nullable: false),
                    Confirmed = table.Column<bool>(nullable: false)
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
                table: "Users",
                columns: new[] { "UserId", "Email", "FirstName", "LastName", "Password", "Phone", "Role", "Salt", "StaffId" },
                values: new object[,]
                {
                    { 1, "admin@admin.com", "Becky", "Smith", "jb8VD9HiOSmPD6KFPoqaeLfI9LjvWpa3BhnXRtEJp34=", "1112223333", "Admin", new byte[] { 11, 8, 185, 20, 27, 148, 106, 118, 87, 88, 54, 85, 221, 246, 185, 135 }, null },
                    { 15, "student14@student.com", "Amanda", "Catalonato", "9KZ3aH6F16AHb+g8+u3c3zlp25IawPqoesFXMupk4X8=", "1112223333", "User", new byte[] { 242, 96, 106, 3, 227, 145, 43, 18, 19, 128, 220, 118, 103, 71, 212, 190 }, null },
                    { 14, "student13@student.com", "Tom", "Avers", "9KZ3aH6F16AHb+g8+u3c3zlp25IawPqoesFXMupk4X8=", "1112223333", "User", new byte[] { 242, 96, 106, 3, 227, 145, 43, 18, 19, 128, 220, 118, 103, 71, 212, 190 }, null },
                    { 13, "student12@student.com", "Lucy", "Vilardo", "9KZ3aH6F16AHb+g8+u3c3zlp25IawPqoesFXMupk4X8=", "1112223333", "User", new byte[] { 242, 96, 106, 3, 227, 145, 43, 18, 19, 128, 220, 118, 103, 71, 212, 190 }, null },
                    { 12, "student11@student.com", "Gary", "Aimes", "9KZ3aH6F16AHb+g8+u3c3zlp25IawPqoesFXMupk4X8=", "1112223333", "User", new byte[] { 242, 96, 106, 3, 227, 145, 43, 18, 19, 128, 220, 118, 103, 71, 212, 190 }, null },
                    { 11, "student10@student.com", "Tim", "Hammond", "9KZ3aH6F16AHb+g8+u3c3zlp25IawPqoesFXMupk4X8=", "1112223333", "User", new byte[] { 242, 96, 106, 3, 227, 145, 43, 18, 19, 128, 220, 118, 103, 71, 212, 190 }, null },
                    { 10, "student9@student.com", "Babe", "Ruth", "9KZ3aH6F16AHb+g8+u3c3zlp25IawPqoesFXMupk4X8=", "1112223333", "User", new byte[] { 242, 96, 106, 3, 227, 145, 43, 18, 19, 128, 220, 118, 103, 71, 212, 190 }, null },
                    { 16, "student15@student.com", "Donald", "Hill", "9KZ3aH6F16AHb+g8+u3c3zlp25IawPqoesFXMupk4X8=", "1112223333", "User", new byte[] { 242, 96, 106, 3, 227, 145, 43, 18, 19, 128, 220, 118, 103, 71, 212, 190 }, null },
                    { 9, "student8@student.com", "Colin", "Livers", "9KZ3aH6F16AHb+g8+u3c3zlp25IawPqoesFXMupk4X8=", "1112223333", "User", new byte[] { 242, 96, 106, 3, 227, 145, 43, 18, 19, 128, 220, 118, 103, 71, 212, 190 }, null },
                    { 7, "student6@student.com", "Bill", "Everet", "9KZ3aH6F16AHb+g8+u3c3zlp25IawPqoesFXMupk4X8=", "1112223333", "User", new byte[] { 242, 96, 106, 3, 227, 145, 43, 18, 19, 128, 220, 118, 103, 71, 212, 190 }, null },
                    { 6, "student5@student.com", "Amy", "Hillbond", "9KZ3aH6F16AHb+g8+u3c3zlp25IawPqoesFXMupk4X8=", "1112223333", "User", new byte[] { 242, 96, 106, 3, 227, 145, 43, 18, 19, 128, 220, 118, 103, 71, 212, 190 }, null },
                    { 5, "student4@student.com", "Sharon", "Manino", "9KZ3aH6F16AHb+g8+u3c3zlp25IawPqoesFXMupk4X8=", "1112223333", "User", new byte[] { 242, 96, 106, 3, 227, 145, 43, 18, 19, 128, 220, 118, 103, 71, 212, 190 }, null },
                    { 4, "student3@student.com", "Russel", "Chavers", "9KZ3aH6F16AHb+g8+u3c3zlp25IawPqoesFXMupk4X8=", "1112223333", "User", new byte[] { 242, 96, 106, 3, 227, 145, 43, 18, 19, 128, 220, 118, 103, 71, 212, 190 }, null },
                    { 3, "student2@student.com", "Mike", "Waters", "9KZ3aH6F16AHb+g8+u3c3zlp25IawPqoesFXMupk4X8=", "1112223333", "User", new byte[] { 242, 96, 106, 3, 227, 145, 43, 18, 19, 128, 220, 118, 103, 71, 212, 190 }, null },
                    { 2, "student1@student.com", "Paul", "Dig", "9KZ3aH6F16AHb+g8+u3c3zlp25IawPqoesFXMupk4X8=", "1112223333", "User", new byte[] { 242, 96, 106, 3, 227, 145, 43, 18, 19, 128, 220, 118, 103, 71, 212, 190 }, null },
                    { 8, "student7@student.com", "Trenton", "Hillsong", "9KZ3aH6F16AHb+g8+u3c3zlp25IawPqoesFXMupk4X8=", "1112223333", "User", new byte[] { 242, 96, 106, 3, 227, 145, 43, 18, 19, 128, 220, 118, 103, 71, 212, 190 }, null },
                    { 17, "student16@student.com", "Richard", "Newman", "9KZ3aH6F16AHb+g8+u3c3zlp25IawPqoesFXMupk4X8=", "1112223333", "User", new byte[] { 242, 96, 106, 3, 227, 145, 43, 18, 19, 128, 220, 118, 103, 71, 212, 190 }, null }
                });

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
                name: "IX_Instance_LocationId",
                table: "Instance",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Instance_UserId",
                table: "Instance",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_StaffId",
                table: "Users",
                column: "StaffId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enrollment");

            migrationBuilder.DropTable(
                name: "Instance");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Staff");
        }
    }
}
