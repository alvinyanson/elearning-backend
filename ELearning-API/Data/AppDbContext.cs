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
                new() { Id = new Guid("c924fda8-abe9-4909-8e1d-616df8f4d231"), Name = "Introduction to Programming", OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"), CreatedAt = new DateTime(2024, 12, 1, 10, 0, 0), UpdatedAt = new DateTime(2024, 12, 1, 10, 0, 0) },
                new() { Id = new Guid("a68ddadc-1af7-4e65-b0b9-4e98736d7fcf"), Name = "Object-Oriented Programming", OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"), CreatedAt = new DateTime(2024, 12, 2, 10, 0, 0), UpdatedAt = new DateTime(2024, 12, 2, 10, 0, 0) },
                new() { Id = new Guid("3f7ecbfa-4c9f-42b7-89fc-dfe7baf7959e"), Name = "Frontend Development", OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"), CreatedAt = new DateTime(2024, 12, 3, 10, 0, 0), UpdatedAt = new DateTime(2024, 12, 3, 10, 0, 0) },
                new() { Id = new Guid("06c74b30-df5b-4fa3-93dc-31f223e1cfd2"), Name = "Backend Development", OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"), CreatedAt = new DateTime(2024, 12, 4, 10, 0, 0), UpdatedAt = new DateTime(2024, 12, 4, 10, 0, 0) },
                new() { Id = new Guid("3e9d40c7-42d3-4dd4-a5f4-12f43c1ed523"), Name = "Data Structures and Algorithms", OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"), CreatedAt = new DateTime(2024, 12, 5, 10, 0, 0), UpdatedAt = new DateTime(2024, 12, 5, 10, 0, 0) },
                new() { Id = new Guid("d8a8eb38-c7a8-4f7a-991f-fc542771f8f1"), Name = "Database Design", OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"), CreatedAt = new DateTime(2024, 12, 6, 10, 0, 0), UpdatedAt = new DateTime(2024, 12, 6, 10, 0, 0) },
                new() { Id = new Guid("63c1f59d-5d9b-466f-8424-fba042e9289b"), Name = "Software Architecture", OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"), CreatedAt = new DateTime(2024, 12, 7, 10, 0, 0), UpdatedAt = new DateTime(2024, 12, 7, 10, 0, 0) },
                new() { Id = new Guid("d8bfa63b-0896-42cc-88cb-916f6319e9b2"), Name = "Web Development Basics", OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"), CreatedAt = new DateTime(2024, 12, 8, 10, 0, 0), UpdatedAt = new DateTime(2024, 12, 8, 10, 0, 0) },
                new() { Id = new Guid("f8f9396c-6bf2-4ad5-8ad9-15cd4187e1ab"), Name = "Version Control with Git", OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"), CreatedAt = new DateTime(2024, 12, 9, 10, 0, 0), UpdatedAt = new DateTime(2024, 12, 9, 10, 0, 0) },
                new() { Id = new Guid("ae885ac6-45e8-4a5c-a2e0-cbe8fb5a60fd"), Name = "Cloud Computing Essentials", OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"), CreatedAt = new DateTime(2024, 12, 10, 10, 0, 0), UpdatedAt = new DateTime(2024, 12, 10, 10, 0, 0) },
                new() { Id = new Guid("69f2cc6c-c84c-4d8c-bc22-f290152bfb49"), Name = "Microservices Architecture", OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"), CreatedAt = new DateTime(2024, 12, 11, 10, 0, 0), UpdatedAt = new DateTime(2024, 12, 11, 10, 0, 0) },
                new() { Id = new Guid("73d0930e-60a4-48b8-bb55-bb738e529a3d"), Name = "APIs and RESTful Design", OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"), CreatedAt = new DateTime(2024, 12, 12, 10, 0, 0), UpdatedAt = new DateTime(2024, 12, 12, 10, 0, 0) },
                new() { Id = new Guid("a9f3d239-7617-4069-b6df-2be7f5a4f9c5"), Name = "Test Driven Development", OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"), CreatedAt = new DateTime(2024, 12, 13, 10, 0, 0), UpdatedAt = new DateTime(2024, 12, 13, 10, 0, 0) },
                new() { Id = new Guid("ed290c6b-3b9d-4026-94c5-449e1cfbcf5c"), Name = "DevOps Practices", OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"), CreatedAt = new DateTime(2024, 12, 14, 10, 0, 0), UpdatedAt = new DateTime(2024, 12, 14, 10, 0, 0) },
                new() { Id = new Guid("f85ecf95-4f94-4ac9-b59e-7a86c6c24422"), Name = "Containerization with Docker", OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"), CreatedAt = new DateTime(2024, 12, 15, 10, 0, 0), UpdatedAt = new DateTime(2024, 12, 15, 10, 0, 0) },
                new() { Id = new Guid("cd45bf8d-d6d1-4193-b25b-66e528fc265d"), Name = "Serverless Computing", OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"), CreatedAt = new DateTime(2024, 12, 16, 10, 0, 0), UpdatedAt = new DateTime(2024, 12, 16, 10, 0, 0) },
                new() { Id = new Guid("f35078a3-90f2-4baf-88c5-d39db537d4b1"), Name = "Mobile App Development", OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"), CreatedAt = new DateTime(2024, 12, 17, 10, 0, 0), UpdatedAt = new DateTime(2024, 12, 17, 10, 0, 0) },
                new() { Id = new Guid("258c02be-53c4-4093-b183-f173dc775e32"), Name = "Game Development Basics", OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"), CreatedAt = new DateTime(2024, 12, 18, 10, 0, 0), UpdatedAt = new DateTime(2024, 12, 18, 10, 0, 0) },
                new() { Id = new Guid("8d92cba6-e93c-47f8-bca5-136f5d2a0d85"), Name = "Introduction to Machine Learning", OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"), CreatedAt = new DateTime(2024, 12, 19, 10, 0, 0), UpdatedAt = new DateTime(2024, 12, 19, 10, 0, 0) },
                new() { Id = new Guid("b8eb87b5-50a3-4812-890e-d6e4d5ba6e7c"), Name = "Natural Language Processing", OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"), CreatedAt = new DateTime(2024, 12, 20, 10, 0, 0), UpdatedAt = new DateTime(2024, 12, 20, 10, 0, 0) },
                new() { Id = new Guid("972c9cb1-86ad-4a03-96ec-687dff0c8173"), Name = "Cybersecurity Basics", OwnerId = new Guid("81213a50-758e-4904-b715-640038ee9cd9"), CreatedAt = new DateTime(2024, 12, 21, 10, 0, 0), UpdatedAt = new DateTime(2024, 12, 21, 10, 0, 0) },
                ];


            Course[] seedCourses =
                {
                    new Course {Id = new Guid("01403752-9f62-4639-a411-109f4a098324"), Title = "Angular", Icon = "angular", IsPublised = false, SubjectId = new Guid("3f7ecbfa-4c9f-42b7-89fc-dfe7baf7959e"), AuthorId = "548241c1-f11a-4323-abc4-9f83f83c8d9d", CreatedAt = new DateTime(2024, 12, 12, 10, 0, 0), UpdatedAt = new DateTime(2024, 12, 12, 10, 0, 0) },
                    new Course {Id = new Guid("11403752-9f62-4639-a411-109f4a098324"), Title = "React", Icon = "react", IsPublised = false, SubjectId = new Guid("3f7ecbfa-4c9f-42b7-89fc-dfe7baf7959e"), AuthorId = "548241c1-f11a-4323-abc4-9f83f83c8d9d", CreatedAt = new DateTime(2024, 12, 13, 10, 0, 0), UpdatedAt = new DateTime(2024, 12, 13, 10, 0, 0) },
                    new Course {Id = new Guid("21403752-9f62-4639-a411-109f4a098324"), Title = "Vue.js", Icon = "vue", IsPublised = false, SubjectId = new Guid("3f7ecbfa-4c9f-42b7-89fc-dfe7baf7959e"), AuthorId = "548241c1-f11a-4323-abc4-9f83f83c8d9d", CreatedAt = new DateTime(2024, 12, 14, 10, 0, 0), UpdatedAt = new DateTime(2024, 12, 14, 10, 0, 0) },
                    new Course {Id = new Guid("31403752-9f62-4639-a411-109f4a098324"), Title = "Node.js", Icon = "nodejs", IsPublised = false, SubjectId = new Guid("3f7ecbfa-4c9f-42b7-89fc-dfe7baf7959e"), AuthorId = "548241c1-f11a-4323-abc4-9f83f83c8d9d", CreatedAt = new DateTime(2024, 12, 15, 10, 0, 0), UpdatedAt = new DateTime(2024, 12, 15, 10, 0, 0) },
                    new Course {Id = new Guid("41403752-9f62-4639-a411-109f4a098324"), Title = "Python", Icon = "python", IsPublised = false, SubjectId = new Guid("3f7ecbfa-4c9f-42b7-89fc-dfe7baf7959e"), AuthorId = "548241c1-f11a-4323-abc4-9f83f83c8d9d", CreatedAt = new DateTime(2024, 12, 16, 10, 0, 0), UpdatedAt = new DateTime(2024, 12, 16, 10, 0, 0) },
                    new Course {Id = new Guid("51403752-9f62-4639-a411-109f4a098324"), Title = "C#", Icon = "csharp", IsPublised = false, SubjectId = new Guid("3f7ecbfa-4c9f-42b7-89fc-dfe7baf7959e"), AuthorId = "548241c1-f11a-4323-abc4-9f83f83c8d9d", CreatedAt = new DateTime(2024, 12, 17, 10, 0, 0), UpdatedAt = new DateTime(2024, 12, 17, 10, 0, 0) },
                    new Course {Id = new Guid("61403752-9f62-4639-a411-109f4a098324"), Title = "Java", Icon = "java", IsPublised = false, SubjectId = new Guid("3f7ecbfa-4c9f-42b7-89fc-dfe7baf7959e"), AuthorId = "548241c1-f11a-4323-abc4-9f83f83c8d9d", CreatedAt = new DateTime(2024, 12, 18, 10, 0, 0), UpdatedAt = new DateTime(2024, 12, 18, 10, 0, 0) },
                    new Course {Id = new Guid("71403752-9f62-4639-a411-109f4a098324"), Title = "Kotlin", Icon = "kotlin", IsPublised = false, SubjectId = new Guid("3f7ecbfa-4c9f-42b7-89fc-dfe7baf7959e"), AuthorId = "548241c1-f11a-4323-abc4-9f83f83c8d9d", CreatedAt = new DateTime(2024, 12, 19, 10, 0, 0), UpdatedAt = new DateTime(2024, 12, 19, 10, 0, 0) },
                    new Course {Id = new Guid("81403752-9f62-4639-a411-109f4a098324"), Title = "PHP", Icon = "php", IsPublised = false, SubjectId = new Guid("3f7ecbfa-4c9f-42b7-89fc-dfe7baf7959e"), AuthorId = "548241c1-f11a-4323-abc4-9f83f83c8d9d", CreatedAt = new DateTime(2024, 12, 20, 10, 0, 0), UpdatedAt = new DateTime(2024, 12, 20, 10, 0, 0) },
                    new Course {Id = new Guid("91403752-9f62-4639-a411-109f4a098324"), Title = "Ruby", Icon = "ruby", IsPublised = false, SubjectId = new Guid("3f7ecbfa-4c9f-42b7-89fc-dfe7baf7959e"), AuthorId = "548241c1-f11a-4323-abc4-9f83f83c8d9d", CreatedAt = new DateTime(2024, 12, 21, 10, 0, 0), UpdatedAt = new DateTime(2024, 12, 21, 10, 0, 0) }
                };



            builder.Entity<Subject>().HasData(seedSubjects);
            builder.Entity<Course>().HasData(seedCourses);

        }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Course> Courses { get; set; }

        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            AddTimestamps();
            return base.SaveChangesAsync();
        }


        private void AddTimestamps()
        {
            var entities = ChangeTracker.Entries()
                .Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in entities)
            {
                var now = DateTime.UtcNow; // current datetime

                if (entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).CreatedAt = now;
                }
                ((BaseEntity)entity.Entity).UpdatedAt = now;
            }
        }
    }
}
