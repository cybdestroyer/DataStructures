using DataStructures.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Tests
{
    [TestClass]
    public class StackOperations
    {
        [TestMethod]
        [TestCategory("STK - Basic")]
        public void Add()
        {
            var stack = new Stack<string>("Base");
            Assert.IsTrue(stack.Push("First Layer"));
            Assert.IsTrue(stack.Push("Second Layer"));
            Assert.IsTrue(stack.Push("Third Layer"));
            Assert.IsTrue(stack.Push("Fourth Layer"));

            Assert.AreEqual("Fourth Layer", stack.Pop().Data);
            Assert.AreEqual("Third Layer", stack.Pop().Data);
            Assert.AreEqual("Second Layer", stack.Pop().Data);
            Assert.AreEqual("First Layer", stack.Pop().Data);
        }

        [TestMethod]
        [TestCategory("STK - Basic")]
        public void Pop()
        {

        }
    }
}
