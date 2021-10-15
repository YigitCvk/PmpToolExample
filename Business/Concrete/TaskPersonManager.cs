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
    public class TaskPersonManager : ITaskPersonService
    {
        ITaskPersonDal _taskPersonDal;

        public TaskPersonManager(ITaskPersonDal taskPersonDal)
        {
            _taskPersonDal = taskPersonDal;
        }

        public IResult Add(TaskPerson taskPerson)
        {
            _taskPersonDal.Add(taskPerson);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(TaskPerson taskPerson)
        {
            _taskPersonDal.Delete(taskPerson);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<TaskPerson>> GetAll()
        {
            return new SuccessDataResult<List<TaskPerson>>(_taskPersonDal.GetAll());
        }

        public IDataResult<TaskPerson> GetById(int taskPersonId)
        {
            return new SuccessDataResult<TaskPerson>(_taskPersonDal.Get(t=>t.Id==taskPersonId));
        }

        public IResult Update(TaskPerson taskPerson)
        {
            _taskPersonDal.Update(taskPerson);
            return new SuccessResult(Messages.Updated);
        }
    }
}
