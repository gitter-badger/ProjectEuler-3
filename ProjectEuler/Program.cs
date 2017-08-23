using System;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            RunSet1();
        }

        static void RunSet1()
        {
            Console.WriteLine("Find the sum of all the multiples of x or y below z. \nAll must be integers.");
            int x = (int) ReadNumber("Please enter x:");
            int y = (int) ReadNumber("Please enter y:");
            int z = (int) ReadNumber("Please enter z:");
            Console.WriteLine("Answer: {0}", Set1.Problem1(x,y,z));
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static double ReadNumber(string args)
        {
            Console.WriteLine(args);
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid number format, try again.");
            }
            return number;

        }
}
}
