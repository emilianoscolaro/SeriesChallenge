using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SeriesChallenge.MVVM;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SeriesChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuestPage : ContentPage 
    {
        public QuestPage()
        {
            InitializeComponent();
            BindingContext = new QuestPageModelView();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            SiguienteChaBtn.Scale = 0;
            await SiguienteChaBtn.ScaleTo(1, 300);

        }

        private async void Button_Clicked_Respuesta(object sender, EventArgs e)
        {
            if (RespuestaFrame.BackgroundColor == Color.FromHex("3FBCA3"))
            {
                WinFrame.Scale = 0;
                await WinFrame.ScaleTo(1, 200);
            }

            if (RespuestaFrame.BackgroundColor == Color.Black)
            {
                LoseFrame.Scale = 0;
                await LoseFrame.ScaleTo(1, 200);
            }


        }

        private async void VolverBtn(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}