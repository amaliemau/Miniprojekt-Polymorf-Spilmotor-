using System.Xml.Linq;


using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine() ?? "Player";

        Console.Write("Enter your health out of 100: ");
        int health = int.Parse(Console.ReadLine()!);

        Console.Write("Enter how much gold you have: ");
        int gold = int.Parse(Console.ReadLine()!);

        Player player = new Player(name)
        {
            Health = health,
            Gold = gold
        };

        player.ShowStatus();

        List<DungeonRoom> rooms = new List<DungeonRoom>
        {
            new DungeonRoom(" dark and damp cave"),
            new DungeonRoom("room filled with treasure"),
            new DungeonRoom(" room with a sleeping dragon")
        };

        rooms[0].AddObject(new Chest(Rarity.Common));
        rooms[0].AddObject(new LockedDoor());
        rooms[0].AddObject(new Dragon());

        rooms[1].AddObject(new Chest(Rarity.Uncommon));
        rooms[1].AddObject(new Goblin());

        rooms[2].AddObject(new Goblin());
        rooms[2].AddObject(new Chest(Rarity.Rare));

        int currentRoom = 0;

        while (player.IsAlive)
        {
            Console.WriteLine("\nWhat do you want to do?");
            Console.WriteLine("1. Explore room");
            Console.WriteLine("2. Change room");
            Console.WriteLine("3. Show status");
            Console.WriteLine("4. Run away");
            Console.Write("Choose: ");

            string choice = Console.ReadLine() ?? "";

            if (choice == "1")
            {
                rooms[currentRoom].ExploreRoom(player);
            }
            else if (choice == "2")
            {
                currentRoom = ChangeRoom(rooms, currentRoom);
            }
            else if (choice == "3")
            {
                player.ShowStatus();
            }
            else if (choice == "4")
            {
                Console.WriteLine("You ran away!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }

        if (!player.IsAlive)
        {
            Console.WriteLine("\nGame over! You have no health left.");
            player.ShowStatus();
        }
    }

    static int ChangeRoom(List<DungeonRoom> rooms, int currentRoom)
    {
        Console.WriteLine("\nChoose a room:");

        for (int i = 0; i < rooms.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {rooms[i].RoomName}");
        }

        Console.Write("Enter room number: ");
        string input = Console.ReadLine() ?? "";

        if (int.TryParse(input, out int choice) &&
            choice >= 1 && choice <= rooms.Count)
        {
            Console.WriteLine($"You entered {rooms[choice - 1].RoomName}");
            return choice - 1;
        }

        Console.WriteLine("Invalid room number.");
        return currentRoom;
    }
}

