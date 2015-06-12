using System;
using Extensions.CustomDataTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Extensions.Tests
{
    [TestClass]
    public class CustomDataTypesTest
    {
        [TestMethod]
        public void FixedSizedQueue_Test()
        {
            FixedSizeQueue<string> q = new FixedSizeQueue<string>(5);
            q.Enqueue("1");
            q.Enqueue("2");
            q.Enqueue("3");
            q.Enqueue("4");
            q.Enqueue("5");
            q.Enqueue("6");
            q.Enqueue("7");
            q.Enqueue("8");

            Assert.AreEqual(5, q.Count);
        }
    }
}
