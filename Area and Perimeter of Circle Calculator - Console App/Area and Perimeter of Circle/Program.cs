using System;

namespace Area_and_Perimeter_of_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            double perimeter;
            double area;

            Console.WriteLine("Area and Perimeter of Circle Calculator");

            Console.WriteLine("\nEnter the radius of your circle");
            radius = Convert.ToDouble(Console.ReadLine());

            perimeter = 2 * 3.14 * radius;
            area = 3.14 * radius * radius;

            Console.WriteLine("\nThe perimeter of your circle is :  " + perimeter);
            Console.WriteLine("The area of your circle is :  " +  area);






            Console.ReadKey();
        }
    }
}
