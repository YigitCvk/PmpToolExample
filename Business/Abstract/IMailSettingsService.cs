using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IMailSettingsService
    {
        IDataResult<List<MailSettings>> GetAll();
        IDataResult<MailSettings> GetById(int mailSettingsId);
        IResult Add(MailSettings mailSettings);
        IResult Delete(MailSettings mailSettings);
        IResult Update(MailSettings mailSettings);
    }
}
