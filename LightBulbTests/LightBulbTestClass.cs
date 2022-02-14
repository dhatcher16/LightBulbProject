using System;
using Xunit;
using LightBulbProject;

namespace LightBulbTests
{
    public class LIghtBulbTestClass
    {
        [Theory]
        [InlineData(new int[] { 1,2,3,4,5}, 5)]
        [InlineData(new int[]{2, 1, 3, 5, 4}, 3)]
        [InlineData(new int[]{2, 3, 4, 1, 5}, 2)]
        [InlineData(new int[]{1, 3, 4, 2, 5}, 3)]
        public void Test1(int[] order, int expectedOutput)
        {
            Assert.Equal(LightBulb.CountMomentsAllTurnedOn(order), expectedOutput);
        }
    }
}
