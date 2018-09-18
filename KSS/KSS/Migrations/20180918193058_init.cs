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
                    InstructorId = table.Column<int>(nullable: false),
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
                    { 1, "admin@admin.com", "Becky", "Smith", "nbCzv5aYMu08N7oIYJIoj7pLFyG3hdlZ838eQdt5y9s=", "1112223333", "Admin", new byte[] { 137, 20, 241, 106, 216, 35, 38, 146, 84, 167, 240, 121, 121, 19, 5, 12 }, null },
                    { 15, "student14@student.com", "Amanda", "Catalonato", "DKgwuomqUjKkKSsWtB3RuaOFc836RSLQoLUNCsIKR0s=", "1112223333", "User", new byte[] { 184, 23, 64, 221, 55, 162, 65, 47, 246, 122, 96, 223, 236, 239, 126, 112 }, null },
                    { 14, "student13@student.com", "Tom", "Avers", "DKgwuomqUjKkKSsWtB3RuaOFc836RSLQoLUNCsIKR0s=", "1112223333", "User", new byte[] { 184, 23, 64, 221, 55, 162, 65, 47, 246, 122, 96, 223, 236, 239, 126, 112 }, null },
                    { 13, "student12@student.com", "Lucy", "Vilardo", "DKgwuomqUjKkKSsWtB3RuaOFc836RSLQoLUNCsIKR0s=", "1112223333", "User", new byte[] { 184, 23, 64, 221, 55, 162, 65, 47, 246, 122, 96, 223, 236, 239, 126, 112 }, null },
                    { 12, "student11@student.com", "Gary", "Aimes", "DKgwuomqUjKkKSsWtB3RuaOFc836RSLQoLUNCsIKR0s=", "1112223333", "User", new byte[] { 184, 23, 64, 221, 55, 162, 65, 47, 246, 122, 96, 223, 236, 239, 126, 112 }, null },
                    { 11, "student10@student.com", "Tim", "Hammond", "DKgwuomqUjKkKSsWtB3RuaOFc836RSLQoLUNCsIKR0s=", "1112223333", "User", new byte[] { 184, 23, 64, 221, 55, 162, 65, 47, 246, 122, 96, 223, 236, 239, 126, 112 }, null },
                    { 10, "student9@student.com", "Babe", "Ruth", "DKgwuomqUjKkKSsWtB3RuaOFc836RSLQoLUNCsIKR0s=", "1112223333", "User", new byte[] { 184, 23, 64, 221, 55, 162, 65, 47, 246, 122, 96, 223, 236, 239, 126, 112 }, null },
                    { 16, "student15@student.com", "Donald", "Hill", "DKgwuomqUjKkKSsWtB3RuaOFc836RSLQoLUNCsIKR0s=", "1112223333", "User", new byte[] { 184, 23, 64, 221, 55, 162, 65, 47, 246, 122, 96, 223, 236, 239, 126, 112 }, null },
                    { 9, "student8@student.com", "Colin", "Livers", "DKgwuomqUjKkKSsWtB3RuaOFc836RSLQoLUNCsIKR0s=", "1112223333", "User", new byte[] { 184, 23, 64, 221, 55, 162, 65, 47, 246, 122, 96, 223, 236, 239, 126, 112 }, null },
                    { 7, "student6@student.com", "Bill", "Everet", "DKgwuomqUjKkKSsWtB3RuaOFc836RSLQoLUNCsIKR0s=", "1112223333", "User", new byte[] { 184, 23, 64, 221, 55, 162, 65, 47, 246, 122, 96, 223, 236, 239, 126, 112 }, null },
                    { 6, "student5@student.com", "Amy", "Hillbond", "DKgwuomqUjKkKSsWtB3RuaOFc836RSLQoLUNCsIKR0s=", "1112223333", "User", new byte[] { 184, 23, 64, 221, 55, 162, 65, 47, 246, 122, 96, 223, 236, 239, 126, 112 }, null },
                    { 5, "student4@student.com", "Sharon", "Manino", "DKgwuomqUjKkKSsWtB3RuaOFc836RSLQoLUNCsIKR0s=", "1112223333", "User", new byte[] { 184, 23, 64, 221, 55, 162, 65, 47, 246, 122, 96, 223, 236, 239, 126, 112 }, null },
                    { 4, "student3@student.com", "Russel", "Chavers", "DKgwuomqUjKkKSsWtB3RuaOFc836RSLQoLUNCsIKR0s=", "1112223333", "User", new byte[] { 184, 23, 64, 221, 55, 162, 65, 47, 246, 122, 96, 223, 236, 239, 126, 112 }, null },
                    { 3, "student2@student.com", "Mike", "Waters", "DKgwuomqUjKkKSsWtB3RuaOFc836RSLQoLUNCsIKR0s=", "1112223333", "User", new byte[] { 184, 23, 64, 221, 55, 162, 65, 47, 246, 122, 96, 223, 236, 239, 126, 112 }, null },
                    { 2, "student1@student.com", "Paul", "Dig", "DKgwuomqUjKkKSsWtB3RuaOFc836RSLQoLUNCsIKR0s=", "1112223333", "User", new byte[] { 184, 23, 64, 221, 55, 162, 65, 47, 246, 122, 96, 223, 236, 239, 126, 112 }, null },
                    { 8, "student7@student.com", "Trenton", "Hillsong", "DKgwuomqUjKkKSsWtB3RuaOFc836RSLQoLUNCsIKR0s=", "1112223333", "User", new byte[] { 184, 23, 64, 221, 55, 162, 65, 47, 246, 122, 96, 223, 236, 239, 126, 112 }, null },
                    { 17, "student16@student.com", "Richard", "Newman", "DKgwuomqUjKkKSsWtB3RuaOFc836RSLQoLUNCsIKR0s=", "1112223333", "User", new byte[] { 184, 23, 64, 221, 55, 162, 65, 47, 246, 122, 96, 223, 236, 239, 126, 112 }, null }
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
                name: "IX_Instance_InstructorId",
                table: "Instance",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Instance_LocationId",
                table: "Instance",
                column: "LocationId");

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
                name: "Users");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Staff");
        }
    }
}
