using System;
using System.Collections.Generic;
using System.Text;


public class Goblin : IInteractable
{
    private int health;
    private readonly int attackDamage;
    private readonly int playerDamage;

    public string Description =>
        health > 0 ? $"A Goblin with {health} health" : "A defeated Goblin";

    public Goblin(int health = 40, int attackDamage = 15,
                  int playerDamage = 20)
    {
        this.health = health;
        this.attackDamage = attackDamage;
        this.playerDamage = playerDamage;
    }

    public void Interact(Player player)
    {
        if (health <= 0)
        {
            Console.WriteLine("The Goblin is already defeated.");
            return;
        }

        Console.WriteLine("The battle begins!");

        health = Math.Max(0, health - playerDamage);
        Console.WriteLine($"You attack the Goblin. It has {health} health left.");

        if (health <= 0)
        {
            Console.WriteLine("The Goblin is defeated!");
            player.AddGold(10);
            return;
        }

        Console.WriteLine("The Goblin attacks!");
        player.TakeDamage(attackDamage);
    }
}
