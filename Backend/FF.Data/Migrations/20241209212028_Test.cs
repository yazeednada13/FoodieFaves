﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FF.Data.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Close",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LiveSite",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Open",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Close", "LiveSite", "Open" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Close", "LiveSite", "Open" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Close", "LiveSite", "Open" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Close", "LiveSite", "Open" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 0, 20, 26, 829, DateTimeKind.Local).AddTicks(2587));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 0, 20, 26, 829, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 0, 20, 26, 829, DateTimeKind.Local).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 0, 20, 26, 829, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 0, 20, 26, 829, DateTimeKind.Local).AddTicks(2638));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Close",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "LiveSite",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "Open",
                table: "Restaurants");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 9, 23, 22, 15, 750, DateTimeKind.Local).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 9, 23, 22, 15, 750, DateTimeKind.Local).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 9, 23, 22, 15, 750, DateTimeKind.Local).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 9, 23, 22, 15, 750, DateTimeKind.Local).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 9, 23, 22, 15, 750, DateTimeKind.Local).AddTicks(3585));
        }
    }
}