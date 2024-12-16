namespace ELearning_API.DTOs.Subject
{
    public class CreateSubjectDTO
    {
        public required string Name { get; set; }
        public Guid OwnerId { get; set; }
    }
}
