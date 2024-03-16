using ConsoleApp1.models;


class Program
{
    static void Main(string[] args)
    {
        ICarFactory sportsCarFactory = new SportsCarFactory();
        ICarFactory regularFactory = new RegularFactory();

        List<Car> cars = new List<Car>
        {
            sportsCarFactory.CreateCar(),
            regularFactory.CreateCar(),
            sportsCarFactory.CreateCar(),
            regularFactory.CreateCar(),
        };


        var finishedCars = runRace(cars, 500);

        int place = 1;
        foreach (var car in finishedCars)
        {
            Console.WriteLine($"{place}. {car.Name}");
            place++;
        }
    }

    private static List<Car> runRace(List<Car> cars, int distance)
    {
        List<Car> finishedCars = new List<Car>();

        while (true)
        {
            foreach (var car in cars)
            {
                if (finishedCars.Count == cars.Count)
                {
                    return finishedCars;
                }

                if (finishedCars.Contains(car))
                {
                    continue;
                }

                if (car.CurrentSpeed > car.MaxSpeed)
                {
                    car.SpeedDown();
                }
                else
                {
                    car.SpeedUp();
                }

                car.Move();

                if (car.Distance >= distance)
                {
                    car.Finish();
                    finishedCars.Add(car);
                }
            }
        }
    }
}