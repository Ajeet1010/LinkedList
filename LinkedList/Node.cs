using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Node
    {
        // taking data from user
        public int data;

        // going to next node
        public Node next;
        public Node(int data)
        {
            this.data = data;
        }
    }
}
