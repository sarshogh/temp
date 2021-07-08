using System;
using Xunit;

namespace repo1_app1
{
    public class UnitTest1
    {
        [Fact]
        public void SampleUnitTest1()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Unit test starting...");
            Console.WriteLine("--------------------------------------");
            Assert.False(1 == 0);
        }

        [Fact]
        public void IsUKWonFootballIn2021AgainstDenmark()
        {
            //Given  //Arrange

            //When   // Action

            //Then   // Assert
            Assert.True(1 == 1);
        }
    }
}
