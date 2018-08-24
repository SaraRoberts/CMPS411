using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KSS.Data.Migrations
{
    public partial class locationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Instance");

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Instance",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Street = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zipcode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Instance_LocationId",
                table: "Instance",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Instance_Location_LocationId",
                table: "Instance",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instance_Location_LocationId",
                table: "Instance");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Instance_LocationId",
                table: "Instance");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Instance");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Instance",
                nullable: true);
        }
    }
}
