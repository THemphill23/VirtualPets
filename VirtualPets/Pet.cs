using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPets
{
    public class Pet
    {
        public string PetName { get; set; }
        public enum Type { organic, robotic }
        public string PetType { get; set; }
        public string PetSpecies { get; set; }

        public int PetHunger = 10;
        public int PetBoredom = 10;
        public int PetHealth = 10;

        public void CreatePet(string petName)
        {
            this.PetName = petName;
        }

        //public void CreateHunger(int petHunger)
        //{
        //    this.PetHunger = petHunger;
        //}
        //public void CreateBoredom(int petBoredom)
        //{
        //    this.PetBoredom = petBoredom;
        //}
        //public void CreateHealth(int petHealth)
        //{
        //    this.PetHealth = petHealth;
        //}
    }


}
