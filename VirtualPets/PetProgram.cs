using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPets
{
    public class PetProgram
    {
        Pet myPet = new Pet();
        Shelter myShelter = new Shelter();
        Menu gameMenu = new Menu();

        public void Start()
        {

           bool inPlay = true;
                while (inPlay)
                {
                gameMenu.TheGameMenu();
                string input = Console.ReadLine().ToLower();


                switch (input)
                    {
                        case "l":
                            inPlay = false;
                            break;

                        case "a":
                            Console.Clear();
                            myPet = new Pet();
                            myPet.CreatePet();
                            myShelter.AddPetToShelter(myPet);
                       
                            break;

                        case "i":
                            Console.Clear();
                            myShelter.ShowListOfPets();
                            break;

                        case "m":
                            gameMenu.SelectPetMenu(myShelter);
                            break;

                        case "s":
                            Console.Clear();
                            myShelter.ShowStatusOfPets();
                            break;

                        case "f":
                            Console.Clear();
                        Console.WriteLine("Would you like to feed the one pet or all pets?");
                        gameMenu.SelectPetMenu(myShelter);
                        string userInput = Console.ReadLine();
                        bool singlePet = userInput.Equals(true);
                        if (singlePet)
                        {
                            
                        }
                            myShelter.FeedAllPets();
                            break;

                        case "p":
                            Console.Clear();
                            myShelter.PlayAllPets();
                            break;

                        case "h":
                            Console.Clear();
                            myShelter.HealAllPets();
                            break;

                    

                        default:
                            Console.WriteLine("Please enter proper response!!!!");
                            break;
                    }
               

                

                }
               
            
            }
            
                   
            
        }
        

        
    }

