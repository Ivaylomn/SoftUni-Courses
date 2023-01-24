namespace CustomList
{
    public class List
    {
        private const int InitialCapacity = 2;
        private int[] items;

        public List()
        {
            items = new int[InitialCapacity];
        }

        public int Count { get; private set; }

        public int this[int index]
        {
            get
            {
                if (index >= Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return items[index];
            }
            set
            {
                if (index >= Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                items[index] = value;
            }
        }

        private void Resize()
        {
            int[] copy = new int[items.Length * 2];

            for (int i = 0; i < items.Length; i++)
            {
                copy[i] = items[i];
            }

            items = copy;
        }

        private void Shift(int index)
        {
            for (int i = index; i < Count; i++)
            {
                items[i] = items[i + 1];
            }
        }

        private void Shrink()
        {
            int[] copy = new int[items.Length / 2];
            for (int i = 0; i < Count; i++)
            {
                copy[i] = items[i];
            }

            items = copy;
        }

        public void Add(int item)
        {
            if (items.Length == Count)
            {
                Resize();
            }

            items[Count] = item;
            Count++;
        }

        public int RemoveAt(int index)
        {
            if (index >= Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            int item = items[index];
            items[index] = default(int);

            Shift(index);

            Count--;
            if (Count <= items.Length / 4)
            {
                Shrink();
            }

            return item;
        }

        public bool Contains(int element)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (element == items[i])
                {
                    return true;
                }
            }

            return false;
        }

        public override string ToString() => String.Join(" ", items);

        public void Reverse()
        {
            Array.Reverse(items);
        }

    }
}
