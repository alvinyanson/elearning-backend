using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ELearning_API.Migrations
{
    /// <inheritdoc />
    public partial class SeedCoursesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "Icon", "IsPublised", "SubjectId", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("01403752-9f62-4639-a411-109f4a098324"), "548241c1-f11a-4323-abc4-9f83f83c8d9d", new DateTime(2024, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "angular", false, new Guid("3f7ecbfa-4c9f-42b7-89fc-dfe7baf7959e"), "Angular", new DateTime(2024, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("11403752-9f62-4639-a411-109f4a098324"), "548241c1-f11a-4323-abc4-9f83f83c8d9d", new DateTime(2024, 12, 13, 10, 0, 0, 0, DateTimeKind.Unspecified), "react", false, new Guid("3f7ecbfa-4c9f-42b7-89fc-dfe7baf7959e"), "React", new DateTime(2024, 12, 13, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("21403752-9f62-4639-a411-109f4a098324"), "548241c1-f11a-4323-abc4-9f83f83c8d9d", new DateTime(2024, 12, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), "vue", false, new Guid("3f7ecbfa-4c9f-42b7-89fc-dfe7baf7959e"), "Vue.js", new DateTime(2024, 12, 14, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("31403752-9f62-4639-a411-109f4a098324"), "548241c1-f11a-4323-abc4-9f83f83c8d9d", new DateTime(2024, 12, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), "nodejs", false, new Guid("3f7ecbfa-4c9f-42b7-89fc-dfe7baf7959e"), "Node.js", new DateTime(2024, 12, 15, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("41403752-9f62-4639-a411-109f4a098324"), "548241c1-f11a-4323-abc4-9f83f83c8d9d", new DateTime(2024, 12, 16, 10, 0, 0, 0, DateTimeKind.Unspecified), "python", false, new Guid("3f7ecbfa-4c9f-42b7-89fc-dfe7baf7959e"), "Python", new DateTime(2024, 12, 16, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("51403752-9f62-4639-a411-109f4a098324"), "548241c1-f11a-4323-abc4-9f83f83c8d9d", new DateTime(2024, 12, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), "csharp", false, new Guid("3f7ecbfa-4c9f-42b7-89fc-dfe7baf7959e"), "C#", new DateTime(2024, 12, 17, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("61403752-9f62-4639-a411-109f4a098324"), "548241c1-f11a-4323-abc4-9f83f83c8d9d", new DateTime(2024, 12, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), "java", false, new Guid("3f7ecbfa-4c9f-42b7-89fc-dfe7baf7959e"), "Java", new DateTime(2024, 12, 18, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("71403752-9f62-4639-a411-109f4a098324"), "548241c1-f11a-4323-abc4-9f83f83c8d9d", new DateTime(2024, 12, 19, 10, 0, 0, 0, DateTimeKind.Unspecified), "kotlin", false, new Guid("3f7ecbfa-4c9f-42b7-89fc-dfe7baf7959e"), "Kotlin", new DateTime(2024, 12, 19, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("81403752-9f62-4639-a411-109f4a098324"), "548241c1-f11a-4323-abc4-9f83f83c8d9d", new DateTime(2024, 12, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), "php", false, new Guid("3f7ecbfa-4c9f-42b7-89fc-dfe7baf7959e"), "PHP", new DateTime(2024, 12, 20, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("91403752-9f62-4639-a411-109f4a098324"), "548241c1-f11a-4323-abc4-9f83f83c8d9d", new DateTime(2024, 12, 21, 10, 0, 0, 0, DateTimeKind.Unspecified), "ruby", false, new Guid("3f7ecbfa-4c9f-42b7-89fc-dfe7baf7959e"), "Ruby", new DateTime(2024, 12, 21, 10, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("01403752-9f62-4639-a411-109f4a098324"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("11403752-9f62-4639-a411-109f4a098324"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("21403752-9f62-4639-a411-109f4a098324"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("31403752-9f62-4639-a411-109f4a098324"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("41403752-9f62-4639-a411-109f4a098324"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("51403752-9f62-4639-a411-109f4a098324"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("61403752-9f62-4639-a411-109f4a098324"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("71403752-9f62-4639-a411-109f4a098324"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("81403752-9f62-4639-a411-109f4a098324"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("91403752-9f62-4639-a411-109f4a098324"));
        }
    }
}
