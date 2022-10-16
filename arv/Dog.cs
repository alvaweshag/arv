using System;
using System.Collections.Generic;
using System.Text;

namespace arv
{
    // Class Dog that inherits from class Djur
    class Dog : Djur
    {
        // Unique variable that only exists in dog class
        public string _breed;

        // constructor to create a dog
        public Dog(bool cute, int noLegs, string habitat, string size, bool endangered, string breed)
        {
            this.cute = cute;
            this.noLegs = noLegs;
            this.habitat = habitat;
            this.size = size;
            this.endangered = endangered;
            _breed = breed;
        }
        // constructor with default values
        public Dog()
        {
            this.cute = true;
            this.noLegs = 4;
            this.habitat = "med människor";
            this.size = "mellan";
            this.endangered = false;
        }
        // methods that overrides the class djur
        public override void MakeSound()
        {
            Console.WriteLine("VOFF VOFF!");
        }
        public override void Moving()
        {
            Console.WriteLine("hunden sniffar runt");
        }
        public override void Eating()
        {
            Console.WriteLine("Hunden äter godis");
        }

        // method unique to the dog class
        public void DogThings()
        {
            Console.WriteLine("luktar");
        }

    }
}
