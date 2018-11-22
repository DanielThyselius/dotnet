using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Zoo;

namespace ZooTest
{
    public class WombatTests
    {
        
        public WombatTests()
        {

        }

        [Fact]
        public void CalculateFood_testingValidWombat_ReturnsCorrectValue()
        {
            //arrange
            var testingWombat = new Wombat("klas", 1, 22);
            //act
            var result = testingWombat.CalculateFood();
            //assert
            Assert.Equal(19.8, result);

        }
        [Fact]
        public void CalculateFood_testingValidWombat_ReturnsInCorrectValue()
        {
            //arrange
            var testingWombat = new Wombat("klas", 1, 22);
            //act
            var result = testingWombat.CalculateFood();
            //assert
            Assert.NotEqual(1, result);
        }

        [Fact]
        public void CalculateFood_testingInvalidWombat_ReturnsException()
        {
            //arrange
            var testingWombat = new Wombat("klas", -1, 22);
            //act & assert
            var ex = Assert.Throws<Exception>(() => testingWombat.CalculateFood());
            
        }
        [Fact]
        public void CalculateFood_testingValidWombatWithAgeAboveSix_ReturnsCorrectValue()
        {
            //arrange
            var testingWombat = new Wombat("klas", 7, 22);
            //act
            var result = testingWombat.CalculateFood();
            //assert
            Assert.Equal(8.8, result);

        }




    }
}
