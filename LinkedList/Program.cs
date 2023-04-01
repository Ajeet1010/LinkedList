using System.Collections.Generic;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****   Linked List Problems  *****"); 
            LinkedList linkedList = new LinkedList();
            linkedList.LinkedListReverseOrder(70);
            linkedList.LinkedListReverseOrder(30);
            linkedList.LinkedListReverseOrder(56);
            linkedList.Display();
        }
    }
}