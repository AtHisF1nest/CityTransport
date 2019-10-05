using Microsoft.EntityFrameworkCore.Migrations;

namespace citytransportAPI.Migrations
{
    public partial class vehiclePhotos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Speed",
                table: "Vehicles",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "Cost",
                table: "Vehicles",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AddColumn<int>(
                name: "PhotoId",
                table: "Vehicles",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_PhotoId",
                table: "Vehicles",
                column: "PhotoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Photos_PhotoId",
                table: "Vehicles",
                column: "PhotoId",
                principalTable: "Photos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Photos_PhotoId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_PhotoId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "PhotoId",
                table: "Vehicles");

            migrationBuilder.AlterColumn<decimal>(
                name: "Speed",
                table: "Vehicles",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "Cost",
                table: "Vehicles",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
