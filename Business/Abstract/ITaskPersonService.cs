using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITaskPersonService
    {
        IDataResult<List<TaskPerson>> GetAll();
        IDataResult<TaskPerson> GetById(int taskPersonId);
        IResult Add(TaskPerson taskPerson);
        IResult Delete(TaskPerson taskPerson);
        IResult Update(TaskPerson taskPerson);
    }
}
