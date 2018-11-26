using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Zoo;

namespace ZooTest
{
    public class PandaTests
    {
        public PandaTests()
        {

        }

        [Fact]
        public void CalculateFood_testingValidPanda_ReturnsCorrectValue()
        {
            //arrange
            var testingPanda = new Panda("klas", 1, 22);
            //act
            var result = testingPanda.CalculateFood();
            //assert
            Assert.Equal(2, result);

        }
        
        [Fact]
        public void CalculateFood_testingInvalidPanda_ReturnsException()
        {
            //arrange
            var testingPanda = new Panda("klas", -1, 22);
            //act & assert
            var ex = Assert.Throws<Exception>(() => testingPanda.CalculateFood());

        }
        [Fact]
        public void CalculateFood_testingValidPandaWithAgeAboveSix_ReturnsCorrectValue()
        {
            //arrange
            var testingPanda = new Panda("klas", 7, 22);
            //act
            var result = testingPanda.CalculateFood();
            //assert
            Assert.Equal(12, result);

        }
        [Fact]
        public void CalculateFood_testingValidPandaWithZeroWeight_ReturnsException()
        {
            //arrange
            var testingPanda = new Panda("klas", 7, 0);
            //act 
            //&
            //assert
            var ex = Assert.Throws<Exception>(() => testingPanda.CalculateFood());

        }
        [Fact]
        public void CalculateFood_testingValidPandaWithNegativeWeight_ReturnsException()
        {
            //arrange
            var testingPanda = new Panda("klas", 7, -1);
            //act 
            //&
            //assert
            var ex = Assert.Throws<Exception>(() => testingPanda.CalculateFood());

        }
    }
}
