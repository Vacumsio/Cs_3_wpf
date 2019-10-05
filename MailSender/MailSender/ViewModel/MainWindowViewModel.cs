﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using MailSender.lib.Data.Linq2SQL;
using MailSender.lib.Services;

namespace MailSender.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private RecipientsDataProvider _RecipientsProvider;
        //private string _WindowTitle = "Рассыльщик почты версии 0.001";

        //public string WindowTitle
        //{
        //    get => _WindowTitle;
        //    set => Set(ref _WindowTitle, value);
        //}

        private ObservableCollection<Recipient> _Recipients = new ObservableCollection<Recipient>();

        public ObservableCollection<Recipient> Recipients
        {
            get => _Recipients;
            set => Set(ref _Recipients, value);
        }

        private Recipient _SelectedRecipient;

        public Recipient SelectedRecipient
        {
            get => _SelectedRecipient;
            set => Set(ref _SelectedRecipient, value);
        }

        public ICommand RefreshDataCommand { get; }

        public MainWindowViewModel(RecipientsDataProvider RecipientsProvider)
        {
            _RecipientsProvider = RecipientsProvider;

            RefreshDataCommand = new RelayCommand(OnRefreshDataCommandExecuted, CanRefreshDataCommandExecuted);
            //RefreshData();
        }

        private bool CanRefreshDataCommandExecuted() => true;

        private void OnRefreshDataCommandExecuted()
        {
            RefreshData();
        }

        public void RefreshData()
        {
            var recipients = new ObservableCollection<Recipient>();
            foreach (var recipient in _RecipientsProvider.GetAll())            
                recipients.Add(recipient);
            Recipients = recipients;
        }
    }
}