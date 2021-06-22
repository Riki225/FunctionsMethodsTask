using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter A String:");
            string userinput = Console.ReadLine();

            int spaces = 0;

            for (int i = 0; i < userinput.Length; i++)
            {
            if (userinput[i] == ' ')
            {
                spaces++;
            }
            }
            Console.WriteLine($"\"{userinput}\" contains {spaces} spaces");
        }
    }
}
