using System;
using System.Collections.Generic;
using System.Text;

namespace W01.CustomStructures
{
    public class DoublyLinkedList<T>
        where T : IComparable<T>
    {
        private class ListNode
        {
            public T Value { get; private set; }

            public ListNode NextNode { get; set; }
            public ListNode PreviousNode { get; set; }

            public ListNode(T value)
            {
                Value = value;
            }
        }

        private ListNode head;
        private ListNode tail;

        public int Count { get; private set; }

        public void AddFirst(T value)
        {
            ListNode newHead = new ListNode(value);

            if (Count == 0)
            {
                tail = head = newHead;
            }
            else
            {
                newHead.NextNode = head;
                head.NextNode = newHead;
                head = newHead;
            }

            Count++;
        }

        public void AddLast(T value)
        {
            ListNode newTail = new ListNode(value);
            if (Count == 0)
            {
                tail = head = newTail;
            }
            else
            {
                newTail.PreviousNode = tail;
                tail.NextNode = newTail;
                tail = newTail;
            }

            Count++;
        }

        public T RemoveFirst()
        {
            IfEmptyThrowExeption();

            T firstElement = head.Value;
            head = head.NextNode;

            if (head == null)
            {
                tail = null;
            }
            else
            {
                head.PreviousNode = null;
            }

            Count--;

            return firstElement;
        }

        public T RemoveLast()
        {
            IfEmptyThrowExeption();

            T lastElement = tail.Value;
            tail = tail.PreviousNode;

            if (tail == null)
            {
                head = null;
            }
            else
            {
                tail.NextNode = null;
            }

            Count--;

            return lastElement;
        }

        public bool Contains(T value)
        {
            ListNode currentNode = head;

            while (currentNode != null)
            {
                if (currentNode.Value.CompareTo(value) == 0)
                {
                    return true;
                }

                currentNode = currentNode.NextNode;
            }

            return false;
        }

        public T[] ToArray()
        {
            T[] array = new T[Count];

            var currentNode = head;
            int count = 0;

            while (currentNode != null)
            {
                array[count++] = currentNode.Value;

                currentNode = currentNode.NextNode;
                
            }

            return array;
        }

        public void Print(Action<T> action)
        {
            ListNode currentNode = head;

            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.NextNode;
            }
        }

        private void IfEmptyThrowExeption()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("DoublyLinkedList is empty!");
            }
        }
    }
}
