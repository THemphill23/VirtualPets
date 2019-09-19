using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPets
{
    public class Shelter
    {
        public List<Pet> allPetsInShelter = new List<Pet>();
        public List<Pet> roboticPets = new List<Pet>();
        public List<Pet> organicPets = new List<Pet>();

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
                //if (pet.PetType == "organic")
                //    pet.PetStatus();

                //else if (pet.PetType == "robotic")
                //    pet.PetStatus();
                //else Console.WriteLine("not a valid entry");
                //break;

            }
        }
        public void FeedSinglePet()
        {
            Console.WriteLine("\nPlease select a pet from your shelter");
            Pet myPet = allPetsInShelter[Convert.ToInt32(Console.ReadLine())-1];
            myPet.Feed();
        }
        public void PlaySinglePet()
        {
            Console.WriteLine("\nPlease select a pet from your shelter");
            Pet myPet = allPetsInShelter[Convert.ToInt32(Console.ReadLine()) - 1];
            myPet.Play();
        }
        public void HealSinglePet()
        {
            Console.WriteLine("\nPlease select a pet from your shelter");
            Pet myPet = allPetsInShelter[Convert.ToInt32(Console.ReadLine()) - 1];
            myPet.Health();
        }

        public void FeedAllPets()
        {
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
