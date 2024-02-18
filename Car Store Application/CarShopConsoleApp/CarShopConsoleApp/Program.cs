using System;
using CarClassLibrary;
class program
{
    static void Main(string[]args)
    {
        Store s = new Store();

        Console.WriteLine("\n| Welcome to XVI Motorsports |\n \nFirst you must create a car inventory. \nThen you can add cars to your shopping cart.\nFinally you may check out and will be given a total of all the cars in your shopping cart.");

        int action = ChooseAction();
        while (action!= 0)
        {
            Console.WriteLine("\nYou chose " + action);

            switch (action)
            {
               
                case 1:
                    Console.WriteLine("\nYou chose to add a new car to the inventory");
                    string carMake = " ";
                    string carModel = " ";
                    decimal carPrice = 0;

                    Console.WriteLine("\nWhat is the make/manufacturer of the car?");
                    carMake = Console.ReadLine();

                    Console.WriteLine("\nWhat is the model of the car?");
                    carModel = Console.ReadLine();

                    Console.WriteLine("\nWhat is the price of the car");
                    carPrice = int.Parse(Console.ReadLine());

                    Car newCar = new Car(carMake, carModel, carPrice);
                    s.CarList.Add(newCar);

                    printInventory(s);

                    break;

                    case 2:
                    Console.WriteLine("\nYou chose to add a car to your shopping cart ↓");
                    printInventory(s);
                    Console.WriteLine("Which item would you like to buy? (number)");
                    int carChosen = int.Parse(Console.ReadLine());

                    s.ShoppingList.Add(s.CarList[carChosen]);
                    printShoppingCart(s);
                    break;

                case 3:
                    printShoppingCart(s);
                    Console.WriteLine("The total cost your cart: " + s.Checkout());
                    break;

                default:
                    break;
            }
            action = ChooseAction();
        }
        Console.ReadKey();
    }

    private static void printShoppingCart(Store s)
    {
        Console.WriteLine("Cars you have chosen to buy");
        for (int i = 0; i < s.ShoppingList.Count; i++)
        {

            Console.WriteLine("\nCar number is: " + i + " " + s.ShoppingList[i]);
        }
    }

    private static void printInventory(Store s)
    {
        for (int i = 0; i < s.CarList.Count; i++)
        {
            
            Console.WriteLine("\nCar number is: " + i + " " + s.CarList[i]);
        }
    }
    static public int ChooseAction()
    {
        int choice = 0;
        Console.WriteLine("\nChoose an action :  \n(0) To quit. \n(1) To add a new car to your inventory. \n(2) To add a car to your cart. \n(3) To checkout.");
        choice = int.Parse(Console.ReadLine());
        return choice;
    }
}


