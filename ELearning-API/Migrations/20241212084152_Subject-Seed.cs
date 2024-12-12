using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ELearning_API.Migrations
{
    /// <inheritdoc />
    public partial class SubjectSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "CreatedAt", "Name", "OwnerId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("b6e33a3a-8c3e-4ec1-b6bb-cb7c32cbdc99"), new DateTime(2024, 12, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "Introduction to Programming", new Guid("81213a50-758e-4904-b715-640038ee9cd9"), new DateTime(2024, 12, 1, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c7437f78-4ed9-45b3-9a2b-b4672b2e8b42"), new DateTime(2024, 12, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), "Object-Oriented Programming", new Guid("81213a50-758e-4904-b715-640038ee9cd9"), new DateTime(2024, 12, 2, 10, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("b6e33a3a-8c3e-4ec1-b6bb-cb7c32cbdc99"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("c7437f78-4ed9-45b3-9a2b-b4672b2e8b42"));
        }
    }
}
