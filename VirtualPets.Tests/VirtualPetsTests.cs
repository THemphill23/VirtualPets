using System;
using Xunit;

namespace VirtualPets.Tests
{
    public class VirtualPetsTests
    {
        [Fact]
        public void Give_The_Pet_A_Name()
        {
            var pet = new Pet();

            pet.CreatePet("name");

            Assert.Equal("name", pet.PetName);
        }
        [Fact]
        public void Did_Pet_Hunger_Improve()
        {
            Pet pet = new Pet();

            pet.CreateHunger(pet.PetHunger-1);

            Assert.Equal(pet.PetHunger = pet.PetHunger -1, pet.PetHunger);
        }
        [Fact]
        public void Did_Pet_Boredom_Improve()
        {
            Pet pet = new Pet();

            pet.CreateBoredom(pet.PetBoredom - 1);

            Assert.Equal(pet.PetBoredom = pet.PetBoredom - 1, pet.PetBoredom);
        }
        [Fact]
        public void Did_Pet_Health_Improve()
        {
            Pet pet = new Pet();

            pet.CreateHealth(pet.PetHealth + 1);

            Assert.Equal(pet.PetHealth = pet.PetHealth + 1, pet.PetHealth);
        }

        

    }
}
