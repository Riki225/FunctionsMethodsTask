using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Base Number:");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Exponent:");
            double b = int.Parse(Console.ReadLine());

            double c = Math.Pow(a,b);
            Console.WriteLine($"So, the number {a}^{b} = {c}");
        }
    }
}
