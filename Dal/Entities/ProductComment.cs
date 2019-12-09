using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Entities
{
    public class ProductComment
    {
        public ProductComment()
        {
            CommentImages = new HashSet<CommentImage>();
        }
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int RatingGiven { get; set; }

        public string UserComment { get; set; }
        public DateTime DateCreated { get; set; }
        public Product Product { get; set; }
        public User User { get; set; }
        public ICollection<CommentImage> CommentImages { get; set; }
    }
}
