
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class TaskBudget:IEntity
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public string Budget { get; set; }
        public int BudgetType { get; set; }
    }
}
