using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogModels.Models
{
    public class Category
    {
        [Key]
        public Guid CategoryID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }

        public ICollection<TopicCategory> TopicCategories { get; set; }
        //public ICollection<Post> Posts { get; set; }

    }
}
