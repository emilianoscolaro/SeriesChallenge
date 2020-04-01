using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using SeriesChallenge.Models;
	


namespace SeriesChallenge.Models
{
    public class DataStorge
    {



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



        public Serie TheBigBangTheory(Serie serie)
        {
            serie = new Serie { Name = "The big bang theory", Index = 3, CharacterA = "Stuart", CharacterB = "Bert", CharacterC = "Leonard", CharacterD = "Amy", CharacterE = "Sheldon" };

            return serie;
        }

        public Serie MrRobot(Serie serie)
        {
            serie = new Serie { Name = "Mr robot", CharacterA = "Elliot", CharacterB = "Darlene", CharacterC = "Tyrell", CharacterD = "Dominique", CharacterE = "White Rose" };

            return serie;
        }

        public Serie TWD(Serie serie)
        {
            serie = new Serie { Name = "The walking dead", CharacterA = "Rick", CharacterB = "Daryl", CharacterC = "Carol", CharacterD = "Michonne", CharacterE = "Carl" };

            return serie;
        }

        public Serie LaCasaDePapel(Serie serie)
        {
            serie = new Serie { Name = "La casa de papel", CharacterA = "Raquel", CharacterB = "Angel", CharacterC = "Rio", CharacterD = "Helsinki", CharacterE = "Tokyo" };

            return serie;
        }

        public Serie Breakingbad(Serie serie)
        {
            serie = new Serie { Name = "Breaking bad", CharacterA = "Skyler", CharacterB = "Hank", CharacterC = "Saul", CharacterD = "Walter", CharacterE = "Jesse" };

            return serie;
        }


        public Serie StrangerThings(Serie serie)
        {
            serie = new Serie { Name = "Stranger things", CharacterA = "Mike", CharacterB = "Will", CharacterC = "Lucas", CharacterD = "Dustin", CharacterE = "Eleven / Once" };

            return serie;
        }




    }
}
