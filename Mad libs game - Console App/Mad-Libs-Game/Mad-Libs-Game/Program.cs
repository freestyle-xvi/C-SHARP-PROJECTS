using System;

namespace Mad_Libs_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //MAD LIBS GAME ........... idk what that even is ngl but i understand the concept lmfao.

            String color, pluralNoun, celebrity;

            Console.WriteLine("| MAD LIBS GAME |");

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.WriteLine("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.WriteLine("Enter a celebrity or fictional character: ");
            celebrity = Console.ReadLine();







            Console.WriteLine("\nRoses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I hate " + celebrity);

            Console.ReadKey();
        }
    }
}

