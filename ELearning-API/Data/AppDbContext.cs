using ELearning_API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ELearning_API.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            Subject[] seedSubjects = [
                new() { Id = new Guid("b6e33a3a-8c3e-4ec1-b6bb-cb7c32cbdc99"), Name = "Introduction to Programming", OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"), CreatedAt = new DateTime(2024, 12, 1, 10, 0, 0), UpdatedAt = new DateTime(2024, 12, 1, 10, 0, 0) },
                new() { Id = new Guid("c7437f78-4ed9-45b3-9a2b-b4672b2e8b42"), Name = "Object-Oriented Programming", OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"), CreatedAt = new DateTime(2024, 12, 2, 10, 0, 0), UpdatedAt = new DateTime(2024, 12, 2, 10, 0, 0) },
                ];

            builder.Entity<Subject>().HasData(seedSubjects);
        }

        public DbSet<Subject> Subjects { get; set; }
    }
}
