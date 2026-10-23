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

    }
}
