using System;
using System.Threading;
using ThreadRobot;

namespace Program
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            start();
        }

        private static void start()
        {
            Robot[] robots = new Robot[10];

            for (int i = 0; i < 10; i++)
            {
                robots[i] = new Robot($"Robot {i}");
            }

            for (int index = 0; index < 20; index++)
            {
                new Thread((() =>
                {
                    for (int j = 0; j < 10; j++)
                    {
                        robots[index].Move();
                        Console.WriteLine(robots[index].GetInfo());
                    }
                })).Start();
            }
        }
    }
}
