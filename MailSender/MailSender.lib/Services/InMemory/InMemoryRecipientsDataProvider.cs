﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender.lib.Entities;
using MailSender.lib.Services.Interfaces;

namespace MailSender.lib.Services.InMemory
{
    public class InMemoryRecipientsDataProvider : IRecipientsDataProvider
    {
        public readonly List<Recipient> _Recipients = new List<Recipient>();

        public int Create(Recipient recipient)
        {
            if (_Recipients.Contains(recipient)) return recipient.Id;

            recipient.Id = _Recipients.Count == 0 ? 1 : _Recipients.Max(r => r.Id) + 1;

            _Recipients.Add(recipient);

            return recipient.Id;
        }

        public void Edit(int id, Recipient item)
        {
            var db_item = GetById(id);
            if (db_item is null) return;
            db_item.Name = item.Name;
            db_item.Address = item.Address;
        }

        public IEnumerable<Recipient> GetAll() => _Recipients;

        public Recipient GetById(int id) => _Recipients.FirstOrDefault(r => r.Id == id);

        public bool Remove(int id)
        {
            var db_tem = GetById(id);
            return _Recipients.Remove(db_tem);
        }

        public void SaveChanges() { }
    }
}
