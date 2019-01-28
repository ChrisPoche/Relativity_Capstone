using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RelativityCapstone.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Airports",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    iata_code = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    lat = table.Column<double>(nullable: false),
                    lon = table.Column<double>(nullable: false),
                    secheduledService = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airports", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CurrentWeather",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    airportId = table.Column<int>(nullable: false),
                    type = table.Column<string>(nullable: true),
                    desc = table.Column<string>(nullable: true),
                    icon = table.Column<byte[]>(nullable: true),
                    temp = table.Column<int>(nullable: false),
                    humidity = table.Column<int>(nullable: false),
                    windSpeed = table.Column<int>(nullable: false),
                    windDeg = table.Column<int>(nullable: false),
                    time = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentWeather", x => x.id);
                    table.ForeignKey(
                        name: "FK_CurrentWeather_Airports_airportId",
                        column: x => x.airportId,
                        principalTable: "Airports",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Runways",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    airportId = table.Column<int>(nullable: false),
                    headingDeg = table.Column<int>(nullable: false),
                    beg_lat = table.Column<int>(nullable: false),
                    beg_lon = table.Column<int>(nullable: false),
                    end_lat = table.Column<int>(nullable: false),
                    end_lon = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Runways", x => x.id);
                    table.ForeignKey(
                        name: "FK_Runways_Airports_airportId",
                        column: x => x.airportId,
                        principalTable: "Airports",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeatherForcasts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    airportId = table.Column<int>(nullable: false),
                    type = table.Column<string>(nullable: true),
                    desc = table.Column<string>(nullable: true),
                    icon = table.Column<byte[]>(nullable: true),
                    min_temp = table.Column<int>(nullable: false),
                    max_temp = table.Column<int>(nullable: false),
                    humidity = table.Column<int>(nullable: false),
                    windSpeed = table.Column<int>(nullable: false),
                    windDeg = table.Column<int>(nullable: false),
                    time = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherForcasts", x => x.id);
                    table.ForeignKey(
                        name: "FK_WeatherForcasts_Airports_airportId",
                        column: x => x.airportId,
                        principalTable: "Airports",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CurrentWeather_airportId",
                table: "CurrentWeather",
                column: "airportId");

            migrationBuilder.CreateIndex(
                name: "IX_Runways_airportId",
                table: "Runways",
                column: "airportId");

            migrationBuilder.CreateIndex(
                name: "IX_WeatherForcasts_airportId",
                table: "WeatherForcasts",
                column: "airportId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CurrentWeather");

            migrationBuilder.DropTable(
                name: "Runways");

            migrationBuilder.DropTable(
                name: "WeatherForcasts");

            migrationBuilder.DropTable(
                name: "Airports");
        }
    }
}
