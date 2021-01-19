using Xunit;
using PrimeNumberCalculator;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

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
        public void Should_FindAll_Odd_Numbers_In_List()
        {
            // arrange
            var oddNumbers = new Calculator();
            var numbers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var expected = new List<int> { 1, 3, 5, 7, 9 };
            // act
            var result = oddNumbers.FindOdd(numbers);
            // assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Should_FindAll_Even_Numbers_In_List()
        {
            // arrange
            var evenNumbers = new Calculator();
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var expected = new List<int> { 2, 4, 6, 8, 10 };
            // act
            var result = evenNumbers.FindEven(numbers);
            // arrange
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Should_Test_DoubleAll_Doubles_Numbers()
        {
            // arrange
            var doubleAll = new Calculator();
            var expected = new List<int>() { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            var numbers = Enumerable.Range(1, 10);
            // act
            var result = doubleAll.DoubleAll(numbers);
            // assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Should_Test_SquareAll_Squares_Numbers()
        {
            // arrange

            // act

            // assert
            
        }
    }
}
