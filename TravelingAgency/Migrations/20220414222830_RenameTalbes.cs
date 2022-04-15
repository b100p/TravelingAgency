using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelingAgency.Migrations
{
    public partial class RenameTalbes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs");

            migrationBuilder.RenameTable(
                name: "Blogs",
                newName: "Passengers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Passengers",
                table: "Passengers",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    Fcode = table.Column<string>(type: "TEXT", nullable: false),
                    Fsrc = table.Column<string>(type: "TEXT", nullable: false),
                    Fdst = table.Column<string>(type: "TEXT", nullable: false),
                    Fdate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Fcap = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.Fcode);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Passengers",
                table: "Passengers");

            migrationBuilder.RenameTable(
                name: "Passengers",
                newName: "Blogs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs",
                column: "Id");
        }
    }
}
