using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace P03.CustomStack
{
    public class MyStack <T> : IEnumerable<T>
    {

        private List<T> innerArr;

        public int Count { get; private set; }

        public MyStack()
        {
            innerArr = new List<T>();
            Count = 0;
        }

        public void Push(T element)
        {
            innerArr.Add(element);
            Count++;
        }

        public T Pop()
        {
            CheckCount();

            Count--;
            T tempElement = innerArr[Count];
            innerArr.RemoveAt(Count);

            return tempElement;
        }

        public IEnumerator<T> GetEnumerator()
        {           
           
            for (int i = Count - 1; i >= 0; i--)
            {
                yield return innerArr[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private void CheckCount()
        {
            if (Count == 0)
            {
                throw new IndexOutOfRangeException("No elements");
            }
        }
    }
}
