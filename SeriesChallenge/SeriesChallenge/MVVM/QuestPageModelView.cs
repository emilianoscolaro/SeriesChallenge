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
            siguienteserie();
            command = new Command(siguiente);
            btnrespuesta = new Command(validrespuesta);
            sigseriebtn = new Command(siguienteserie);
            BtnVis = true;
            RespuestaColor=Color.White;
            OnPropertyChanged();
        }






        private string respuesta;

        public string Respuesta
        {
            get { return respuesta; }
            set { respuesta = value; OnPropertyChanged(); }
        }



        int serieindex = 0;
        int sigbtnpress;
        //Serie seriealpha;


        DataStorge dt = new DataStorge();



        private Serie seriealpha;

        public Serie SerieAlpha
        {
            get { return seriealpha; }
            set { seriealpha = value; OnPropertyChanged(); }
        }


        private string name;

        public string Name
        {
            get { return seriealpha.Name; }
            set { seriealpha.Name = value; OnPropertyChanged(); }
        }



        private string cha;

        public string ChA
        {
            get { return seriealpha.CharacterA; }
            set { seriealpha.CharacterA = value; OnPropertyChanged(); }
        }

        private string chb;

        public string ChB
        {
            get { return seriealpha.CharacterB; }
            set { seriealpha.CharacterB = value; OnPropertyChanged(); }
        }


        private string chc;

        public string ChC
        {
            get { return seriealpha.CharacterC; }
            set { seriealpha.CharacterC = value; OnPropertyChanged(); }
        }


        private string chd;

        public string ChD
        {
            get { return seriealpha.CharacterD; }
            set { seriealpha.CharacterD = value; OnPropertyChanged(); }
        }

        private string che;

        public string ChE
        {
            get { return seriealpha.CharacterE; }
            set { seriealpha.CharacterE = value; OnPropertyChanged(); }
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


        private bool btnvis;

        public bool BtnVis
        {
            get { return btnvis;  }
            set { btnvis = value; OnPropertyChanged(); }
        }


        private bool winframe;

        public bool WinFrame
        {
            get { return winframe; }
            set { winframe = value; OnPropertyChanged(); }
        }



        private Command btnrespuesta;

        public Command BtnRespuesta
        {
            get { return btnrespuesta; }
            set { btnrespuesta = value; }
        }


        private Command command;

        public Command SiguienteBtn
        {
            get { return command; }
            set { command = value; }
        }

        private Command sigseriebtn;

        public Command SigSerieBtn
        {
            get { return sigseriebtn; }
            set { sigseriebtn = value; }
        }





        private void siguienteserie()
        {
            
            if (serieindex == 0)
                SerieAlpha = dt.Friends(SerieAlpha);
            if (serieindex == 1)
                SerieAlpha = dt.Got(SerieAlpha);
            serieindex = serieindex + 1;
            WinFrame = false;
            CBVis = false;
            CCVis = false;
            CDVis = false;
            CEVis = false;
            Respuesta = "";
            RespuestaColor = Color.White;
            if (BtnVis == false)
                BtnVis = true;
            OnPropertyChanged(cha);
        }


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
            {
                CEVis = true;
                BtnVis = false;
            }
        }


        private void validrespuesta()
        {
            if(respuesta == seriealpha.Name)
            {
                RespuestaColor = Color.FromHex("3FBCA3");
                WinFrame = true;
            }
            else
            {
                RespuestaColor = Color.Red;
            }
        }


        private Color respuestacolor;

        public Color RespuestaColor
        {
            get { return respuestacolor; }
            set { respuestacolor = value; OnPropertyChanged();
            }
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
