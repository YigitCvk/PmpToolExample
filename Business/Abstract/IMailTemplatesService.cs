using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IMailTemplatesService
    {

        IDataResult<List<MailTemplates>> GetAll();
        IDataResult<MailTemplates> GetById(int mailTemplatesId);
        IResult Add(MailTemplates mailTemplates);
        IResult Delete(MailTemplates mailTemplates);
        IResult Update(MailTemplates mailTemplates);
    }
}
