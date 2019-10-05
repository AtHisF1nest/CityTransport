using Microsoft.EntityFrameworkCore.Migrations;

namespace citytransportAPI.Migrations
{
    public partial class photsource : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SourcePath",
                table: "Photos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SourcePath",
                table: "Photos");
        }
    }
}
