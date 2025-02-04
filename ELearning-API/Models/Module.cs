using System.ComponentModel.DataAnnotations.Schema;

namespace ELearning_API.Models
{
    public class Module : BaseEntity
    {
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }
        public bool IsPublished { get; set; }
        
        [ForeignKey("Course")]
        public Guid CourseId { get; set; }

        // navigation property
        public virtual Course Course { get; set; }

        [ForeignKey("ApplicationUser")]
        public string AuthorId { get; set; }

        public virtual ApplicationUser Author { get; set; }

        public virtual List<Content> Content { get; set; }
    }
}
