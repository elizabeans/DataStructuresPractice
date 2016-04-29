using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures
{
    public class MyStack<T> : IMyStack<T>
    {
        private T[] _data;
        public int Count { get; private set; }

        public MyStack()
        {
            _data = new T[1000];
            Count = 0;
        }

        public MyStack(int capacity)
        {
            _data = new T[capacity];
            Count = 0;
        }

        public bool IsEmpty()
        {
            return Count == 0;
        }

        public bool IsFull()
        {
            
        }

        public void Push(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException();
            }
            _data[Count++] = item;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException();
            }
            else
            {
                T top = _data[Count--];
                return top;
            }
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException();
            }
            else
            {
                T top = _data[Count];
                return top;
            }
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            _data = null;
        }
    }
}
