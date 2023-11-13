using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

public class Program
{
    public static void Main(string[] args)
    {

        ProductTest();
    }

    private static void CategoryTest()
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        foreach (var category in categoryManager.GetAll())
        {
            Console.WriteLine(category.CategoryName);
        }
    }
    private static void ProductTest()
    {
        ProductManager productManager = new ProductManager(new EfProductDal());

        //foreach (var product in productManager.GetProductDetails())
        //{
        //    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
        //}

    }


}
