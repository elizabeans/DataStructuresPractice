namespace DataStructures
{
    public interface IMyStack<T>
    {
        int Count { get; }

        void Push(T item);

        T Pop();

        T Peek();

        bool Contains(T item);

        void Clear();

        bool IsEmpty();

        bool IsFull();
    }
}
