using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        List<Product> GetAllByCategory(int CategoryId);
    }
}
