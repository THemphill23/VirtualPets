using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPets
{
    public class PetProgram
    {
        Pet myPet = new Pet();
        Shelter myShelter = new Shelter();

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
                    Console.WriteLine("Type 'H' to heal your pet.");
                    Console.WriteLine("Type 'V' to view the list of pets.");
                    string input = Console.ReadLine().ToLower();
                    

                    switch (input)
                    {
                        case "l":
                            inPlay = false;
                            break;

                        case "a":
                            myPet.CreatePet();
                            myShelter.AddPetToShelter(myPet);
                       
                            break;

                        case "v":
                            myShelter.ShowListOfPets();
                            break;

                        case "i":

                            Console.Clear();
                            myPet.PetInfo();
                            break;

                        case "s":
                            Console.Clear();
                            myPet.PetStatus();
                            break;

                        case "f":
                            Console.Clear();
                            myPet.Feed();

                            break;

                        case "p":
                            Console.Clear();
                            myPet.Play();
                            break;

                        case "h":
                            Console.Clear();
                            myPet.Health();
                            break;

                    

                        default:
                            Console.WriteLine("Please enter proper response!!!!");
                            break;
                    }
               

                

                }
               
            
            }
            
                   
            
        }
        

        
    }

