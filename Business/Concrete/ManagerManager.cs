using Business.Abstract;
using DataAccess.Abstract.DataAccessLayer;
using DataAccess.Concrete.EntityFramework.DataAccessLayer;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ManagerManager : IManagerService
    {
        IManagerDal _managerDal;

        public ManagerManager(IManagerDal managerDal)
        {
            _managerDal = managerDal;
        }

        public List<Manager> GetAll()
        {
            return _managerDal.GetAll();
        }
    }
}
