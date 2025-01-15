using System.ComponentModel.DataAnnotations.Schema;

namespace ELearning_API.Models
{
    public class Course : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public bool IsPublised { get; set; }

        [ForeignKey("Subject")]
        public Guid SubjectId { get; set; }

        // Navigation property
        public Subject Subject { get; set; }

        [ForeignKey("ApplicationUser")]
        public string AuthorId { get; set; }

        // Navigation property
        public ApplicationUser Author { get; set; }
    }
}
