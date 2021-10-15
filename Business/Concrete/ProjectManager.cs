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
    public class ProjectManager : IProjectService
    {
        IProjectDal _projectDal;

        public ProjectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        public IResult Add(Project project)
        {
            _projectDal.Add(project);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Project project)
        {

            _projectDal.Delete(project);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Project>> GetAll()
        {
            return new SuccessDataResult<List<Project>>(_projectDal.GetAll());
        }

        public IDataResult<Project> GetById(int projectId)
        {
            return new SuccessDataResult<Project>(_projectDal.Get(p=>p.Id==projectId));
        }

        public IResult Update(Project project)
        {
            _projectDal.Update(project);
            return new SuccessResult(Messages.Updated);
        }
    }
}
