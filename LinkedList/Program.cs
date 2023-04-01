using System.Collections.Generic;
using System.Runtime;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****   Linked List Problems  *****");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(70);
            list.Add(36);
            list.Add(89);
            list.Display();
            list.RemoveLastNode();
            list.Display();
        }
    }
}