using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProjectService
    {
        IDataResult<List<Project>> GetAll();
        IDataResult<Project> GetById(int projectId);
        IResult Add(Project project);
        IResult Delete(Project project);
        IResult Update(Project project);
    }
}
