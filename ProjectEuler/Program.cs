using System;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            RunSet1();
        }

        static void RunSet1();
        {
            Console.WriteLine(string "Find the sum of all the multiples of x or y below z. \nAll must be integers.");
            int x = ReadNumber(string "Please enter x:");
            int y = ReadNumber(string "Please enter y:");
            int z = ReadNumber(string "Please enter z:");
            Console.WriteLine("Answer: {0}", Set1.Problem1(x,y,z));
        }
    
        static double ReadNumber(string args)
        {
            Console.WriteLine(args);
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid number format");
            }
            return number;

        }
}
}
