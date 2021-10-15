using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITaskFileService
    {
        IDataResult<List<TaskFile>> GetAll();
        IDataResult<TaskFile> GetById(int taskFileId);
        IResult Add(TaskFile taskFile);
        IResult Delete(TaskFile taskFile);
        IResult Update(TaskFile taskFile);
    }
}
