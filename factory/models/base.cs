using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.models
{
    abstract class Car
    {
        public string Name;
        public int MaxSpeed;
        public int Distance;
        public int CurrentSpeed;

        public abstract void SpeedUp();
        public abstract void SpeedDown();
        public abstract void Move();

        public void Finish()
        {
            Console.WriteLine($"{Name} финишировал!");
        }
    }
}
