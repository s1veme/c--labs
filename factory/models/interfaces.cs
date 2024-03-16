namespace ConsoleApp1.models
{
    interface ICarFactory
    {
        Car CreateCar();
    }

    class SportsCarFactory : ICarFactory
    {
        public Car CreateCar()
        {
            return new SportsCar();
        }
    }

    class RegularFactory : ICarFactory
    {
        public Car CreateCar()
        {
            return new Regular();
        }
    }
}
