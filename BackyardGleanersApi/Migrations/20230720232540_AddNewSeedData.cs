using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackyardGleanersApi.Migrations
{
    public partial class AddNewSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Gardeners",
                keyColumn: "GardenerId",
                keyValue: 1,
                column: "Location",
                value: "N Washburne Ave & N Lombard St, Portland, OR 97217");

            migrationBuilder.UpdateData(
                table: "Gardeners",
                keyColumn: "GardenerId",
                keyValue: 4,
                column: "Location",
                value: "SE 9th Ave & SE Division St, Portland, OR 97214");

            migrationBuilder.UpdateData(
                table: "Gardeners",
                keyColumn: "GardenerId",
                keyValue: 5,
                column: "Location",
                value: "NE 33rd Ave & NE Killingsworth St, Portland, OR 97211");

            migrationBuilder.UpdateData(
                table: "Gardeners",
                keyColumn: "GardenerId",
                keyValue: 6,
                column: "Location",
                value: "SW Condor Ave & SW Barbur Blvd, Portland, OR 97239");

            migrationBuilder.UpdateData(
                table: "Gardeners",
                keyColumn: "GardenerId",
                keyValue: 7,
                column: "Location",
                value: "NE 24th Ave & NE Broadway, Portland, OR 97232");

            migrationBuilder.UpdateData(
                table: "Gardeners",
                keyColumn: "GardenerId",
                keyValue: 8,
                column: "Location",
                value: "NW Skyline Boulevard & NW Cornell Road, Forest Park, Portland, OR 97229");

            migrationBuilder.UpdateData(
                table: "Gardeners",
                keyColumn: "GardenerId",
                keyValue: 9,
                column: "Location",
                value: "N Mason Street & N Castle Avenue, Portland, OR 97227, Overlook");

            migrationBuilder.UpdateData(
                table: "Gardeners",
                keyColumn: "GardenerId",
                keyValue: 10,
                column: "Location",
                value: "N Morgan Street & N Moore Avenue, Portland, OR 97217");

            migrationBuilder.UpdateData(
                table: "Gardeners",
                keyColumn: "GardenerId",
                keyValue: 11,
                column: "Location",
                value: "SE Duke St & SE 66th Ave, Portland, OR 97206");

            migrationBuilder.UpdateData(
                table: "Gardeners",
                keyColumn: "GardenerId",
                keyValue: 12,
                column: "Location",
                value: "NE Wygant Street & NE 10th Avenue, Portland, OR 97211");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Gardeners",
                keyColumn: "GardenerId",
                keyValue: 1,
                column: "Location",
                value: "N Washburne Ave & N Lombard St., Portland, OR 97217");

            migrationBuilder.UpdateData(
                table: "Gardeners",
                keyColumn: "GardenerId",
                keyValue: 4,
                column: "Location",
                value: "SE 9th Ave & SE Division StPortland, OR 97214");

            migrationBuilder.UpdateData(
                table: "Gardeners",
                keyColumn: "GardenerId",
                keyValue: 5,
                column: "Location",
                value: "NE 33rd Ave & NE Killingsworth StPortland, OR 97211");

            migrationBuilder.UpdateData(
                table: "Gardeners",
                keyColumn: "GardenerId",
                keyValue: 6,
                column: "Location",
                value: "SW Condor Ave & SW Barbur BlvdPortland, OR 97239");

            migrationBuilder.UpdateData(
                table: "Gardeners",
                keyColumn: "GardenerId",
                keyValue: 7,
                column: "Location",
                value: "NE 24th Ave & Northeast Broadway, Portland, OR 97232");

            migrationBuilder.UpdateData(
                table: "Gardeners",
                keyColumn: "GardenerId",
                keyValue: 8,
                column: "Location",
                value: "Northwest Skyline Boulevard & Northwest Cornell Road, Forest Park, Portland, OR 97229");

            migrationBuilder.UpdateData(
                table: "Gardeners",
                keyColumn: "GardenerId",
                keyValue: 9,
                column: "Location",
                value: "North Mason Street & North Castle Avenue, Portland, OR 97227");

            migrationBuilder.UpdateData(
                table: "Gardeners",
                keyColumn: "GardenerId",
                keyValue: 10,
                column: "Location",
                value: "North Morgan Street & North Moore Avenue, Portland, OR 97217");

            migrationBuilder.UpdateData(
                table: "Gardeners",
                keyColumn: "GardenerId",
                keyValue: 11,
                column: "Location",
                value: "SE Duke St & SE 66th AvePortland, OR 97206");

            migrationBuilder.UpdateData(
                table: "Gardeners",
                keyColumn: "GardenerId",
                keyValue: 12,
                column: "Location",
                value: "Northeast Wygant Street & Northeast 10th Avenue, Portland, OR 97211");
        }
    }
}
