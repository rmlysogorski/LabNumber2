using System;

namespace LabNumber2
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = String.Empty;
            float length = 0, width = 0, height = 0;
            bool again = true;

            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

            do
            {
                Console.Write("\nEnter Length: ");
                length = GetValidFloat();
                Console.Write("Enter Width: ");
                width = GetValidFloat();
                Console.Write("Enter Height: ");
                height = GetValidFloat();
                Console.WriteLine("Area: " + (length * width));
                Console.WriteLine("Perimeter: " + (2 * length + 2 * width));
                Console.WriteLine("Volume: " + (length * width * height));
                Console.Write("Continue? (y/n): ");
                choice = Console.ReadLine().ToUpper();
                if (choice[0] != 'Y')
                {
                    again = false;
                }
            } while (again == true);                       
        }

        private static float GetValidFloat()
        {
            string input = String.Empty;
            float num = 0;
            bool flag = false;

            do
            {
                input = Console.ReadLine();
                try
                {
                    num = float.Parse(input);
                    flag = true;

                }
                catch (FormatException)
                {
                    Console.Write("Please enter a valid floating point number: ");
                    flag = false;
                }
            } while (flag == false);
            return num;
        }
    }
}
