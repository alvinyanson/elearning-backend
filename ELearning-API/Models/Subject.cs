﻿namespace ELearning_API.Models
{
    public class Subject : BaseEntity
    {
        public string Name { get; set; }
        public Guid OwnerId { get; set; }
        public bool IsPublished { get; set; }

        public List<Course> Courses { get; set; }
    }
}
