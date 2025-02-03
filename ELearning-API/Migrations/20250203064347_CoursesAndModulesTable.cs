using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ELearning_API.Migrations
{
    /// <inheritdoc />
    public partial class CoursesAndModulesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: false),
                    ModuleCount = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Courses_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modules_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Modules_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "Duration", "Icon", "IsPublished", "ModuleCount", "SubjectId", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("01403752-9f62-4639-a411-109f4a098324"), "81213A50-758E-4904-B715-640038EE9CD9", new DateTime(2024, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "angular", false, 0, new Guid("3f7ecbfa-4c9f-42b7-89fc-dfe7baf7959e"), "Angular", new DateTime(2024, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("11403752-9f62-4639-a411-109f4a098324"), "81213A50-758E-4904-B715-640038EE9CD9", new DateTime(2024, 12, 13, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "react", false, 0, new Guid("3f7ecbfa-4c9f-42b7-89fc-dfe7baf7959e"), "React", new DateTime(2024, 12, 13, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("21403752-9f62-4639-a411-109f4a098324"), "81213A50-758E-4904-B715-640038EE9CD9", new DateTime(2024, 12, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "vue", false, 0, new Guid("3f7ecbfa-4c9f-42b7-89fc-dfe7baf7959e"), "Vue.js", new DateTime(2024, 12, 14, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("31403752-9f62-4639-a411-109f4a098324"), "81213A50-758E-4904-B715-640038EE9CD9", new DateTime(2024, 12, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "nodejs", false, 0, new Guid("3f7ecbfa-4c9f-42b7-89fc-dfe7baf7959e"), "Node.js", new DateTime(2024, 12, 15, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("41403752-9f62-4639-a411-109f4a098324"), "81213A50-758E-4904-B715-640038EE9CD9", new DateTime(2024, 12, 16, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "python", false, 0, new Guid("3f7ecbfa-4c9f-42b7-89fc-dfe7baf7959e"), "Python", new DateTime(2024, 12, 16, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("51403752-9f62-4639-a411-109f4a098324"), "81213A50-758E-4904-B715-640038EE9CD9", new DateTime(2024, 12, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "csharp", false, 0, new Guid("3f7ecbfa-4c9f-42b7-89fc-dfe7baf7959e"), "C#", new DateTime(2024, 12, 17, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("61403752-9f62-4639-a411-109f4a098324"), "81213A50-758E-4904-B715-640038EE9CD9", new DateTime(2024, 12, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "java", false, 0, new Guid("3f7ecbfa-4c9f-42b7-89fc-dfe7baf7959e"), "Java", new DateTime(2024, 12, 18, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("71403752-9f62-4639-a411-109f4a098324"), "81213A50-758E-4904-B715-640038EE9CD9", new DateTime(2024, 12, 19, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "kotlin", false, 0, new Guid("3f7ecbfa-4c9f-42b7-89fc-dfe7baf7959e"), "Kotlin", new DateTime(2024, 12, 19, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("81403752-9f62-4639-a411-109f4a098324"), "81213A50-758E-4904-B715-640038EE9CD9", new DateTime(2024, 12, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "php", false, 0, new Guid("3f7ecbfa-4c9f-42b7-89fc-dfe7baf7959e"), "PHP", new DateTime(2024, 12, 20, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("91403752-9f62-4639-a411-109f4a098324"), "81213A50-758E-4904-B715-640038EE9CD9", new DateTime(2024, 12, 21, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "ruby", false, 0, new Guid("3f7ecbfa-4c9f-42b7-89fc-dfe7baf7959e"), "Ruby", new DateTime(2024, 12, 21, 10, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "AuthorId", "CourseId", "CreatedAt", "Duration", "IsPublished", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("3f7654fe-0ad8-4289-9436-04ce9005f500"), "81213A50-758E-4904-B715-640038EE9CD9", new Guid("01403752-9f62-4639-a411-109f4a098324"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 30, 0, 0), false, "Web Development Basics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("42f831f1-8641-451e-878e-c786182036e1"), "81213A50-758E-4904-B715-640038EE9CD9", new Guid("01403752-9f62-4639-a411-109f4a098324"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 30, 0, 0), true, "Database Design Principles", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4467cacb-2fbd-4928-b5ce-f4028f8068d8"), "81213A50-758E-4904-B715-640038EE9CD9", new Guid("01403752-9f62-4639-a411-109f4a098324"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 4, 0, 0, 0), true, "Machine Learning Essentials", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4b146c3b-9cb1-4c0f-b07f-fccba7b6effc"), "81213A50-758E-4904-B715-640038EE9CD9", new Guid("01403752-9f62-4639-a411-109f4a098324"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 30, 0, 0), false, "Advanced C# Techniques", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("54d33185-0e39-45f4-8f05-37fc100d29ea"), "81213A50-758E-4904-B715-640038EE9CD9", new Guid("01403752-9f62-4639-a411-109f4a098324"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0), true, "Introduction to Programming", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_AuthorId",
                table: "Courses",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_SubjectId",
                table: "Courses",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Modules_AuthorId",
                table: "Modules",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Modules_CourseId",
                table: "Modules",
                column: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
