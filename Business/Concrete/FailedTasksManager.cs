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
    public class FailedTasksManager : IFailedTasksService
    {
        IFailedTasksDal _failedTaksDal;

        public FailedTasksManager(IFailedTasksDal failedTaksDal)
        {
            _failedTaksDal = failedTaksDal;
        }

        public IResult Add(FailedTasks failedTasks)
        {
            _failedTaksDal.Add(failedTasks);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(FailedTasks failedTasks)
        {
            _failedTaksDal.Delete(failedTasks);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<FailedTasks>> GetAll()
        {
            return new SuccessDataResult<List<FailedTasks>>(_failedTaksDal.GetAll());
        }

        public IDataResult<FailedTasks> GetById(int failedTasksId)
        {
            return new SuccessDataResult<FailedTasks>(_failedTaksDal.Get(f=>f.Id==failedTasksId));
        }

        public IResult Update(FailedTasks failedTasks)
        {
            _failedTaksDal.Update(failedTasks);
            return new SuccessResult(Messages.Updated);
        }
    }
}
