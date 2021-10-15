using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IFailedTasksService
    {
        IDataResult<List<FailedTasks>> GetAll();
        IDataResult<FailedTasks> GetById(int failedTasksId);
        IResult Add(FailedTasks failedTasks);
        IResult Delete(FailedTasks failedTasks);
        IResult Update(FailedTasks failedTasks);

    }
}
