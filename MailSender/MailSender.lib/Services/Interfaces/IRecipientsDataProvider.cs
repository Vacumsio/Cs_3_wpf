using System.Collections.Generic;
using MailSender.lib.Entities;

namespace MailSender.lib.Services.Interfaces
{
    public interface IRecipientsDataProvider
    {
        IEnumerable<Recipient> GetAll();

        Recipient GetById(int id);

        int Create(Recipient recipient);

        void Edit(int id, Recipient item);

        bool Remove(int id);

        void SaveChanges();
    }
}
