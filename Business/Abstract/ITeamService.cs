using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITeamService
    {
        IDataResult<List<Team>> GetAll();
        IDataResult<Team> GetById(int teamId);
        IResult Add(Team team);
        IResult Delete(Team team);
        IResult Update(Team team);
    }
}
