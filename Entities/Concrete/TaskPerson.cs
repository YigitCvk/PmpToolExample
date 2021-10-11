
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class TaskPerson:IEntity
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int PersonId { get; set; }
        public string Description { get; set; }
    }
}
