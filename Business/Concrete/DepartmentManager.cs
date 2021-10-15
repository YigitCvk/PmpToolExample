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
    public class DepartmentManager : IDepartmentService
    {
        IDepartmentDal _departmentDal;

        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }

        public IResult Add(Department department)
        {
            _departmentDal.Add(department);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Department department)
        {
            _departmentDal.Delete(department);
            return new SuccessResult(Messages.Deleted);

        }

        public IDataResult<List<Department>> GetAll()
        {
            return new SuccessDataResult<List<Department>>(_departmentDal.GetAll());
        }

        public IDataResult<Department> GetById(int departmentId)
        {
            return new SuccessDataResult<Department>(_departmentDal.Get(d=>d.Id==departmentId));
        }

        public IResult Update(Department department)
        {
            _departmentDal.Update(department);
            return new SuccessResult();
        }
    }
}
