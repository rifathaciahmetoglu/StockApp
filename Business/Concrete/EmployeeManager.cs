using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract.DataAccessLayer;
using DataAccess.Concrete.EntityFramework.DataAccessLayer;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _employeeDal;
        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal=employeeDal;
        }

        public IResult Add(Employee employee)
        {
            _employeeDal.Add(employee);

            return new SuccessResult(Messages.EmployeeAdded);
        }

        public IResult Delete(Employee employee)
        {
            _employeeDal.Delete(employee);
            return new SuccessResult(Messages.EmployeeDeleted);
        }

        public IDataResult<List<Employee>> GetAll()
        {
            return new DataResult<List<Employee>>(_employeeDal.GetAll(), true, Messages.EmployeesListed);
        }

        public IDataResult<List<UserDetailDto>> GetUserDetails()
        {
            return new SuccessDataResult<List<UserDetailDto>>(_employeeDal.GetUserDetails());
        }

        public IResult Update(Employee employee)
        {
            _employeeDal.Update(employee);
            return new SuccessResult(Messages.EmployeeUpdated);
        }

    }
}
