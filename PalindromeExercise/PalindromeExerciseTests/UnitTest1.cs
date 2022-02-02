using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("car", false)]
        [InlineData("hannah", true)]
        [InlineData("cardio", false)]
        [InlineData("madam", true)]
        public void PalindromeTest(string word, bool expected)
        {
            //Arrange
            var wordSmith = new WordSmith();

            //Act
            bool ans = wordSmith.IsAPalindromeTest(word);

            //Assert
            Assert.Equal(expected, ans);
        }
    }
}
