using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num; 
            int a; 
            int b = 0; 
            int counter = 0;

            Console.WriteLine("Input a number:");
            num = int.Parse(Console.ReadLine());
            
            b = num / 2;

            for (a = 2; a <= b; a++)
            {
                if (num % a == 0)
                {
                    Console.WriteLine($"{num} is Not a Prime Number.");
                    counter = 1;
                    break;
                }
            }
            if (counter == 0)
                Console.WriteLine($"{num} is a Prime Number.");
        }
    }
}
