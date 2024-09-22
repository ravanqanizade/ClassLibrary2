
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public  class Comment: BaseEntity
    {
        public string Text { get; set; }
        public string comment { get; set; }
        public int LikeCount { get; set; }
        public int ViewCount { get; set; }
        
        public ICollection<Post> Posts { get; set; }
    }

