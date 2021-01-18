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
            primes.Calculate(limit);
            var result = primes.Calculate(limit);
            // assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Should_Test_PrimeNumberCalculator_List_Count()
        {
            // arrange
            var primes = new Calculator();
            var limit = 10;
            var expected = 4;
            // act
            var result = primes.Calculate(limit);
            // assert
            Assert.Equal(expected, result.Count);
        }
        [Fact]
        public void Should_Find_All_OddNumbers_In_List()
        {
            // arrange
            var oddNumbers = new Calculator();
            var limit = 10;
            var expected = new List<int> { 1, 3, 5, 7, 9 };
            // act
            var result = oddNumbers.FindOdd(limit);
            // assert
            Assert.Equal(expected, result);
        }
    }
}
