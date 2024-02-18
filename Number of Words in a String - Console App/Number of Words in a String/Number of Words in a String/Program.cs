using System;

namespace Number_of_Words_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            String sentence;
            Console.WriteLine("Enter a string : ");
            sentence = Console.ReadLine();
            String[] words = sentence.Split(' ');
            Console.WriteLine("Number of words in the sentence : " + words.Length);
            Console.ReadKey();
        }
    }
}
