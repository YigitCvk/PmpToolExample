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
    public class ProjectLeaderManager : IProjectLeaderService
    {
        IProjectLeaderDal _projectLeaderDal;

        public ProjectLeaderManager(IProjectLeaderDal projectLeaderDal)
        {
            _projectLeaderDal = projectLeaderDal;
        }

        public IResult Add(ProjectLeader projectLeader)
        {
            _projectLeaderDal.Add(projectLeader);
            return new SuccessResult(Messages.Added);

        }

        public IResult Delete(ProjectLeader projectLeader)
        {
            _projectLeaderDal.Delete(projectLeader);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<ProjectLeader>> GetAll()
        {
            return new SuccessDataResult<List<ProjectLeader>>(_projectLeaderDal.GetAll());
        }

        public IDataResult<ProjectLeader> GetById(int projectLeaderId)
        {
            return new SuccessDataResult<ProjectLeader>(_projectLeaderDal.Get(p=>p.Id==projectLeaderId));
        }

        public IResult Update(ProjectLeader projectLeader)
        {
            _projectLeaderDal.Update(projectLeader);
            return new SuccessResult(Messages.Updated);
        }
    }
}
