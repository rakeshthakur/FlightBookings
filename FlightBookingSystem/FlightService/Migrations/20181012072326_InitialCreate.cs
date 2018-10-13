using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FlightService.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FlightDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FlightName = table.Column<string>(nullable: true),
                    FlightNumber = table.Column<string>(nullable: true),
                    FirstClassSeat = table.Column<int>(nullable: false),
                    BusinessClassSeat = table.Column<int>(nullable: false),
                    EconomySeat = table.Column<int>(nullable: false),
                    FirstClassFare = table.Column<int>(nullable: false),
                    BusinessClassFare = table.Column<int>(nullable: false),
                    EconomyFare = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FlightSchedules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Source = table.Column<string>(nullable: true),
                    Destination = table.Column<string>(nullable: true),
                    DepartureDateTime = table.Column<DateTime>(nullable: false),
                    ArivalDateTime = table.Column<DateTime>(nullable: false),
                    FlightId = table.Column<int>(nullable: false),
                    FlightDetailsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightSchedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FlightSchedules_FlightDetails_FlightDetailsId",
                        column: x => x.FlightDetailsId,
                        principalTable: "FlightDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlightSchedules_FlightDetailsId",
                table: "FlightSchedules",
                column: "FlightDetailsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlightSchedules");

            migrationBuilder.DropTable(
                name: "FlightDetails");
        }
    }
}
