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
                Console.WriteLine("Døren er allerede låst op.");
                return;
            }

            if (player.HasKey)
            {
                isUnlocked = true;
                Console.WriteLine("Du bruger nøglen og låser døren op.");
            }
            else
            {
                Console.WriteLine("Døren er solidt låst. Du mangler en nøgle!");
            }
        }
    }

