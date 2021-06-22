using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PC will calculate the sum of two numbers...");
            Console.WriteLine("Please Enter A Number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Another Number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int sum = num1 + num2;
            Console.WriteLine($"The Sum of The Two Numbers Is : {sum}");
        }
    }
}
