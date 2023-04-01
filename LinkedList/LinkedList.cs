using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList
{
    // UC2- Displaying element inserted in reverse order.
    internal class LinkedList
    {
        public Node head;
        public void LinkedListReverseOrder(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
                this.head = newNode;
            else
            {
                Node temp = this.head;
                head = newNode;
                head.next = temp;
            }
            Console.WriteLine("{0} inserted into Linked List", head.data);
        }

        // Displaying the insertion in linked list.
        internal void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            Console.WriteLine("\nElements in linked list are inserted in reverse order: ");
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}