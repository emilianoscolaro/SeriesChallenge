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




    }
}