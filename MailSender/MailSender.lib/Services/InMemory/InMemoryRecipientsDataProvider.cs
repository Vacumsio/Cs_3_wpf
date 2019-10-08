using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender.lib.Entities;
using MailSender.lib.Services.Interfaces;

namespace MailSender.lib.Services.InMemory
{
    public class InMemoryRecipientsDataProvider : InDataProvider<Recipient>
    {
        public override void Edit(int id, Recipient item)
        {
            var db_item = GetById(id);
            if (db_item is null) return;
            db_item.Name = item.Name;
            db_item.Address = item.Address;
        }
    }


    public class InMemoryServersDataProvider : InDataProvider<Server>
    {
        public override void Edit(int id, Server item)
        {
            var db_item = GetById(id);
            if (db_item is null) return;
            db_item.Name = item.Name;
            db_item.Address = item.Address;
        }
    }

    public class InMemorySendersDataProvider : InDataProvider<Sender>
    {
        public override void Edit(int id, Sender item)
        {
            var db_item = GetById(id);
            if (db_item is null) return;
            db_item.Name = item.Name;
            db_item.Address = item.Address;
        }
    }

    public class InMemoryEmailDataProvider : InDataProvider<Email>
    {
        public override void Edit(int id, Email item)
        {
            var db_item = GetById(id);
            if (db_item is null) return;
            db_item.Subject = item.Subject;
            db_item.Body = item.Body;
        }
    }
}
