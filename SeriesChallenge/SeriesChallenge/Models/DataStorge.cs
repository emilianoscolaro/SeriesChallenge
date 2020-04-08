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
            serie = new Serie { Name = "Game of thrones",NameDos="Juego de tronos", Index = 2, CharacterA = "Gilly", CharacterB = "Robert", CharacterC = "Oberyn", CharacterD = "Sansa", CharacterE = "Hodor" };

            return serie;
        }



        public Serie TheBigBangTheory(Serie serie)
        {
            serie = new Serie { Name = "The big bang theory", NameDos="La teoria del big bang", CharacterA = "Stuart", CharacterB = "Bert", CharacterC = "Leonard", CharacterD = "Amy", CharacterE = "Sheldon" };

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

        public Serie Vikingos(Serie serie)
        {
            serie = new Serie { Name = "Vikings" ,NameDos= "Vikingos", CharacterA = "Rollo", CharacterB = "Floki", CharacterC = "Bjorn", CharacterD = "Lagertha", CharacterE = "Ragnar" };

            return serie;
        }

        public Serie Dark(Serie serie)
        {
            serie = new Serie { Name = "Dark", CharacterA = "Jonas", CharacterB = "Katharina", CharacterC = "Magnus ", CharacterD = "Charlotte", CharacterE = "Ulrich" };

            return serie;
        }
        public Serie Lost(Serie serie)
        {
            serie = new Serie { Name = "Lost",NameDos= "Perdidos", CharacterA = "Hugo", CharacterB = "James", CharacterC = "Sun", CharacterD = "Kate", CharacterE = "Sayid" };

            return serie;
        }
        public Serie PrisonBreak(Serie serie)
        {
            serie = new Serie { Name = "Prison break", CharacterA = "Michael", CharacterB = "Sara", CharacterC = "Theodore 'T-Bag'", CharacterD = "Lincoln 'Linc'", CharacterE = "Fernando" };

            return serie;
        }
        public Serie LosSimpsons(Serie serie)
        {
            serie = new Serie { Name = "Los simpsons",NameDos ="The simpsons", CharacterA = "Troy", CharacterB = "Selma", CharacterC = "Bob", CharacterD = "Homero", CharacterE = "Bart" };

            return serie;
        }

    }


    public class SeriesNivelDos
    {
        public Serie MrRobot(Serie serie)
        {
            serie = new Serie { Name = "Mr robot", CharacterA = "Elliot", CharacterB = "Darlene", CharacterC = "Tyrell", CharacterD = "Dominique", CharacterE = "White Rose" };

            return serie;
        }

        public Serie Merli(Serie serie)
        {
            serie = new Serie { Name = "Merli", NameDos= "Merlí", CharacterA = "Pol", CharacterB = "Joan", CharacterC = "Berta", CharacterD = "Eugeni", CharacterE = "Gerard" };

            return serie;
        }

        public Serie HowIMetYourMother(Serie serie)
        {
            serie = new Serie { Name = "How I Met Your Mother",NameDos="Como conoci a su madre", CharacterA = "Lily", CharacterB = "Ted", CharacterC = "Marshall", CharacterD = "Robin", CharacterE = "Barney " };

            return serie;
        }

        public Serie TheOffice(Serie serie)
        {
            serie = new Serie { Name = "The office", CharacterA = "Pam", CharacterB = "Jim", CharacterC = "Dwight", CharacterD = "Michael", CharacterE = "Ryan" };

            return serie;
        }

        public Serie Seinfeld(Serie serie)
        {
            serie = new Serie { Name = "Seinfeld", CharacterA = "Elaine", CharacterB = "Jerry", CharacterC = "Kramer", CharacterD = "George", CharacterE = "Ruthie" };

            return serie;
        }

        public Serie PeakyBlinders(Serie serie)
        {
            serie = new Serie { Name = "Peaky blinders", CharacterA = "Arthur", CharacterB = "Thomas", CharacterC = "Polly", CharacterD = "Finn", CharacterE = "Grace" };

            return serie;
        }

        public Serie HouseofCards(Serie serie)
        {
            serie = new Serie { Name = "House of cards", CharacterA = "Francis", CharacterB = "Doug", CharacterC = "Seth", CharacterD = "Edward", CharacterE = "Claire" };

            return serie;
        }

        public Serie Dexter(Serie serie)
        {
            serie = new Serie { Name = "Dexter", CharacterA = "Debra", CharacterB = "Vince", CharacterC = "Angel", CharacterD = "Harry", CharacterE = "Dexter" };

            return serie;
        }



        public Serie Futurama(Serie serie)
        {
            serie = new Serie { Name = "Futurama", CharacterA = "Hermes", CharacterB = "Amy", CharacterC = "Leela", CharacterD = "Fry", CharacterE = "Bender" };

            return serie;
        }

        public Serie StarTrek(Serie serie)
        {
            serie = new Serie { Name = "Star trek", CharacterA = "Kirk", CharacterB = "McCoy", CharacterC = "Uhura", CharacterD = "Lt. Leslie", CharacterE = "Spock" };

            return serie;
        }


    }

    public class PelicilasNvUno
    {
        public Serie Elpadrino(Serie serie)
        {
            serie = new Serie { Name = "El padrino",NameDos= "The godfather", CharacterA = "Tom", CharacterB = "Michael", CharacterC = "Sonny", CharacterD = "Clemenza", CharacterE = "Don Vito Corleone" };

            return serie;
        }

        public Serie TheLordoftheRings(Serie serie)
        {
            serie = new Serie { Name = "The lord of the rings",NameDos= "El señor de los anillos", CharacterA = "Galadriel", CharacterB = "Sam", CharacterC = "Pippin", CharacterD = "Legolas", CharacterE = "Frodo" };

            return serie;
        }

        public Serie ForrestGump(Serie serie)
        {
            serie = new Serie { Name = "Forrest Gump", NameDos= "Forrest gump", CharacterA = "Jenny", CharacterB = "Dan", CharacterC = "Benjamin Buford", CharacterD = "Dorothy ", CharacterE = "Forrest" };

            return serie;
        }

        public Serie Matrix(Serie serie)
        {
            serie = new Serie { Name = "Matrix", CharacterA = "	Cypher", CharacterB = "Trinity", CharacterC = "Smith", CharacterD = "Morpheus", CharacterE = "Neo" };

            return serie;
        }

        public Serie CiudaddeDios(Serie serie)
        {
            serie = new Serie { Name = "Ciudad de Dios",NameDos= "Ciudad de dios", CharacterA = "Bené", CharacterB = "Dadinho", CharacterC = "Alicate", CharacterD = "Zé Pequeno", CharacterE = "Buscapé" };

            return serie;
        }

        public Serie Elsilenciodelosinocentes(Serie serie)
        {
            serie = new Serie { Name = "El silencio de los inocentes", NameDos= "The silence of the lambs", CharacterA = "Clarice", CharacterB = "Ardelia", CharacterC = "Miggs", CharacterD = "Hannibal", CharacterE = "¿es joda?" };

            return serie;
        }

        public Serie StarWars(Serie serie)
        {
            serie = new Serie { Name = "Star wars",NameDos= "La guerra de las galaxias", CharacterA = "Ben", CharacterB = "Han", CharacterC = "Luke", CharacterD = "Leia", CharacterE = "R2-D2" };

            return serie;
        }

        public Serie Elreyleon(Serie serie)
        {
            serie = new Serie { Name = "El rey leon",NameDos= "The lion king", CharacterA = "Sarabi", CharacterB = "Pumbaa", CharacterC = "Rafiki", CharacterD = "Simba", CharacterE = "Mufasa" };

            return serie;
        }

        public Serie BacktotheFuture(Serie serie)
        {
            serie = new Serie { Name = "Back to the future", NameDos="Volver al futuro",CharacterA = "Lorraine ", CharacterB = "George", CharacterC = "Marty", CharacterD = "Emmett", CharacterE = "Biff" };

            return serie;
        }

        public Serie Terminator(Serie serie)
        {
            serie = new Serie { Name = "Terminator", CharacterA = "Sarah", CharacterB = "John", CharacterC = "Dr. Silberman", CharacterD = "Miles", CharacterE = "Tarissa" };

            return serie;
        }

        public Serie Psycho(Serie serie)
        {
            serie = new Serie { Name = "Psycho",NameDos= "Psicosis", CharacterA = "Lila", CharacterB = "Norman", CharacterC = "Marion", CharacterD = "Sam", CharacterE = "Milton Arbogast" };

            return serie;
        }


    }
    public class PelicilasNvDos
    {

        public Serie Gladiator(Serie serie)
        {
            serie = new Serie { Name = "Gladiator",NameDos="Gladiador", CharacterA = "Lucilla", CharacterB = "Graco", CharacterC = "	Maximus", CharacterD = "Proximo", CharacterE = "Marcus Aurelius" };

            return serie;
        }

        public Serie Joker(Serie serie)
        {
            serie = new Serie { Name = "Joker",NameDos="Guason", CharacterA = "Arthur", CharacterB = "Murray", CharacterC = "	Sophie ", CharacterD = "Bruce", CharacterE = "Thomas" };

            return serie;
        }

        public Serie Alien(Serie serie)
        {
            serie = new Serie { Name = "Alien",NameDos= "Alien el octavo pasajero", CharacterA = "Dallas", CharacterB = "Ripley", CharacterC = "Lambert", CharacterD = "Brett", CharacterE = "Parker" };

            return serie;
        }

        public Serie Avengers(Serie serie)
        {
            serie = new Serie { Name = "Avengers",NameDos="Vengadores", CharacterA = "Tony", CharacterB = "Bruce", CharacterC = "Natasha ", CharacterD = "Thor", CharacterE = "Steve" };

            return serie;
        }

        public Serie Coco(Serie serie)
        {
            serie = new Serie { Name = "Coco", CharacterA = "Miguel", CharacterB = "Héctor", CharacterC = "Mamá Imelda", CharacterD = "Ernesto", CharacterE = "Dante" };

            return serie;
        }

        public Serie ToyStory(Serie serie)
        {
            serie = new Serie { Name = "Toy story", CharacterA = "Rex", CharacterB = "Sid", CharacterC = "	Woody", CharacterD = "Buzz", CharacterE = "Andy" };

            return serie;
        }

        public Serie KillBill(Serie serie)
        {
            serie = new Serie { Name = "Kill bill", CharacterA = "O-Ren Ishii", CharacterB = "Vernita", CharacterC = "	Budd", CharacterD = "Bill", CharacterE = "Hattori" };

            return serie;
        }

        public Serie Elclubdelapelea(Serie serie)
        {
            serie = new Serie { Name = "El club de la pelea",NameDos= "Fight club", CharacterA = "Tyler ", CharacterB = "Jack", CharacterC = "Richard", CharacterD = "Marla", CharacterE = "Angel Face" };

            return serie;
        }

        public Serie Titanic(Serie serie)
        {
            serie = new Serie { Name = "Titanic", CharacterA = "Jack", CharacterB = "Cal", CharacterC = "Rose", CharacterD = "Molly", CharacterE = "Fabrizzio" };

            return serie;
        }

        public Serie TheNotebook(Serie serie)
        {
            serie = new Serie { Name = "The notebook",NameDos="Diario de una pasion", CharacterA = "Allie", CharacterB = "Noah", CharacterC = "Fin", CharacterD = "Harry", CharacterE = "Lon Hammond" };

            return serie;
        }


    }
}
