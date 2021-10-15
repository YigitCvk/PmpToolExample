using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IMilestoneService
    {
        IDataResult<List<Milestone>> GetAll();
        IDataResult<Milestone> GetById(int milestoneId);
        IResult Add(Milestone milestone);
        IResult Delete(Milestone milestone);
        IResult Update(Milestone milestone);
    }
}
