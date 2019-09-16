﻿using System;
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
                            myPet = new Pet();
                            myPet.CreatePet();
                            myShelter.AddPetToShelter(myPet);
                       
                            break;

                        case "i":
                            myShelter.ShowListOfPets();
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

