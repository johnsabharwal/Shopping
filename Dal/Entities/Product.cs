using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Entities
{
    public class Product
    {
        public Product()
        {
            ProductColors = new HashSet<ProductColor>();
            ProductSizes = new HashSet<ProductSize>();
            ProductsImages = new HashSet<ProductsImages>();
            OrderDetails = new HashSet<OrderDetails>();
            ProductComments = new HashSet<ProductComment>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string ProductCode { get; set; }
        public decimal Price { get; set; }
        public DateTime DateCreated { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public decimal ShippingCost { get; set; }
        public bool InStock { get; set; }
        public Category Category { get; set; }

        public ICollection<ProductColor> ProductColors { get; set; }
        public ICollection<ProductSize> ProductSizes { get; set; }
        public ICollection<ProductsImages> ProductsImages { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
        public ICollection<ProductComment> ProductComments { get; set; }

    }
}
