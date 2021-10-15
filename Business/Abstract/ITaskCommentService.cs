using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITaskCommentService
    {
        IDataResult<List<TaskComment>> GetAll();
        IDataResult<TaskComment> GetById(int taskCommentId);
        IResult Add(TaskComment taskComment);
        IResult Delete(TaskComment taskComment);
        IResult Update(TaskComment taskComment);
    }
}
