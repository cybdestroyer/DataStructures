using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Objects
{
    public class LinkedList<T> where T : IComparable
    {
        #region Members
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }

        public int Count { get { return Size(Head); } }
        #endregion

        #region Public Methods
        public LinkedList(T value)
        {
            Head = Tail = new Node<T>(value);
        }

        public bool Add(T value)
        {
            try
            {
                var node = Head;

                if (value != null)
                    Add(ref node, value);

                Head = node;

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
                var node = Head;

                if (value != null)
                    Remove(ref node, value);

                Head = node;

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }

        public bool Find(T value)
        {
            try
            {
                if (value != null)
                    return Find(Head, value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }
        #endregion

        #region Private Methods
        private int Size(Node<T> head)
        {
            int count = 0;

            while (head != null)
            {
                count += 1;

                head = head.Next;
            }

            return count;
        }

        private void Reverse()
        {

        }

        private void Add(ref Node<T> head, T value)
        {
            if (head == null)
            {
                head = new Node<T>(value);
                Tail = head;
            }
            else
            {
                var next = head.Next;
                Add(ref next, value);
                head.Next = next;
            }
        }

        private void Remove(ref Node<T> head, T value)
        {
            if (head != null)
            {
                var next = head.Next;
                Remove(ref next, value);
                head.Next = next;

                if (head.Next == null)
                    Tail = head;

                if (head.Data.CompareTo(value) == 0)
                {
                    head = head.Next;
                }
            }
        }

        private bool Find(Node<T> head, T value)
        {
            if (head != null)
            {
                if (head.Data.CompareTo(value) == 0)
                    return true;

                return Find(head.Next, value);
            }

            return false;
        }
        #endregion
    }
}
