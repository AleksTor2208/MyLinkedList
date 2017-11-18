using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLinkedList;
using System.Collections.Generic;

namespace TestMyLinkedList
{
    [TestClass]
    public class TestMyLinkedList
    {
        [TestMethod]
        public void TestGetByIndexReturnValidValue()
        {
            var LinkedList = new MyLinkedList<int>();
            LinkedList.Add(1);
            LinkedList.Add(2);
            var actual = LinkedList.GetByIndex(0);
            var expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIndexOutOfRangeExceptionIsThrownWhenGetByIndexHasInvalidArgs()
        {
            var myList = new MyLinkedList<int>();           
            Assert.ThrowsException<IndexOutOfRangeException>(() => myList.GetByIndex(1));
        }

        [TestMethod]
        public void TestAsListMethodReturnValidType()
        {
            var myList = new MyLinkedList<string>();
            myList.Add("example string");
            var actual = myList.AsList().GetType();
            var expected = new List<string>().GetType();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAsListMethodReturnProperValue()
        {
            var myList = new MyLinkedList<string>();
            myList.Add("No i cóż");
            myList.Add("że ze");
            myList.Add("Szwecji");
            var expected = "Szwecji";
            var actual = myList.AsList()[2];
            Assert.AreEqual(expected, actual);
        }
    }
}
