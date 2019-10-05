﻿using MailSender.lib.Entities.Base;
using System.Collections.Generic;

namespace MailSender.lib.Entities
{
    public class RecipientsList : NameEntity
    {
        public ICollection<Recipient> Recipients { get; set; }
    }
}
