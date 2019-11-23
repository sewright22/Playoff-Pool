using Playoff_Pool.ViewModels;
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
    public partial class MyPicksView : ContentView
    {
        public MyPicksView()
        {
            InitializeComponent();
            BindingContext = new MyPicksViewModel();
        }
    }
}