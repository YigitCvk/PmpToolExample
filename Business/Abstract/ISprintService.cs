using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISprintService
    {

        IDataResult<List<Sprint>> GetAll();
        IDataResult<Sprint> GetById(int sprintId);
        IResult Add(Sprint sprint);
        IResult Delete(Sprint sprint);
        IResult Update(Sprint sprint);
    }
}
