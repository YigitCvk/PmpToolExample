using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModel
{
    public class MailViewModel
    {
        public List<MailSettings> MailSettingsList { get; set; }
        public List<MailTemplates> MailTemplatesList { get; set; }
    }
}
