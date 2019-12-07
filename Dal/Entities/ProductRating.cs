using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Entities
{
    public class ProductRating
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int userId { get; set; }
        public int Rating { get; set; }
        public int RatingFrom { get; set; }
        public Product Product { get; set; }
        public User User { get; set; }

    }
}
