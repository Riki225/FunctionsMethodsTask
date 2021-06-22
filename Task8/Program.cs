using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 1;
            int num3; 

            Console.WriteLine("Input number of Fibonacci Series :");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine($"The Fibonacci series of {length} numbers is:");
            Console.Write($"{num1} {num2} ");

            for (int i = 2; i < length; i++)
            {
                num3 = num1 + num2;
                Console.Write($"{num3} ");
                num1 = num2;
                num2 = num3;
            }
        }    
        
    }
}
