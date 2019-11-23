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
    public partial class CustomTab : ContentView
    {
        public static readonly BindableProperty IconNameProperty =  BindableProperty.Create(nameof(IconName), typeof(string), typeof(CustomTab), "", BindingMode.TwoWay, propertyChanged: IconNamePropertyChanged);

        public static readonly BindableProperty LabelTextProperty =  BindableProperty.Create(nameof(LabelText), typeof(string), typeof(CustomTab), "", BindingMode.TwoWay, propertyChanged: TextLabelChanged);

        public CustomTab()
        {
            InitializeComponent();

            var tapGestureRecognizer = new TapGestureRecognizer();

            tapGestureRecognizer.Tapped += async (s, e) =>
            {
                // more info about animations:
                // https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/animation/simple
                var timeFrame = (uint)125;
                // scale the frame to x1.2
                var scaleUpAnimationTask = this.ScaleTo(1.2, timeFrame);
                // set opacity to 0 (transparent)
                var fadeOutAnimationTask = this.FadeTo(0, timeFrame);

                // wait for the 2 animations to finish...
                await Task.WhenAll(scaleUpAnimationTask, fadeOutAnimationTask).ConfigureAwait(true);

                // scale the frame back to original size
                var scaleDownAnimationTask = this.ScaleTo(1, timeFrame);
                // set opacity back to 1 (solid)
                var fadeInAnimationTask = this.FadeTo(1, timeFrame);

                // wait for the 2 animations to finish...
                await Task.WhenAll(scaleDownAnimationTask, fadeInAnimationTask).ConfigureAwait(true);
            };

            this.GestureRecognizers.Add(tapGestureRecognizer);
        }

        public string IconName
        {
            get { return (string)GetValue(IconNameProperty); }
            set { SetValue(IconNameProperty, value); }
        }

        public string LabelText
        {
            get { return (string)GetValue(LabelTextProperty); }
            set { SetValue(LabelTextProperty, value); }
        }

        private static void IconNamePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CustomTab)bindable;
            control.iconLabel.Text = newValue.ToString();
        }

        private static void TextLabelChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CustomTab)bindable;
            control.labelText.Text = newValue.ToString();
        }
    }
}