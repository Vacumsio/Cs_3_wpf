using MailSender.lib.Entities.Base;
using System;

namespace MailSender.lib.Entities
{
    public class SchedullerTask : BaseEntity
    {
        public DateTime time { get; set; }

        public Sender Sender { get; set; }

        public Server Server { get; set; }

        public RecipientsList Recipients { get; set; }

        public Email Email { get; set; }
    }
}
