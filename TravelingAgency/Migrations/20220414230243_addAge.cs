using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelingAgency.Migrations
{
    public partial class addAge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Age",
                table: "Passengers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    flightFcode = table.Column<string>(type: "TEXT", nullable: true),
                    passengerId = table.Column<int>(type: "INTEGER", nullable: false),
                    Fdate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Fcap = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Flights_flightFcode",
                        column: x => x.flightFcode,
                        principalTable: "Flights",
                        principalColumn: "Fcode");
                    table.ForeignKey(
                        name: "FK_Tickets_Passengers_passengerId",
                        column: x => x.passengerId,
                        principalTable: "Passengers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_flightFcode",
                table: "Tickets",
                column: "flightFcode");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_passengerId",
                table: "Tickets",
                column: "passengerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Passengers");
        }
    }
}
