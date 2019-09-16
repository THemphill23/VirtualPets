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

        public void CreatePet()
        {
            
            Console.WriteLine("\nWhat is your pet's name?");
            PetName = Console.ReadLine();
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Is your pet organic or robotic?");
                string petType = Console.ReadLine().ToLower();
                PetType = petType;

                if (petType == "organic")
                    break;
                else if (petType == "robotic")
                    break;
                else Console.WriteLine("not a valid entry");
            }
            Console.WriteLine("What species is your pet?");
            string petSpecies = Console.ReadLine().ToLower();
            PetSpecies = petSpecies;

            Console.Clear();


        }

        public void Feed()
        {

            if (PetHunger > 0)
            {
                PetHunger--;
                Console.WriteLine("You have fed your pet.");

            }

            else

                Console.WriteLine("Pet is full");

        }
        public void Play()
        {

            
            if (PetBoredom > 0)
            {
                PetBoredom --;
                Console.WriteLine("You have played with your pet.");
            }

            else

                Console.WriteLine("Pet is Happy");

        }
        public void Health()
        {

           
            if (PetHealth < 10)
            {
                PetHealth ++;
                Console.WriteLine("You have improved your pet's health.");
            }

            else
            
                Console.WriteLine("Pet is Healthy");

        }
        public void PetInfo()
        {
            Console.WriteLine("Your pet name is " + PetName + " and it is an " + PetType + " " + PetSpecies + ".");
        }
        public void PetStatus()
        {
            Console.WriteLine("Your pets status is:");
            Console.WriteLine("hunger " + PetHunger);
            Console.WriteLine("boredom " + PetBoredom);
            Console.WriteLine("health " + PetHealth);
        }
        

    }
    


}
