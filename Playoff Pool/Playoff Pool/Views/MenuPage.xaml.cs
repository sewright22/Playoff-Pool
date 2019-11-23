using Playoff_Pool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Playoff_Pool.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();
            BindingContext = App.Locator.MenuPageViewModel;
        }
    }
}