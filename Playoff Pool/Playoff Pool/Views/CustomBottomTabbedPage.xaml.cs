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
    public partial class CustomBottomTabbedPage : ContentPage
    {
        public CustomBottomTabbedPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            this.Detail.Content = new WelcomeView();
            //this.Detail.Content = new WelcomeView();
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            this.Detail.Content = new ConferenceTabView();
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            this.Detail.Content = new HistoryView();
        }

        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            this.Detail.Content = new LeaderboardView();
        }
    }
}