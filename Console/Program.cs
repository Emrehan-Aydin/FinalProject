using Business.Concrete;
using DataAcces.Concrete.EntityFramework;
using DataAcces.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetAll();
            if(result.Success==false)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            //foreach (var item in productManager.GetAllByCategoryId(1).Data)
            //{
            //    Console.WriteLine(item.ProductName);
            //}
            //ProductTest();
            //CategoryTest();

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManagar = new CategoryManager(new EfCategoryDal());
            foreach (var item in categoryManagar.GetAll())
            {
                Console.WriteLine(item.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetProductDetails().Data)
            {
                Console.WriteLine(product.ProductName+" - "+product.CategoryName);
            }
        }
    }
}
