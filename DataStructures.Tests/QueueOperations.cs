using DataStructures.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Tests
{
    [TestClass]
    public class QueueOperations
    {
        [TestMethod]
        [TestCategory("Q - Basic")]
        public void Test()
        {
            var queue = new Queue<int>(0);
            queue.Add(1);
            queue.Add(2);
            queue.Add(3);
            queue.Add(4);

            for (int i = 0; i < queue.Count; i++)
            {
                Assert.AreEqual(i, queue.DeQueue().Data);
            }
        }
    }
}
