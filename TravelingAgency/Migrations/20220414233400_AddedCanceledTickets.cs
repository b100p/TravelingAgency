using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelingAgency.Migrations
{
    public partial class AddedCanceledTickets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CanceledTickets",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    TicketId = table.Column<string>(type: "TEXT", nullable: false),
                    Fcode = table.Column<string>(type: "TEXT", nullable: false),
                    CancelDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CanceledTickets", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CanceledTickets");
        }
    }
}
