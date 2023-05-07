using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal abstract class Animal : IMove
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract void MakeSound();


        public virtual void Move()
        {
            Console.WriteLine("Animals are Moving");
        }

        public virtual void Move(int distance)
        {
            Console.WriteLine($"Animals are moving with distance {distance}");
        }
    }
}
