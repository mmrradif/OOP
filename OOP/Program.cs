using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dog
            Dog dog = new Dog();
            dog.Name = "Fido";
            dog.Age = 1;
            dog.Color = "White";
            dog.Move();
            dog.Move(5);
            Console.WriteLine("------------------------------");
            Console.WriteLine();


            // Cat
            Cat cat = new Cat();
            cat.Name = "Boxer";
            cat.Age = 2;
            cat.Move();
            cat.Move(3);
            Console.WriteLine("------------------------------");
            Console.WriteLine();


            // Zoo
            Zoo zoo = new Zoo();
            zoo.AddAnimal(dog);
            zoo.AddAnimal(cat);

            zoo.MakeAllSound();

            Console.ReadLine(); 
        }
    }
}
