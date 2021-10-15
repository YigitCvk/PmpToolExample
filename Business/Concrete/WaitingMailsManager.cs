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
    public class WaitingMailsManager : IWaitingMailsService
    {
        IWaitingMailsDal _waitingMailsDal;
        public IResult Add(WaitingMails waitingMails)
        {
            _waitingMailsDal.Add(waitingMails);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(WaitingMails waitingMails)
        {
            _waitingMailsDal.Delete(waitingMails);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<WaitingMails>> GetAll()
        {
            return new SuccessDataResult<List<WaitingMails>>(_waitingMailsDal.GetAll());
        }

        public IDataResult<WaitingMails> GetById(int waitingMailsId)
        {
            return new SuccessDataResult<WaitingMails>(_waitingMailsDal.Get(w=>w.Id==waitingMailsId));
        }

        public IResult Update(WaitingMails waitingMails)
        {
            _waitingMailsDal.Update(waitingMails);
            return new SuccessResult(Messages.Updated);
        }
    }
}
