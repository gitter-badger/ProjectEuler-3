using System;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Find the sum of all the multiples of x or y below z. \nAll must be integers.");
	        var x = (int)ReadNumber("Please enter x:");
	        var y = (int)ReadNumber("Please enter y:");
	        var z = (int)ReadNumber("Please enter z:");
	        Console.WriteLine("Answer: {0}", Set1.Problem1(x, y, z));
	        Console.WriteLine("Press any key to exit...");
	        Console.ReadKey();
		}

		/// <summary>
		/// Wrapper for sanitized input from console
		/// </summary>
		/// <param name="args">Message to print to the user</param>
		/// <returns>Input value</returns>
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
