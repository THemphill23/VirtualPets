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
            Console.WriteLine(pet);
            Console.WriteLine("Pet Inbound");
        }


        //public void Show_Pets_Name()
        //{

        //string nameOne = Pet.PetName;
        //    foreach (Pet pet in allPetsInShelter)

        //        Console.WriteLine(nameOne);

        ////}


    }
}
