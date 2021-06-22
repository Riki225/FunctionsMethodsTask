using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            int num1 = num;
            int sum = 0;

            while (num > 0)
            {
                sum += (num % 10);
                num = num / 10;
            }

            Console.WriteLine($"The sum of the digits of the number {num1} is: {sum}");
        }
    }
}
