using System.Collections.Generic;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****   Linked List Problems  *****");
            LinkedList list = new LinkedList();
            list.Add(56);                                   // adding root node
            list.Add(30);                                   // adding left node
            list.Add(70);                                   // adding right node
            list.Display();                                 // displaying the insertion.
            list.LinkedListReverseOrder(70);
            list.LinkedListReverseOrder(30);
            list.LinkedListReverseOrder(56);
            list.Display();
        }
    }
}