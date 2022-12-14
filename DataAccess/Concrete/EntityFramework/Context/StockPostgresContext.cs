using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class StockPostgresContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=PostgreSQL; Database=StockAutomation;
                user Id=postgres; password=solo;
                Trusted_Connection =true");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category>Categories { get; set; }
        public DbSet<Employee>Employees { get; set; }
        public DbSet<Manager>Managers { get; set; }
    }
}
