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
            list.InsertAtParticuarPosition(0, 30);
            list.InsertAtParticuarPosition(0, 70);
            list.Display();

        }
    }
}