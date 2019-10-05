using Microsoft.EntityFrameworkCore.Migrations;

namespace citytransportAPI.Migrations
{
    public partial class ownerCity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "MapFields",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MapFields_CityId",
                table: "MapFields",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_MapFields_Cities_CityId",
                table: "MapFields",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MapFields_Cities_CityId",
                table: "MapFields");

            migrationBuilder.DropIndex(
                name: "IX_MapFields_CityId",
                table: "MapFields");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "MapFields");
        }
    }
}
