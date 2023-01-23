using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDoublyLinkedList
{
    public class ListNode
    {
        public ListNode(int value)
        {
            Value = value;
        }

        public int Value { get; set; }

        public ListNode NextNode { get; set; }

        public ListNode PreviousNode{ get; set; }
    }
}
