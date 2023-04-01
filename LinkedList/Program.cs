using System.Collections.Generic;

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
            list.Display();
            list.InsertInBetween(1, 30);
            list.Display();
        }
    }
}