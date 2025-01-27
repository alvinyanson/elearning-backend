using ELearning_API.DTOs.Instructor;
using ELearning_API.DTOs.Subject;
using ELearning_API.Migrations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ELearning_API.DTOs.Course
{
    public class GetCourseDTO : BaseCourseDTO
    {
        [ValidateNever]
        public virtual BaseSubjectDTO Subject { get; set; }
    }
}
