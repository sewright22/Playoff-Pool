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
    public partial class ConferenceTabView : ContentView
    {
        public ConferenceTabView()
        {
            InitializeComponent();
            this.Detail.Content = new AFCView();
            this.AFCLabel.TextDecorations = TextDecorations.Underline;
        }

        private void OnSwipedLeft(object sender, SwipedEventArgs e)
        {
            if (this.Detail.Content.GetType() == typeof(AFCView))
            {
                this.Detail.Content = new NFCView();
                this.NFCLabel.TextDecorations = TextDecorations.Underline;
                this.AFCLabel.TextDecorations = TextDecorations.None;
            }
        }

        private void OnSwipedRight(object sender, SwipedEventArgs e)
        {
            if(this.Detail.Content.GetType()==typeof(NFCView))
            {
                this.Detail.Content = new AFCView();
                this.NFCLabel.TextDecorations = TextDecorations.None;
                this.AFCLabel.TextDecorations = TextDecorations.Underline;
            }
        }
    }
}