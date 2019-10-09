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

using GalaSoft.MvvmLight.Ioc;
using System;
using GalaSoft.MvvmLight.Ioc;

namespace MailSender.ViewModel
{
    public static class SimpleIocExtensions
    {
        public static SimpleIoc TryRegister<TIntefrace, TService>(this SimpleIoc services)
            where TIntefrace : class
            where TService : class, TIntefrace
        {
            if (services.IsRegistered<TIntefrace>()) return services;
            services.Register<TIntefrace, TService>();

            return services;
        }

        public static SimpleIoc TryRegister<TService>(this SimpleIoc services)
            where TService : class
        {
            if (services.IsRegistered<TService>()) return services;

            services.Register<TService>();

            return services;
        }

        public static SimpleIoc TryRegister<TService>(this SimpleIoc services, Func<TService> Factory)
            where TService : class
        {
            if (services.IsRegistered<TService>()) return services;

            services.Register(Factory);

            return services;
        }
    }
}