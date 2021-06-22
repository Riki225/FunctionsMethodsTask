using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Another Number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Now the 1st number is: {num2}, and the 2nd number is: {num1}");
        }
    }
}
