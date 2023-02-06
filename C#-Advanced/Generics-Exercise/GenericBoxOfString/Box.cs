using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace GenericBoxOfString
{
    public class Box
    {
        private List<string> value = new List<string>();


        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var item in this.value)
            {
                stringBuilder.AppendLine($"{item.GetType()}: {item}");
            }

            return stringBuilder.ToString().TrimEnd();
        }

        public void Add(string value)
        {
            this.value.Add(value);
        }
    }
}
