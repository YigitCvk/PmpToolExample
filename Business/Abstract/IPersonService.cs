using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPersonService
    {
        IDataResult<List<Person>> GetAll();
        IDataResult<Person> GetById(int personId);
        IResult Add(Person person);
        IResult Delete(Person person);
        IResult Update(Person person);
    }
}
