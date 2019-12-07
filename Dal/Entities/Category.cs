using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Entities
{
    public class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
