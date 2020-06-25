﻿using MailSender.lib.Entities;
using MailSender.lib.Services.Interfaces;

namespace MailSender.lib.Services.InMemory
{
    public class InMemoryServersDataProvider : InDataProvider<Server>, IServersDataProvider
    {
        public override void Edit(int id, Server item)
        {
            var db_item = GetById(id);
            if (db_item is null) return;

            db_item.Host = item.Host;
            db_item.Port = item.Port;
            db_item.UseSSL = item.UseSSL;
            db_item.UserName = item.UserName;
            db_item.Password = item.Password;
        }
    }
}
