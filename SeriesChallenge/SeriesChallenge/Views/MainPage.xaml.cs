using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SeriesChallenge.Views;

namespace SeriesChallenge
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            SerieBtn.Opacity = 0;
            await SerieBtn.FadeTo(1, 300);
            QuestPage nuevapagina = new QuestPage();
            await Navigation.PushAsync(nuevapagina);
        }

        private async void Comojugar_Clicked(object sender, EventArgs e)
        {
            PrincipalMenu.IsVisible = false;
            ComoJugarTxt.IsVisible = true;
            ComoJugarTxt.Scale = 0;
            await ComoJugarTxt.ScaleTo(1, 300);
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            PrincipalMenu.IsVisible = true;
            ComoJugarTxt.IsVisible = false;
            PrincipalMenu.Scale = 0;
            await PrincipalMenu.ScaleTo(1, 300);
        }
    }
}
