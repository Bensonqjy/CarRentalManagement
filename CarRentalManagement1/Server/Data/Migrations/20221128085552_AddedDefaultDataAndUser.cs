using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement1.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 28, 16, 55, 51, 815, DateTimeKind.Local).AddTicks(6099), new DateTime(2022, 11, 28, 16, 55, 51, 816, DateTimeKind.Local).AddTicks(3247) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 28, 16, 55, 51, 816, DateTimeKind.Local).AddTicks(3995), new DateTime(2022, 11, 28, 16, 55, 51, 816, DateTimeKind.Local).AddTicks(3999) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 28, 16, 55, 51, 817, DateTimeKind.Local).AddTicks(2871), new DateTime(2022, 11, 28, 16, 55, 51, 817, DateTimeKind.Local).AddTicks(2877) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 28, 16, 55, 51, 817, DateTimeKind.Local).AddTicks(2880), new DateTime(2022, 11, 28, 16, 55, 51, 817, DateTimeKind.Local).AddTicks(2881) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 28, 16, 55, 51, 817, DateTimeKind.Local).AddTicks(5736), new DateTime(2022, 11, 28, 16, 55, 51, 817, DateTimeKind.Local).AddTicks(5741) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 28, 16, 55, 51, 817, DateTimeKind.Local).AddTicks(5744), new DateTime(2022, 11, 28, 16, 55, 51, 817, DateTimeKind.Local).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 28, 16, 55, 51, 817, DateTimeKind.Local).AddTicks(5746), new DateTime(2022, 11, 28, 16, 55, 51, 817, DateTimeKind.Local).AddTicks(5747) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 28, 16, 55, 51, 817, DateTimeKind.Local).AddTicks(5748), new DateTime(2022, 11, 28, 16, 55, 51, 817, DateTimeKind.Local).AddTicks(5749) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 28, 16, 50, 51, 294, DateTimeKind.Local).AddTicks(7290), new DateTime(2022, 11, 28, 16, 50, 51, 294, DateTimeKind.Local).AddTicks(7296) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 28, 16, 50, 51, 294, DateTimeKind.Local).AddTicks(7299), new DateTime(2022, 11, 28, 16, 50, 51, 294, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 28, 16, 50, 51, 295, DateTimeKind.Local).AddTicks(65), new DateTime(2022, 11, 28, 16, 50, 51, 295, DateTimeKind.Local).AddTicks(70) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 28, 16, 50, 51, 295, DateTimeKind.Local).AddTicks(108), new DateTime(2022, 11, 28, 16, 50, 51, 295, DateTimeKind.Local).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 28, 16, 50, 51, 295, DateTimeKind.Local).AddTicks(110), new DateTime(2022, 11, 28, 16, 50, 51, 295, DateTimeKind.Local).AddTicks(111) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 28, 16, 50, 51, 295, DateTimeKind.Local).AddTicks(112), new DateTime(2022, 11, 28, 16, 50, 51, 295, DateTimeKind.Local).AddTicks(113) });
        }
    }
}
