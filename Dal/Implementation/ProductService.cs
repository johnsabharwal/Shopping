using Dal.DTO;
using Dal.Entities;
using Dal.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProductSize = Dal.DTO.ProductSize;

namespace Dal.Implementation
{
    public class ProductService : IProductService
    {
        DBContext dBContext;

        public ProductService(DBContext db)
        {
            dBContext = db;
        }
        public Products GetProdutDetails(int productId)
        {
            return dBContext.Product.Where(x => x.Id == productId).Select(
                x => new Products()
                {
                    Name = x.Name,
                    InStock = x.InStock,
                    DateCreated = x.DateCreated,
                    Price = x.Price,
                    ProductCode = x.ProductCode,
                    Id = x.Id,
                    CategoryId = x.CategoryId,
                    Ratings = x.ProductRatings.Select(y => new Rating() { GivenRating = y.Rating, RatingFrom = y.RatingFrom, userId = y.userId }).ToList(),

                    ProductColors = x.ProductColors.Select(y => new ProductColors() { Color = y.Color }).ToList(),
                    ProductImages = x.ProductsImages.Select(y => new ProductImages() { Path = y.ImagePath }).ToList(),
                    ProductSizes = x.ProductSizes.Select(y => new ProductSize() { Size = y.Size }).ToList(),
                    Category = new Category() { Id = x.CategoryId, Name = x.Category.Name },
                    Description = x.Description
                }).FirstOrDefault();
        }
        public (int,List<Products>) GetProduts(int pageNo, int categoryId, string searchString)
        {
            var data = dBContext.Product.Where(x => (x.CategoryId == categoryId || categoryId == 0)
              && (x.Name.Contains(searchString) || searchString == "" || searchString == null))
                .Select(x => new Products()
                {
                    Name = x.Name,
                    InStock = x.InStock,
                    DateCreated = x.DateCreated,
                    Price = x.Price,
                    ProductCode = x.ProductCode,
                    Id = x.Id,
                    CategoryId = x.CategoryId,
                    ProductColors = x.ProductColors.Select(y => new ProductColors() { Color = y.Color }).ToList(),
                    ProductImages = x.ProductsImages.Select(y => new ProductImages() { Path = y.ImagePath }).ToList(),
                    ProductSizes = x.ProductSizes.Select(y => new ProductSize() { Size = y.Size }).ToList(),
                    Category = new Category() { Id = x.CategoryId, Name = x.Category.Name },
                    Description = x.Description,
                    Ratings = x.ProductRatings.Select(y => new Rating() { GivenRating = y.Rating, RatingFrom = y.RatingFrom, userId = y.userId }).ToList(),
                });
            return (data.Count(), data.Skip(pageNo-1).Take(10).ToList());
        }
    }
}
