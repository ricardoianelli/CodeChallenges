using CodeChallenges.General;
using FluentAssertions;
using Xunit;

namespace Tests.General
{
    public class ArraysTests
    {
        [Theory]
        [InlineData(null, null)]
        [InlineData(new int[] {}, new int[] {})]
        [InlineData(new[] {1}, new[] {1})]
        [InlineData(new[] {1, 2}, new[] {2, 1})]
        [InlineData(new[] {1, 5, 3, 6, 1, 3}, new[] {3, 1, 6, 3, 5, 1})]
        [InlineData(new[] {23, 5, 1, 0, -5}, new[] {-5, 0, 1, 5, 23})]
        public void ReverseArray_GivenAnIntegerArray_ReturnTheArrayReversed(int[] inputArray, int[] expected)
        {
            var result = Arrays.ReverseArray(inputArray);
            result.Should().Equal(expected);
        }
        
        [Theory]
        [InlineData(null, null)]
        [InlineData(new char[] {}, new char[] {})]
        [InlineData(new[] {'a'}, new[] {'a'})]
        [InlineData(new[] {'a', 'b'}, new[] {'b', 'a'})]
        [InlineData(new[] {'a', 'e', 'b'}, new[] {'b', 'e', 'a'})]
        [InlineData(new[] {'a', 'e', 'a', 'f'}, new[] {'f', 'a', 'e', 'a'})]
        public void ReverseArray_GivenAnCharArray_ReturnTheArrayReversed(char[] inputArray, char[] expected)
        {
            var result = Arrays.ReverseArray(inputArray);
            result.Should().Equal(expected);
        }

        [Theory]
        [InlineData(new [] {1}, 1)]
        [InlineData(new [] {1,2,3}, 1)]
        [InlineData(new [] {10,-4,3}, -4)]
        [InlineData(new [] {33,12,5}, 5)]
        public void GetMin_GivenAnIntegerArray_ShouldReturnMinimumValueOnArray(int[] inputArray, int expectedResult)
        {
            var result = Arrays.GetMin(inputArray);
            result.Should().Be(expectedResult);
        }
        
        [Theory]
        [InlineData(new [] {1}, 1)]
        [InlineData(new [] {1,2,3}, 3)]
        [InlineData(new [] {10,-4,3}, 10)]
        [InlineData(new [] {33,12,5}, 33)]
        public void GetMax_GivenAnIntegerArray_ShouldReturnMaximumValueOnArray(int[] inputArray, int expectedResult)
        {
            var result = Arrays.GetMax(inputArray);
            result.Should().Be(expectedResult);
        }
    }
}