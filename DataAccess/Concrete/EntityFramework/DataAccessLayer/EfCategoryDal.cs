﻿using DataAccess.Abstract.DataAccessLayer;
using Core.DataAccess;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework.DataAccessLayer
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category,StockPostgresContext>, ICategoryDal
    {
        
    }
}
