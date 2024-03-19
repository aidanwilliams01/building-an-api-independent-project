using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParksLookup.Migrations
{
    public partial class Updateseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1,
                columns: new[] { "Location", "Name", "Type" },
                values: new object[] { "Maine", "Acadia", "National" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Location", "Name", "Type" },
                values: new object[] { 2, "Tennessee", "Great Smoky Mountains", "National" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Location", "Name", "Type" },
                values: new object[] { 3, "Washington", "Beacon Rock", "State" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1,
                columns: new[] { "Location", "Name", "Type" },
                values: new object[] { null, null, null });
        }
    }
}
