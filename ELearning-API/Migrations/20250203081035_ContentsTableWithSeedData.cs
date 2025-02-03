using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELearning_API.Migrations
{
    /// <inheritdoc />
    public partial class ContentsTableWithSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HTMLContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ModuleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contents_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contents_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HTMLContent", "IsPublished", "ModuleId", "Type", "UpdatedAt" },
                values: new object[] { new Guid("06d93e6c-4d65-429d-8a40-e0e5cf5e9d5a"), "81213A50-758E-4904-B715-640038EE9CD9", new DateTime(2025, 2, 3, 8, 10, 34, 635, DateTimeKind.Utc).AddTicks(364), "<p>Introduction to the course</p>", true, new Guid("3f7654fe-0ad8-4289-9436-04ce9005f500"), "Text", new DateTime(2025, 2, 3, 8, 10, 34, 635, DateTimeKind.Utc).AddTicks(367) });

            migrationBuilder.CreateIndex(
                name: "IX_Contents_AuthorId",
                table: "Contents",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Contents_ModuleId",
                table: "Contents",
                column: "ModuleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contents");
        }
    }
}
