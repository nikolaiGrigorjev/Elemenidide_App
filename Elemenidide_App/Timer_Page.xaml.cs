﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemenidide_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Timer_Page : ContentPage
    {
        public Timer_Page()
        {
            InitializeComponent();
        }

        bool on_off = true;

        private async void ShowTime()
        {
            while(on_off)
            {
                timer_btn.Text = DateTime.Now.ToString("T");
                await Task.Delay(1000);
            }

        }


        private void timer_btn_Clicked(object sende,EventArgs e)
        {
            if(on_off)
            {
                on_off = false;
            }
            else

            {
                on_off = true;
                ShowTime();

            }

        }

       

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            lbl.Text = "Valjutatud";
        }
    }
}