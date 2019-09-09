using System;
using Xunit;

namespace VirtualPets.Tests
{
    public class VirtualPetsTests
    {
        [Fact]
        public void Get_Returns_Player_Can_Start_Game()
        {
            var clickStart = new ClickStart();

            var result = clickStart.Start(1);

            Assert.Equal("1", result);
        }

        [Fact]
        public void Player_Starts_Game()
        {
            ClickStart clickStart = new ClickStart();

            string result = clickStart.Start(1);

            Assert.Equal("1", result);
        }

       
    }
}
