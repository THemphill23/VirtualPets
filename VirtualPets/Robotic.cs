using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPets
{
    class Robotic : Pet
    {
        public int PetOil { get; set; }
        public int PetPower { get; set; }

        public Robotic(string name, string species)
        {
            PetName = PetName;
            PetSpecies = PetSpecies;
            PetHunger = PetOil; 
            PetBoredom = PetBoredom;
            PetHealth = PetPower; 
        }

        public override void PetStatus()
        {
            Console.WriteLine(PetName + " status:");
            Console.WriteLine("oil " + PetHunger);
            Console.WriteLine("boredom " + PetBoredom);
            Console.WriteLine("power " + PetHealth);
        }
    }
}
