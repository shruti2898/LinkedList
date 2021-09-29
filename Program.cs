using System;

namespace DataStructurePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            //////UC1: Ability to create Linked List by appending 56 and 30 to 70
            //UC1_CreateLinkedList linkedList = new UC1_CreateLinkedList();
            //linkedList.Add(56);
            //linkedList.Add(30);
            //linkedList.Add(70);
            //linkedList.printList();

            //////UC2: Ability to create Linked List by appending 56 and 30 to 70 from front 
            //UC2_AddAtFirstPosition linkedList2 = new UC2_AddAtFirstPosition();
            //linkedList2.Add(70);
            //linkedList2.InsertFromFront(30);
            //linkedList2.InsertFromFront(56);
            //linkedList2.printList();

            //////UC3: Ability to create Linked List by appending 30 and 70 to 56
            //UC3_AppendList linkedList3 = new UC3_AppendList();
            //linkedList3.Append(56);   //Node with data 56 is First Created
            //linkedList3.Append(30);   //Next Append 30 to 56
            //linkedList3.Append(70);   //Finally Append 70 to 30
            //linkedList3.printList();  //Linked List : 56 30 70

            ////UC4: Ability to insert 30 between 56 and 70
            //UC4_InsertAtPosition linkedList4 = new UC4_InsertAtPosition();
            //linkedList4.Append(56);  
            //linkedList4.Append(70);  
            //linkedList4.insertAt(linkedList4.head,30);   
            //linkedList4.printList();  //Linked List : 56 30 70


            ////UC5 : delete the first element in the LinkedList
            //UC5_DeleteFirstElement linkedList5 = new UC5_DeleteFirstElement();
            //linkedList5.Append(56);
            //linkedList5.Append(30);
            //linkedList5.Append(70);
            //linkedList5.printList();
            //linkedList5.firstElement();
            //Console.WriteLine("\nAfter removing first element from linked list");
            //linkedList5.printList();

            ////UC6 : delete the last element from the LinkedList
            //UC6_DeleteLastElement linkedList6 = new UC6_DeleteLastElement();
            //linkedList6.Append(56);
            //linkedList6.Append(30);
            //linkedList6.Append(70);
            //linkedList6.printList();
            //linkedList6.lastElement();
            //Console.WriteLine("\nAfter removing last element from linked list");
            //linkedList6.printList();

            ////UC7 : search for the element with value of 30 in LinkedList
            //UC7_SearchNode linkedList7 = new UC7_SearchNode();
            //linkedList7.Append(56);
            //linkedList7.Append(30);
            //linkedList7.Append(70);
            //linkedList7.printList();
            //int position = linkedList7.SearchElement(30);
            //String result = (position==-1)? "\n\nNot found": "\n\nFound at position " + position;
            //Console.WriteLine(result);


            ////UC8 : search for the element with value of 30 and insert 40 after that element
            UC8_InsertAfterNode linkedList8 = new UC8_InsertAfterNode();
            linkedList8.Append(56);
            linkedList8.Append(30);
            linkedList8.Append(70);
            linkedList8.printList();
            linkedList8.InsertAt(40, 3);
            linkedList8.printList();


            //UC9 : search for the element with value of 40 and remove it from list
            UC9_DeleteElementAtPosition linkedList9 = new UC9_DeleteElementAtPosition();
            linkedList9.Append(56);
            linkedList9.Append(30);
            linkedList9.Append(40);
            linkedList9.Append(70);
            linkedList9.printList();
            linkedList9.deleteAt(2);
            linkedList9.printList();

            Console.ReadKey();
        }
    }
}
