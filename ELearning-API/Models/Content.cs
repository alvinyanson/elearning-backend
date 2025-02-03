using System.ComponentModel.DataAnnotations.Schema;

namespace ELearning_API.Models
{
    public class Content : BaseEntity
    {
        public string HTMLContent { get; set; }
        public string Type { get; set; }
        public bool IsPublished { get; set; }

        [ForeignKey("ApplicationUser")]
        public string AuthorId { get; set; }

        public virtual ApplicationUser Author { get; set; }

        [ForeignKey("Module")]
        public Guid ModuleId { get; set; }

        public virtual Module Module { get; set; }

    }
}
