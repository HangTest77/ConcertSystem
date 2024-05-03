using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConcertSystem.Data.Migrations
{
    public partial class time : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "artist",
                table: "Admin",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "dateTime",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "language",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Admin",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "time",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "trending",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "venue",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "artist",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "dateTime",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "language",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "name",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "time",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "trending",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "venue",
                table: "Admin");
        }
    }
}
