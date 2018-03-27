using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppLightbulbAdventure
{
    class Lightbulb
    {        

        private bool lit = false;

        public void Toggle()
        {
            lit = !lit;           
        }
        
        public bool Lit
        {
            get
            {
                return lit;
            }
        }

        public Lightbulb()
        {
            Console.WriteLine("Ik ben een pratende lamp en ik ben zonet gemaakt.");
        }

        public void WasMade(Person p)
        {
            Console.WriteLine("Hell yes! Ik ben gevonden door {0}.", p.Voornaam);
            Console.WriteLine("Toggle-time");
            this.Toggle();
            this.Toggle();
            this.Toggle();
        }
    }
}
