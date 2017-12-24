using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Objects
{
    public sealed class Stack<T> where T : IComparable
    {
        private LinkedList<T> stack { get; set; }

        public Stack(T value)
        {
            stack = new LinkedList<T>(value);
        }

        public bool Push(T value)
        {
            return stack.Add(value);
        }

        public Node<T> Pop()
        {
            var node = stack.Tail;
            stack.Remove(node.Data);
            return node;
        }
    }
}
