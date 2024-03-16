using System;

namespace ThreadRobot
{
    public class Robot
    {
        public Tuple<int, int> Coordinates { get; set; }
        public string Name { get; }
        public int Direction { get; }

        private static Random Random = new Random();
        
        public Robot(string name)
        {
            Name = name;
            Coordinates = new Tuple<int, int>(0, 0);
            Direction = Random.Next(0, 4);
        }

        public string GetInfo()
        {
            return $"{Name} ({Coordinates.Item1} {Coordinates.Item2}) {getDirection()}";
        }

        private string getDirection() {
            string direction;
            switch (Direction)
            {
                case 0:
                    direction = "Вперёд";
                    break;
                case 1:
                    direction = "Назад";
                    break;
                case 2:
                    direction = "Вправо";
                    break;
                case 3:
                    direction = "Влево";
                    break;
            }
        }

        public void Move()
        {
            Direction = Random.Next(0, 4);
            switch (Direction)
            {
                case 0: // Вперёд
                    Coordinates = new Tuple<int, int>(Coordinates.Item1, Coordinates.Item2 + 1);
                    break;
                case 1: // Назад
                    Coordinates = new Tuple<int, int>(Coordinates.Item1, Coordinates.Item2 - 1);
                    break;
                case 2: // Вправо
                    Coordinates = new Tuple<int, int>(Coordinates.Item1 + 1, Coordinates.Item2);
                    break;
                case 3: // Влево
                    Coordinates = new Tuple<int, int>(Coordinates.Item1 - 1, Coordinates.Item2);
                    break;
            }
        }
    }
}
