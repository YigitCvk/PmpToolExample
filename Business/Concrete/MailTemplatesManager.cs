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
    public class MailTemplatesManager : IMailTemplatesService
    {
        IMailTemplatesDal _mailTemplatesDal;

        public MailTemplatesManager(IMailTemplatesDal mailTemplatesDal)
        {
            _mailTemplatesDal = mailTemplatesDal;
        }

        public IResult Add(MailTemplates mailTemplates)
        {
            _mailTemplatesDal.Add(mailTemplates);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(MailTemplates mailTemplates)
        {
            _mailTemplatesDal.Delete(mailTemplates);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<MailTemplates>> GetAll()
        {
            return new SuccessDataResult<List<MailTemplates>>(_mailTemplatesDal.GetAll());
        }

        public IDataResult<MailTemplates> GetById(int mailTemplatesId)
        {
            return new SuccessDataResult<MailTemplates>(_mailTemplatesDal.Get(m=>m.Id==mailTemplatesId));
        }

        public IResult Update(MailTemplates mailTemplates)
        {
            _mailTemplatesDal.Update(mailTemplates);
            return new SuccessResult(Messages.Updated);
        }
    }
}
