using System;

namespace Lab2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            char choice;

            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

            do
            {
                Console.WriteLine("Enter Length");
                float userInput1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter Width");
                float userInput2 = float.Parse(Console.ReadLine());

                Console.WriteLine($"Area is {userInput1 * userInput2}");
                Console.WriteLine($"Perimeter is {userInput1 * 2 + userInput2 * 2}");

                Console.WriteLine("Continue? Enter (Y/N)");
                choice = Convert.ToChar(Console.ReadLine().ToUpper());

            } while (choice.Equals(Char.Parse("Y")));

            Console.WriteLine("Have a Great Day!");

            Console.ReadKey();
        }
    }
}
