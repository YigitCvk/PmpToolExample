using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IWaitingMailsService
    {
        IDataResult<List<WaitingMails>> GetAll();
        IDataResult<WaitingMails> GetById(int waitingMailsId);
        IResult Add(WaitingMails waitingMails);
        IResult Delete(WaitingMails waitingMails);
        IResult Update(WaitingMails waitingMails);
    }
}
