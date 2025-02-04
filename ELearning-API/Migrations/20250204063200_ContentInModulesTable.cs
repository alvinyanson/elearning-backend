using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELearning_API.Migrations
{
    /// <inheritdoc />
    public partial class ContentInModulesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("06d93e6c-4d65-429d-8a40-e0e5cf5e9d5a"));

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HTMLContent", "IsPublished", "ModuleId", "Type", "UpdatedAt" },
                values: new object[] { new Guid("08f6938b-e1f1-493c-9ddf-78238b0de90c"), "81213A50-758E-4904-B715-640038EE9CD9", new DateTime(2025, 2, 4, 6, 31, 59, 909, DateTimeKind.Utc).AddTicks(9718), "<p>Introduction to the course</p>", true, new Guid("3f7654fe-0ad8-4289-9436-04ce9005f500"), "Text", new DateTime(2025, 2, 4, 6, 31, 59, 909, DateTimeKind.Utc).AddTicks(9720) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("08f6938b-e1f1-493c-9ddf-78238b0de90c"));

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HTMLContent", "IsPublished", "ModuleId", "Type", "UpdatedAt" },
                values: new object[] { new Guid("06d93e6c-4d65-429d-8a40-e0e5cf5e9d5a"), "81213A50-758E-4904-B715-640038EE9CD9", new DateTime(2025, 2, 3, 8, 10, 34, 635, DateTimeKind.Utc).AddTicks(364), "<p>Introduction to the course</p>", true, new Guid("3f7654fe-0ad8-4289-9436-04ce9005f500"), "Text", new DateTime(2025, 2, 3, 8, 10, 34, 635, DateTimeKind.Utc).AddTicks(367) });
        }
    }
}
