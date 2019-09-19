using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPets
{
    class Organic : Pet
    {

        public int PetHunger { get; set; }
        public int PetBoredom { get; set; }
        public int PetHealth { get; set; }

        public Organic()
        {

            PetHunger = 5;
            PetBoredom = 5;
            PetHealth = 5;

        }



        public override void CreatePet(Pet myPet)
        {

            Console.WriteLine("\nWhat is your pet's name?");
            PetName = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("What species is your pet?");
            string petSpecies = Console.ReadLine().ToLower();
            PetSpecies = petSpecies;

            Console.Clear();


        }

        public override void Feed()
        {

            if (PetHunger > 0)
            {
                PetHunger--;
                Console.WriteLine("You have fed " + PetName);

            }

            else

                Console.WriteLine("Pet is full");

        }


        public override void Play()
        {


            if (PetBoredom > 0)
            {
                PetBoredom--;
                Console.WriteLine("You have played with " + PetName);
            }

            else

                Console.WriteLine("Pet is Happy");

        }
        public override void Health()
        {


            if (PetHealth < 10)
            {
                PetHealth++;
                Console.WriteLine("You have improved " + PetName + "'s health");
            }

            else

                Console.WriteLine("Pet is Healthy");

        }
        public override void PetInfo()
        {
            Console.WriteLine("organic");
            Console.WriteLine("Your pet name is " + PetName + " and it is an " + PetSpecies + ".");
        }
        public override void PetStatus()
        {
            Console.WriteLine(PetName + " status:");
            Console.WriteLine("hunger " + PetHunger);
            Console.WriteLine("boredom " + PetBoredom);
            Console.WriteLine("health " + PetHealth);
        }

        public override void Ticking()
        {
            PetBoredom++;
            PetHunger++;
            PetHealth--;
        }


    }
}
