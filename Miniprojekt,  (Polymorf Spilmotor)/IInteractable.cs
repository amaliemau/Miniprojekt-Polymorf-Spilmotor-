using System;
using System.Collections.Generic;
using System.Text;

    public interface IInteractable
    {
        public string Description { get; }


        public void Interact(Player player);
    }




