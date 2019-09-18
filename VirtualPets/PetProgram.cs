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
                            myPet.CreatePet(myPet);
                            myShelter.AddPetToShelter(myPet);
                       
                            break;

                        case "i":
                            Console.Clear();
                            myShelter.ShowListOfPets();
                            break;

                        case "m":
                            gameMenu.PetMenu(myShelter);
                            break;

                        case "s":
                            Console.Clear();
                            myShelter.ShowStatusOfPets();
                            break;

                        case "f":
                            Console.Clear();
                            gameMenu.PetMenu(myShelter);
                            myShelter.FeedSinglePet();
                            break;

                    case "fa":
                            Console.Clear();
                            myShelter.FeedAllPets();
                            break;

                    //Console.WriteLine("Would you like to feed the one pet or all pets?");
                    //gameMenu.SelectPetMenu(myShelter);
                    case "p":
                        Console.Clear();
                        gameMenu.PetMenu(myShelter);
                        myShelter.PlaySinglePet();
                        break;


                    case "pa":
                            Console.Clear();
                            myShelter.PlayAllPets();
                            break;
                    case "h":
                        Console.Clear();
                        gameMenu.PetMenu(myShelter);
                        myShelter.HealSinglePet();
                        break;

                    case "ha":
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

