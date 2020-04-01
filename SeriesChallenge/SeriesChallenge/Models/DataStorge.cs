using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using SeriesChallenge.Models;
	


namespace SeriesChallenge.Models
{
    public class DataStorge
    {

      //  public List<Series> GetSeries()
      //  {
      //      var series = new List<Series>()
      //      {
      //          new Series(){ Name="Friends" ,Index = 1, CharacterA="Richard" , CharacterB="monica" ,CharacterC="Gunther" , CharacterD="Ross", CharacterE="Rachell", Tip="Tiene 10 temporadas"},
      //          new Series(){ Name ="Game of thrones",Index=2, CharacterA="Gilly" ,CharacterB ="Robert" ,CharacterC="Oberyn",CharacterD="Sansa",CharacterE="Hodor"},
      //          new Series(){Name="The Big Bang Theory",Index=3,CharacterA="Stuart",CharacterB="Bert",CharacterC="Leonard",CharacterD="Amy",CharacterE="Sheldon"},
      //
      //
      //
      //      };
      //
      //      return series;
      //      
      //  }


       // private ObservableCollection<Serie> series;
       //
       // public ObservableCollection<Serie> Series
       // {
       //     get { return series; }
       // }



       public Serie Friends(Serie serie)
       {

            serie = new Serie { Name = "Friends", Index = 1, CharacterA = "Richard", CharacterB = "monica", CharacterC = "Gunther", CharacterD = "Ross", CharacterE = "Rachell", Tip = "Tiene 10 temporadas" };

            return serie;

       }


        public Serie Got(Serie serie)
        {
            serie = new Serie { Name = "Game of thrones", Index = 2, CharacterA = "Gilly", CharacterB = "Robert", CharacterC = "Oberyn", CharacterD = "Sansa", CharacterE = "Hodor" };

            return serie;
        }



        }
}
