using System;

namespace LinkedListProb
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Linked List operations");
            LinkedLists list = new LinkedLists();
            list.Add(56);                                   // adding root node
            list.Add(30);                                   // adding left node
            list.Add(70);                                   // adding right node
            list.Display();
        }
    }
}
