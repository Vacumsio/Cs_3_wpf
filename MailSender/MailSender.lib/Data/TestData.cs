using MailSender.lib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.lib.Data
{
    public static class TestData
    {
        public static List<Server> Servers { get; } = new List<Server>
        {
            new Server{Id= 1, Name = "Yandex", Address="smtp.yandex.ru",UserName="UsenName",Password="Pass"},
            new Server{Id= 2, Name = "Mail.ru", Address="smtp.mali.ru",UserName="UsenName",Password="Pass"},
            new Server{Id= 3, Name = "Gmail.com", Address="smtp.gmail.com", Port=465, UserName="UsenName",Password="Pass"}
        };

        public static List<Sender> Senders { get; } = new List<Sender>
        {
            new Sender{Id=1,Name="Иванов",Address="ivanov.yandex.ru"},
            new Sender{Id=2,Name="Петров",Address="petrov@mail.ru"},
            new Sender{Id=3,Name="Сидоров",Address="sidorov@gmail.com"}
        };
    }
} 
