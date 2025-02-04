
namespace ELearning_API.DTOs.Module
{
    public class CreateContentDTO
    {
        public string HTMLContent { get; set; }
        public string Type { get; set; }
        public bool IsPublished { get; set; }
        public string AuthorId { get; set; }
        public Guid ModuleId { get; set; }
    }

}
