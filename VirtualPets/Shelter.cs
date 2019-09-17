using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPets
{
    public class Shelter
    {
        public List<Pet> allPetsInShelter = new List<Pet>();
          
        public void AddPetToShelter(Pet myPet)
        {
           
            allPetsInShelter.Add(myPet);

        }

        public void ShowListOfPets()
        {
            foreach (Pet pet in allPetsInShelter)
            pet.PetInfo();
        }
        public void ShowStatusOfPets()
        {
            foreach (Pet pet in allPetsInShelter)
            {
                pet.PetStatus();
                Console.WriteLine();
            }
        }
        public void FeedAllPets()
        {
            Console.WriteLine("Would you like to feed the one pet or all pets?");
            gameMenu.SelectPetMenu(myShelter);
            string userInput = Console.ReadLine();
            bool singlePet = userInput.Equals(true);
            if (singlePet)
            {
                Pet.Feed();
            }
            foreach (Pet pet in allPetsInShelter)
            pet.Feed();
        }
        public void HealAllPets()
        {
            foreach (Pet pet in allPetsInShelter)
            pet.Health();
        }
        public void PlayAllPets()
        {
            foreach (Pet pet in allPetsInShelter)
            pet.Play();
        }
    }
}
