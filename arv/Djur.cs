using System;
using System.Collections.Generic;
using System.Text;

namespace arv
{
    // base class Djur
    class Djur
    { 
        public bool cute = false;
        public int noLegs = 0;
        public string habitat = "ingenstans";
        public string size = "superstor";
        public bool endangered = true;

        // methods for the class Djur
        public virtual void Eating()
        {
            Console.WriteLine("...");
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("...");
        }
        public virtual void Moving()
        {
            Console.WriteLine("...");
        }
        public void PrintBase()
        {
            Console.WriteLine("Antal ben: " + noLegs);
            Console.WriteLine("Habitat: " + habitat);
            Console.WriteLine("Storlek: " + size);
            Console.WriteLine("hotad: " + endangered);
        }
    }
}
