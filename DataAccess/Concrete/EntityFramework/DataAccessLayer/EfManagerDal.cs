using DataAccess.Abstract.DataAccessLayer;
using DataAccess.Abstract.Repository;
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
    public class EfManagerDal : IManagerDal
    {
        public void Add(Manager entity)
        {
            using StockPostgresContext context = new();
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Delete(Manager entity)
        {
            using StockPostgresContext context = new();
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public Manager Get(Expression<Func<Manager, bool>> filter)
        {
            using StockPostgresContext context = new();
            return context.Set<Manager>().SingleOrDefault(filter);
        }

        public List<Manager> GetAll(Expression<Func<Manager, bool>>? filter = null)
        {
            using StockPostgresContext context = new();
            return filter == null
                ? context.Set<Manager>().ToList()
                : context.Set<Manager>().Where(filter).ToList();
        }

        public void Update(Manager entity)
        {
            using StockPostgresContext context = new();
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
