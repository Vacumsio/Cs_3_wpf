﻿using MailSender.lib.Entities;
using MailSender.lib.Services.Interfaces;
using System.Linq;

namespace MailSender.lib.Services.InMemory
{
    public class InMemoryEmailsDataProvider : InDataProvider<Email>, IEmailsDataProvider
    {
        public InMemoryEmailsDataProvider()
        {
            //_Items.Add(new Email { Id = 0, Subject = "Messege 1", Body = "Body msg" });
            _Items.AddRange(Enumerable.Range(1, 20).Select(i => new Email { Id = i, Subject = $"Сообщение  {i}", Body=$"Тело письма {i}"}));
        }

        public override void Edit(int id, Email item)
        {
            var db_item = GetById(id);
            if (db_item is null) return;

            db_item.Subject = item.Subject;
            db_item.Body = item.Body;
        }
    }
}
