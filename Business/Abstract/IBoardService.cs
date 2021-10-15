using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBoardService
    {
        IDataResult<List<Board>> GetAll();
        IDataResult<Board> GetById(int boardId);
        IResult Add(Board board);
        IResult Delete(Board board);
        IResult Update(Board board);
    }
}
