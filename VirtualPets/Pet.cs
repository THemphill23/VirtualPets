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

        public void CreatePet(string petName)
        {
            //var pet = new Pet();

            this.PetName = petName;

            
        }
    }


}
