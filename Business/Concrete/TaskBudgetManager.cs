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
    public class TaskBudgetManager : ITaskBudgetService
    {
        ITaskBudgetDal _taskBudgetDal;

        public TaskBudgetManager(ITaskBudgetDal taskBudgetDal)
        {
            _taskBudgetDal = taskBudgetDal;
        }

        public IResult Add(TaskBudget taskBudget)
        {
            _taskBudgetDal.Add(taskBudget);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(TaskBudget taskBudget)
        {
            _taskBudgetDal.Add(taskBudget);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<TaskBudget>> GetAll()
        {
            return new SuccessDataResult<List<TaskBudget>>(_taskBudgetDal.GetAll());
        }

        public IDataResult<TaskBudget> GetById(int taskBudgetId)
        {
            return new SuccessDataResult<TaskBudget>(_taskBudgetDal.Get(t=>t.Id==taskBudgetId));
        }

        public IResult Update(TaskBudget taskBudget)
        {
            _taskBudgetDal.Update(taskBudget);
            return new SuccessResult(Messages.Updated);
        }
    }
}
