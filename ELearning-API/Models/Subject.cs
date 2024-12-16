namespace ELearning_API.Models
{
    public class Subject : BaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid OwnerId { get; set; }
    }
}
