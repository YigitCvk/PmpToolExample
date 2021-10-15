using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBoardTaskService
    {
        IDataResult<List<BoardTask>> GetAll();
        IDataResult<BoardTask> GetById(int boardTaskId);
        IResult Add(BoardTask boardTask);
        IResult Delete(BoardTask boardTask);

        IResult Update(BoardTask boardTask);

    }
}
