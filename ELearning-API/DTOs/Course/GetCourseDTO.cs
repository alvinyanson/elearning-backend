using System.ComponentModel.DataAnnotations.Schema;

namespace ELearning_API.DTOs.Course
{
    public class GetCourseDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public bool IsPublised { get; set; }

        public Guid SubjectId { get; set; }

        public string AuthorId { get; set; }
    }
}
