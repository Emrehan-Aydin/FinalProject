using Core.DataAccess.EntityFramework;
using DataAcces.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAcces.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NordWindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (NordWindContext context = new NordWindContext())
            {
                var result = from p in context.Products
                            join c in context.Categories
                            on p.CategoryId equals c.CategoryId
                            select new ProductDetailDto 
                            {
                                ProductId =p.ProductId,ProductName=p.ProductName,
                                CategoryName=c.CategoryName,UnitInStocks=p.UnitsInStock 
                            };
                return result.ToList();
            }
        }
    }
}
