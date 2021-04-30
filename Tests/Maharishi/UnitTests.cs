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
    }
}