using PalindromeNumber;

namespace PalindromeUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testCase1()
        {
            Assert.IsTrue(PalindromeSolution.IsPalindrome(121));
        }

        [TestMethod]
        public void testCase2()
        {
            Assert.IsFalse(PalindromeSolution.IsPalindrome(-121));
        }

        [TestMethod]
        public void testCase3()
        {
            Assert.IsFalse(PalindromeSolution.IsPalindrome(10));
        }
    }
}