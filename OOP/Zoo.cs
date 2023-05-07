using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Zoo
    {
        private List<Animal> animals;

        public Zoo()
        {
            animals = new List<Animal>();
        }


        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }


        public void MakeAllSound()
        {
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Name);
                Console.WriteLine(animal.Age);

                animal.MakeSound();

                Console.WriteLine("-----------------------------");
                Console.WriteLine();
            }
        }
    }
}
