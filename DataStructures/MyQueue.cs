using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures
{
    public class MyQueue<T> : IMyQueue<T>
    {
        private T[] _data;
        private int _size;
        private T Front;
        public int Count { get; private set; }
        public void Enqueue(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException();
            }

            if (IsEmpty())
            {
                Front = _data[Count];
            }

            if (IsFull())
            {
                throw new InvalidOperationException();
            }

            _data[Count++] = item;
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException();
            }
            else
            {
                return Front;
            }

        }

        public T Peek()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            return _data.Contains(item);
        }

        public void Clear()
        {
            _data = null;
        }

        public bool IsEmpty()
        {
            return Count == 0;
        }

        public bool IsFull()
        {
            return Count == _size;
        }
    }
}
