using System;
using Extensions.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Extensions.Tests
{
    [TestClass]
    public class StringExtensionsTest
    {
        [TestMethod]
        public void GetOccurencesOf_Test()
        {
            string str = "this is a long string which is going to test another string in the string ext library for string";
            Assert.AreEqual(4, str.GetOccurencesOf("string"));
        }

        [TestMethod]
        public void RemoveVowels_Test()
        {
            string str = "This is owl in the night";
            Assert.AreEqual("Ths s wl n th nght", str.RemoveVowels());
        }

        [TestMethod]
        public void Reverse_Test()
        {
            string str = "reverse string baby!!";
            Assert.AreEqual("!!ybab gnirts esrever", str.Reverse());
        }

        [TestMethod]
        public void IsNullOrEmpty_TestForEmpty()
        {
            string str = string.Empty;
            string strQuotes = "";
            Assert.IsTrue(str.IsNullOrEmpty());
            Assert.IsTrue(strQuotes.IsNullOrEmpty());
        }

        [TestMethod]
        public void IsNullOrEmpty_TestForNull()
        {
            string str = null;
            Assert.IsTrue(str.IsNullOrEmpty());
        }

        [TestMethod]
        public void IsPalindrome_Test()
        {
            string str = "racecar";
            Assert.AreEqual(str, str.Reverse());
        }

        [TestMethod]
        public void TruncateWithEllipses_Test()
        {
            string str = "This string is going to be terminated";
            string emptyStr = string.Empty;
            Assert.AreEqual("This string is goi...", str.TruncateWithEllipses(18));
            Assert.AreEqual(str, str.TruncateWithEllipses(100));
            Assert.AreEqual(emptyStr, emptyStr.TruncateWithEllipses(3));
        }
    }
}
