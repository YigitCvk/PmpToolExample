using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class FailedTasks:IEntity
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public string FailDescription { get; set; }
        public int FailStatus { get; set; }
        public int ProjectId { get; set; }
    }
}
