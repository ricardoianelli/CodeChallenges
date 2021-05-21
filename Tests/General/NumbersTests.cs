using CodeChallenges.General;
using FluentAssertions;
using Xunit;

namespace Tests.General
{
    public class NumbersTests
    {
        [Theory]
        [InlineData(0, 3, 0)]
        [InlineData(1, 0, 1)]
        [InlineData(1, 1, 1)]
        [InlineData(1, 5, 1)]
        [InlineData(2, 0, 1)]
        [InlineData(2, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(3, 4, 81)]
        public void RaiseNumber_GivenANumberAndAPower_ShouldReturnTheNumberToThePower(int n, int power, int expected)
        {
            Numbers.RaiseNumber(n, power).Should().Be(expected);
        }
    }
}