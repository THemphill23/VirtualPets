using System;
using Xunit;

namespace VirtualPets.Tests
{
    public class VirtualPetsTests
    {
        Pet pet;
        Shelter shelter;

        public VirtualPetsTests()
            {
            pet = new Pet();
            shelter = new Shelter();
            }
       


        [Fact]
        public void Did_Pet_Hunger_Improve()
        {

            pet.Feed();

            Assert.Equal(4, pet.PetHunger);
        }

        [Fact]
        public void Hunger_Does_Not_Go_Below_Zero()
        {

            pet.PetHunger = 0;
            pet.Feed();

            Assert.Equal(0, pet.PetHunger);
        }

        [Fact]
        public void Did_Pet_Boredom_Improve()
        {

            pet.Play();

            Assert.Equal(4, pet.PetBoredom);

        }
        [Fact]
        public void Boredom_Does_Not_Go_Below_Zero()
        {

            pet.PetBoredom = 0;
            pet.Play();

            Assert.Equal(0, pet.PetBoredom);
        }
        [Fact]
        public void Did_Pet_Health_Improve()
        {

            pet.Health();

            Assert.Equal(6, pet.PetHealth);
        }
        [Fact]
        public void Health_Does_Not_Go_Above_Ten()
        {

            pet.PetHealth = 10;
            pet.Health();

            Assert.Equal(10, pet.PetHealth);
        }
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
