using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]

        [InlineData("racecar", true)]
        [InlineData("three", false)]
        [InlineData("tacocat", true)]
        [InlineData("example", false)]
        [InlineData("aa", true)]
        [InlineData("a", true)]
        [InlineData("car", false)]

        public void PalindromeTest(string input, bool expected)
        {
            var wordSmith = new WordSmith();

            var actual = wordSmith.IsAPalindrome(input);

            Assert.Equal(expected, actual);
        }
    }
}
