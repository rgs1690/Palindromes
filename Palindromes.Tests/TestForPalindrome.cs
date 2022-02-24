using Xunit;
using System;

namespace Palindromes.Tests
{
    public class TestForPalindrome
    {
        [Fact]
        public void Is_The_Word_Stats_A_Palindrome_Test()
        {
            //ARRANGE
            var wordToTest = "Stats";
            bool expectedOutcome = true;
            // ACT
            var actualOutCome = IsItAPalindrome.PalindromeTester(wordToTest);
            //ASSERT
            Assert.Equal(expectedOutcome, actualOutCome);


        }

        [InlineData("Amore Roma", true)]
        [InlineData("Stars", false)]
        [InlineData("O, a kak Uwakov lil vo kawu kakao!", true)]
        [InlineData("Some men interpret nine memos", true)]
        [InlineData("Was it a cat I saw?", true)]
        [Theory]
        public void Words_Can_Be_Tested_To_See_If_Palindrome(string stringToTest, bool expectedOutcome)
        {
            var actualOutcome = IsItAPalindrome.PalindromeTester(stringToTest);

            Assert.Equal(expectedOutcome, actualOutcome);
        }


    }
}