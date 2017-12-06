using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Objects
{
    public class DoubleLinkedList<T> : LinkedList<T> where T : IComparable
    {
        public DoubleLinkedList(T value) : base(value) { }

        public new bool Insert(T value)
        {
            return false;
        }
    }
}
