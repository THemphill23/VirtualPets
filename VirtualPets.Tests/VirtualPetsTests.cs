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

        //[Fact]
        //public void Is_Your_Pet_Organic()
        //{
        //    var petAmok = new PetAmok();
        //    petAmok.MyPet = new Pet();

        //    petAmok.SetPetType("organic");

        //    Assert.Equal(Pet.Type.organic, petAmok.MyPet.PetType);
        //}
       
        //[Fact]
        //public void Is_Your_Pet_Robotic()
        //{
        //    var petAmok = new PetAmok();
        //    petAmok.MyPet = new Pet();

        //    petAmok.SetPetType("robotic");

        //    Assert.Equal(Pet.Type.robotic, petAmok.MyPet.PetType);
        //}
       
    }
}
