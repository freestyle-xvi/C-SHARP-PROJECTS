internal class programBase
{
    static public int ChooseAction()
    {
        int choice = 0;
        Console.WriteLine("choose an action (0) to quit (1) to add a new car to yuor inventory (2) to add a car to your cart (3) to checkout");

        choice = int.Parse(Console.ReadLine());
        return choice; 
    }
}