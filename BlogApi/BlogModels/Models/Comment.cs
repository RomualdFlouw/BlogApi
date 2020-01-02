using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogModels.Models
{
    public class Comment
    {
        [Key]
        public Guid CommentID { get; set; }
        [Required]
        public string CommentText { get; set; }
        public DateTime DateMade { get; set; }
        public int Upvotes { get; set; }
        public int Downvotes { get; set; }
        public Guid PostID { get; set; }
        public string UserName { get; set; }

        //public virtual Post Post { get; set; }
        //public virtual User User { get; set; }
    }
}
