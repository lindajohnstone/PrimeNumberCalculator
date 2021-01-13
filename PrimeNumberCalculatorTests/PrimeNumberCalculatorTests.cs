using Xunit;
using PrimeNumberCalculator;
using System.Collections.Generic;

namespace PrimeNumberCalculatorTests
{
    public class PrimeNumberCalculatorTests
    {
        [Fact]
        public void Should_Test_PrimeNumberCalculator_Adds_To_List()
        {
            // arrange
            var primes = new Calculator();
            var limit = 10;
            var expected = new List<int>() {2, 3, 5, 7};
            // act
            var result = primes.Calculate(limit);
            // assert
            Assert.Equal(expected, result);
        }
    }
}
