using DataStructures.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Tests
{
    [TestClass]
    public class BinarySearchTree
    {
        [TestMethod]
        [TestCategory("BST - Basic")]
        public void Insert()
        {
            var tree = new BinaryTree<string>("D");
            tree.Add("B");
            tree.Add("F");
            tree.Add("A");
            tree.Add("C");
            tree.Add("E");
            tree.Add("G");
            tree.Add("Z");

            Assert.IsTrue(tree.Find("B"));
            Assert.IsTrue(tree.Find("G"));

            Assert.AreEqual(4, tree.Depth);
        }

        [TestMethod]
        [TestCategory("BST - Basic")]
        public void Delete()
        {
            var tree = new BinaryTree<int>(15);
            tree.Add(9);
            tree.Add(21);
            tree.Add(3);
            tree.Add(11);
            tree.Add(13);
            tree.Add(20);

            Assert.IsTrue(tree.Find(15));
            Assert.IsTrue(tree.Find(21));
            Assert.IsFalse(tree.Find(100));

            Assert.AreEqual(4, tree.Depth);

            tree.Remove(13);

            Assert.IsFalse(tree.Find(13));
            Assert.AreEqual(3, tree.Depth);

            tree.Remove(3);
            tree.Remove(11);
            tree.Remove(20);

            Assert.IsFalse(tree.Find(3));
            Assert.IsFalse(tree.Find(11));
            Assert.IsFalse(tree.Find(20));
            Assert.AreEqual(2, tree.Depth);
        }

        [TestMethod]
        [TestCategory("BST - Basic")]
        public void Search()
        {
            var tree = new BinaryTree<int>(0);
            tree.Add(1);
            tree.Add(2);
            tree.Add(3);
            tree.Add(4);

            Assert.IsTrue(tree.Find(2));
            Assert.IsTrue(tree.Find(3));

            tree.Remove(2);

            Assert.IsFalse(tree.Find(2));
            Assert.IsTrue(tree.Find(3));

            tree.Remove(0);

            Assert.IsFalse(tree.Find(0));
            Assert.AreEqual(3, tree.Depth);
        }

        [TestMethod]
        [TestCategory("BST - Intermediate")]
        public void TestMethod1()
        {
            var tree = new BinaryTree<int>(10);
            tree.Add(7);
            tree.Add(3);
            tree.Add(5);
            tree.Add(20);
            tree.Add(17);
            tree.Add(15);

            Assert.AreEqual(4, tree.Depth);

            // Remove root node
            tree.Remove(10);

            Assert.AreEqual(6, tree.Depth);
            Assert.IsFalse(tree.Find(10));
        }

        [TestMethod]
        [TestCategory("BST - Intermediate")]
        public void TestMethod2()
        {
            // TO DO
        }
    }
}
