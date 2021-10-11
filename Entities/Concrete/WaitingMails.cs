
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class WaitingMails:IEntity
    {
        public int Id { get; set; }
        public int PersonId{ get; set; }
        public int Status { get; set; }
        public string Context { get; set; }
        public DateTime SaveDate { get; set; }
    }
}
