using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumApp.Data.Models
{
    public class PostReplay
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Creation { get; set; }
        
        public virtual ApplicationUser User { get; set; }
        public virtual Post Post { get; set; }
    }
}
