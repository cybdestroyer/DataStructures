using DataStructures.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Tests
{
    [TestClass]
    public class GraphUnitTests
    {
        [TestMethod]
        [TestCategory("GPH - Basic")]
        public void TestMethod1()
        {
            var graph = new Graph(6);
            Assert.IsTrue(graph.AddVertex("A"));
            Assert.IsFalse(graph.AddVertex("A"));
            Assert.IsTrue(graph.AddVertex("C"));
            Assert.IsTrue(graph.AddVertex("G"));
            Assert.IsTrue(graph.AddVertex("Z"));
            Assert.IsTrue(graph.AddVertex("X"));
            Assert.IsTrue(graph.AddVertex("B"));

            Assert.IsFalse(graph.AddVertex("O"));
            Assert.IsFalse(graph.AddVertex("B"));
        }

        [TestMethod]
        [TestCategory("")]
        public void TestMethod2()
        {
            var graph = new Graph(4);
            Assert.IsTrue(graph.AddVertex("Start"));
            Assert.IsTrue(graph.AddVertex("Checkpoint 1"));
            Assert.IsTrue(graph.AddVertex("Checkpoint 2"));
            Assert.IsTrue(graph.AddVertex("Finish"));

            Assert.AreEqual(4, graph.VertexCount);

            Assert.IsFalse(graph.RemoveVertex("Checkpoint 3"));
            Assert.IsTrue(graph.RemoveVertex("Finish"));
            Assert.AreEqual(3, graph.VertexCount);
            Assert.IsTrue(graph.AddVertex("Checkpoint 3"));
        }
    }
}