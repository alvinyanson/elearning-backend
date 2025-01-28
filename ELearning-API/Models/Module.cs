using System.ComponentModel.DataAnnotations.Schema;

namespace ELearning_API.Models
{
    public class Module : BaseEntity
    {
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }
        public bool IsPublished { get; set; }
        public string AuthorId { get; set; }
        
        [ForeignKey("Course")]
        public Guid CourseId { get; set; }

        // navigation property
        public virtual Course Course { get; set; }

        public virtual ApplicationUser Author { get; set; }

    }
}
