using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class MyTuple<Item1, Item2, Item3>
    {
        public MyTuple(Item1 firstItem, Item2 seconditem, Item3 thirdItem)
        {
            FirstItem = firstItem;
            SecondItem = seconditem;
            ThirdItem = thirdItem;
        }

        public Item1 FirstItem { get; set; }

        public Item2 SecondItem { get; set; }

        public Item3 ThirdItem { get; set; }

        public override string ToString()
        {
            return $"{FirstItem} -> {SecondItem} -> {ThirdItem}";
        }

    }
}
