namespace ELearning_API.DTOs.Subject
{
    public class GetSubjectDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid OwnerId { get; set; }
        public bool IsPublished { get; set; }
    }
}
