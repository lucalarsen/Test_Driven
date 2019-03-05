

using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD;

namespace UnitTestTDD
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodFindYInMysterious()
        {
            var stringToCheck = "mysterious";
            var stringToFind = "y";
            var expectedResult = 1;
            var classUnderTest = new StringUtilities();
            var actualResult = classUnderTest.CountCountOccurences(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void TestMethodShouldFindTwo()
        {
            var stringToCheck = "mysterious";
            var stringToFind = "s";
            var expectedResult = 2;
            var classUnderTest = new StringUtilities();
            var actualResult = classUnderTest.CountCountOccurences(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void TestMethodSouldBeCaseSensitive()
        {
            var stringToCheck = "mySterious";
            var stringToFind = "s";
            var expectedResult = 2;
            var classUnderTest = new StringUtilities();
            var actualResult = classUnderTest.CountCountOccurences(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void TestMethodSouldBeAbleTohandleNull()
        {
            string stringToCheck = null;
            var stringToFind = "s";
            var expectedResult = -1;
            var classUnderTest = new StringUtilities();
            var actualResult = classUnderTest.CountCountOccurences(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
