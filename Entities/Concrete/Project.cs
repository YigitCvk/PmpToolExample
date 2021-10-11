﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Project:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public int ProjectLeader { get; set; }
        public int Status { get; set; }
    }
}
