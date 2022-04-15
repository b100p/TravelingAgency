using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelingAgency.Migrations
{
    public partial class fixNamingAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Flights_FlightFcode",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Passengers_PassengerId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_FlightFcode",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_PassengerId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "FlightFcode",
                table: "Tickets");

            migrationBuilder.AlterColumn<string>(
                name: "PassengerId",
                table: "Tickets",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<string>(
                name: "Fcode",
                table: "Tickets",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fcode",
                table: "Tickets");

            migrationBuilder.AlterColumn<int>(
                name: "PassengerId",
                table: "Tickets",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "FlightFcode",
                table: "Tickets",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_FlightFcode",
                table: "Tickets",
                column: "FlightFcode");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_PassengerId",
                table: "Tickets",
                column: "PassengerId");

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
    }
}
