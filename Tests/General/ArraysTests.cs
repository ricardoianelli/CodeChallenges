﻿using CodeChallenges.General;
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
    }
}