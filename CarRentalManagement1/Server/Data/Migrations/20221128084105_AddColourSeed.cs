using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement1.Server.Data.Migrations
{
    public partial class AddColourSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[] { 1, "System", new DateTime(2022, 11, 28, 16, 41, 4, 734, DateTimeKind.Local).AddTicks(1893), new DateTime(2022, 11, 28, 16, 41, 4, 734, DateTimeKind.Local).AddTicks(9064), "Black", "System" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[] { 2, "System", new DateTime(2022, 11, 28, 16, 41, 4, 734, DateTimeKind.Local).AddTicks(9838), new DateTime(2022, 11, 28, 16, 41, 4, 734, DateTimeKind.Local).AddTicks(9842), "Blue", "System" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
