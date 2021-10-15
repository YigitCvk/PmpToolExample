using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProjectLeaderService
    {
        IDataResult<List<ProjectLeader>> GetAll();
        IDataResult<ProjectLeader> GetById(int projectLeaderId);
        IResult Add(ProjectLeader projectLeader);
        IResult Delete(ProjectLeader projectLeader);
        IResult Update(ProjectLeader projectLeader);
    }
}
