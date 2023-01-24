namespace CustomQueue
{
    public class CustomQueue
    {
        private const int InitialCapacity = 4;
        private const int FirstElementIndex = 0;
        private int[] items;
        private int count;

        public CustomQueue()
        {
            count = 0;
            items = new int[InitialCapacity];
        }

        public int Count => count;

        public void Enqueue(int item)
        {
            if (items.Length == count)
            {
                IncreaseSize();
            }

            items[count] = item;
            count++;
        }

        public int Dequeue()
        {
            IsEmpty();
            count--;
            int firstElement = items[FirstElementIndex];
            SwitchElements();

            return firstElement;
        }

        public int Peek()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("CustomQueue is empty");
            }

            return items[count - 1];
        }

        public void ForEach(Action<object> action)
        {
            for (int i = 0; i < count; i++)
            {
                action(items[i]);
            }
        }

        private void SwitchElements()
        {
            items[FirstElementIndex] = default;

            for (int i = 0; i < items.Length; i++)
            {
                items[i - 1] = items[i];
            }

            items[items.Length - 1] = default;
        }

        private void IsEmpty()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("The queue is empty");
            }
        }

        private void IncreaseSize()
        {
            int[] tempArr = new int[items.Length * 2];
            items.CopyTo(tempArr, 0);
            items = tempArr;
        }
    }
}
