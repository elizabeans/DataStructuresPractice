namespace DataStructures
{
    public interface IMyQueue<T>
    {
        int Count { get; }

        void Enqueue(T item);

        T Dequeue();

        T Peek();

        bool Contains(T item);

        void Clear();

        bool IsEmpty();

        bool IsFull();

    }
}
