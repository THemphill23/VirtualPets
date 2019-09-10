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
                Console.WriteLine("Type 'Add' to add a pet to shelter");
                Console.WriteLine("After you Add a pet, type 'Info' to view its information.");
                Console.WriteLine("Type 'Info' to view its information, 'Status' to view its status,");
                Console.WriteLine("After you Add a pet, type 'Feed' to give your pet food.");
                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case ("l"):
                        inPlay = false;
                        break;

                    case ("add"):
                        Console.WriteLine("What is your pet's name?");
                        string petName = Console.ReadLine();
                        //int petHunger = Convert.ToInt32("10");
                        //int petBoredom = Convert.ToInt32("10");
                        //int petHealth = Convert.ToInt32("10");
                        Console.Clear();
                        myPet.CreatePet(petName);

                        Console.WriteLine("Your pet's name is " + petName);
                        while (true)
                        {
                            Console.WriteLine("Is your pet organic or robotic?");
                            string petType = Console.ReadLine().ToLower();
                            myPet.PetType = petType;

                            if (petType == "organic")
                                break;
                            else if (petType == "robotic")
                                break;
                            else Console.WriteLine("not a valid entry");
                        }

                        while (true)
                        {

                            Console.WriteLine("What species of pet is it");
                            Console.WriteLine("Dog, Cat, Hampster, Lizard, Bird, Robot");
                            string petSpecies = Console.ReadLine().ToLower();
                            myPet.PetSpecies = petSpecies;

                            if (petSpecies == "dog")
                                break;
                            else if (petSpecies == "cat")
                                break;
                            else if (petSpecies == "hampster")
                                break;
                            else if (petSpecies == "lizard")
                                break;
                            else if (petSpecies == "bird")
                                break;
                            else if (petSpecies == "robot")
                                break;
                        
                            else Console.WriteLine("not a valid entry");

                        }
                         Console.Clear();
                        
                        
                        break;

                        
                      
                    case ("info"):
                        
                        Console.Clear();
                        Console.WriteLine("Your pet name is " + myPet.PetName + " and it is an " + myPet.PetType + " " + myPet.PetSpecies);
                        break;

                    case ("status"):
                        Console.Clear();
                        Console.WriteLine("Your pets status is:");
                        Console.WriteLine("hunger " + myPet.PetHunger);
                        Console.WriteLine("boredom " + myPet.PetBoredom);
                        Console.WriteLine("health " + myPet.PetHealth);
                        break;

                    case ("feed"):
                        Console.Clear();
                        Console.WriteLine("You have fed your pet.");
                        myPet.PetHunger -- ;
                        break;
                    default:
                        Console.WriteLine("Please enter proper response");
                        break;
                }
            }
        }
        

        
    }
}
