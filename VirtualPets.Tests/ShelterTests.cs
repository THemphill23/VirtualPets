using System;
using Xunit;

namespace VirtualPets.Tests
{
    public class ShelterTests
    {
        Pet pet;
        Shelter shelter;

       
        
        [Fact]
        public void Is_A_List_Made()
        {

        }



        [Fact]
        public void Pet_Gets_Added_To_List()
        {
            Pet pet = new Pet();
            Shelter shelter = new Shelter();
            shelter.allPetsInShelter.Clear();

            shelter.AddPetToShelter(pet);

            Assert.Single(shelter.allPetsInShelter);



        }





    }
}
