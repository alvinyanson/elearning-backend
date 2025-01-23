namespace ELearning_API.DTOs.Course
{
    public class CreateCourseDTO
    {
        public string Title { get; set; }
        public string Icon { get; set; }
        public bool IsPublished { get; set; }
        public TimeSpan Duration { get; set; }
        public Guid SubjectId { get; set; }
        public string AuthorId { get; set; }
    }
}
