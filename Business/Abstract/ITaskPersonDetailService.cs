using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITaskPersonDetailService
    {
        IDataResult<List<TaskPersonDetail>> GetAll();
        IDataResult<TaskPersonDetail> GetById(int taskPersonDetailId);
        IResult Add(TaskPersonDetail taskPersonDetail);
        IResult Delete(TaskPersonDetail taskPersonDetail);
        IResult Update(TaskPersonDetail taskPersonDetail);
    }
}
