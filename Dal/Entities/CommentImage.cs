using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Entities
{
   public class CommentImage
    {
        public int Id { get; set; }
        public int ProductCommentId { get; set; }
        public string ImagePath { get; set; }
        public ProductComment ProductComment { get; set; }
    }
}
