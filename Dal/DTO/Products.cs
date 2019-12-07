using Dal.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.DTO
{
    public class Products
    {
        public Products()
        {
            ProductImages = new List<ProductImages>();
            ProductColors = new List<ProductColors>();
            ProductSizes = new List<ProductSize>();
            Category = new Category();
            Ratings = new List<Rating>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string ProductCode { get; set; }
        public decimal Price { get; set; }
        public DateTime DateCreated { get; set; }
        public string Description{ get; set; }
        public int Status { get; set; }

        public bool InStock { get; set; }
        public Category Category { get; set; }
        public  List<ProductImages> ProductImages { get; set; }
        public List<ProductColors> ProductColors { get; set; }
        public List<ProductSize> ProductSizes { get; set; }
        public List<Rating> Ratings { get; set; }
    }
    public class ProductImages
    {
        public string Path { get; set; }
    }
    public class ProductColors
    {
        public string Color { get; set; }
    }
    public class ProductSize
    {
        public string Size { get; set; }
    }
    public class Categorys
    {
        public int Id { get; set; }
        public string Value { get; set; }

    }
    public class Rating
    {
        public int GivenRating { get; set; }
        public int userId { get; set; }
        public int RatingFrom { get; set; }
    }
}
