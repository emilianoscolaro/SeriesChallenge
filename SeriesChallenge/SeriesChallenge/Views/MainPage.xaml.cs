using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SeriesChallenge.Views;
using SeriesChallenge.MVVM;

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

        string nivel;

        private async void Series(object sender, EventArgs e)
        {
            SerieBtn.Opacity = 0;
            await SerieBtn.FadeTo(1, 300);
            if (SeriesLvl.IsVisible == false)
            {
                SeriesLvl.IsVisible = true;
                SeriesLvl.ScaleY = 0;
                SeriesLvl.AnchorY = -.1;
                await SeriesLvl.ScaleYTo(1, 100);
            }
            else
            {
                SeriesLvl.AnchorY = -.1;
                await SeriesLvl.ScaleYTo(0, 100);
                SeriesLvl.IsVisible = false;
            }

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
            Puntuacion.IsVisible = false;
            PrincipalMenu.Scale = 0;
            await PrincipalMenu.ScaleTo(1, 300);
        }

        private async void Puntuacion_Clicked(object sender, EventArgs e)
        {
            PrincipalMenu.IsVisible = false;
            Puntuacion.IsVisible = true;
            Puntuacion.Scale = 0;
            await Puntuacion.ScaleTo(1, 300);

        }

        private async void NivelUnoSerie(object sender, EventArgs e)
        {
            nivel = "Sniv1";
            SLvunoBtn.Opacity = 0;
            await SLvunoBtn.FadeTo(1, 300);
            QuestPage nuevapagina = new QuestPage(nivel);
            await Navigation.PushAsync(nuevapagina);
        }

        private async void NivelDosSerie(object sender, EventArgs e)
        {
            nivel = "Sniv2";
            SLvdosBtn.Opacity = 0;
            await SLvdosBtn.FadeTo(1, 300);
            QuestPage nuevapagina = new QuestPage(nivel);
            await Navigation.PushAsync(nuevapagina);
        }



        private async void Peliculas(object sender, EventArgs e)
        {
            PeliculasBtn.Opacity = 0;
            await PeliculasBtn.FadeTo(1, 300);
            if (Peliculaslvl.IsVisible == false)
            {
                Peliculaslvl.IsVisible = true;
                Peliculaslvl.ScaleY = 0;
                Peliculaslvl.AnchorY = -.1;
                await Peliculaslvl.ScaleYTo(1, 100);
            }
            else
            {
                Peliculaslvl.AnchorY = -.1;
                await Peliculaslvl.ScaleYTo(0, 100);
                Peliculaslvl.IsVisible = false;
            }

        }


        private async void NivelUnoPeliculas(object sender, EventArgs e)
        {
            nivel = "Pniv1";
            PLvunoBtn.Opacity = 0;
            await PLvunoBtn.FadeTo(1, 300);
            QuestPage nuevapagina = new QuestPage(nivel);
            await Navigation.PushAsync(nuevapagina);
        }

        private async void NivelDosPeliculas(object sender, EventArgs e)
        {
            nivel = "Pniv2";
            PLvdosBtn.Opacity = 0;
            await PLvdosBtn.FadeTo(1, 300);
            QuestPage nuevapagina = new QuestPage(nivel);
            await Navigation.PushAsync(nuevapagina);
        }




    }
}
