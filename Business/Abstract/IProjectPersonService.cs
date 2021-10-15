using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProjectPersonService
    {
        IDataResult<List<ProjectPerson>> GetAll();
        IDataResult<ProjectPerson> GetById(int projectPersonId);
        IResult Add(ProjectPerson projectPerson);
        IResult Delete(ProjectPerson projectPerson);
        IResult Update(ProjectPerson projectPerson);
    }
}
