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
                        Console.WriteLine("If you want to make an organic pet: press 'o'");
                        Console.WriteLine("If you want to make an robotic pet: press 'r'");
                        string OrganicOrRobotic = Console.ReadLine();
                        if (OrganicOrRobotic == "o")
                        {
                            myPet = new Organic();
                            myPet.CreatePet(myPet);
                            myShelter.AddPetToShelter(myPet);
                        }
                        else if (OrganicOrRobotic == "r")
                        {
                            myPet = new Robotic();
                            myPet.CreatePet(myPet);
                            myShelter.AddPetToShelter(myPet);
                        }

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

                    case "r":
                            Console.Clear();
                            int petIndex = SelectPetMenu(myShelter);
                            myShelter.RemovePet(petIndex);

                        break;

                    

                        default:
                            Console.WriteLine("Please enter proper response!!!!");
                            break;
                    }
               

                

                }
               
            
            }

        public static int SelectPetMenu(Shelter shelter)
        {
            Console.WriteLine("Please select a pet:");
            int petNumber = 1;
            foreach (Pet pet in shelter.allPetsInShelter)
            {
                Console.WriteLine($"{petNumber}. {pet.PetName}, {pet.PetSpecies}");
                petNumber++;
            }

            int selectedPetNumber = Convert.ToInt32(Console.ReadLine());

            return (selectedPetNumber - 1);
        }

    }
        

        
    }

