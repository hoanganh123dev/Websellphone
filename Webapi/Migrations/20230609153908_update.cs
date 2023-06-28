using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Webapi.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "b9545caf-95f6-4729-8c39-e20ef224a1dd");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1e029810-30fb-40ec-a174-f54646e9512a", "AQAAAAEAACcQAAAAEJYwB4QPLF1xNq8oxWnyfjPFrTTfIp4uP0nowBWfvektSFAEWP9V0yHkMBngbpa7jA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 6, 9, 22, 39, 8, 125, DateTimeKind.Local).AddTicks(8584));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "7a1bc099-c4d8-4d98-b901-88bb2aa2343c");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3fd35e4c-f19c-4ae7-a627-7bd8b57e4ae8", "AQAAAAEAACcQAAAAECNspFvJIhSb6umbdDxGdKIrX1uXMXTZbg8eLc4xahCwhKB5EIzoHdnCfmdfsh4Ueg==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 6, 1, 11, 38, 8, 278, DateTimeKind.Local).AddTicks(1067));
        }
    }
}
