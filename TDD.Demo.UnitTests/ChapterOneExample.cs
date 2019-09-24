using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TDD.Demo.UnitTests
{
    
    public class ChapterOneExampleTest
    {
        [Fact]
        public void ShouldFindOneYInMysterious()
        {
            var stringToCheck = "mysterious";
            var stringToFind = "y";
            var expectResult = 1;
            var classUnderTest = new StringUtilities();
            var artualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);
            Assert.Equal(expectResult, artualResult);
        }
        [Fact]
        public void ShouldFindTwoYInMysterious()
        {
            var stringToCheck = "mysterious";
            var stringToFind = "s";
            var expectResult = 2;
            var classUnderTest = new StringUtilities();
            var artualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);
            Assert.Equal(expectResult, artualResult);
        }
        [Fact]
        public void SearchShouldBecaseSenstive()
        {
            var stringToCheck = "mySterious";
            var stringToFind = "s";
            var expectResult = 2;
            var classUnderTest = new StringUtilities();
            var artualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);
            Assert.Equal(expectResult, artualResult);
        }
        [Fact]
        public void ShouldBeAbleToHanbleNulls()
        {
            string stringToCheck = null;
            var stringToFind = "s";
            var expectdResult = -1;
            var classUnderTest = new StringUtilities();
            var artualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);
            Assert.Equal(expectdResult,artualResult);
        }
    }

    public class StringUtilities
    {
        public int CountOccurences(string stringToCheck, string stringToFind)
        {
            if (stringToCheck == null) return -1;
            var stringAsCharArray = stringToCheck.ToUpper().ToCharArray();
            var stringToCheckForAsChar = stringToFind.ToUpper().ToCharArray()[0];
            var occurenceCount = 0;
            for (int characterIndex = 0; characterIndex <= stringAsCharArray.GetUpperBound(0); characterIndex++)
            {
                if (stringAsCharArray[characterIndex] == stringToCheckForAsChar)
                    occurenceCount++;
            }
            return occurenceCount;
        }
    }
}
