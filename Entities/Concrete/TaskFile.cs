
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class TaskFile:IEntity
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public int TaskId { get; set; }
    }
}
