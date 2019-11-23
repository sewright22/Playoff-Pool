using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Playoff_Pool.Services;
using Playoff_Pool.Views;
using GalaSoft.MvvmLight.Views;
using GalaSoft.MvvmLight.Ioc;
using Playoff_Pool.Messages;

namespace Playoff_Pool
{
    public partial class App : Application
    {
        //TODO: Replace with *.azurewebsites.net url after deploying backend to Azure
        //To debug on Android emulators run the web backend against .NET Core not IIS
        //If using other emulators besides stock Google images you may need to adjust the IP address
        public static string AzureBackendUrl = DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5000" : "http://localhost:5000";
        public static bool UseMockDataStore = true;

        private static ViewModelLocator _locator;
        public static ViewModelLocator Locator
        {
            get
            {
                return _locator ?? (_locator = new ViewModelLocator());
            }
        }
        public App()
        {
            InitializeComponent();

            SimpleIoc.Default.Register<IViewNavigationService, ViewNavigationService>();
            var nav = SimpleIoc.Default.GetInstance<IViewNavigationService>();
            nav.Initialize();
            MainPage = new CustomBottomTabbedPage();
            //nav.SetMainPage(MainPage);
        }

        protected override void OnStart()
        {
            Locator.Messenger.Send(new SelectFirstItemMessage());
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
