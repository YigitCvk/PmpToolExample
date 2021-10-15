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
    public class SprintManager : ISprintService
    {
        ISprintDal _sprintDal;

        public SprintManager(ISprintDal sprintDal)
        {
            _sprintDal = sprintDal;
        }

        public IResult Add(Sprint sprint)
        {
            _sprintDal.Add(sprint);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Sprint sprint)
        {
            _sprintDal.Delete(sprint);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Sprint>> GetAll()
        {
            return new SuccessDataResult<List<Sprint>>(_sprintDal.GetAll());
        }

        public IDataResult<Sprint> GetById(int sprintId)
        {
            return new SuccessDataResult<Sprint>(_sprintDal.Get(s=>s.Id==sprintId));
        }

        public IResult Update(Sprint sprint)
        {
            _sprintDal.Update(sprint);
            return new SuccessResult(Messages.Updated);
        }
    }
}
