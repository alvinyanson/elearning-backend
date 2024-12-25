using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ELearning_API.Migrations
{
    /// <inheritdoc />
    public partial class SubjectSeedItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("b6e33a3a-8c3e-4ec1-b6bb-cb7c32cbdc99"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("c7437f78-4ed9-45b3-9a2b-b4672b2e8b42"));

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "CreatedAt", "IsPublished", "Name", "OwnerId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("06c74b30-df5b-4fa3-93dc-31f223e1cfd2"), new DateTime(2024, 12, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), false, "Backend Development", new Guid("81213a50-758e-4904-b715-640038ee9cd9"), new DateTime(2024, 12, 4, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("258c02be-53c4-4093-b183-f173dc775e32"), new DateTime(2024, 12, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), false, "Game Development Basics", new Guid("81213a50-758e-4904-b715-640038ee9cd9"), new DateTime(2024, 12, 18, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3e9d40c7-42d3-4dd4-a5f4-12f43c1ed523"), new DateTime(2024, 12, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), false, "Data Structures and Algorithms", new Guid("81213a50-758e-4904-b715-640038ee9cd9"), new DateTime(2024, 12, 5, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3f7ecbfa-4c9f-42b7-89fc-dfe7baf7959e"), new DateTime(2024, 12, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), false, "Frontend Development", new Guid("81213a50-758e-4904-b715-640038ee9cd9"), new DateTime(2024, 12, 3, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("63c1f59d-5d9b-466f-8424-fba042e9289b"), new DateTime(2024, 12, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), false, "Software Architecture", new Guid("81213a50-758e-4904-b715-640038ee9cd9"), new DateTime(2024, 12, 7, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("69f2cc6c-c84c-4d8c-bc22-f290152bfb49"), new DateTime(2024, 12, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), false, "Microservices Architecture", new Guid("81213a50-758e-4904-b715-640038ee9cd9"), new DateTime(2024, 12, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("73d0930e-60a4-48b8-bb55-bb738e529a3d"), new DateTime(2024, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), false, "APIs and RESTful Design", new Guid("81213a50-758e-4904-b715-640038ee9cd9"), new DateTime(2024, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8d92cba6-e93c-47f8-bca5-136f5d2a0d85"), new DateTime(2024, 12, 19, 10, 0, 0, 0, DateTimeKind.Unspecified), false, "Introduction to Machine Learning", new Guid("81213a50-758e-4904-b715-640038ee9cd9"), new DateTime(2024, 12, 19, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("972c9cb1-86ad-4a03-96ec-687dff0c8173"), new DateTime(2024, 12, 21, 10, 0, 0, 0, DateTimeKind.Unspecified), false, "Cybersecurity Basics", new Guid("81213a50-758e-4904-b715-640038ee9cd9"), new DateTime(2024, 12, 21, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a68ddadc-1af7-4e65-b0b9-4e98736d7fcf"), new DateTime(2024, 12, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), false, "Object-Oriented Programming", new Guid("81213a50-758e-4904-b715-640038ee9cd9"), new DateTime(2024, 12, 2, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a9f3d239-7617-4069-b6df-2be7f5a4f9c5"), new DateTime(2024, 12, 13, 10, 0, 0, 0, DateTimeKind.Unspecified), false, "Test Driven Development", new Guid("81213a50-758e-4904-b715-640038ee9cd9"), new DateTime(2024, 12, 13, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ae885ac6-45e8-4a5c-a2e0-cbe8fb5a60fd"), new DateTime(2024, 12, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), false, "Cloud Computing Essentials", new Guid("81213a50-758e-4904-b715-640038ee9cd9"), new DateTime(2024, 12, 10, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b8eb87b5-50a3-4812-890e-d6e4d5ba6e7c"), new DateTime(2024, 12, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), false, "Natural Language Processing", new Guid("81213a50-758e-4904-b715-640038ee9cd9"), new DateTime(2024, 12, 20, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c924fda8-abe9-4909-8e1d-616df8f4d231"), new DateTime(2024, 12, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, "Introduction to Programming", new Guid("81213a50-758e-4904-b715-640038ee9cd9"), new DateTime(2024, 12, 1, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cd45bf8d-d6d1-4193-b25b-66e528fc265d"), new DateTime(2024, 12, 16, 10, 0, 0, 0, DateTimeKind.Unspecified), false, "Serverless Computing", new Guid("81213a50-758e-4904-b715-640038ee9cd9"), new DateTime(2024, 12, 16, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d8a8eb38-c7a8-4f7a-991f-fc542771f8f1"), new DateTime(2024, 12, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), false, "Database Design", new Guid("81213a50-758e-4904-b715-640038ee9cd9"), new DateTime(2024, 12, 6, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d8bfa63b-0896-42cc-88cb-916f6319e9b2"), new DateTime(2024, 12, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), false, "Web Development Basics", new Guid("81213a50-758e-4904-b715-640038ee9cd9"), new DateTime(2024, 12, 8, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ed290c6b-3b9d-4026-94c5-449e1cfbcf5c"), new DateTime(2024, 12, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), false, "DevOps Practices", new Guid("81213a50-758e-4904-b715-640038ee9cd9"), new DateTime(2024, 12, 14, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f35078a3-90f2-4baf-88c5-d39db537d4b1"), new DateTime(2024, 12, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), false, "Mobile App Development", new Guid("81213a50-758e-4904-b715-640038ee9cd9"), new DateTime(2024, 12, 17, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f85ecf95-4f94-4ac9-b59e-7a86c6c24422"), new DateTime(2024, 12, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), false, "Containerization with Docker", new Guid("81213a50-758e-4904-b715-640038ee9cd9"), new DateTime(2024, 12, 15, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f8f9396c-6bf2-4ad5-8ad9-15cd4187e1ab"), new DateTime(2024, 12, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), false, "Version Control with Git", new Guid("81213a50-758e-4904-b715-640038ee9cd9"), new DateTime(2024, 12, 9, 10, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("06c74b30-df5b-4fa3-93dc-31f223e1cfd2"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("258c02be-53c4-4093-b183-f173dc775e32"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("3e9d40c7-42d3-4dd4-a5f4-12f43c1ed523"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("3f7ecbfa-4c9f-42b7-89fc-dfe7baf7959e"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("63c1f59d-5d9b-466f-8424-fba042e9289b"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("69f2cc6c-c84c-4d8c-bc22-f290152bfb49"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("73d0930e-60a4-48b8-bb55-bb738e529a3d"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("8d92cba6-e93c-47f8-bca5-136f5d2a0d85"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("972c9cb1-86ad-4a03-96ec-687dff0c8173"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("a68ddadc-1af7-4e65-b0b9-4e98736d7fcf"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("a9f3d239-7617-4069-b6df-2be7f5a4f9c5"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("ae885ac6-45e8-4a5c-a2e0-cbe8fb5a60fd"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("b8eb87b5-50a3-4812-890e-d6e4d5ba6e7c"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("c924fda8-abe9-4909-8e1d-616df8f4d231"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("cd45bf8d-d6d1-4193-b25b-66e528fc265d"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("d8a8eb38-c7a8-4f7a-991f-fc542771f8f1"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("d8bfa63b-0896-42cc-88cb-916f6319e9b2"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("ed290c6b-3b9d-4026-94c5-449e1cfbcf5c"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("f35078a3-90f2-4baf-88c5-d39db537d4b1"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("f85ecf95-4f94-4ac9-b59e-7a86c6c24422"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("f8f9396c-6bf2-4ad5-8ad9-15cd4187e1ab"));

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "CreatedAt", "IsPublished", "Name", "OwnerId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("b6e33a3a-8c3e-4ec1-b6bb-cb7c32cbdc99"), new DateTime(2024, 12, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, "Introduction to Programming", new Guid("81213a50-758e-4904-b715-640038ee9cd9"), new DateTime(2024, 12, 1, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c7437f78-4ed9-45b3-9a2b-b4672b2e8b42"), new DateTime(2024, 12, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), false, "Object-Oriented Programming", new Guid("81213a50-758e-4904-b715-640038ee9cd9"), new DateTime(2024, 12, 2, 10, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
