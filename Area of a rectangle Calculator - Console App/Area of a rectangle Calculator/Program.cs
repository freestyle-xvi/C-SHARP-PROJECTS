using System;

namespace Area_of_a_rectangle_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" Area and Perimeter of a rectangle ");
            Console.WriteLine("-----------------------------------");

            int length;
            int width;
            int area;
            int perimeter;

            Console.WriteLine("\nEnter the length of the Rectangle in cm");
            length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter the width of the Rectangle in cm");
            width = Convert.ToInt32(Console.ReadLine());

            area = length * width;

            perimeter = length * 2 + width * 2;

            Console.WriteLine("\nThe perimeter of your Rectangle is: " + perimeter + "cm");
            Console.WriteLine("The area of your Rectangle is: " + area + "cm");

          











            Console.ReadKey();
        }
    }
}
