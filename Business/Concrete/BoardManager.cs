using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Dal.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class BoardManager : IBoardService
    {
        IBoardDal _boardDal;

        public BoardManager(IBoardDal boardDal)
        {
            _boardDal = boardDal;
        }

        public IResult Add(Board board)
        {
            _boardDal.Add(board);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Board board)
        {
            _boardDal.Delete(board);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Board>> GetAll()
        {
            return new SuccessDataResult<List<Board>>(_boardDal.GetAll());
        }

        public IDataResult<Board> GetById(int boardId)
        {
            return new SuccessDataResult<Board>(_boardDal.Get(b=>b.Id==boardId));
        }

        public IResult Update(Board board)
        {
            _boardDal.Update(board);
            return new SuccessResult(Messages.Updated);
        }
        private IResult CheckIfBlogNameExists(string blogName)
        {
            var result = _boardDal.GetAll(b => b.Name == blogName).Any();
            if (result)
            {
                return new ErrorResult(Messages.NameAllReadyExists);
            }
            return new SuccessResult();
        }
    }
}
