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
    public partial class Entry_Page : ContentPage
    {
        Editor ed;
        Label lb;

        public Entry_Page()
        {
            //  InitializeComponent();
            
            
            ed = new Editor
            {
                Placeholder = "Sisesta siia teksti",
                BackgroundColor = Color.White,
                TextColor = Color.Blue,

            };

            ed.TextChanged += Ed_TextChanged1;
            Button tagasi = new Button
            {
                Text = "Tagasi"
            };
            tagasi.Clicked += Tagasi_Clicked;


            lb = new Label()
            {
                Text = "Mingi tekst",
                TextColor = Color.Accent
            };

           

            StackLayout st = new StackLayout()
            {
                Children={ ed,lb,tagasi }
            };
            st.BackgroundColor = Color.Aqua;

            Content = st;


        }
        int i = 0;

        private void Ed_TextChanged1(object sender, TextChangedEventArgs e)
        {
            ed.TextChanged += Ed_TextChanged1;
            char key = e.NewTextValue?.LastOrDefault() ?? ' ';


            if (key =='A')
            {
                i++;
                lb.Text = key.ToString() + ":" + i;
            }

            ed.TextChanged += Ed_TextChanged1;


        }    

        private async void Tagasi_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
       


    }
}