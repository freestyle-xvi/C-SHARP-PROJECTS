using System;

namespace Calculator.XVI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                do
                {
                    double num1 = 0;
                    double num2 = 0;
                    double result = 0;

                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("XVI || Calculator Program || XVI");
                    Console.WriteLine("---------------------------------");

                    Console.Write("Enter number 1: ");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter number 2: ");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter an option: ");
                    Console.WriteLine("\t+ : Add");
                    Console.WriteLine("\t- : Subtract");
                    Console.WriteLine("\t* : Multiply");
                    Console.WriteLine("\t/ : Divide");
                    Console.Write("Enter an option: ");


                    switch (Console.ReadLine())
                    {
                        case "+":
                            result = num1 + num2;
                            Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                            break;
                        case "-":
                            result = num1 - num2;
                            Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                            break;
                        case "*":
                            result = num1 * num2;
                            Console.WriteLine($"Your result: {num1} * {num2} = " + result);
                            break;
                        case "/":
                            result = num1 / num2;
                            Console.WriteLine($"Your result: {num1} / {num2} = " + result);
                            break;
                        default:
                            Console.WriteLine("That was not a valid option");
                            break;
                    }

                    Console.Write("Would you like to continue? (Y = yes, N = No): ");
                } while (Console.ReadLine().ToUpper() == "Y");
            }
            catch(FormatException )
            {
                Console.WriteLine("YOU CAN ONLY ENTER NUMBERS YOU IDIOT!!!");
            }
            catch(Exception )
            {
                Console.WriteLine("Something went wrong , please try again.");
            }
            finally
                {
                Console.WriteLine("thanks for using XVI calculators, get good.");
            }

                Console.WriteLine("Bye!");
                Console.ReadKey();
            








            //Console.ReadKey();
        }
    }
}
