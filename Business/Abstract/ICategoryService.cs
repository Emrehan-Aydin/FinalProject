using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetAllById(int categoryId);
    }
}
