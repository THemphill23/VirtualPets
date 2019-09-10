using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPets
{
    public class PetAmok
    {
        Pet myPet = new Pet();

        public void Start()
        {

            bool inPlay = true;
            while(inPlay)
            {
                Console.WriteLine();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Enter 'L' to leave");
                Console.WriteLine("Type 'Add' to add a pet");
                Console.WriteLine("After you Add a pet, type 'Info' to view its information");

                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case ("l"):
                        inPlay = false;
                        break;

                    case ("add"):
                        Console.WriteLine("What is your pet's name?");
                        string petName = Console.ReadLine();
                        Console.Clear();
                        myPet.CreatePet(petName);

                        Console.WriteLine("Your pet's name is " + petName);
                        Console.WriteLine("Is your pet organic or robotic?");
                        string petType = Console.ReadLine().ToLower();
                        Console.Clear();
                        myPet.PetType = petType;
                        break;
                      
                    case ("info"):
                        
                        Console.Clear();
                        Console.WriteLine("Your pet name is " + myPet.PetName + " and it is " + myPet.PetType);
                       
                        break;

                    default:
                        Console.WriteLine("Please enter proper response");
                        break;
                }
            }
        }
        

        
    }
}
