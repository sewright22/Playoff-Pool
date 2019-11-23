using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using Playoff_Pool.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Playoff_Pool
{
    public sealed class ViewModelLocator
    {
        public  ViewModelLocator()
        {

            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<IMessenger, Messenger>();
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<MenuPageViewModel>();
        }

        public IMessenger Messenger => ServiceLocator.Current.GetInstance<IMessenger>();

        public MainViewModel MainViewModel => ServiceLocator.Current.GetInstance<MainViewModel>();

        public MenuPageViewModel MenuPageViewModel => ServiceLocator.Current.GetInstance<MenuPageViewModel>();
    }
}
