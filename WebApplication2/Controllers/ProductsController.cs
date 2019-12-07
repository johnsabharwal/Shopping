using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dal.common;
using Dal.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public JsonResult GetProducts(int page, int categoryId, string searchString)
        {

            var products = _productService.GetProduts(page, categoryId, searchString);
            if (products.Item2.Count > 0)
            {
                return new JsonResult(new Response()
                {
                    Status = Dal.Enum.ResponseTypes.ok,
                    Data = new { Products = products.Item2, Total = products.Item1 }
                });
            }
            else
            {
                return new JsonResult(new Response()
                {
                    Status = Dal.Enum.ResponseTypes.noData,
                });
            }
        }
        [HttpGet]
        public JsonResult GetProductDetail(int productId)
        {
            var product = _productService.GetProdutDetails(productId);
            if (product != null)
                return new JsonResult(new Response()
                {
                    Status = Dal.Enum.ResponseTypes.ok,
                    Data = product
                });
            else
                return new JsonResult(new Response()
                {
                    Status = Dal.Enum.ResponseTypes.invalid,
                });
        }
    }
}