namespace PracticeConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guy joe = new() { Name = "Joe", Cash = 50 };
            Guy bob = new() { Name = "Bob", Cash = 100 };
            while (true)
            {   
                Console.WriteLine("Hello Bob and Joe I am dzungf and will be the witness to your transaction.");
                joe.WriteMyInfo();
                bob.WriteMyInfo();
                Console.Write("Enter an amount you want to give (or a blank to exit): ");
                string howMuch = Console.ReadLine();
                if (howMuch == "") return;
                if (int.TryParse(howMuch, out int amount))
                {
                    Console.Write("Who should give the cash (Joe or Bob) : ");
                    
                    string whichGuy = Console.ReadLine();
                    while (whichGuy != "Joe" && whichGuy != "Bob")
                    {
                        Console.Write("Please enter either Joe or Bob: ");
                        whichGuy = Console.ReadLine();
                    }
                    if (whichGuy == "Joe")
                    {
                        int cashGiven = joe.GiveCash(amount);
                        bob.ReceiveCash(cashGiven);
                        Console.WriteLine("Enter to start new transaction");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else if (whichGuy == "Bob")
                    {
                        int cashGiven = bob.GiveCash(amount);
                        joe.ReceiveCash(cashGiven);
                        Console.WriteLine("Enter to start new transaction");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Plase enter either Joe or Bob");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an amount (or a blank to exit).");
                }

            }
        }
    }
}
