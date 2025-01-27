using ELearning_API.DTOs.Course;
using ELearning_API.DTOs.Instructor;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ELearning_API.DTOs.Subject
{
    public class GetSubjectDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid OwnerId { get; set; }
        public bool IsPublished { get; set; }
    }

    public class GetSubjectWithCourseDTO : GetSubjectDTO
    {
        public List<BaseCourseDTO> Courses { get; set; }
    }
}
