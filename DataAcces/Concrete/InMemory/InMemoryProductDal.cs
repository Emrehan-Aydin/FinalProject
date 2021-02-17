using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAcces.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _product;
        public InMemoryProductDal()
        {
            _product = new List<Product>{
                new Product{CategoryId=1,ProductId=1,ProductName="Bardak",UnitInStock=15,UnitPrice=15},
                new Product{CategoryId=1,ProductId=2,ProductName="Kamera",UnitInStock=3,UnitPrice=500},
                new Product{CategoryId=1,ProductId=3,ProductName="Telefon",UnitInStock=5,UnitPrice=1500},
                new Product{CategoryId=2,ProductId=4,ProductName="Klavye",UnitInStock=65,UnitPrice=150},
                new Product{CategoryId=2,ProductId=5,ProductName="Fare",UnitInStock=1,UnitPrice=85}
            };
        }
        public void Add(Product product)
        {
            _product.Add(product);
        }

        public void Delete(Product product)
        {
            Product ProductToDelete = _product.SingleOrDefault(p=>p.ProductId==product.ProductId);
        }

        public List<Product> GetAll()
        {
            return _product;
        }

        public List<Product> GetAllByCategory(int CategoryId)
        {
            return _product.Where(p => p.CategoryId == CategoryId).ToList();
        }

        public void Update(Product product)
        {
            Product ProductToUpdate = _product.SingleOrDefault(p => p.ProductId == product.ProductId);
            ProductToUpdate.ProductName = product.ProductName;
            ProductToUpdate.CategoryId = product.CategoryId;
            ProductToUpdate.UnitInStock = product.UnitInStock;
            ProductToUpdate.UnitPrice= product.UnitPrice;
        }
    }
}
