class Program
{
    public void Main(string[] args)
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        Console.Write("Enter your health: ");
        int health = int.Parse(Console.ReadLine());
        Console.Write("Enter your gold: ");
        int gold = int.Parse(Console.ReadLine());
        Player player = new Player(name) { Health = health, Gold = gold };
        player.ShowStatus();            
    }
}
