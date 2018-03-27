using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppLightbulbAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Er waren eens twee stoere boys.");
 
            var karel = new Person("Karel");
            var derk = new Person("Derk");

            Console.WriteLine("Ze heette {0} en {1}.", karel.Voornaam, derk.Voornaam);

            var ledLight = new Lightbulb();
            var flashLight = new Lightbulb();

            Console.WriteLine("De zaklamp brandt {0}.", flashLight.Lit ? "" : "niet");
            Console.WriteLine("In het bos lagen allerlei voorwerpen");
            Console.WriteLine("Deze voorwerpen konden gevonden worden...");

            flashLight.WasMade(karel);

            karel.Geboortedatum = new DateTime(2000, 1, 1);
            karel.Postcode = "1000";
            derk.Geboortedatum = new DateTime(2012, 1, 2);
            derk.Postcode = "6666";

            Console.WriteLine("Karel is {0} jaar.", karel.Leeftijd);
            Console.WriteLine("Derk is {0} jaar.", derk.Leeftijd);
            
        }
    }
}
