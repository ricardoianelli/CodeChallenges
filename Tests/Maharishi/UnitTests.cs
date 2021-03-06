using Xunit;
using CodeChallenges.Maharishi;
using FluentAssertions;

namespace Tests.Maharishi
{
    public class UnitTests
    {
        [Theory]
        [InlineData(new []{1, 2, 3, 4, 5}, 0)]
        [InlineData(new []{3, 2, 1, 4, 5}, 1)]
        [InlineData(new []{3, 2, 1, 4, 1}, 0)]
        [InlineData(new []{1, 2, 3, 4}, 0)]
        [InlineData(new int[]{}, 0)]
        [InlineData(new []{10}, 1)]
        [InlineData(null, 0)]
        public void IsACenteredArray_GivenAnInput_ShouldMatchExpectedOutput(int[] input, int expectedOutput)
        {
            var output = FirstSample.IsACenteredArray(input);
            output.Should().Be(expectedOutput);
        }
        
        [Theory]
        [InlineData(new []{1}, 1)]
        [InlineData(new []{1, 2}, -1)]
        [InlineData(new []{1, 2, 3}, 2)]
        [InlineData(new []{1, 2, 3, 4}, -2)]
        [InlineData(new []{3, 3, 4, 4}, -2)]
        [InlineData(new []{3, 2, 3, 4}, 0)]
        [InlineData(new []{4, 1, 2, 3}, -2)]
        [InlineData(new []{1, 1}, 2)]
        [InlineData(new int[]{}, 0)]
        [InlineData(null, 0)]
        public void DifferenceOfSums_GivenAnInput_ShouldMatchExpectedOutput(int[] input, int expectedOutput)
        {
            var output = SecondSample.DifferenceOfSums(input);
            output.Should().Be(expectedOutput);
        }

        [Theory]
        [InlineData(new []{'a', 'b', 'c'}, 0, 3, new []{'a', 'b', 'c'})]
        [InlineData(new []{'a', 'b', 'c'}, 0, 2, new []{'a', 'b'})]
        [InlineData(new []{'a', 'b', 'c'}, 0, 1, new []{'a'})]
        [InlineData(new []{'a', 'b', 'c'}, 1, 2, new []{'b', 'c'})]
        [InlineData(new []{'a', 'b', 'c'}, 1, 1, new []{'b'})]
        [InlineData(new []{'a', 'b', 'c'}, 2, 1, new []{'c'})]
        [InlineData(new []{'a', 'b', 'c'}, 1, 0, new char[]{})]
        public void GetCharsFromArray_GivenValidInputs_ShouldReturnExpectedOutput(char[] charArray, int startIndex, int charsToTake, char[] expectedOutput)
        {
            var output = ThirdSample.GetCharsFromArray(charArray, startIndex, charsToTake);
            output.Should().Equal(expectedOutput);
        }
        
        [Theory]
        [InlineData(new []{'a', 'b', 'c'}, 0, 4, null)]
        [InlineData(new []{'a', 'b', 'c'}, 1, 3, null)]
        [InlineData(new []{'a', 'b', 'c'}, 2, 2, null)]
        [InlineData(new []{'a', 'b', 'c'}, 3, 1, null)]
        [InlineData(new []{'a', 'b', 'c'}, -1, 2, null)]
        [InlineData(new []{'a', 'b', 'c'}, -1, -2, null)]
        [InlineData(new char[]{}, 0, 1, null)]
        [InlineData(null, 0, 1, null)]
        public void GetCharsFromArray_GivenInvalidInputs_ShouldReturnExpectedOutput(char[] charArray, int startIndex, int charsToTake, char[] expectedOutput)
        {
            var output = ThirdSample.GetCharsFromArray(charArray, startIndex, charsToTake);
            output.Should().Equal(expectedOutput);
        }

        [Theory]
        [InlineData(1234, 4321)]
        [InlineData(12005, 50021)]
        [InlineData(1, 1)]
        [InlineData(1000, 1)]
        [InlineData(0, 0)]
        [InlineData(-12345, -54321)]
        public void ReverseNumber_GivenAValidNumber_ShouldReturnNumberReversed(int inputNumber, int outputNumber)
        {
            var output = FourthSample.ReverseNumber(inputNumber);
            output.Should().Be(outputNumber);
        }

        [Theory]
        [InlineData(new []{1, 8, 3, 2}, new []{4, 2, 6, 1}, new []{1, 2})]
        [InlineData(new []{1, 8, 3, 2, 6}, new []{2, 6, 1}, new []{2, 6, 1})]
        [InlineData(new []{1, 3, 7, 9}, new []{7, 1, 9, 3}, new []{1, 3, 7, 9})]
        [InlineData(new []{1, 2}, new []{3, 4}, new int[]{})]
        [InlineData(new int[]{}, new []{1, 2, 3}, new int[]{})]
        [InlineData(new []{1, 2}, new int[]{}, new int[]{})]
        public void InnerJoin_GivenTwoArrays_ShouldReturnCommonNumberBetweenThem(int[] firstArray, int[] secondArray,
            int[] expectedOutput)
        {
            var output = FifthSample.InnerJoin(firstArray, secondArray);
            output.Should().Equal(expectedOutput);
        }
        
        [Theory]
        [InlineData(new []{1, 2}, null)]
        [InlineData(null, new int[]{})]
        [InlineData(null, null)]
        public void InnerJoin_GivenANullInput_ShouldReturnNull(int[] firstArray, int[] secondArray)
        {
            var output = FifthSample.InnerJoin(firstArray, secondArray);
            output.Should().BeNull();
        }

        [Theory]
        [InlineData(new []{1, 8, 3, 7, 10, 2}, 3)]
        [InlineData(new []{1, 5, 3, 1, 1, 1, 1, 1, 1}, 2)]
        [InlineData(new []{2, 1, 1, 1, 2, 1, 7}, 5)]
        public void GetPointOfEquilibrium_GivenArraysThatHaveAPoE_ShouldReturnTheirIndexes(int[] inputArray, int poeIndex)
        {
            var result = SixthSample.GetPointOfEquilibrium(inputArray);
            result.Should().Be(poeIndex);
        }
        
        [Theory]
        [InlineData(new []{2})]
        [InlineData(new []{1, 2, 3})]
        [InlineData(new []{3, 4, 5, 10})]
        [InlineData(new []{1, 2, 10, 3, 4})]
        public void GetPointOfEquilibrium_GivenArraysThatDoesNotHaveAPoE_ShouldReturnNegativeOne(int[] inputArray)
        {
            var result = SixthSample.GetPointOfEquilibrium(inputArray);
            result.Should().Be(-1);
        }
        
        [Theory]
        [InlineData(new int[0])]
        [InlineData(null)]
        public void GetPointOfEquilibrium_GivenAnEmptyOrNullArray_ShouldReturnNegativeOne(int[] inputArray)
        {
            var result = SixthSample.GetPointOfEquilibrium(inputArray);
            result.Should().Be(-1);
        }
    }
}