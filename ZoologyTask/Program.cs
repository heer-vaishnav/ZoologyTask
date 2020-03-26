using System;

namespace ZoologyTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zoology Department of Microdoc College ");
            Console.WriteLine("LIFE OF ELEPHANTS");
            Elephant elephant = new Elephant();
            elephant.African();
            elephant.Asian();
            elephant.Trunk();
            elephant.Tusk();
            elephant.Teeth();
            elephant.Skin();
            elephant.Legs();
            elephant.Ears();
            elephant.Herbivores();
            elephant.Interval();
            elephant.Weight();
            elephant.Use();
            Console.WriteLine("Hope you find it interesting.");
            Console.WriteLine("Thank You!!");
            Console.ReadKey();
        }
    }
}
