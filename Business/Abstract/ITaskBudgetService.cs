using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITaskBudgetService
    {
        IDataResult<List<TaskBudget>> GetAll();
        IDataResult<TaskBudget> GetById(int taskBudgetId);
        IResult Add(TaskBudget taskBudget);
        IResult Delete(TaskBudget taskBudget);
        IResult Update(TaskBudget taskBudget);
    }
}
