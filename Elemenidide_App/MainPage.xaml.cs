﻿using System;
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

            StackLayout st = new StackLayout
            {
                Children = { Ent_btn, Timer_btn }
            };

            st.BackgroundColor = Color.PaleGreen;
            Content = st;
            Ent_btn.Clicked += Ent_btn_Clicked;
            Timer_btn.Clicked += Timer_btn_Clicked;

            
        }

        private void Timer_btn_Clicked(object sender, EventArgs e)
        {
            
        }

        private async void Ent_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Entry_Page());
        }
    }
}
