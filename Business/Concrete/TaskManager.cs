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
    public class TaskManager : ITaskService
    {
        ITaskDal _taskDal;

        public TaskManager(ITaskDal taskDal)
        {
            _taskDal = taskDal;
        }

        public IResult Add(Task task)
        {
            _taskDal.Add(task);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Task task)
        {
            _taskDal.Delete(task);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Task>> GetAll()
        {
            return new SuccessDataResult<List<Task>>(_taskDal.GetAll());
        }

        public IDataResult<Task> GetById(int taskId)
        {
            return new SuccessDataResult<Task>(_taskDal.Get(t=>t.Id==taskId));
        }

        public IResult Update(Task task)
        {
            _taskDal.Update(task);
            return new SuccessResult(Messages.Updated);
        }
    }
}
