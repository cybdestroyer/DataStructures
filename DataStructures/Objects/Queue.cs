using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Objects
{
    public class Queue<T> where T : IComparable
    {
        private LinkedList<T> queue { get; set; }

        public int Count { get { return queue.Count; } }

        public Queue(T value)
        {
            queue = new LinkedList<T>(value);
        }

        public bool Add(T value)
        {
            return queue.Add(value);
        }

        public Node<T> DeQueue()
        {
            var first = queue.Head;
            queue.Remove(first.Data);
            return first;
        }
    }
}
