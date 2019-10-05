using Microsoft.EntityFrameworkCore.Migrations;

namespace citytransportAPI.Migrations
{
    public partial class cityLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GridX",
                table: "Cities",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GridY",
                table: "Cities",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GridX",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "GridY",
                table: "Cities");
        }
    }
}
