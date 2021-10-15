using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Dal.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RoleManager : IRoleService
    {
        IRoleDal _roleDal;

        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        public IResult Add(Role role)
        {
            _roleDal.Add(role);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Role role)
        {
            _roleDal.Delete(role);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Role>> GetAll()
        {
            return new SuccessDataResult<List<Role>>(_roleDal.GetAll());
        }

        public IDataResult<Role> GetById(int roleId)
        {
            return new SuccessDataResult<Role>(_roleDal.Get(p=>p.Id==roleId));
        }

        public IResult Update(Role role)
        {
            _roleDal.Update(role);
            return new SuccessResult(Messages.Updated);
        }
    }
}
