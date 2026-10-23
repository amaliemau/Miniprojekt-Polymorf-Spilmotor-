using System;
using System.Collections.Generic;
using System.Text;


    public class Player
    {
    public string Name { get; set; }
    public int Health { get; set; }
    public int Gold { get; set; }
    public bool HasKey { get; set; }
    public bool IsAlive => Health > 0;

    public Player (string name)
    {
        Name = name;
    }

    public void TakeDamage(int amount)
    {
        if (amount <= 0) return;

        Health = Math.Max(0, Health - amount);
        Console.WriteLine($"{Name} mister {amount} liv!");
    }
    public void AddGold(int amount)
    {
        if (amount <= 0) return;
        Gold += amount;
        Console.WriteLine($"{Name} har fået {amount} guld!");
    }
    public void ShowStatus()
    {
        Console.WriteLine("======= Player Status =======");
        Console.WriteLine($"Name:    {Name}");
        Console.WriteLine($"Health:     {Health}/100");
        Console.WriteLine($"Gold:    {Gold}");
        Console.WriteLine($"Key:   {(HasKey ? "Ja" : "Nej")}");
    }
}

    