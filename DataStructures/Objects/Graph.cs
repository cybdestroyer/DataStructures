using System;
using System.Collections.Generic;

namespace DataStructures.Objects
{
    public class Graph
    {
        #region Members
        private int[,] matrix { get; set; }
        private Dictionary<string, int> vertices { get; set; }

        public int VertexCount { get { return vertices.Keys.Count; } }
        #endregion

        #region Public Methods
        public Graph(int size)
        {
            matrix = new int[size, size];
            vertices = new Dictionary<string, int>();
        }

        public bool AddVertex(string v)
        {
            try
            {
                if (!string.IsNullOrEmpty(v))
                    return Add(v);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }

        public bool RemoveVertex(string v)
        {
            try
            {
                if (!string.IsNullOrEmpty(v))
                    return Remove(v);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }

        public bool AddEdge(string v1, string v2)
        {
            try
            {
                if (!string.IsNullOrEmpty(v1) && !string.IsNullOrEmpty(v2))
                    return Add(v1, v2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }

        public bool AddEdge(string v1, string v2, int weight)
        {
            try
            {
                if (!string.IsNullOrEmpty(v1) && !string.IsNullOrEmpty(v2))
                    return Add(v1, v2, weight);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }

        public bool RemoveEdge(string v1, string v2)
        {
            try
            {
                if (!string.IsNullOrEmpty(v1) && !string.IsNullOrEmpty(v2))
                    return Remove(v1, v2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }
        #endregion

        #region Private Methods
        private bool Remove(string v)
        {
            return vertices.Remove(v);
        }

        private bool Remove(string v1, string v2)
        {
            var row = vertices[v1];
            var column = vertices[v2];

            matrix[row, column] = 0;

            return true;
        }

        private bool Add(string v)
        {
            bool added = false;

            if (!vertices.ContainsKey(v))
            {
                if (vertices.Keys.Count < matrix.GetLength(0))
                {
                    vertices[v] = getEmptyIndex(matrix);
                    added = true;
                }
            }

            return added;
        }

        private bool Add(string v1, string v2, int weight = 0)
        {
            var row = vertices[v1];
            var column = vertices[v2];

            matrix[row, column] = weight;

            return true;
        }

        private int getEmptyIndex(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                bool hasEdge = false;

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > 0)
                        hasEdge = true;
                }

                if (!hasEdge && !vertices.ContainsValue(i))
                    return i;
            }

            return -1;
        }
        #endregion  
    }
}