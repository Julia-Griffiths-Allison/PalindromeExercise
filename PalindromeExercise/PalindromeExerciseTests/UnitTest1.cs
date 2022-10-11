using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            [Theory]
            [InlineData("racecar", true)]
            [InlineData("helo", false)]
            [InlineData("hannah", true)]
            [InlineData("kayak", true)]
            [InlineData("john", false)]
            [InlineData("", false)]
            [InlineData(null, false)]
            void PalindromeTester(string answer, bool expected)
            {
                var wordsmith = new WordSmith();
                var actual = WordSmith.IsAPalindrome(answer);
                Assert.Equal(actual, expected); 
            }
        }
    }
}
