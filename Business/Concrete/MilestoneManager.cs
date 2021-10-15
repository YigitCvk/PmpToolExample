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
    public class MilestoneManager : IMilestoneService
    {
        IMilesStoneDal _milestoneDal;

        public MilestoneManager(IMilesStoneDal milestoneDal)
        {
            _milestoneDal = milestoneDal;
        }

        public IResult Add(Milestone milestone)
        {
            _milestoneDal.Add(milestone);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Milestone milestone)
        {
            _milestoneDal.Delete(milestone);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Milestone>> GetAll()
        {
            return new SuccessDataResult<List<Milestone>>(_milestoneDal.GetAll());
        }

        public IDataResult<Milestone> GetById(int milestoneId)
        {
            return new SuccessDataResult<Milestone>(_milestoneDal.Get(m=>m.Id==milestoneId));
        }

        public IResult Update(Milestone milestone)
        {
            _milestoneDal.Update(milestone);
            return new SuccessResult(Messages.Updated);
        }
    }
}
