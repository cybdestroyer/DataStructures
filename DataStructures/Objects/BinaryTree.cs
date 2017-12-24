using System;

namespace DataStructures.Objects
{
    public sealed class BinaryTree<T> where T : IComparable
    {
        #region Members
        public int Depth { get { return MaxDepth(Root); } }

        private Node<T> Root { get; set; }
        #endregion

        #region Public Methods
        public BinaryTree(T root)
        {
            Root = new Node<T>(root);
        }

        public bool Add(T value)
        {
            try
            {
                var root = Root;

                if (value != null)
                    Add(ref root, value);

                Root = root;

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }

        public bool Remove(T value)
        {
            try
            {
                var root = Root;

                if (value != null)
                    Remove(ref root, value);

                Root = root;

                return true;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }

            return false;
        }

        public bool Find(T value)
        {
            try
            {
                return Find(Root, value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }
        #endregion

        #region Private Methods
        private int MaxDepth(Node<T> node)
        {
            if (node == null)
                return 0;

            int leftDepth = MaxDepth(node.Left);
            int rightDepth = MaxDepth(node.Right);

            return (leftDepth > rightDepth) ? leftDepth + 1 : rightDepth + 1;
        }

        private void InOrder(Node<T> node)
        {

        }

        private void PostOrder(Node<T> node)
        {

        }

        private void Add(ref Node<T> root, T val)
        {
            if (root == null)
                root = new Node<T>(val);

            if (root.Data.CompareTo(val) > 0)
            {
                var leftChild = root.Left;
                Add(ref leftChild, val);
                root.Left = leftChild;
            }

            if (root.Data.CompareTo(val) < 0)
            {
                var rightChild = root.Right;
                Add(ref rightChild, val);
                root.Right = rightChild;
            }
        }

        private void Remove(ref Node<T> root, T val)
        {
            if (root.Data.CompareTo(val) > 0)
            {
                var leftChild = root.Left;
                Remove(ref leftChild, val);
                root.Left = leftChild;
            }
            else if (root.Data.CompareTo(val) < 0)
            {
                var rightChild = root.Right;
                Remove(ref rightChild, val);
                root.Right = rightChild;
            }
            else
            {
                // NO CHILD - LEAF
                if (root.Left == null && root.Right == null)
                {
                    root = null;
                }

                // ONE CHILD - RIGHT
                else if (root.Left == null && root.Right != null)
                {
                    root = root.Right;
                }

                // ONE CHILD - LEFT
                else if (root.Left != null && root.Right == null)
                {
                    root = root.Left;
                }

                // TWO CHILDREN 
                else
                {
                    if (root.Left != null && root.Right != null)
                    {
                        var originalLeftChild = root.Left;
                        var originalRightChild = root.Right;

                        // CURRENT = RIGHT CHILD
                        root = root.Right;
                        // TRAVERSE NODE TO MIN ELEMENT
                        while (originalRightChild.Left != null)
                        {
                            originalRightChild = originalRightChild.Left;
                        }
                        // APPEND ORIGINAL LEFT CHILD TO MIN ELMENT
                        originalRightChild.Left = originalLeftChild;
                    }
                }
            }
        }

        private bool Find(Node<T> root, T val)
        {
            if (root == null)
                return false;

            if (root.Data.CompareTo(val) > 0)
            {
                return Find(root.Left, val);
            }
            else if (root.Data.CompareTo(val) < 0)
            {
                return Find(root.Right, val);
            }
            else
            {
                return true;
            }
        }
        #endregion
    }
}