using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender.lib.MVVM;

namespace MailSender.WPF.test
{
    class MainWindowViewModel: ViewModel
    {
        private string _Title = "Window name";

        public string Title
        {
            get => _Title;
            set
            {
                if (_Title == value)
                {
                    _Title = value;
                    //OnPropertyChanged(nameof(Title));
                    //OnPropertyChanged(nameof("Title"));
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(TitleLength));
                }
            }
        }

        public int TitleLength => Title?.Length ?? 0;

        private int _OffsetY = 10;

        public int OffsetY
        {
            get => _OffsetY;
            set => Set(ref _OffsetY, value);
        }
    }
}
