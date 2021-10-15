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
    public class BoardTaskManager : IBoardTaskService
    {
        IBoardTaskDal _boardTaskDal;

        public BoardTaskManager(IBoardTaskDal boardTaskDal)
        {
            _boardTaskDal = boardTaskDal;
        }

        public IResult Add(BoardTask boardTask)
        {
            _boardTaskDal.Add(boardTask);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(BoardTask boardTask)
        {
            _boardTaskDal.Delete(boardTask);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<BoardTask>> GetAll()
        {
            return new SuccessDataResult<List<BoardTask>>(_boardTaskDal.GetAll());
        }

        public IDataResult<BoardTask> GetById(int boardTaskId)
        {
            return new SuccessDataResult<BoardTask>(_boardTaskDal.Get(b=>b.Id==boardTaskId));
        }

        public IResult Update(BoardTask boardTask)
        {
            _boardTaskDal.Update(boardTask);
            return new SuccessResult(Messages.Updated);
        }
    }
}
