using MailSender.lib.Entities.Base;

namespace MailSender.lib.Entities
{
    public class Server : NameEntity
    {        
        public string Host { get; set; }

        public int Port { get; set; } = 25;

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Description { get; set; }
    }
}
