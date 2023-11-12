using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1,ProductName="Bardak",UnitPrice=150,UnitsInStock=20},
                new Product{ProductId=2, CategoryId=1,ProductName="Çatal Kaşık Seti",UnitPrice=200,UnitsInStock=50},
                new Product{ProductId=3, CategoryId=2,ProductName="Telefon",UnitPrice=50000,UnitsInStock=30},
                new Product{ProductId=4, CategoryId=2,ProductName="Laptop",UnitPrice=60000,UnitsInStock=20},
                new Product{ProductId=5, CategoryId=2,ProductName="Kamera",UnitPrice=30000,UnitsInStock=40},
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.Find(x => x.ProductId == product.ProductId);

            _products.Remove(productToDelete);

        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(x=>x.CategoryId == categoryId).ToList();

        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.Find(x => x.ProductId == product.ProductId);

            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }
    }
}
