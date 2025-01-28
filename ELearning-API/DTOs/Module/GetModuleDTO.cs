using ELearning_API.DTOs.Course;
using ELearning_API.DTOs.Instructor;

namespace ELearning_API.DTOs.Module
{
    public class GetModuleDTO : BaseModuleDTO
    {
        public virtual GetCourseDTO Course { get; set; }
        public virtual GetInstructorDTO Author { get; set; }
    }
}
