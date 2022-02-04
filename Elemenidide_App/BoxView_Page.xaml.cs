using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemenidide_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BoxView_Page : ContentPage
    {
        public BoxView_Page()
        {
            BoxView Box = new BoxView
            {
                Color = Color.Blue,
                CornerRadius = 10,
                WidthRequest = 200,
                HeightRequest = 400,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,

            };
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;

            StackLayout st = new StackLayout { Children = { Box } };
            Content = st;
        }
        Random rnd;
        private void Tap_Tapped(object sender, EventArgs e)
        {
            rnd = new Random();
            Box.Color = Color.FromRgb(rnd.Next(0, 255),rnd.Next(0, 255),rnd.Next(0, 255));

        }
    }
}