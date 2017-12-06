namespace DataStructures.Objects
{
    public class Node<T>
    {
        #region Next/Prev
        public Node<T> Next { get { return next; } set { next = value; } }
        public Node<T> Prev { get { return prev; } set { prev = value; } }
        #endregion

        #region Left/Right
        public Node<T> Left { get { return prev; } set { prev = value; } }
        public Node<T> Right { get { return next; } set { next = value; } }
        #endregion

        private Node<T> next { get; set; }
        private Node<T> prev { get; set; }

        public T Data { get; set; }

        public Node(T value)
        {
            Data = value;
        }
    }
}
