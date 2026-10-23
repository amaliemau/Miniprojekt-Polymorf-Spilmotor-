using System;
using System.Collections.Generic;
using System.Text;

namespace Miniprojekt____Polymorf_Spilmotor_
{
    public interface IInteractable
    {
        public string Description { get; }


        public void Interact(Player player);
    }

}


