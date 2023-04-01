using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkedList
    {
        public Node head;

        // UC1- Creating a Simple linked list.
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Linked List", node.data);
        }

        // UC2- Displaying element inserted in reverse order.
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
            Console.WriteLine("\n{0} inserted into Linked List", head.data);
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
            Console.WriteLine("\nElements in linked list are: ");
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
