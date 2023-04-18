using System.Collections.Generic;

namespace BoxOfT
{
    public class Box<T>
    {
        Stack<T> elements = new Stack<T>();

        public void Add(T element)
        {
            elements.Push(element);
        }

        public T Remove()
        {
            T elementToRemove = elements.Peek();
            elements.Pop();

            return elementToRemove;
        }

        public int Count
            => elements.Count;
    }
}
