using GalaSoft.MvvmLight.Messaging;
using Playoff_Pool.Messages;
using Playoff_Pool.Models;
using Playoff_Pool.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Playoff_Pool.ViewModels
{
    public class MenuPageViewModel : BaseViewModel
    {
        public MenuPageViewModel(IViewNavigationService navigationService, IMessenger messenger)
        {
            _navigationService = navigationService;
            _messenger = messenger;
            MenuItems = new ObservableCollection<HomeMenuItem>();

            Load();

            _messenger?.Register<SelectFirstItemMessage>(this, x=>
            {
                SelectedMenuItem = MenuItems[0];
            });
        }

        private void Load()
        {
            MenuItems.Clear();
            MenuItems.Add(new HomeMenuItem() { Id = MenuItemType.Home, Title = "Welcome" });
            MenuItems.Add(new HomeMenuItem() { Id= MenuItemType.History, Title="History"});
            MenuItems.Add(new HomeMenuItem() { Id= MenuItemType.MyPicks, Title="My Picks"});
            MenuItems.Add(new HomeMenuItem() { Id= MenuItemType.Leaderboard, Title="Leaderboard"});
        }

        private IViewNavigationService _navigationService;
        private IMessenger _messenger;
        private HomeMenuItem _selectedMenuItem;

        public HomeMenuItem SelectedMenuItem { get { return _selectedMenuItem; } set { SetProperty(ref _selectedMenuItem, value, nameof(SelectedMenuItem), SelectedMenuItemChanged); } }

        private void SelectedMenuItemChanged()
        {
            if (_selectedMenuItem.Id == MenuItemType.Home)
            {
                _navigationService.Navigate("Home", null);
            }
            else
            {

            }
        }

        public ObservableCollection<HomeMenuItem> MenuItems { get; }
    }
}
