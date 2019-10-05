using Microsoft.EntityFrameworkCore.Migrations;

namespace citytransportAPI.Migrations
{
    public partial class poprawka2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MapFields_Photos_PhotoId",
                table: "MapFields");

            migrationBuilder.AlterColumn<int>(
                name: "PhotoId",
                table: "MapFields",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_MapFields_Photos_PhotoId",
                table: "MapFields",
                column: "PhotoId",
                principalTable: "Photos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MapFields_Photos_PhotoId",
                table: "MapFields");

            migrationBuilder.AlterColumn<int>(
                name: "PhotoId",
                table: "MapFields",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MapFields_Photos_PhotoId",
                table: "MapFields",
                column: "PhotoId",
                principalTable: "Photos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
