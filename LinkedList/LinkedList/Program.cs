using LinkedListProb;
using System;
using System.Collections.Generic;

namespace LinkedListProb
{
    class Program
    {
        static void Main(string[] args) 
        {
            LinkedLists linkedLists = new LinkedLists();
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("Linked List problems ");
                Console.WriteLine("1.CreateLinkedList\n" +
                                  "2.LinkedListReverseOrder\n" +
                                  "3.Create by appending\n" +
                                  "4.Deletion of first node\n" +
                                  "5.Deletion of last node\n" +
                                  "6.Exit" + "\n");
                Console.WriteLine("Select to perform operation");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        linkedLists.Add(56);                                   // adding root node
                        linkedLists.Add(30);                                   // adding left node
                        linkedLists.Add(70);                                   // adding right node
                        linkedLists.Display();
                        break;

                    case 2:
                        linkedLists.LinkedListReverseOrder(70);
                        linkedLists.LinkedListReverseOrder(30);
                        linkedLists.LinkedListReverseOrder(56);
                        linkedLists.Display();
                        break;

                    case 3:
                        linkedLists.Add(56);
                        linkedLists.Add(70);
                        linkedLists.InsertAtParticuarPosition(1, 30);
                        linkedLists.Display();
                        break;

                    case 4:
                        linkedLists.Add(56);
                        linkedLists.Add(30);
                        linkedLists.Add(70);
                        linkedLists.RemoveFirstNode();
                        linkedLists.Display();
                        break;

                    case 5:
                        linkedLists.Add(56);
                        linkedLists.Add(30);
                        linkedLists.Add(70);
                        linkedLists.RemoveLastNode();
                        linkedLists.Display();
                        break;

                    case 6:
                        flag = false;
                        break;
                }
            }
        }
    }
}       