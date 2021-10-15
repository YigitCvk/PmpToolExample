
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
    public class MailSettingsManager : IMailSettingsService
    {
        IMailSettingsDal _mailSettingsDal;

        public MailSettingsManager(IMailSettingsDal mailSettingsDal)
        {
            _mailSettingsDal = mailSettingsDal;
        }

        public IResult Add(MailSettings mailSettings)
        {
            _mailSettingsDal.Add(mailSettings);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(MailSettings mailSettings)
        {
            _mailSettingsDal.Delete(mailSettings);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<MailSettings>> GetAll()
        {
            return new SuccessDataResult<List<MailSettings>>(_mailSettingsDal.GetAll());
        }

        public IDataResult<MailSettings> GetById(int mailSettingsId)
        {
            return new SuccessDataResult<MailSettings>(_mailSettingsDal.Get(m=>m.Id==mailSettingsId));
        }

        public IResult Update(MailSettings mailSettings)
        {
            _mailSettingsDal.Update(mailSettings);
            return new SuccessResult(Messages.Updated);
        }
    }
}
