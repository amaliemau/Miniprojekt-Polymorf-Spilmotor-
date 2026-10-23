using System;
using System.Collections.Generic;
using System.Text;


    public class LockedDoor
    {
        private bool isUnlocked=false;
        public void Interact(Player player)
        {
            if (isUnlocked)
            {
                Console.WriteLine("Door is already open");
                return;
            }

            if (player.HasKey)
            {
                isUnlocked = true;
                Console.WriteLine("You have the key and open the door");
            }
            else
            {
                Console.WriteLine("The door is closed. You haven´t the key");
            }
        }
    }

