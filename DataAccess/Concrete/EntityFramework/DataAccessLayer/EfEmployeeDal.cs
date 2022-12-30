using DataAccess.Abstract.DataAccessLayer;
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
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework.DataAccessLayer
{
    public class EfEmployeeDal : EfEntityRepositoryBase<Employee, StockPostgresContext>, IEmployeeDal
    {
        public List<UserDetailDto> GetUserDetails()
        {
            using(StockPostgresContext context=new())
            {
                var result = from e in context.employees
                             join p in context.persons
                             on e.PersonId equals p.PersonId
                             
                             select new UserDetailDto
                             {
                                 EmployeeId = e.EmployeeId,
                                 UserId= e.UserId,
                                 FirstName = p.FirstName,
                                 LastName = p.LastName,
                                 Phone = p.Phone,
                                 Email = p.Email,
                                 Adress = p.Adress,
                                 Username = e.Username,
                                 Password = e.Password
                             };
                return result.ToList();
            }
        }
    }
}
