
using System;
using System.Collections.Generic;
using System.Text;

public class DungeonRoom
{
    public string RoomName { get; set; }

    public List<IInteractable> ObjectsInRoom = new List<IInteractable>();

    public DungeonRoom(string roomName)
    {
        RoomName = roomName;
    }

    public void AddObject(IInteractable obj)
    {
        ObjectsInRoom.Add(obj);
    }

    public void ExploreRoom(Player player)
    {
        Console.WriteLine("{\nYou have entered the " + RoomName);
        Console.WriteLine("what would you like to search?\n");

        for (int i = 0; i < ObjectsInRoom.Count; i++)
        {
            Console.WriteLine(
                (i + 1) + ". " + ObjectsInRoom[i].Description
            );
        }

        if (ObjectsInRoom.Count == 0)
        {
            Console.WriteLine("Rummet indeholder ingen objekter.");
            return;
        }

        Console.Write("\nVælg et objekt (1-" +
                ObjectsInRoom.Count + "): ");

        int choice;

        // Kontrollér, at input er et gyldigt tal
        if (int.TryParse(Console.ReadLine(), out choice))
        {
            // Kontrollér, at valget er inden for listen
            if (choice >= 1 && choice <= ObjectsInRoom.Count)
            {
                // Hent det valgte objekt
                IInteractable selectedObject =
                    ObjectsInRoom[choice - 1];

                // Interagér med objektet
                selectedObject.Interact(player);
            }
            else
            {
                Console.WriteLine("Ugyldigt valg!");
            }
        }
        else
        {
            Console.WriteLine("Du skal indtaste et tal!");
        }
    }
}
