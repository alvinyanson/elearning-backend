using System.ComponentModel.DataAnnotations.Schema;

namespace ELearning_API.Models
{
    public class Course : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public bool IsPublished { get; set; }

        public TimeSpan Duration { get; set; }

        public int ModuleCount { get; set; }

        [ForeignKey("Subject")]
        public Guid SubjectId { get; set; }

        // Navigation property
        public virtual Subject Subject { get; set; }

        [ForeignKey("ApplicationUser")]
        public string AuthorId { get; set; }

        // Navigation property
        public virtual ApplicationUser Author { get; set; }
    }
}
