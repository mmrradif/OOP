using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Dog:Animal
    {
        public string Color { get; set; }

        public override void MakeSound()
        {
            Console.WriteLine("Dogs are Barking");
        }


        public override void Move()
        {
            base.Move();
        }


        public override void Move(int distance)
        {
            Console.WriteLine($"Dogs are Moving with Distance {distance}");
        }
    }
}
