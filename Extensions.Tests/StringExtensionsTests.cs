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

        [TestMethod]
        public void IsValidUrl_Test()
        {
            string str = "http://google.com";
            Assert.IsTrue(str.IsValidUrl());

            string strNoURL = "google.com";
            Assert.IsFalse(strNoURL.IsValidUrl());
        }

        [TestMethod]
        public void IsNumber_Test()
        {
            string str = "3";
            Assert.IsTrue(str.IsNumber());

            string strEmpty = "";
            Assert.IsFalse(strEmpty.IsNumber());

            string strString = "this";
            Assert.IsFalse(strString.IsNumber());
        }

        public void IsGuid_Test()
        {
            string guid_1 = "{B403E835-8D7D-4168-BBFA-14EE9951211E}";
            string guid_2 = "{24D26D8D-69CA-4E39-8191-AAD7366412CA}";
            string guid_3 = "[Guid(\"24D26D8D-69CA-4E39-8191-AAD7366412CA\")]";
            string guid_4 = "<Guid(\"24D26D8D-69CA-4E39-8191-AAD7366412CA\")>";

            Assert.IsTrue(guid_1.IsGuid());
            Assert.IsTrue(guid_2.IsGuid());
            Assert.IsTrue(guid_3.IsGuid());
            Assert.IsTrue(guid_4.IsGuid());
        }

        [TestMethod]
        public void ToProperCase_Test()
        {
            string str_1 = "this is a default test title";
            string str_2 = "This is a DefaulT TEST TiTlE";
            Assert.AreEqual("This Is A Default Test Title", str_1.ToProperCase());
            Assert.AreEqual("This Is A Default TEST Title", str_2.ToProperCase());
        }

        [TestMethod]
        public void IsAlphanumeric_Test()
        {
            string str_1 = "abcd";
            string str_2 = "#$%#$%";
            string str_3 = "abcd12";
            string str_4 = "HH&@#";
            string str_5 = "23424";
            Assert.IsTrue(str_1.IsAlphanumeric());
            Assert.IsFalse(str_2.IsAlphanumeric());
            Assert.IsTrue(str_3.IsAlphanumeric());
            Assert.IsFalse(str_4.IsAlphanumeric());
            Assert.IsTrue(str_5.IsAlphanumeric());
        }

        [TestMethod]
        public void MD5Encode_Test()
        {
            string str = "Microsoft";
            Assert.AreEqual("140864078AECA1C7C35B4BEB33C53C34", str.MD5Encode());
        }
    }
}
