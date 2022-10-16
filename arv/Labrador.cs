using System;
using System.Collections.Generic;
using System.Text;

namespace arv
{   // class Labrador that inherits from the Dog class
    class Labrador : Dog

    {   // unique variable that only exists in the Labrador class 
        public bool _labLike;

        // constructor to create a labrador
        public Labrador(bool cute, int noLegs, string habitat, string size, bool endangered, bool labLike)
        {
            this.cute = cute;
            this.noLegs = noLegs;
            this.habitat = habitat;
            this.size = size;
            this.endangered = endangered;
            this._breed = "Labrador";
            _labLike = labLike;
        }
        // method unique to the labrador class
        public void LabradorThings()
        {
            Console.WriteLine("Labradoren hämtar en boll");
        }
    }
}
