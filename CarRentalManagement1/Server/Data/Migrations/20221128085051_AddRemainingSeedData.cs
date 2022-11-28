using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement1.Server.Data.Migrations
{
    public partial class AddRemainingSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 28, 16, 50, 51, 292, DateTimeKind.Local).AddTicks(9850), new DateTime(2022, 11, 28, 16, 50, 51, 293, DateTimeKind.Local).AddTicks(7662) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 28, 16, 50, 51, 293, DateTimeKind.Local).AddTicks(8388), new DateTime(2022, 11, 28, 16, 50, 51, 293, DateTimeKind.Local).AddTicks(8391) });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 28, 16, 50, 51, 294, DateTimeKind.Local).AddTicks(7290), new DateTime(2022, 11, 28, 16, 50, 51, 294, DateTimeKind.Local).AddTicks(7296), "BMW", "System" },
                    { 2, "System", new DateTime(2022, 11, 28, 16, 50, 51, 294, DateTimeKind.Local).AddTicks(7299), new DateTime(2022, 11, 28, 16, 50, 51, 294, DateTimeKind.Local).AddTicks(7300), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 28, 16, 50, 51, 295, DateTimeKind.Local).AddTicks(65), new DateTime(2022, 11, 28, 16, 50, 51, 295, DateTimeKind.Local).AddTicks(70), "3 Series", "System" },
                    { 2, "System", new DateTime(2022, 11, 28, 16, 50, 51, 295, DateTimeKind.Local).AddTicks(108), new DateTime(2022, 11, 28, 16, 50, 51, 295, DateTimeKind.Local).AddTicks(109), "X5", "System" },
                    { 3, "System", new DateTime(2022, 11, 28, 16, 50, 51, 295, DateTimeKind.Local).AddTicks(110), new DateTime(2022, 11, 28, 16, 50, 51, 295, DateTimeKind.Local).AddTicks(111), "Prius", "System" },
                    { 4, "System", new DateTime(2022, 11, 28, 16, 50, 51, 295, DateTimeKind.Local).AddTicks(112), new DateTime(2022, 11, 28, 16, 50, 51, 295, DateTimeKind.Local).AddTicks(113), "Rav4", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 28, 16, 41, 4, 734, DateTimeKind.Local).AddTicks(1893), new DateTime(2022, 11, 28, 16, 41, 4, 734, DateTimeKind.Local).AddTicks(9064) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 28, 16, 41, 4, 734, DateTimeKind.Local).AddTicks(9838), new DateTime(2022, 11, 28, 16, 41, 4, 734, DateTimeKind.Local).AddTicks(9842) });
        }
    }
}
