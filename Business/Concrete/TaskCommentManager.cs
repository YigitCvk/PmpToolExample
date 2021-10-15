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
    public class TaskCommentManager : ITaskCommentService
    {
        ITaskCommentDal _taskCommentDal;

        public TaskCommentManager(ITaskCommentDal taskCommentDal)
        {
            _taskCommentDal = taskCommentDal;
        }

        public IResult Add(TaskComment taskComment)
        {
            _taskCommentDal.Add(taskComment);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(TaskComment taskComment)
        {
            _taskCommentDal.Delete(taskComment);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<TaskComment>> GetAll()
        {
            return new SuccessDataResult<List<TaskComment>>(_taskCommentDal.GetAll());
        }

        public IDataResult<TaskComment> GetById(int taskCommentId)
        {
            return new SuccessDataResult<TaskComment>(_taskCommentDal.Get(t=>t.Id==taskCommentId));
        }

        public IResult Update(TaskComment taskComment)
        {
            _taskCommentDal.Update(taskComment);
            return new SuccessResult(Messages.Updated);
        }
    }
}
