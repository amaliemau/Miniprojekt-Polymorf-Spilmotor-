using System;
using System.Collections.Generic;
using System.Text;


public class Monster : IInteractable
{
    private int health;
    private readonly int attackDamage;
    private readonly int playerDamage;

    public string Description =>
        health > 0 ? $"A Monster with {health} health" : "A defeated Monster";

    public Monster(int health = 40, int attackDamage = 15,
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
            Console.WriteLine("The Monster is already defeated.");
            return;
        }

        Console.WriteLine("The battle begins!");

        health = Math.Max(0, health - playerDamage);
        Console.WriteLine($"You attack the Monster. It has {health} health left.");

        if (health <= 0)
        {
            Console.WriteLine("The Monster is defeated!");
            player.AddGold(10);
            return;
        }

        Console.WriteLine("The Monster attacks!");
        player.TakeDamage(attackDamage);
    }
}
public class Goblin : Monster
{
    public Goblin() : base(health: 30, attackDamage: 10, playerDamage: 15)
    {
    }
}
public class Dragon : Monster
{
    public Dragon() : base(health: 100, attackDamage: 25, playerDamage: 30)
    {
    }
}