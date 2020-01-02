using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogModels.Models
{
    public class Topic
    {
        [Key]
        public Guid TopicID { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public int AmountMembers { get; set; }
        public DateTime Birthdate { get; set; }

        public ICollection<TopicsSubbed> TopicsSubbed { get; set; }
        public ICollection<TopicCategory> TopicCategories { get; set; }


    }
}
