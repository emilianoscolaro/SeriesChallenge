using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SeriesChallenge.Models;
using SeriesChallenge.Views;
using Xamarin.Forms;

namespace SeriesChallenge.MVVM
{
    public class QuestPageModelView : INotifyPropertyChanged
    {


        public QuestPageModelView(string nivel)
        {
            _nivel = nivel;
            Encabezados();
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

        string _nivel;

       


        private string respuesta;

        public string Respuesta
        {
            get { return respuesta; }
            set { respuesta = value; OnPropertyChanged(); }
        }


        int index;
        int serieindex = 0;
       


        DataStorge dt = new DataStorge();
        SeriesNivelDos sndos = new SeriesNivelDos();
        PelicilasNvUno pnivuno = new PelicilasNvUno();
        PelicilasNvDos pnivdos = new PelicilasNvDos();

        private Serie seriealpha;

        public Serie SerieAlpha
        {
            get { return seriealpha; }
            set { seriealpha = value; OnPropertyChanged(); }
        }


        private string encabezado;

        public string Encabezado
        {
            get { return encabezado; }
            set { encabezado = value; }
        }


        private void Encabezados()
        {
            if (_nivel == "Sniv1" || _nivel == "Sniv2")
                Encabezado = "¿A que serie pertenecen estos personajes?";
            if (_nivel == "Pniv1" || _nivel == "Pniv2")
                Encabezado = "¿A que pelicula pertenecen estos personajes?";
        }

        private string name;

        public string Name
        {
            get { return seriealpha.Name; }
            set { seriealpha.Name = value; OnPropertyChanged(); }
        }

        private string namedos;

        public string NameDos
        {
            get { return seriealpha.NameDos; }
            set { seriealpha.NameDos = value; OnPropertyChanged(); }
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
            set { textresultado = value;OnPropertyChanged(); }
        }




        private void siguienteserie()
        {
            if (_nivel == "Sniv1")
            {
                if (serieindex == 0)
                    SerieAlpha = dt.Friends(SerieAlpha);
                if (serieindex == 1)
                    SerieAlpha = dt.Got(SerieAlpha);
                if (serieindex == 2)
                    SerieAlpha = dt.TWD(SerieAlpha);
                if (serieindex == 3)
                    SerieAlpha = dt.TheBigBangTheory(SerieAlpha);
                if (serieindex == 4)
                    SerieAlpha = dt.StrangerThings(SerieAlpha);
                if (serieindex == 5)
                    SerieAlpha = dt.Vikingos(SerieAlpha);
                if (serieindex == 6)
                    SerieAlpha = dt.Dark(SerieAlpha);
                if (serieindex == 7)
                    SerieAlpha = dt.Lost(SerieAlpha);
                if (serieindex == 8)
                    SerieAlpha = dt.PrisonBreak(SerieAlpha);
                if (serieindex == 9)
                    SerieAlpha = dt.LosSimpsons(SerieAlpha);
                if (serieindex == 10)
                    SerieAlpha = dt.Breakingbad(SerieAlpha);
                if (serieindex == 11)
                    SerieAlpha = dt.LaCasaDePapel(SerieAlpha);
            }
            

            if(_nivel == "Sniv2")
            {
                if (serieindex == 0)
                    SerieAlpha = sndos.MrRobot(SerieAlpha);
                if (serieindex == 1)
                    SerieAlpha = sndos.Merli(SerieAlpha);
                if (serieindex == 2)
                    SerieAlpha = sndos.HowIMetYourMother(SerieAlpha);
                if (serieindex == 3)
                    SerieAlpha = sndos.TheOffice(SerieAlpha);
                if (serieindex == 4)
                    SerieAlpha = sndos.Seinfeld(SerieAlpha);
                if (serieindex == 5)
                    SerieAlpha = sndos.PeakyBlinders(SerieAlpha);
                if (serieindex == 6)
                    SerieAlpha = sndos.HouseofCards(SerieAlpha);
                if (serieindex == 7)
                    SerieAlpha = sndos.Dexter(SerieAlpha);
                if (serieindex == 8)
                    SerieAlpha = sndos.Futurama(SerieAlpha);
                if (serieindex == 9)
                    SerieAlpha = sndos.StarTrek(SerieAlpha);
            }

            if (_nivel == "Pniv1")
            {
                if (serieindex == 0)
                    SerieAlpha = pnivuno.Elpadrino(SerieAlpha);
                if (serieindex == 1)
                    SerieAlpha = pnivuno.TheLordoftheRings(SerieAlpha);
                if (serieindex == 2)
                    SerieAlpha = pnivuno.ForrestGump(SerieAlpha);
                if (serieindex == 3)
                    SerieAlpha = pnivuno.Psycho(SerieAlpha);
                if (serieindex == 4)
                    SerieAlpha = pnivuno.CiudaddeDios(SerieAlpha);
                if (serieindex == 5)
                    SerieAlpha = pnivuno.Elsilenciodelosinocentes(SerieAlpha);
                if (serieindex == 6)
                    SerieAlpha = pnivuno.StarWars(SerieAlpha);
                if (serieindex == 7)
                    SerieAlpha = pnivuno.Elreyleon(SerieAlpha);
                if (serieindex == 8)
                    SerieAlpha = pnivuno.BacktotheFuture(SerieAlpha);
                if (serieindex == 9)
                    SerieAlpha = pnivuno.Terminator(SerieAlpha);
                if (serieindex == 10)
                    SerieAlpha = pnivuno.Matrix(SerieAlpha);

            }


            if (_nivel == "Pniv2")
            {
                if (serieindex == 0)
                    SerieAlpha = pnivdos.Gladiator(SerieAlpha);
                if (serieindex == 1)
                    SerieAlpha = pnivdos.Joker(SerieAlpha);
                if (serieindex == 2)
                    SerieAlpha = pnivdos.Alien(SerieAlpha);
                if (serieindex == 3)
                    SerieAlpha = pnivdos.Avengers(SerieAlpha);
                if (serieindex == 4)
                    SerieAlpha = pnivdos.Coco(SerieAlpha);
                if (serieindex == 5)
                    SerieAlpha = pnivdos.ToyStory(SerieAlpha);
                if (serieindex == 6)
                    SerieAlpha = pnivdos.KillBill(SerieAlpha);
                if (serieindex == 7)
                    SerieAlpha = pnivdos.Elclubdelapelea(SerieAlpha);
                if (serieindex == 8)
                    SerieAlpha = pnivdos.TheNotebook(SerieAlpha);
                if (serieindex == 9)
                    SerieAlpha = pnivdos.Titanic(SerieAlpha);
            }



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
            if(respuesta=="" || respuesta == null)
            {

            }
            else
            {
                if (respuesta == "La casa de papel" && respuesta == seriealpha.Name 
                    || respuesta == "Star trek" && respuesta == seriealpha.Name
                    || respuesta == "Matrix" && respuesta == seriealpha.Name
                    || respuesta == "Titanic" && respuesta == seriealpha.Name)
                {
                    RespuestaColor = Color.FromHex("3FBCA3");
                    PrincipalFrame = false;
                    PrincipalDosFrame = false;
                    ResultdoFrame = true;
                    ResultadoColor = Color.Green;
                    CoinsTotales = CoinsTotales + Coins;
                }
                else
                {
                    if (respuesta == seriealpha.Name || respuesta == seriealpha.NameDos)
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

                    if (Intentos == 0 && serieindex == 7)
                    {
                        RespuestaColor = Color.Black;
                        PrincipalFrame = false;
                        PrincipalDosFrame = false;
                        ResultdoFrame = true;
                        ResultadoColor = Color.Red;
                        Coins = 0;
                    }
                    else
                    {
                        if (Intentos == 0)
                        {
                            RespuestaColor = Color.Black;
                            PrincipalFrame = false;
                            PrincipalDosFrame = false;
                            LoseFrame = true;
                            Coins = 0;
                        }
                    }
                }
            }
            
            
        }






        private Color respuestacolor;

        public Color RespuestaColor
        {
            get { return respuestacolor; }
            set { respuestacolor = value; OnPropertyChanged();
            }
        }

        private Color resultadocolor;

        public Color ResultadoColor
        {
            get { return resultadocolor; }
            set { resultadocolor = value;OnPropertyChanged(); }
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
