using System;

namespace Animals
{
    public class Dog : Animal
    {
        public Dog(string name, string food) 
            : base(name, food)
        {
        }

        public override string ExplainSelf()
        {
            return $"{base.ExplainSelf()}{Environment.NewLine}DJAAF";
        }
    }
}
