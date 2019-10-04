using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace MailSender.ViewModel
{
    public class MainWindowViewModel :ViewModelBase
    {
        private string _WindowTitle = "Рассыльщик почты версии 0.001";

        public string WindowTitle
        {
            get => _WindowTitle;
            set => Set(ref _WindowTitle, value);
        }
    }
}