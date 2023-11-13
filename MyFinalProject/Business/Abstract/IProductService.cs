using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;


namespace Business.Abstract
{
    public interface IProductService
    {
        IDateResult<List<Product>> GetAll();
        IDateResult<List<Product>> GetAllByCategoryId(int id);
        IDateResult<List<Product>> GetAllByUnitPrice(decimal min, decimal max);
        IDateResult<List<ProductDetailDto>> GetProductDetails();
        IDateResult<Product> GetById(int id);
        IResult Add(Product product);
    }
}
