using System;

namespace Even_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number : ");
            num = Int32.Parse(Console.ReadLine());

            Console.WriteLine("--------------------");
            if(num%2==0)
            {
                Console.WriteLine(num + " is an even number");
            }
            else
            {
                Console.WriteLine( num + " is an odd number");
            }
            Console.WriteLine("--------------------");








            Console.ReadKey();
        }
    }
}
