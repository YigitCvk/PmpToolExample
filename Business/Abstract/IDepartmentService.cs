using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IDepartmentService
    {
        IDataResult<List<Department>> GetAll();
        IDataResult<Department> GetById(int departmentId);
        IResult Add(Department department);
        IResult Delete(Department department);
        IResult Update(Department department);


    }
}
