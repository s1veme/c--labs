namespace ConsoleApp1.models
{
    class Regular : Car
    {
        public Regular()
        {
            Name = "Обычный автомобиль";
            MaxSpeed = 120;
            CurrentSpeed = 0;
            Distance = 0;
        }

        public override void SpeedUp()
        {
            if (CurrentSpeed < MaxSpeed)
                CurrentSpeed += 10;
        }

        public override void SpeedDown()
        {
            if (CurrentSpeed > 0)
                CurrentSpeed -= 5;
        }

        public override void Move()
        {
            Distance += CurrentSpeed;
            Console.WriteLine($"{Name} скорость: {CurrentSpeed} км/ч, расстояние: {Distance} км.");
        }
    }

}
