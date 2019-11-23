using Playoff_Pool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Playoff_Pool.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectTeamView : ContentView
    {
        public delegate void WinnerChangedEventHandler(object sender, Team e);
        public event WinnerChangedEventHandler WinnerChanged;
        public SelectTeamView()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty HomeTeamProperty = BindableProperty.Create(nameof(HomeTeam), typeof(Team), typeof(SelectTeamView), null, BindingMode.TwoWay, propertyChanged: HomeTeamPropertyChanged);
        public static readonly BindableProperty HomeTeamIsSelectedProperty = BindableProperty.Create(nameof(HomeTeamIsSelected), typeof(bool), typeof(SelectTeamView), false, BindingMode.TwoWay, propertyChanged: HomeTeamIsSelectedChanged);

        private static void HomeTeamIsSelectedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (SelectTeamView)bindable;
            control.HomeTeamSwitch.IsToggled = (bool)newValue;
        }

        public Team HomeTeam
        {
            get { return (Team)GetValue(HomeTeamProperty); }
            set { SetValue(HomeTeamProperty, value); }
        }

        public bool HomeTeamIsSelected
        {
            get { return (bool)GetValue(HomeTeamIsSelectedProperty); }
            set { SetValue(HomeTeamIsSelectedProperty, value); }
        }

        private static void HomeTeamPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (SelectTeamView)bindable;
            control.homeTeamName.Text = newValue.ToString();
        }

        public static readonly BindableProperty AwayTeamProperty = BindableProperty.Create(nameof(AwayTeam), typeof(Team), typeof(SelectTeamView), null, BindingMode.TwoWay, propertyChanged: AwayTeamPropertyChanged);
        public static readonly BindableProperty AwayTeamIsSelectedProperty = BindableProperty.Create(nameof(AwayTeamIsSelected), typeof(bool), typeof(SelectTeamView), false, BindingMode.TwoWay, propertyChanged: AwayTeamIsSelectedChanged);

        private static void AwayTeamIsSelectedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (SelectTeamView)bindable;
            control.AwayTeamSwitch.IsToggled = (bool)newValue;
        }

        public Team AwayTeam
        {
            get { return (Team)GetValue(AwayTeamProperty); }
            set { SetValue(AwayTeamProperty, value); }
        }

        public bool AwayTeamIsSelected
        {
            get { return (bool)GetValue(AwayTeamIsSelectedProperty); }
            set { SetValue(AwayTeamIsSelectedProperty, value); }
        }

        private static void AwayTeamPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (SelectTeamView)bindable;
            control.awayTeamName.Text = newValue.ToString();
        }

        private void HomeTeam_Toggled(object sender, ToggledEventArgs e)
        {
            if(e.Value)
            {
                AwayTeamSwitch.IsToggled = false;
                if (WinnerChanged != null)
                {
                    WinnerChanged(this, HomeTeam);
                }
            }
        }

        private void AwayTeam_Toggled(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                HomeTeamSwitch.IsToggled = false;
                if (WinnerChanged != null)
                {
                    WinnerChanged(this, AwayTeam);
                }
            }
        }
    }
}