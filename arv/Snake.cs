using System;
using System.Collections.Generic;
using System.Text;

namespace arv
{
    // Class Snake that inherits from class Djur
    class Snake : Djur
    {
        public int _noEyes;
        // constructor to create a snake
        public Snake(bool cute, int noLegs, string habitat, string size, bool endangered, int noEyes)
        {
            this.noLegs = noLegs;
            this.habitat = habitat;
            this.size = size;
            this.endangered = endangered;
            _noEyes = noEyes;
        }
        // methods that overrides the class djur
        public string length = "1 meter";
        public override void MakeSound()
        {
            Console.WriteLine("sssssssssssss");
        }
        public override void Moving()
        {
            Console.WriteLine("ormen krålar");
        }
        public override void Eating()
        {
            Console.WriteLine("Ormen äter en björn");
        }

        // method unique to the giraffe class
        public void SnakeThings()
        {
            Console.WriteLine("ormen byter skinn");
        }
    }
}
