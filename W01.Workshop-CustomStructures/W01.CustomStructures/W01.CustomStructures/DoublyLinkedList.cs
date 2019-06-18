using System;
using System.Collections.Generic;
using System.Text;

namespace W01.CustomStructures
{
    class DoublyLinkedList
    {
        private class ListNode
        {
            public int Value { get; private set; }

            public ListNode NextNode { get; set; }
            public ListNode PreviousNode { get; set; }

            public ListNode(int value)
            {
                Value = value;
            }
        }

        private ListNode head;
        private ListNode tail;

        public int Count { get; private set; }

        public void AddFirst(int value)
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

        public void AddLast(int value)
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

        public int RemoveFirst()
        {
            IfEmptyThrowExeption();

            int firstElement = head.Value;
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

        public int RemoveLast()
        {
            IfEmptyThrowExeption();

            int lastElement = tail.Value;
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

        public bool Contains(int value)
        {
            ListNode currentNode = head;

            while (currentNode != null)
            {
                if (currentNode.Value == value)
                {
                    return true;
                }

                currentNode = currentNode.NextNode;
            }

            return false;
        }

        public int[] ToArray()
        {
            int[] array = new int[Count];

            var currentNode = head;
            int count = 0;

            while (currentNode != null)
            {
                array[count++] = currentNode.Value;

                currentNode = currentNode.NextNode;
                
            }

            return array;
        }

        public void Print(Action<int> action)
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
