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
    public class PersonManager : IPersonService
    {
        IPersonDal _personDal;
        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }

        public IResult Add(Person person)
        {
            _personDal.Add(person);

            return new SuccessResult(Messages.PersonAdded);
        }

        public IResult Delete(Person person)
        {
            _personDal.Delete(person);
            return new SuccessResult(Messages.PersonDeleted);
        }

        public IDataResult<List<Person>> GetAll()
        {
            return new DataResult<List<Person>>(_personDal.GetAll(), true, Messages.PersonListed);
        }

        public IResult Update(Person person)
        {
            _personDal.Update(person);
            return new SuccessResult(Messages.PersonUpdated);
        }
    }
}
