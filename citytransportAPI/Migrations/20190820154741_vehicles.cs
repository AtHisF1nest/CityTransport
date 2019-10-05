using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace citytransportAPI.Migrations
{
    public partial class vehicles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Players_OwnerId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_OwnerId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Vehicles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Vehicles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Vehicles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_OwnerId",
                table: "Vehicles",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Players_OwnerId",
                table: "Vehicles",
                column: "OwnerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
