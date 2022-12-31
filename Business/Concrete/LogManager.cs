using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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
    public class LogManager : ILogService
    {
        ILogDal _logDal;
        public LogManager(ILogDal logDal)
        {
            _logDal = logDal;
        }

        public IResult Add(Log log)
        {
            _logDal.Add(log);
            return new SuccessResult(Messages.LogAdded);
        }

        public IDataResult<List<Log>> GetAll()
        {
            return new DataResult<List<Log>>(_logDal.GetAll(),true,Messages.LogListed);
        }
    }
}
