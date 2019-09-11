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
                while (inPlay)
                {
                    Console.WriteLine("\nWhat would you like to do?");
                    Console.WriteLine("Enter 'L' to leave");
                    Console.WriteLine("Type 'A' to add a pet to shelter.");

                    Console.WriteLine("\nOnce you have a pet added:");
                    Console.WriteLine("Type 'I' to view its information.");
                    Console.WriteLine("Type 'S' to view its status.");

                    Console.WriteLine("Type 'F' to give your pet food.");
                    Console.WriteLine("Type 'P' to play with your pet.");
                    Console.WriteLine("Type 'D' to heal your pet.");
                    string input = Console.ReadLine().ToLower();
                    

                    switch (input)
                    {
                        case ("l"):
                            inPlay = false;
                            break;

                        case ("a"):
                            Console.WriteLine("\nWhat is your pet's name?");
                            string petName = Console.ReadLine();
                            Console.Clear();
                            myPet.CreatePet(petName);

                            
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
                            Console.WriteLine("What species is your pet?");
                            string petSpecies = Console.ReadLine().ToLower();
                            myPet.PetSpecies = petSpecies;
                            Console.Clear();
                            break;

                        case ("i"):

                            Console.Clear();
                            Console.WriteLine("Your pet name is " + myPet.PetName + " and it is an " + myPet.PetType + " " + myPet.PetSpecies + ".");
                            break;

                        case ("s"):
                            Console.Clear();
                            Console.WriteLine("Your pets status is:");
                            Console.WriteLine("hunger " + myPet.PetHunger);
                            Console.WriteLine("boredom " + myPet.PetBoredom);
                            Console.WriteLine("health " + myPet.PetHealth);
                            break;

                        case ("f"):
                            Console.Clear();

                            Console.WriteLine("You have fed your pet.");
                            myPet.Feed();

                            break;

                        case ("p"):
                            Console.Clear();
                            Console.WriteLine("You have played with your pet.");

                            myPet.CreateBoredom(myPet.PetBoredom);
                            break;

                        case ("d"):
                            Console.Clear();
                            Console.WriteLine("You have improved your pet's health.");

                            myPet.CreateHealth(myPet.PetHealth);
                            break;

                        default:
                            Console.WriteLine("Please enter proper response!!!!");
                            break;
                    }
                }
               
            
            }
            
                   
            
        }
        

        
    }

