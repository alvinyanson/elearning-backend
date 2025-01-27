using ELearning_API.DTOs.Instructor;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ELearning_API.DTOs.Course
{
    public class BaseCourseDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public bool IsPublished { get; set; }

        public TimeSpan Duration { get; set; }

        public int ModuleCount { get; set; }

        [ValidateNever]
        public virtual GetInstructorDTO Author { get; set; }
    }
}
