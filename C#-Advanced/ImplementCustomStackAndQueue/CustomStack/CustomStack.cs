namespace CustomStack
{
    public class CustomStack
    {
        private const int initialCapacity = 4;
        private int[] items;
        private int count;

        public CustomStack()
        {
            count = 0;
            items = new int[initialCapacity];
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public void Push(int element)
        {
            if (items.Length == count)
            {
                int[] nextItems = new int[items.Length * 2];
                for (int i = 0; i < items.Length; i++)
                {
                    nextItems[i] = items[i];
                }

                items = nextItems;
            }

            items[count] = element;
            count++;
        }

        public int Pop()
        {
            if (items.Length == 0)
            {
                throw new InvalidOperationException("CustomStack is empty");
            }

            int lastIndex = count - 1;
            int lastElement = items[lastIndex];
            count--;

            return lastElement;
        }

        public int Peek()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("CustomStack is empty");
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
    }
}
