using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MailSender.Controls
{
    /// <summary>
    /// Логика взаимодействия для TabControllerSwitcher.xaml
    /// </summary>
    public partial class TabControllerSwitcher
    {
        public event EventHandler LeftButtonClick;

        public event EventHandler RightButtonClick;

        public bool LeftButtonVisible
        {
            get => LeftButton.Visibility == Visibility;
            set => LeftButton.Visibility = value ? Visibility.Visible : Visibility.Collapsed;
        }

        public bool RightButtonVisible
        {
            get => RightButton.Visibility == Visibility;
            set => RightButton.Visibility = value ? Visibility.Visible : Visibility.Collapsed;
        }

        public TabControllerSwitcher() => InitializeComponent();

        public void ButtonBase_OnClick(object Sender, RoutedEventArgs e)
        {
            if (!(e.Source is Button button)) return;
            switch(button.Name)
            {
                case "LeftButton":
                    LeftButtonClick?.Invoke(this, EventArgs.Empty);
                    break;
                case "RightButton":
                    RightButtonClick?.Invoke(this, EventArgs.Empty);
                    break;
            }
        }
    }
}
