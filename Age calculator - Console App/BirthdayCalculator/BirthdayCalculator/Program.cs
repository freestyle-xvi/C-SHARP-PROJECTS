using System;

namespace BirthdayCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 0;
            int dob = 0;
            int result;
            int days;
             
            Console.WriteLine("Age calculator");
            Console.WriteLine("-------------------");

            Console.WriteLine("\nEnter current year");
            year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter your year of birth");
            dob = Convert.ToInt32(Console.ReadLine());

            result = year - dob;


            Console.WriteLine("-------------------------------------");

            Console.WriteLine("\nyou are " + result + " years old" );
            Console.WriteLine("\n" + result * 12 + " months old");

            days = result * 365;

            Console.WriteLine("\n" + days + " days old");

            




            Console.ReadKey();
        }
    }
}
