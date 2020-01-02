using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogModels.Models
{
    public class TopicsSubbed
    {
        public Guid TopicID { get; set; }
        public string UserID { get; set; }
        public bool MadeTopic { get; set; }

        public virtual Topic Topic { get; set; }
        public virtual User User { get; set; }
    }
}
