using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPets
{
    class Menu
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

            Console.WriteLine("Type 'F' to give your pet food.");
            Console.WriteLine("Type 'P' to play with your pet.");
            Console.WriteLine("Type 'H' to heal your pet.");

        }
        
            
            public int SelectPetMenu(Shelter shelter)
            {

                Console.WriteLine("\nWhich Pet would you like to interact with?");
                int petNumber = 1;
                foreach(Pet pet in shelter.allPetsInShelter)
                    {
                        Console.WriteLine($"{petNumber} {pet.PetName} {pet.PetSpecies} {pet.PetType}");
                        petNumber++;
                    }
            string selectedPetNumber = Console.ReadLine();

                return Convert.ToInt32(selectedPetNumber) -1;

        //}
            }
            
    //    Console.WriteLine("Please select a car:");
    //        int carNumber = 1;
    //        foreach(Car car in garage.Cars)
    //        {
    //        Console.WriteLine(carNumber + ", " + car.Make + ", " + car.Model);
    //        carNumber++;
    //        }

    //string selectedCarNumber = Console.ReadLine();

    //        return Convert.ToInt32(selectedCarNumber) -1;
    }
}
