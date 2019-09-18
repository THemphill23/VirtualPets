using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPets
{
    public class Menu
    {
        public void TheGameMenu()
        {
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("Enter 'L' to leave");
            Console.WriteLine("Type 'A' to add a pet to shelter.");

            Console.WriteLine("\nOnce you have a pet added:");
            Console.WriteLine("Type 'I' to view its information.");
            Console.WriteLine("Type 'S' to view its status.");

            Console.WriteLine("Type 'M' to see list of pets.");

            Console.WriteLine("Type 'F' to give a chosen pet food.");
            Console.WriteLine("Type 'FA' to feed all pets in the shelter.");
            Console.WriteLine("Type 'P' to play with your pet.");
            Console.WriteLine("Type 'H' to heal your pet.");

        }


        //public Pet SelectPetMenu(Shelter shelter)
        //{

        //    Console.WriteLine("\nWhich Pet would you like to interact with?");
        //    int petNumber = 1;
        //    foreach (Pet pet in shelter.allPetsInShelter)
        //    {
        //        Console.WriteLine($"{petNumber} {pet.PetName} {pet.PetSpecies} {pet.PetType}");
        //        petNumber++;
        //    }
        //    int selectedPetNumber = Convert.ToInt32(Console.ReadLine());
        //    return shelter.allPetsInShelter[selectedPetNumber -1];
        //}

        public Pet PetMenu(Shelter shelter)
        {

            int petNumber = 1;
            foreach (Pet pet in shelter.allPetsInShelter)
            {
                Console.WriteLine($"{petNumber} {pet.PetName} {pet.PetSpecies} {pet.PetType}");
                petNumber++;
            }
            return null;
        }
    }
            
    
    
}
