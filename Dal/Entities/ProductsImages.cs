using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Entities
{
   public class ProductsImages
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public Product Product { get; set; }

    }

}
