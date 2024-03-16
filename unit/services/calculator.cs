namespace ConsoleApp1.services
{
    class CalculatorService
    {
        public static List<double> Calculate(double k, double N, int countIterations)
        {
            List<double> results = new List<double>();
            for (double x = 0; x <= k; x += 0.1)
            {
                countIterations--;
                if (countIterations <= 0)
                {
                    return results;
                }

                try
                {
                    results.Add(1 / (x - N));
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("failed divisions by zero");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("failed going out of range");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("failed going out of range");
                }
            }
            return results;
        }
    }
}
