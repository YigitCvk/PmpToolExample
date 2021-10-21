using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModel
{
    public class TaskViewModel
    {
        public List<Task> TasksList { get; set; }
        public List<TaskBudget> TaskBudgetsList { get; set; }
        public List<TaskComment> TaskCommentList { get; set; }
        public List<TaskFile> TaskFileList { get; set; }
        public List<TaskPerson> TaskPersonList { get; set; }
        public List<TaskPersonDetail> TaskPersonDetailList { get; set; }
    }
}
