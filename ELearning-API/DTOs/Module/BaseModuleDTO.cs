using ELearning_API.DTOs.Course;

namespace ELearning_API.DTOs.Module
{
    public class BaseModuleDTO
    {
        public Guid Id { get; set; }

        public string Title { get; set; }
        public TimeSpan Duration { get; set; }
        public bool IsPublished { get; set; }
        public string AuthorId { get; set; }
        public Guid CourseId { get; set; }
    }

}
