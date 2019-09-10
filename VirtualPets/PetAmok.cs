using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPets
{
    public class PetAmok
    {
        public Pet MyPet{get; set;}
        public void Start()
        {
            Console.WriteLine("Type start to begin the game.");

            while(true)
            {
                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case ("leave"):
                        return;

                    case ("start"):
                        Console.WriteLine("What is your pet's name?");
                        string petName = Console.ReadLine();
                        MyPet = this.CreatePet(petName);

                        Console.WriteLine("Your pet's name is " + petName);
                        Console.WriteLine("Is your pet organic or robotic?");
                        string petType = Console.ReadLine().ToLower();
                        SetPetType(petType);

                 break;

                        
                }
            }
        }
        public void SetPetType(string petType)

        {
            switch (petType)
            {

                case ("oragnic"):
                    Console.WriteLine("Your pet is organic.");
                    MyPet.PetType = Pet.Type.organic;
                    break;

                case ("robotic"):
                    Console.WriteLine("Your pet is robotic.");
                    MyPet.PetType = Pet.Type.robotic;
                    break;
            }
        }

        public Pet CreatePet(string petName)
        {
            var pet = new Pet();

            pet.petName = petName;

            return pet;
        }
    }
}
