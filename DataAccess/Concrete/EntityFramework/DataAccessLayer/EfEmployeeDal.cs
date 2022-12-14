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
    public class EfEmployeeDal : IEntityRepository<Employee>
    {
        public void Add(Employee entity)
        {
            using (StockPostgresContext context = new StockPostgresContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Employee entity)
        {
            using (StockPostgresContext context = new StockPostgresContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Employee Get(Expression<Func<Employee, bool>> filter)
        {
            using (StockPostgresContext context = new StockPostgresContext())
            {
                return context.Set<Employee>().SingleOrDefault(filter);
            }
        }

        public List<Employee> GetAll(Expression<Func<Employee, bool>> filter = null)
        {
            using (StockPostgresContext context = new StockPostgresContext())
            {
                return filter == null
                    ? context.Set<Employee>().ToList()
                    : context.Set<Employee>().Where(filter).ToList();
            }
        }

        public void Update(Employee entity)
        {
            using (StockPostgresContext context = new StockPostgresContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
