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
    public class TaskFileManager : ITaskFileService
    {
        ITaskFileDal _taskFileDal;

        public TaskFileManager(ITaskFileDal taskFileDal)
        {
            _taskFileDal = taskFileDal;
        }

        public IResult Add(TaskFile taskFile)
        {
            _taskFileDal.Add(taskFile);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(TaskFile taskFile)
        {
            _taskFileDal.Delete(taskFile);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<TaskFile>> GetAll()
        {
            return new SuccessDataResult<List<TaskFile>>(_taskFileDal.GetAll());
        }

        public IDataResult<TaskFile> GetById(int taskFileId)
        {
            return new SuccessDataResult<TaskFile>(_taskFileDal.Get(t=>t.Id==taskFileId));
        }

        public IResult Update(TaskFile taskFile)
        {
            _taskFileDal.Update(taskFile);
            return new SuccessResult(Messages.Updated);
        }
    }
}
