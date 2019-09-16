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
            Console.WriteLine("Pet Inbound");
        }



    }
}
