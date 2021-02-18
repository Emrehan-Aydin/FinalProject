using Core.DataAccess.EntityFramework;
using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAcces.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NordWindContext>, ICategoryDal
    {

    }
}
