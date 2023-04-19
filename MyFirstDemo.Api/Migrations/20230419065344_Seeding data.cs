using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyFirstDemo.Api.Migrations
{
    /// <inheritdoc />
    public partial class Seedingdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("17b5b9e7-cf76-49a3-9f62-eba81363082b"), "Medium" },
                    { new Guid("2ae1794c-360e-4365-bd1d-3509875e9c6e"), "Hard" },
                    { new Guid("3e1d541b-a205-429e-bb56-f50cecb2c9df"), "Easy" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("2ea3adbf-201a-4019-8726-44e873309375"), "STL", "SouthLand", "SouthLand.png" },
                    { new Guid("6457b92f-6269-48ed-88e6-8740ceccb5c2"), "BOP", "Bay of Plenty", null },
                    { new Guid("78f28f34-abd5-4686-8a7b-fba4ce2fc8e4"), "AKL", "Auckland", "Auckland.jpg" },
                    { new Guid("fea2520a-c78a-4b40-8b28-c6b1f11a2331"), "WGN", "Wellington", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("17b5b9e7-cf76-49a3-9f62-eba81363082b"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("2ae1794c-360e-4365-bd1d-3509875e9c6e"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("3e1d541b-a205-429e-bb56-f50cecb2c9df"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("2ea3adbf-201a-4019-8726-44e873309375"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("6457b92f-6269-48ed-88e6-8740ceccb5c2"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("78f28f34-abd5-4686-8a7b-fba4ce2fc8e4"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("fea2520a-c78a-4b40-8b28-c6b1f11a2331"));
        }
    }
}
