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
    public class TaskPersonDetailManager : ITaskPersonDetailService
    {
        ITaskPersonDetailDal _taskPersonDetailDal;

        public TaskPersonDetailManager(ITaskPersonDetailDal taskPersonDetailDal)
        {
            _taskPersonDetailDal = taskPersonDetailDal;
        }

        public IResult Add(TaskPersonDetail taskPersonDetail)
        {
            _taskPersonDetailDal.Add(taskPersonDetail);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(TaskPersonDetail taskPersonDetail)
        {
            _taskPersonDetailDal.Delete(taskPersonDetail);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<TaskPersonDetail>> GetAll()
        {
            return new SuccessDataResult<List<TaskPersonDetail>>(_taskPersonDetailDal.GetAll());
        }

        public IDataResult<TaskPersonDetail> GetById(int taskPersonDetailId)
        {
            return new SuccessDataResult<TaskPersonDetail>(_taskPersonDetailDal.Get(t=>t.Id==taskPersonDetailId));
        }

        public IResult Update(TaskPersonDetail taskPersonDetail)
        {
            _taskPersonDetailDal.Update(taskPersonDetail);
            return new SuccessResult(Messages.Updated);
        }
    }
}
