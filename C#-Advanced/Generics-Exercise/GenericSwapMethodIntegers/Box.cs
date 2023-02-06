using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodIntegers
{
    public class Box<T>
    {
        private List<T> values;

        public Box()
        {
            values = new List<T>();
        }

        public T Value { get; private set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in values)
            {
                stringBuilder.Append(typeof(T));
                stringBuilder.AppendLine($": {item}");
            }

            return stringBuilder.ToString().TrimEnd();
        }

        public void Add(T element)
        {
            Value = element;
            values.Add(Value);
        }

        public void Swap(int elementOne, int elementTwo)
        {
            var temp = values[elementOne];
            values[elementOne] = values[elementTwo];
            values[elementTwo] = temp;
        }
    }
}
