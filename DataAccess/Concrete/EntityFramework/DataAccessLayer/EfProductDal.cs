﻿using DataAccess.Abstract.DataAccessLayer;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.DataAccessLayer
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            using StockPostgresContext context = new();
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Delete(Product entity)
        {
            using StockPostgresContext context = new();
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using StockPostgresContext context = new();
            return context.Set<Product>()
                .SingleOrDefault(filter);
        }

        public List<Product> GetAll(Expression<Func<Product, bool>>? filter = null)
        {
            using StockPostgresContext context = new();
            return filter == null
               ? context.Set<Product>().ToList()
               : context.Set<Product>().Where(filter).ToList();
        }

        public void Update(Product entity)
        {
            using StockPostgresContext context = new();
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
