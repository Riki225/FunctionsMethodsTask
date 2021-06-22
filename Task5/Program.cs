using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elementArray = new int[5];
            int i;

            Console.WriteLine("Please Input 5 Elements, Pressing Enter At The End of Each Input.");
            for (i=0; i<5; i++)
            {
                Console.Write($"element - {i} : ");
	            elementArray[i] = int.Parse(Console.ReadLine());  	
            }

            Console.WriteLine("The Sum Of The Elements Of The Array Is: ");
            int sum = 0;
            for (i=0; i<5; i++)
            {
                sum += elementArray[i];
            }
           Console.WriteLine(sum);
        }
    }
}
