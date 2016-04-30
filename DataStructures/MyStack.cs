using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures
{
    public class MyStack<T> : IMyStack<T>
    {
        private T[] _data;
        private int _size;
        public int Count { get; private set; }

        public MyStack()
        {
            _size = 1000;
            _data = new T[_size];
            Count = 0;
        }

        public MyStack(int capacity)
        {
            _size = capacity;
            _data = new T[_size];
            Count = 0;
        }

        public bool IsEmpty()
        {
            return Count == 0;
        }

        public bool IsFull()
        {
            return Count == _size;
        }

        public void Push(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException();
            }

            if (IsFull())
            {
                throw new InvalidOperationException();
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
            return _data.Contains(item);
        }

        public void Clear()
        {
            _data = null;
        }
    }
}
