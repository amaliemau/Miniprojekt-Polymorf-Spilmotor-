using System.Xml.Linq;

class Program
{

    public static void Main(string[] args)
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        Console.Write("Enter your health out of 100: ");
        int health = int.Parse(Console.ReadLine());
        Console.Write("Enter how much gold you have: ");
        int gold = int.Parse(Console.ReadLine());
        Player player = new Player(name) { Health = health, Gold = gold };
        player.ShowStatus();
        Console.WriteLine("You encounted a player");

        while (player.IsAlive)
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Run");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                player.TakeDamage(10);
                player.ShowStatus();
            }
            else if (choice == "2")
            {
                Console.WriteLine("You ran away!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}
