using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogModels.Models
{
    public class User : IdentityUser
    {
        [Required]
        public DateTime Birthday { get; set; }
     
        public ICollection<TopicsSubbed> TopicsSubbed { get; set; }
        //public ICollection<Comment> Comments { get; set; }
        //public ICollection<Post> Posts { get; set; }
    }
}
