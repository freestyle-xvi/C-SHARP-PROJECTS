using System;

namespace Average_of_3_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            int average;

            Console.WriteLine("Average of 3 numbers program");
            Console.WriteLine("-----------------------------");

            Console.WriteLine("\nEnter the 1st number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number: ");
            num2 =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 3rd number: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            average = (num1 + num2 + num3)  / 3;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("The average of the 3 numbers is : " + average);
            Console.WriteLine("------------------------------------------");











            Console.ReadKey();
        }
    }
}
