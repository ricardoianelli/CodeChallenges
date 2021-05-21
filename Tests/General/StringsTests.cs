using CodeChallenges.General;
using FluentAssertions;
using Xunit;

namespace Tests.General
{
    public class StringsTests
    {
        [Theory]
        [InlineData("ricardo", 'i', 1)]
        [InlineData("ricardo", 'r', 2)]
        [InlineData("ricardo", 'f', 0)]
        [InlineData("", 'f', 0)]
        [InlineData(null, 'f', 0)]
        public void CountCharAppearance_GivenAStringAndAChar_ShouldReturnCorrectCount(string s, char c, int expected)
        {
            Strings.CountCharAppearance(s, c).Should().Be(expected);
        }
    }
}