using System.ComponentModel.DataAnnotations;

namespace GenericBoxOfInteger
{
    public class Box<T>
    {
        public Box(T value)
        {
            Value = value;
        }

        public T Value { get; private set; }

        public override string ToString() 
            => $"{typeof(T)}: {Value}";

    }
}
