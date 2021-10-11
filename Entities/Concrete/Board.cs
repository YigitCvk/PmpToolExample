using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Board:IEntity
    {
        public string Name { get; set; }
        public int ProjectId { get; set; }
        public int Id { get; set; }
        public bool IsDescriptionRequired { get; set; }
        public int Status { get; set; }
    }
}
