using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Elemenidide_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //InitializeComponent();
            StackLayout st = new StackLayout();
            Button Ent_btn = new Button
            {
                Text = "Entry",
                BackgroundColor = Color.Fuchsia
            };
            Button Timer_btn = new Button
            {
                Text = "Entry",
                BackgroundColor = Color.AliceBlue
            };
            st.Children.Add(Ent_btn);
            st.Children.Add(Timer_btn);
            st.BackgroundColor = Color.PaleGreen;
            Content = st;
            Ent_btn.Clicked += Ent_btn_Clicked;

            
        }

        private async void Ent_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Entry_Page());
        }
    }
}
