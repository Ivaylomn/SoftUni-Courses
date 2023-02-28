using System;

namespace Animals
{
    public class Cat : Animal
    {
        public Cat(string name, string food) 
            : base(name, food)
        {
        }

        public override string ExplainSelf()
        {
            return base.ExplainSelf() + Environment.NewLine + "MEEOW";
        }
    }
}
