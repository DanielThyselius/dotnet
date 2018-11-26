using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Zoo;

namespace ZooTest
{
    public class LionTests
    {
        public LionTests()
        {

        }
        [Fact]
        public void CalculateFood_testingValidPanda_ReturnsCorrectValue()
        {
            //arrange
            var testingLion = new Lion("klas", 1, 22);
            //act
            var result = testingLion.CalculateFood();
            //assert
            Assert.Equal(0, result);
        }
    }
}
