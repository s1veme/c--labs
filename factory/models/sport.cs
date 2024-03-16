namespace ConsoleApp1.models
{
    class SportsCar : Car
    {
        public SportsCar()
        {
            Name = "Спортивный автомобиль";
            MaxSpeed = 300;
            CurrentSpeed = 0;
            Distance = 0;
        }

        public override void SpeedUp()
        {
            if (CurrentSpeed < MaxSpeed)
                CurrentSpeed += 30;
        }

        public override void SpeedDown()
        {
            if (CurrentSpeed > 0)
                CurrentSpeed -= 20;
        }

        public override void Move()
        {
            Distance += CurrentSpeed;
            Console.WriteLine($"{Name} скорость: {CurrentSpeed} км/ч, расстояние: {Distance} км.");
        }
    }
}
