using System;
using System.Collections.Generic;
using System.Text;

namespace arv
{
    // Class Giraffe that inherits from class Djur
    class Giraffe : Djur
    {
        public int _noSpots;

        // constructor to create a giraffe
        public Giraffe(bool cute, int noLegs, string habitat, string size, bool endangered, int noSpots)
        {
            this.cute = cute;
            this.noLegs = noLegs;
            this.habitat = habitat;
            this.size = size;
            this.endangered = endangered;
            _noSpots = noSpots;
        }
        // methods that overrides the class djur
        public override void MakeSound()
        {
            Console.WriteLine("Giraffen är tyst");
        }
        public override void Moving()
        {
            Console.WriteLine("giraffen skuttar omkring");
        }
        public override void Eating()
        {
            Console.WriteLine("Giraffen äter löv");
        }

        // method unique to the giraffe class
        public void GiraffeThings()
        {
            Console.WriteLine("Böjer sig ner");
        }
    }
}
