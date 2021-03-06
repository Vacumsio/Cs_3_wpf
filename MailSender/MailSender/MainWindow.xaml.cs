﻿using MailSender.Controls;
using MailSender.lib.Entities;
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

namespace MailSender
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml 4th-5th-lesson
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        private void TabControllerSwitcher_LeftButtonClick(object Sender, EventArgs E)
        {
            if (!(Sender is TabControllerSwitcher switcher)) return;

            MainTabControl.SelectedIndex--;

            if (MainTabControl.SelectedIndex == 0)
            {
                switcher.LeftButtonVisible = false;
            }
        }

        private void TabControllerSwitcher_RightButtonClick(object Sender, EventArgs E)
        {
            if (!(Sender is TabControllerSwitcher switcher)) return;

            MainTabControl.SelectedIndex++;

            if (MainTabControl.SelectedIndex == MainTabControl.Items.Count - 1)
            {
                switcher.RightButtonVisible = false;
            }
        }

    }
}
