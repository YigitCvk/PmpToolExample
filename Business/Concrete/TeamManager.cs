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
    public class TeamManager : ITeamService
    {
        ITeamDal _teamDal;

        public TeamManager(ITeamDal teamDal)
        {
            _teamDal = teamDal;
        }

        public IResult Add(Team team)
        {
            _teamDal.Add(team);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Team team)
        {

            _teamDal.Delete(team);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Team>> GetAll()
        {
            return new SuccessDataResult<List<Team>>(_teamDal.GetAll());
        }

        public IDataResult<Team> GetById(int teamId)
        {
            return new SuccessDataResult<Team>(_teamDal.Get(t=>t.Id==teamId));
        }

        public IResult Update(Team team)
        {

            _teamDal.Update(team);
            return new SuccessResult(Messages.Updated);
        }
    }
}
