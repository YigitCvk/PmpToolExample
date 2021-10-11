
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class TaskComment:IEntity
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int PersonId { get; set; }
        public string Comment { get; set; }
        public bool Status { get; set; }
        public DateTime DateTime { get; set; }

    }
}
