using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModel
{
    public class HomeViewModel
    {
        public List<Project> Project { get; set; }
        public List<ProjectLeader> ProjectLeader { get; set; }
        public List<ProjectPerson> ProjectPerson { get; set; }
     
    }
}
