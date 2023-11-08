
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

ProductManager productManager = new ProductManager(new EfProductDal());



Console.WriteLine("-------------------------------------");

foreach (var product in productManager.GetAllByUnitPrice(50,100))
{
    Console.WriteLine(product.ProductName);
}
