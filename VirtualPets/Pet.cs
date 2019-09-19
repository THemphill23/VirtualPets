using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPets
{
    public  class Pet 
    {
        Robotic robotic = new Robotic();
        Organic organic = new Organic();



        public string PetName { get; set; }
        //public enum Type { organic, robotic }
        public string PetType { get; set; }
        public string PetSpecies { get; set; }

        public int PetHunger { get; set; }
        public int PetHealth { get; set; }
        public int PetBoredom { get; set; }

        public Pet()
        {
            PetHunger = 5;
            PetHealth = 5;
            PetBoredom = 5;
            
        }

        

        public void CreatePet(Pet myPet)
        {
            
            Console.WriteLine("\nWhat is your pet's name?");
            PetName = Console.ReadLine();
            Console.Clear();
            //while (true)
            
                Console.WriteLine("Is your pet organic or robotic?");
                string petType = Console.ReadLine().ToLower();
                PetType = petType;
            //switch (petType)
            //{
            //    case "organic":
            //        organicPets.Add(myPet);
            //        break;

            //    case "robotic":
            //        roboticPets.Add(myPet);
            //        break;

            //    default:
            //        Console.WriteLine("not a valid entry");
            //        break;
                    //}
                    //if (petType == "robotic")
                    //else if (petType == "organic")
                    //break;

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
                Console.WriteLine("You have fed " + PetName);

            }

            else

                Console.WriteLine("Pet is full");

        }

        
        public void Play()
        {

            
            if (PetBoredom > 0)
            {
                PetBoredom --;
                Console.WriteLine("You have played with " + PetName);
            }

            else

                Console.WriteLine("Pet is Happy");

        }
        public void Health()
        {

           
            if (PetHealth < 10)
            {
                PetHealth ++;
                Console.WriteLine("You have improved " + PetName + "'s health");
            }

            else
            
                Console.WriteLine("Pet is Healthy");

        }
        public void PetInfo()
        {
            Console.WriteLine("Your pet name is " + PetName + " and it is an " + PetType + " " + PetSpecies + ".");
        }
        public  void PetStatus()
        {
                Console.WriteLine(PetName + " status:");
                Console.WriteLine("hunger " + PetHunger);
                Console.WriteLine("boredom " + PetBoredom);
                Console.WriteLine("health " + PetHealth);
            }
        


        //public void ShowOrganicPets()
        //{
        //    foreach (Pet pet in organicPets)
        //        pet.PetInfo();
        //}

        //public void ShowRoboticPets()
        //{
        //    foreach (Pet pet in roboticPets)
        //        pet.PetInfo();
        //}
    }
    


}
