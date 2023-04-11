using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Palindrome;


namespace Tests
{
    [TestClass]
    public class Palindrome_Tests
    {
        [TestMethod]
        public void Palindrome_Test()
        {
            //Arrange
            string original = "reconocer";
            string result = "";
            //Act
            result = Palindrome.Program.Palindrome(original);
            //Assert
            Assert.IsTrue(IsPalindrome(result));
        }

        public static bool IsPalindrome(string text)
        {
            if (text.Length % 2 != 0)
                return false;
            string halfA = text.Substring(0, text.Length / 2);
            string halfB = text.Substring(text.Length / 2, text.Length / 2);
            halfB = new string (halfB.Reverse().ToArray());
            return halfA == halfB;
        }
    }
}
