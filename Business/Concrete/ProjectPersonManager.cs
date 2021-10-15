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
    public class ProjectPersonManager : IProjectPersonService
    {
        IProjectPersonDal _projectPersonDal;

        public ProjectPersonManager(IProjectPersonDal projectPersonDal)
        {
            _projectPersonDal = projectPersonDal;
        }

        public IResult Add(ProjectPerson projectPerson)
        {
            _projectPersonDal.Add(projectPerson);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(ProjectPerson projectPerson)
        {
            _projectPersonDal.Delete(projectPerson);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<ProjectPerson>> GetAll()
        {
            return new SuccessDataResult<List<ProjectPerson>>(_projectPersonDal.GetAll());
        }

        public IDataResult<ProjectPerson> GetById(int projectPersonId)
        {
            return new SuccessDataResult<ProjectPerson>(_projectPersonDal.Get(p=>p.Id==projectPersonId));
        }

        public IResult Update(ProjectPerson projectPerson)
        {
            _projectPersonDal.Update(projectPerson);
            return new SuccessResult(Messages.Updated);
        }
    }
}
