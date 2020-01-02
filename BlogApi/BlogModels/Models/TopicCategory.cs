using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogModels.Models
{
    public class TopicCategory
    {
        public Guid TopicID { get; set; }
        public Guid CategoryID { get; set; }

        public virtual Topic Topic { get; set; }
        public virtual Category Category { get; set; }
    }
}
