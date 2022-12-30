﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract.DataAccessLayer;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
           _categoryDal=categoryDal;
        }
        public IDataResult<List<Category>> GetAll()
        {
            return new DataResult<List<Category>>(_categoryDal.GetAll(),true,Messages.CategoryListed);
        }
    }
}
