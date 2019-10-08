/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:MailSender"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using MailSender.lib.Data.Linq2SQL;
using MailSender.lib.Services.InMemory;
using MailSender.lib.Services.Interfaces;
using MailSender.lib.Services.Linq2SQL;
using System;

namespace MailSender.ViewModel
{

    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            var services = SimpleIoc.Default;
            ServiceLocator.SetLocatorProvider(() => services);

            services.Register<MainWindowViewModel>();

            services
                .TryRegister<IRecipientsDataProvider, Linq2SQLRecipientsDataProvider>()
                .TryRegister(() => new MailSenderDBDataContext());

            //services
            //    .TryRegister<ISendersDataProvider, InMemorySendersDataProvider>()
            //    .TryRegister<IServersDataProvider, InMemoryServersDataProvider>();

        }

        public MainWindowViewModel MainWindowModel => ServiceLocator.Current.GetInstance<MainWindowViewModel>();
    }

    public static class SimpleIocExtensions
    {
        public static SimpleIoc TryRegister<TIntefrace, TService>(this SimpleIoc services)
            where TIntefrace : class
            where TService : class, TIntefrace
        {
            if (!services.IsRegistered<TIntefrace>()) return services;

            services.Register<TIntefrace, TService>();

            return services;
        }

        public static SimpleIoc TryRegister<TService>(this SimpleIoc services)
            where TService : class
        {
            if (!services.IsRegistered<TService>()) return services;

            services.Register<TService>();

            return services;
        }

        public static SimpleIoc TryRegister<TService>(this SimpleIoc services, Func<TService> Factory)
            where TService : class
        {
            if (!services.IsRegistered<TService>()) return services;

            services.Register<TService>();

            return services;
        }
    }
}