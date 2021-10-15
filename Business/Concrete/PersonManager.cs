using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Dal.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

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
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Person person)
        {
            _personDal.Delete(person);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Person>> GetAll()
        {
            return new SuccessDataResult<List<Person>>(_personDal.GetAll());
        }

        public IDataResult<Person> GetById(int personId)
        {
            return new SuccessDataResult<Person>(_personDal.Get(p=>p.Id==personId));
        }

        public IResult Update(Person person)
        {
            _personDal.Update(person);
            return new SuccessResult(Messages.Updated);
        }
    }
}
