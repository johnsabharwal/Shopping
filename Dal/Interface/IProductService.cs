using Dal.DTO;
using Dal.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Interface
{
    public interface IProductService
    {
        (int, List<Products>) GetProduts(int pageNo,int categoryId,string searchString);
        Products GetProdutDetails(int productId);

    }
}
