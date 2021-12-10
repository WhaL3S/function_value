class Program
    {
        static void Main(string[] args)
        {
            double x, result;
            Console.WriteLine("Enter the number:");
            x = double.Parse(Console.ReadLine());
            if (x >= -2 && x < 0)
            {
                result = 3.2 * x * x;
            }
            else if (x >= 0 && x <= 1)
            {
                result = Math.Pow(Math.Sin(x + 1), 2);
            }
            else
            {
                result = 3 * x * x - 1;
            }
            Console.WriteLine(result);
        }
    }
