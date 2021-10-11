using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class ProjectLeader:IEntity
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int PersonId { get; set; }
    }
}
