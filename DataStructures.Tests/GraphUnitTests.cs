using DataStructures.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Tests
{
    [TestClass]
    public class GraphUnitTests
    {
        string[] locations = {
            "Home", "Grocery Store", "Gym", "Car Wash", "85th Park", "Cathedral", "School"
        };

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
        [TestCategory("Graph - Vertices")]
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

        [TestMethod]
        [TestCategory("Graph - Edges")]
        public void TestMethod3()
        {
            var graph = new Graph(10);
            Assert.IsTrue(graph.AddVertex(locations[0]));
            Assert.IsTrue(graph.AddVertex(locations[1]));
            Assert.IsTrue(graph.AddVertex(locations[2]));
            Assert.IsTrue(graph.AddVertex(locations[3]));
            Assert.IsTrue(graph.AddVertex(locations[4]));
            Assert.IsTrue(graph.AddVertex(locations[5]));
            Assert.IsTrue(graph.AddVertex(locations[6]));

            Assert.IsTrue(graph.AddEdge(locations[0], locations[1], 6));
            Assert.IsTrue(graph.AddEdge(locations[0], locations[2], 3));
            Assert.IsTrue(graph.AddEdge(locations[0], locations[3], 4));
            Assert.IsTrue(graph.AddEdge(locations[0], locations[4], 10));
            Assert.IsTrue(graph.AddEdge(locations[0], locations[5], 7));
            Assert.IsTrue(graph.AddEdge(locations[0], locations[6], 1));

            Assert.AreEqual(6, graph.GetWeight(locations[0], locations[1]));
            Assert.AreEqual(3, graph.GetWeight(locations[0], locations[2]));
            Assert.AreEqual(4, graph.GetWeight(locations[0], locations[3]));
            Assert.AreEqual(10, graph.GetWeight(locations[0], locations[4]));
            Assert.AreEqual(7, graph.GetWeight(locations[0], locations[5]));
            Assert.AreEqual(1, graph.GetWeight(locations[0], locations[6]));

            Assert.IsTrue(graph.RemoveEdge(locations[0], locations[6]));
            Assert.AreEqual(0, graph.GetWeight(locations[0], locations[6]));
        }

        [TestMethod]
        [TestCategory("Graph - Overflow")]
        public void TestMethod4()
        {
            var graph = new Graph(4);
            Assert.IsTrue(graph.AddVertex(locations[0]));
            Assert.IsTrue(graph.AddVertex(locations[1]));
            Assert.IsTrue(graph.AddVertex(locations[2]));
            Assert.IsTrue(graph.AddVertex(locations[3]));

            // Overflow vertices
            Assert.IsFalse(graph.AddVertex(locations[4]));
            Assert.IsFalse(graph.AddVertex(locations[5]));

            Assert.IsTrue(graph.AddEdge(locations[0], locations[1], 5));
            Assert.IsTrue(graph.AddEdge(locations[1], locations[3], 3));
            Assert.IsTrue(graph.AddEdge(locations[1], locations[2], 2));
            Assert.IsTrue(graph.AddEdge(locations[0], locations[2], 2));

            // Add edges for vertices that don't exist
            Assert.IsFalse(graph.AddEdge(locations[4], locations[5], 2));
            Assert.IsFalse(graph.AddEdge(locations[5], locations[4], 2));
            Assert.IsFalse(graph.AddEdge(locations[1], locations[4], 10));

            // Remove vertices that don't exist
            Assert.IsFalse(graph.RemoveVertex(locations[4]));
        }
    }
}