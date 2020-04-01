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
            PrincipalFrame = true;
            PrincipalDosFrame = true;
            siguienteserie();
            command = new Command(siguiente);
            btnrespuesta = new Command(validrespuesta);
            sigseriebtn = new Command(siguienteserie);
            BtnVis = true;
            RespuestaColor=Color.White;
            Coins = 5;
            Intentos = 3;
            OnPropertyChanged();
        }






        private string respuesta;

        public string Respuesta
        {
            get { return respuesta; }
            set { respuesta = value; OnPropertyChanged(); }
        }


        int index;
        int serieindex = 0;
       


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



        private bool principalframe;

        public bool PrincipalFrame
        {
            get { return principalframe; }
            set { principalframe = value;OnPropertyChanged(); }
        }

        private bool principaldosframe;

        public bool PrincipalDosFrame
        {
            get { return principaldosframe; }
            set { principaldosframe = value; OnPropertyChanged(); }
        }


        private bool winframe;

        public bool WinFrame
        {
            get { return winframe; }
            set { winframe = value; OnPropertyChanged(); }
        }

        private bool loseframe;

        public bool LoseFrame
        {
            get { return loseframe; }
            set { loseframe = value; OnPropertyChanged(); }
        }

        private bool resultadoframe;

        public bool ResultdoFrame
        {
            get { return resultadoframe; }
            set { resultadoframe = value; OnPropertyChanged(); }
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



        private int coins;

        public int Coins
        {
            get { return coins; }
            set { coins = value; OnPropertyChanged(); }
        }

        private int coinstotales;

        public int CoinsTotales
        {
            get { return coinstotales; }
            set { coinstotales = value; OnPropertyChanged(); }
        }



        private int intentis;

        public int Intentos
        {
            get { return intentis;  }
            set { intentis = value; OnPropertyChanged(); }
        }

        private string textresultado;

        public string TextResultado
        {
            get { return textresultado; }
            set { textresultado = value; }
        }




        private void siguienteserie()
        {
            
            if (serieindex == 6)
                SerieAlpha = dt.Friends(SerieAlpha);
            if (serieindex == 1)
                SerieAlpha = dt.Got(SerieAlpha);
            if (serieindex == 2)
                SerieAlpha = dt.TWD(SerieAlpha);
            if (serieindex == 3)
                SerieAlpha = dt.TheBigBangTheory(SerieAlpha);
            if (serieindex == 4)
                SerieAlpha = dt.MrRobot(SerieAlpha);
            if (serieindex == 5)
                SerieAlpha = dt.StrangerThings(SerieAlpha);
            if (serieindex == 0)
                SerieAlpha = dt.LaCasaDePapel(SerieAlpha);
            serieindex = serieindex + 1;
            WinFrame = false;
            LoseFrame = false;
            CBVis = false;
            CCVis = false;
            CDVis = false;
            CEVis = false;
            Respuesta = "";
            RespuestaColor = Color.White;
            if (BtnVis == false)
                BtnVis = true;
            index = 0;
            Intentos = 3;
            Coins = 5;
            PrincipalFrame = true;
            PrincipalDosFrame = true;
            OnPropertyChanged(cha);
            OnPropertyChanged(chb);
            OnPropertyChanged(chc);
            OnPropertyChanged(chd);
            OnPropertyChanged(che);
            OnPropertyChanged(Name);

        }

        



        public void siguiente()
        {

            index = index +1;

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

            Coins = Coins - 1;

        }


        private void validrespuesta()
        {
            if(respuesta == seriealpha.Name)
            {
                RespuestaColor = Color.FromHex("3FBCA3");
                PrincipalFrame = false;
                PrincipalDosFrame = false;
                WinFrame = true;
                CoinsTotales = CoinsTotales + Coins;
            }
            else
            {
                RespuestaColor = Color.Red;
                Intentos = Intentos - 1;
            }

            if (Intentos == 0)
            {
                RespuestaColor = Color.Black;
                PrincipalFrame = false;
                PrincipalDosFrame = false;
                LoseFrame = true;
                Coins = 0;
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
