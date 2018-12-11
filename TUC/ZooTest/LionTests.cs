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
        [Fact]
        public void Eat_validList_ReturnsCorrectList()
        {
            //arrange
            var testingLion = new Lion("klas", 1, 22);
            var panda = new Panda("Daniel",1, 1);
            var wombat = new Wombat("wombatName", 2, 4);

            List<Animal> animals = new List<Animal>();
            animals.Add(testingLion);
            animals.Add(panda);
            animals.Add(wombat);

            //act
            var result = testingLion.Eat(animals);
            //assert
            Assert.Contains(testingLion, result);
            Assert.Equal(2, animals.Count);
                                      
            
        }
        [Fact]
        public void Eat_ListThatDoesNotContainCalledLion_RetunsArgumentExceptions()
        {
            //arrange
            var testingLion = new Lion("klas", 1, 22);
            var panda = new Panda("Daniel", 1, 1);
            var wombat = new Wombat("wombatName", 2, 4);

            List<Animal> animals = new List<Animal>();
            
            animals.Add(panda);
            animals.Add(wombat);

            //act
            //&
            //assert
            var ex = Assert.Throws<ArgumentException>(() => testingLion.Eat(animals));


        }

    }
}
