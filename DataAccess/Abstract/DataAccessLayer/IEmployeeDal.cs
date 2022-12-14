using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract.DataAccessLayer
{
    public interface IEmployeeDal
    {
        List<Employee> getAll { get; }

        List<Employee> GetAll();
    }
}
