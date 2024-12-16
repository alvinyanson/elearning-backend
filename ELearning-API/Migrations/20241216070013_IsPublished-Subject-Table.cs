using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELearning_API.Migrations
{
    /// <inheritdoc />
    public partial class IsPublishedSubjectTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPublished",
                table: "Subjects",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("b6e33a3a-8c3e-4ec1-b6bb-cb7c32cbdc99"),
                column: "IsPublished",
                value: false);

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("c7437f78-4ed9-45b3-9a2b-b4672b2e8b42"),
                column: "IsPublished",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPublished",
                table: "Subjects");
        }
    }
}
