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

        public int PetHunger { get; set; }
      
        public int PetBoredom { get; set; }
        public int PetHealth { get; set; }

        public Pet()
        {
            PetHunger = 5;
            PetBoredom = 5;
            PetHealth = 5;
            
        }

        public void CreatePet(string petName)
        {
            this.PetName = petName;
        }

        public void Feed()
        {
            if (PetHunger > 0)
            {
                PetHunger--;

            }

            else

                Console.WriteLine("Pet is full");

        }
        public void CreateBoredom(int petBoredom)
        {

            this.PetBoredom = petBoredom;
            if (PetBoredom > 0)
            {
                PetBoredom --;

            }

            else

                Console.WriteLine("Pet is Happy");

        }
        public void CreateHealth(int petHealth)
        {

            this.PetHealth = petHealth;
            if (PetHealth < 10)
            {
                PetHealth ++;

            }

            else
            
                Console.WriteLine("Pet is Healthy");

        }
       
    }
    


}
