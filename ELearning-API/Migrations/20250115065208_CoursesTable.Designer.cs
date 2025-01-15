﻿// <auto-generated />
using System;
using ELearning_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ELearning_API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250115065208_CoursesTable")]
    partial class CoursesTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ELearning_API.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("ELearning_API.Models.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AuthorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPublised")
                        .HasColumnType("bit");

                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("ELearning_API.Models.Subject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c924fda8-abe9-4909-8e1d-616df8f4d231"),
                            CreatedAt = new DateTime(2024, 12, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPublished = false,
                            Name = "Introduction to Programming",
                            OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"),
                            UpdatedAt = new DateTime(2024, 12, 1, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("a68ddadc-1af7-4e65-b0b9-4e98736d7fcf"),
                            CreatedAt = new DateTime(2024, 12, 2, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPublished = false,
                            Name = "Object-Oriented Programming",
                            OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"),
                            UpdatedAt = new DateTime(2024, 12, 2, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("3f7ecbfa-4c9f-42b7-89fc-dfe7baf7959e"),
                            CreatedAt = new DateTime(2024, 12, 3, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPublished = false,
                            Name = "Frontend Development",
                            OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"),
                            UpdatedAt = new DateTime(2024, 12, 3, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("06c74b30-df5b-4fa3-93dc-31f223e1cfd2"),
                            CreatedAt = new DateTime(2024, 12, 4, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPublished = false,
                            Name = "Backend Development",
                            OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"),
                            UpdatedAt = new DateTime(2024, 12, 4, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("3e9d40c7-42d3-4dd4-a5f4-12f43c1ed523"),
                            CreatedAt = new DateTime(2024, 12, 5, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPublished = false,
                            Name = "Data Structures and Algorithms",
                            OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"),
                            UpdatedAt = new DateTime(2024, 12, 5, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("d8a8eb38-c7a8-4f7a-991f-fc542771f8f1"),
                            CreatedAt = new DateTime(2024, 12, 6, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPublished = false,
                            Name = "Database Design",
                            OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"),
                            UpdatedAt = new DateTime(2024, 12, 6, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("63c1f59d-5d9b-466f-8424-fba042e9289b"),
                            CreatedAt = new DateTime(2024, 12, 7, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPublished = false,
                            Name = "Software Architecture",
                            OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"),
                            UpdatedAt = new DateTime(2024, 12, 7, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("d8bfa63b-0896-42cc-88cb-916f6319e9b2"),
                            CreatedAt = new DateTime(2024, 12, 8, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPublished = false,
                            Name = "Web Development Basics",
                            OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"),
                            UpdatedAt = new DateTime(2024, 12, 8, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("f8f9396c-6bf2-4ad5-8ad9-15cd4187e1ab"),
                            CreatedAt = new DateTime(2024, 12, 9, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPublished = false,
                            Name = "Version Control with Git",
                            OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"),
                            UpdatedAt = new DateTime(2024, 12, 9, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("ae885ac6-45e8-4a5c-a2e0-cbe8fb5a60fd"),
                            CreatedAt = new DateTime(2024, 12, 10, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPublished = false,
                            Name = "Cloud Computing Essentials",
                            OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"),
                            UpdatedAt = new DateTime(2024, 12, 10, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("69f2cc6c-c84c-4d8c-bc22-f290152bfb49"),
                            CreatedAt = new DateTime(2024, 12, 11, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPublished = false,
                            Name = "Microservices Architecture",
                            OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"),
                            UpdatedAt = new DateTime(2024, 12, 11, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("73d0930e-60a4-48b8-bb55-bb738e529a3d"),
                            CreatedAt = new DateTime(2024, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPublished = false,
                            Name = "APIs and RESTful Design",
                            OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"),
                            UpdatedAt = new DateTime(2024, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("a9f3d239-7617-4069-b6df-2be7f5a4f9c5"),
                            CreatedAt = new DateTime(2024, 12, 13, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPublished = false,
                            Name = "Test Driven Development",
                            OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"),
                            UpdatedAt = new DateTime(2024, 12, 13, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("ed290c6b-3b9d-4026-94c5-449e1cfbcf5c"),
                            CreatedAt = new DateTime(2024, 12, 14, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPublished = false,
                            Name = "DevOps Practices",
                            OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"),
                            UpdatedAt = new DateTime(2024, 12, 14, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("f85ecf95-4f94-4ac9-b59e-7a86c6c24422"),
                            CreatedAt = new DateTime(2024, 12, 15, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPublished = false,
                            Name = "Containerization with Docker",
                            OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"),
                            UpdatedAt = new DateTime(2024, 12, 15, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("cd45bf8d-d6d1-4193-b25b-66e528fc265d"),
                            CreatedAt = new DateTime(2024, 12, 16, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPublished = false,
                            Name = "Serverless Computing",
                            OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"),
                            UpdatedAt = new DateTime(2024, 12, 16, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("f35078a3-90f2-4baf-88c5-d39db537d4b1"),
                            CreatedAt = new DateTime(2024, 12, 17, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPublished = false,
                            Name = "Mobile App Development",
                            OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"),
                            UpdatedAt = new DateTime(2024, 12, 17, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("258c02be-53c4-4093-b183-f173dc775e32"),
                            CreatedAt = new DateTime(2024, 12, 18, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPublished = false,
                            Name = "Game Development Basics",
                            OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"),
                            UpdatedAt = new DateTime(2024, 12, 18, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("8d92cba6-e93c-47f8-bca5-136f5d2a0d85"),
                            CreatedAt = new DateTime(2024, 12, 19, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPublished = false,
                            Name = "Introduction to Machine Learning",
                            OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"),
                            UpdatedAt = new DateTime(2024, 12, 19, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("b8eb87b5-50a3-4812-890e-d6e4d5ba6e7c"),
                            CreatedAt = new DateTime(2024, 12, 20, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPublished = false,
                            Name = "Natural Language Processing",
                            OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"),
                            UpdatedAt = new DateTime(2024, 12, 20, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("972c9cb1-86ad-4a03-96ec-687dff0c8173"),
                            CreatedAt = new DateTime(2024, 12, 21, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPublished = false,
                            Name = "Cybersecurity Basics",
                            OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"),
                            UpdatedAt = new DateTime(2024, 12, 21, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ELearning_API.Models.Course", b =>
                {
                    b.HasOne("ELearning_API.Models.ApplicationUser", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ELearning_API.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ELearning_API.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ELearning_API.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ELearning_API.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ELearning_API.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
