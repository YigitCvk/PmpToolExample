using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Person:IEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int TeamId { get; set; }
        public int Status { get; set; }
        public bool IsAdmin { get; set; }
        public int Id { get; set; }
        public int RoleId { get; set; }
    }
}
