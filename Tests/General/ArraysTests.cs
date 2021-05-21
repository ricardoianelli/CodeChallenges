using CodeChallenges.General;
using FluentAssertions;
using Xunit;

namespace Tests.General
{
    public class ArraysTests
    {
        [Fact]
        public void ReverseArray_GivenAnIntegerArray_ReturnTheArrayReversed()
        {
            var inputArray = new[] {1, 2, 3, 4, 5, 6};
            var expected = new[] {6, 5, 4, 3, 2, 1};

            var result = Arrays.ReverseArray(inputArray);
            result.Should().Equal(expected);
        }
    }
}