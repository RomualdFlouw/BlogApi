using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogModels.Models
{
    public class Post
    {
        [Key]
        public Guid PostID { get; set; }
        [Required]
        public string Text { get; set; }
        public int Upvotes { get; set; }
        public int Downvotes { get; set; }
        public DateTime DateMade { get; set; }
        public Guid CategoryID { get; set; }


        //public ICollection<Comment> Comments { get; set; }
        //public virtual User User { get; set; }
        //public virtual Category Category { get; set; }

    }
}
