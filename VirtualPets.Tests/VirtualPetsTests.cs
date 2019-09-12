using System;
using Xunit;

namespace VirtualPets.Tests
{
    public class VirtualPetsTests
    {
        [Fact]
        public void Did_Pet_Hunger_Improve()
        {
            Pet pet = new Pet();

            pet.Feed();

            Assert.Equal(4, pet.PetHunger);
        }

        [Fact]
        public void Hunger_Does_Not_Go_Below_Zero()
        {
            Pet pet = new Pet();

            pet.PetHunger = 0;
            pet.Feed();

            Assert.Equal(0, pet.PetHunger);
        }

        [Fact]
        public void Did_Pet_Boredom_Improve()
        {
            Pet pet = new Pet();

            pet.Play();

            Assert.Equal(4, pet.PetBoredom);

        }
        [Fact]
        public void Boredom_Does_Not_Go_Below_Zero()
        {
            Pet pet = new Pet();

            pet.PetBoredom = 0;
            pet.Play();

            Assert.Equal(0, pet.PetBoredom);
        }
        [Fact]
        public void Did_Pet_Health_Improve()
        {
            Pet pet = new Pet();

            pet.Health();

            Assert.Equal(6, pet.PetHealth);
        }
        [Fact]
        public void Health_Does_Not_Go_Above_Ten()
        {
            Pet pet = new Pet();

            pet.PetHealth = 10;
            pet.Health();

            Assert.Equal(10, pet.PetHealth);
        }


    }
}
