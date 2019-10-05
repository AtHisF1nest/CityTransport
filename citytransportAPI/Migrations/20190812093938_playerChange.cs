using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace citytransportAPI.Migrations
{
    public partial class playerChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Players",
                newName: "PasswordSalt");

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordHash",
                table: "Players",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Players");

            migrationBuilder.RenameColumn(
                name: "PasswordSalt",
                table: "Players",
                newName: "Password");
        }
    }
}
