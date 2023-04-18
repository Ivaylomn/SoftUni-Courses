using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public string RandomString()
        {
            Random randomString = new Random();

            string currentElement = this[randomString.Next(0, this.Count - 1)];
            this.Remove(currentElement);

            return currentElement;
        }
    }
}
