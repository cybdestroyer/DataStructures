using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures.Objects;

namespace DataStructures.Tests
{
    [TestClass]
    public class LinkedLists
    {
        [TestMethod]
        [TestCategory("LL - Basic")]
        public void Insertion()
        {
            var list = new LinkedList<string>("HEAD");

            Assert.IsTrue(list.Add("1st"));
            Assert.IsTrue(list.Add("2nd"));
            Assert.IsTrue(list.Add("3rd"));
            Assert.IsTrue(list.Add("4th"));
            Assert.IsTrue(list.Add("5th"));

            Assert.IsTrue(list.Find("HEAD"));
            Assert.IsTrue(list.Find("1st"));
            Assert.IsTrue(list.Find("2nd"));
            Assert.IsTrue(list.Find("3rd"));
            Assert.IsTrue(list.Find("4th"));
            Assert.IsTrue(list.Find("5th"));
        }

        [TestMethod]
        [TestCategory("LL - Basic")]
        public void Deletion()
        {
            var list = new LinkedList<int>(0);

            Assert.IsTrue(list.Add(1));
            Assert.IsTrue(list.Add(2));
            Assert.IsTrue(list.Add(3));
            Assert.IsTrue(list.Add(4));
            Assert.IsTrue(list.Add(5));

            list.Remove(3);

            Assert.AreEqual(5, list.Count);
            Assert.IsFalse(list.Find(3));

            list.Remove(0);

            Assert.AreEqual(4, list.Count);
        }

        [TestMethod]
        [TestCategory("LL - Basic")]
        public void Search()
        {
            var groceryList = new LinkedList<string>("Milk");
            groceryList.Add("Eggs");
            groceryList.Add("Flour");
            groceryList.Add("Bread");
            groceryList.Add("Orange Juice");

            Assert.AreEqual(5, groceryList.Count);

            groceryList.Remove("Eggs");

            Assert.IsFalse(groceryList.Find("Eggs"));
            Assert.AreEqual(4, groceryList.Count);
        }

        [TestMethod]
        [TestCategory("LL - Intermediate")]
        public void TestMethod1()
        {
            var list = new LinkedList<char>('+');
            list.Add('+');
            list.Add('+');
            list.Add('-');
            list.Add('-');

            Assert.IsTrue(list.Find('+'));
            Assert.IsTrue(list.Find('-'));
            Assert.AreEqual(5, list.Count);

            list.Remove('+');

            Assert.AreEqual(2, list.Count);
            Assert.IsFalse(list.Find('+'));
            Assert.IsTrue(list.Find('-'));

            list.Remove('-');

            Assert.AreEqual(0, list.Count);
            Assert.IsFalse(list.Find('-'));
        }
    }
}
