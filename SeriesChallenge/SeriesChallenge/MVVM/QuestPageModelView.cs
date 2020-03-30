using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using SeriesChallenge.Models;
using Xamarin.Forms;

namespace SeriesChallenge.MVVM
{
    public class QuestPageModelView : INotifyPropertyChanged
    {

        public QuestPageModelView()
        {
           seriealpha = dt.Friends(seriealpha);
            command = new Command(siguiente);

        }


        Serie seriealpha;

        int index = 1;
        DataStorge dt = new DataStorge();
        

        


        private string name;

        public string Name
        {
            get { return seriealpha.Name; }
            set { seriealpha.Name = value; }
        }

        private string cha;

        public string ChA
        {
            get { return seriealpha.CharacterA; }
            set { seriealpha.CharacterA = value; }
        }

        private string chb;

        public string ChB
        {
            get { return seriealpha.CharacterB; }
            set { seriealpha.CharacterB = value; }
        }


        private string chc;

        public string ChC
        {
            get { return seriealpha.CharacterC; }
            set { seriealpha.CharacterC = value; }
        }


        private string chd;

        public string ChD
        {
            get { return seriealpha.CharacterD; }
            set { seriealpha.CharacterD = value; }
        }

        private string che;

        public string ChE
        {
            get { return seriealpha.CharacterE; }
            set { seriealpha.CharacterE = value; }
        }



        private bool cbvis;

        public bool CBVis
        {
            get { return cbvis; }
            set { cbvis = value;OnPropertyChanged(); }
        }

        private bool ccvis;

        public bool CCVis
        {
            get { return ccvis; }
            set { ccvis = value; OnPropertyChanged(); }
        }

        private bool cdvis;

        public bool CDVis
        {
            get { return cdvis; }
            set { cdvis = value; OnPropertyChanged(); }
        }

        private bool cevis;

        public bool CEVis
        {
            get { return cevis; }
            set { cevis = value; OnPropertyChanged(); }
        }



        private Command command;

        public Command SiguienteBtn
        {
            get { return command; }
            set { command = value; }
        }

        int sigbtnpress;

        public void siguiente()
        {

            sigbtnpress = sigbtnpress+ 1;
            int index = sigbtnpress;

            if (index == 1)
                CBVis = true;
            if (index == 2)
                CCVis = true;
            if (index == 3)
                CDVis = true;
            if (index == 4)
                CEVis = true;

            
        }



        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string NombrePropiedad = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(NombrePropiedad));
            }

        }

    }
}
