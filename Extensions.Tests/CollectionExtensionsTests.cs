using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using Extensions.Collections;
using System.Diagnostics;

namespace Extensions.Tests
{
    [TestClass]
    public class CollectionExtensionsTests
    {
        [TestMethod]
        public void RemoveDuplicates_Test()
        {
            ArrayList arr = new ArrayList();
            arr.Add("val 1");
            arr.Add("val 1");
            arr.Add("val 2");
            arr.Add("val 3");
            arr.Add("val 4");
            arr.Add("val 4");
            arr.Add("val 5");

            ArrayList _arr = new ArrayList();
            _arr.Add("val 1");
            _arr.Add("val 2");
            _arr.Add("val 3");
            _arr.Add("val 4");
            _arr.Add("val 5");

            Assert.AreEqual(_arr.Count, arr.RemoveDuplicates().Count);
        }
    }
}
