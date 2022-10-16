using System;
using System.Collections.Generic;
using System.Text;

namespace arv
{   // class Chihuahua that inherits from the Dog class
    class Chihuahua : Dog
    {   // unique variable that only exists in the Chihuahua class
        public bool _ratLike;

        // constructor to create a chihuahua
        public Chihuahua(bool cute, int noLegs, string habitat, string size, bool endangered, bool ratLike)
        {
            this.cute = cute;
            this.noLegs = noLegs;
            this.habitat = habitat;
            this.size = size;
            this.endangered = endangered;
            this._breed = "Chihuahua";
            _ratLike = ratLike;
        }
        // method unique to the chihuahua class
        public void ChihuahuaThings()
        {
            Console.WriteLine("Chihuahuan sover");
        }
    }

}
