﻿using Core.Dal.EntityFramework;
using Dal.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Concrete
{
    public class EfSprintDal : EfEntityRepositoryBase<Sprint, PmpContext>, ISprintDal
    {
    }
}