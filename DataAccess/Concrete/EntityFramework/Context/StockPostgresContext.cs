using DataAccess.Concrete.EntityFramework.DataAccessLayer;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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
            optionsBuilder.UseNpgsql(@"server=localhost; database=StockAutomation;
                user Id=postgres; password=12345; Integrated Security=false");
        }
        public DbSet<Product>? products { get; set; }
        public DbSet<Category>? categories { get; set; }
        public DbSet<Employee>? employees { get; set; }
        public DbSet<Person>? persons { get; set; }
        public DbSet<Log> logs { get; set; }

    }
}
