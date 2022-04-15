using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelingAgency.Migrations
{
    public partial class fixNaming : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Flights_flightFcode",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Passengers_passengerId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "Fcap",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "passengerId",
                table: "Tickets",
                newName: "PassengerId");

            migrationBuilder.RenameColumn(
                name: "flightFcode",
                table: "Tickets",
                newName: "FlightFcode");

            migrationBuilder.RenameColumn(
                name: "Fdate",
                table: "Tickets",
                newName: "Amount");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_passengerId",
                table: "Tickets",
                newName: "IX_Tickets_PassengerId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_flightFcode",
                table: "Tickets",
                newName: "IX_Tickets_FlightFcode");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Flights_FlightFcode",
                table: "Tickets",
                column: "FlightFcode",
                principalTable: "Flights",
                principalColumn: "Fcode");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Passengers_PassengerId",
                table: "Tickets",
                column: "PassengerId",
                principalTable: "Passengers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Flights_FlightFcode",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Passengers_PassengerId",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "PassengerId",
                table: "Tickets",
                newName: "passengerId");

            migrationBuilder.RenameColumn(
                name: "FlightFcode",
                table: "Tickets",
                newName: "flightFcode");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Tickets",
                newName: "Fdate");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_PassengerId",
                table: "Tickets",
                newName: "IX_Tickets_passengerId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_FlightFcode",
                table: "Tickets",
                newName: "IX_Tickets_flightFcode");

            migrationBuilder.AddColumn<string>(
                name: "Fcap",
                table: "Tickets",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Flights_flightFcode",
                table: "Tickets",
                column: "flightFcode",
                principalTable: "Flights",
                principalColumn: "Fcode");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Passengers_passengerId",
                table: "Tickets",
                column: "passengerId",
                principalTable: "Passengers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
