using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ELearning_API.Migrations
{
    /// <inheritdoc />
    public partial class ModulesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "AuthorId", "CourseId", "CreatedAt", "Duration", "IsPublished", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("5d16034a-8cfa-4297-909f-a1684b5bcd94"), "81213A50-758E-4904-B715-640038EE9CD9", new Guid("01403752-9f62-4639-a411-109f4a098324"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 30, 0, 0), false, "Web Development Basics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8815cfcc-3b07-40be-a29f-d216f821ae2b"), "81213A50-758E-4904-B715-640038EE9CD9", new Guid("01403752-9f62-4639-a411-109f4a098324"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 30, 0, 0), false, "Advanced C# Techniques", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cf116480-7bab-4748-85eb-63244ac43ef0"), "81213A50-758E-4904-B715-640038EE9CD9", new Guid("01403752-9f62-4639-a411-109f4a098324"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 30, 0, 0), true, "Database Design Principles", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f5b979d5-11a3-4ad2-af7f-1d215efb5a0e"), "81213A50-758E-4904-B715-640038EE9CD9", new Guid("01403752-9f62-4639-a411-109f4a098324"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0), true, "Introduction to Programming", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fbccea49-acce-4c2e-b3f9-d013c64cff7d"), "81213A50-758E-4904-B715-640038EE9CD9", new Guid("01403752-9f62-4639-a411-109f4a098324"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 4, 0, 0, 0), true, "Machine Learning Essentials", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("5d16034a-8cfa-4297-909f-a1684b5bcd94"));

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("8815cfcc-3b07-40be-a29f-d216f821ae2b"));

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("cf116480-7bab-4748-85eb-63244ac43ef0"));

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("f5b979d5-11a3-4ad2-af7f-1d215efb5a0e"));

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("fbccea49-acce-4c2e-b3f9-d013c64cff7d"));
        }
    }
}
