﻿using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender.lib.Data.Linq2SQL;

namespace MailSender.lib.Services
{
    public class RecipientsDataProvider
    {
        private readonly MailSenderDBDataContext _db;

        public RecipientsDataProvider(MailSenderDBDataContext db)
        {

            _db = db;
        }

        public IEnumerable<Recipient> GetAll()
        {
            _db.Refresh(RefreshMode.OverwriteCurrentValues);
            return _db.Recipient.ToArray();
        }
    }
}
