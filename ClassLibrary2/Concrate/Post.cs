using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   
        public class Post : BaseEntity
        {
            public int Id { get; set; }
            public string Text { get; set; }
            public string Comment { get; set; }
            public int LikeCount { get; set; }
            public int ViewCount { get; set; }
            
            public int UserId { get; set; }

            public User User { get; set; }

            public ICollection<Comment> Comments { get; set; }
        }
    

