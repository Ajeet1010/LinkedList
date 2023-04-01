using System.Collections.Generic;
using System.Runtime;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****   Linked List Problems  *****");
            Console.Write("1. Insertion of element.\n2. Displaying element in reverse order.\n3. Insertion at a particular position.\n" +
                "4. Insertion data in between element.\n5. Deletion of first element of node.\nChoose option to perform:  ");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your choice is: " + option + "\n");
            LinkedList list = new LinkedList();
            switch (option)
            {
                case 1:
                    list.Add(56);                                   // adding root node
                    list.Add(30);                                   // adding left node
                    list.Add(70);                                   // adding right node
                    list.Display();                                 // displaying the insertion.
                    break;
                case 2:
                    list.LinkedListReverseOrder(70);
                    list.LinkedListReverseOrder(30);
                    list.LinkedListReverseOrder(56);
                    list.Display();
                    break; 
                case 3:
                    list.Add(56);
                    list.InsertAtParticuarPosition(0, 30);
                    list.InsertAtParticuarPosition(0, 70);
                    list.Display();
                    break; 
                case 4:
                    list.Add(56);
                    list.Add(70);
                    list.Display();
                    list.InsertInBetween(1, 30);
                    list.Display();
                    break;
                case 5:
                    list.Add(56);
                    list.Add(70);
                    list.Add(36);
                    list.Add(89);
                    list.Display();
                    list.RemoveFirstNode();
                    list.Display();
                    break;
                default:
                    Console.WriteLine("Choose the correct option");
                    break;

            }
        }
    }
}