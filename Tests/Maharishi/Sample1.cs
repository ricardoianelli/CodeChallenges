using Xunit;
using CodeChallenges.Maharishi;
using FluentAssertions;

namespace Tests.Maharishi
{
    public class Sample1
    {
        [Theory]
        [InlineData(new []{1, 2, 3, 4, 5}, 0)]
        [InlineData(new []{3, 2, 1, 4, 5}, 1)]
        [InlineData(new []{3, 2, 1, 4, 1}, 0)]
        [InlineData(new []{1, 2, 3, 4}, 0)]
        [InlineData(new int[]{}, 0)]
        [InlineData(new []{10}, 1)]
        [InlineData(null, 0)]
        public void Maharishi1(int[] input, int expectedOutput)
        {
            var output = MaharishiSample1.IsACenteredArray(input);
            output.Should().Be(expectedOutput);
        }
    }
}