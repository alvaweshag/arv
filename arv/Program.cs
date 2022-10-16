using System;

namespace arv
{  // Alva Westrin Haglund .NET22
    class Program
    {
        static void Main(string[] args)
        {   // makes and prints out a snake 
            Snake snake = new Snake(false, 0,"lite överallt", "liten men kan vara stor", false, 2);

            Console.WriteLine("ORM");

            snake.PrintBase();
            snake.MakeSound();
            snake.Moving();
            snake.Eating();
            snake.SnakeThings();

            Console.WriteLine(" ");

            // makes and prints out a giraffe
            Giraffe giraffe = new Giraffe(false, 4, "på savannen", "stor", true, 222);

            Console.WriteLine("GIRAFF");

            giraffe.PrintBase();
            giraffe.MakeSound();
            giraffe.Moving();
            giraffe.Eating();
            giraffe.GiraffeThings();

            Console.WriteLine(" ");

            // makes and prints out a dog
            Dog dog = new Dog(true, 4, "med människor", "mellan", false, "Pitbull");

            Console.WriteLine("HUND");
     
            dog.PrintBase();
            dog.MakeSound();
            dog.Moving();
            dog.Eating();
            dog.DogThings();

            Console.WriteLine(" ");

            // makes and pritns out a chihuahua
            Chihuahua chihuahua = new Chihuahua(true, 4, "med människor", "liten", false, true);

            Console.WriteLine("CHIHUAHUA");

            chihuahua.PrintBase();
            chihuahua.MakeSound();
            chihuahua.Moving();
            chihuahua.Eating();
            chihuahua.ChihuahuaThings();
            chihuahua.DogThings();

            Console.WriteLine(" ");

            // makes and prints out a labrador
            Labrador labrador = new Labrador(true, 4, "med människor", "stor", false, true);

            Console.WriteLine("LABRADOR");

            labrador.PrintBase();
            labrador.MakeSound();
            labrador.Moving();
            labrador.Eating();
            labrador.LabradorThings();
            labrador.DogThings();
        }
    }
}
