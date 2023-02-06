using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace GenericBoxOfString
{
    public class Box<T>
    {
        private List<T> value = new List<T>();


        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var item in this.value)
            {
                stringBuilder.AppendLine($"{typeof(T)}: {item}");
            }

            return stringBuilder.ToString().TrimEnd();
        }

        public void Add(T value)
        {
            this.value.Add(value);
        }
    }
}
