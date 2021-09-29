using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    class UC10_LinkedListInAscendingOrder
    {
        public Node head;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
                next = null;
            }
        }

        public void SortedLinkedList()
        {
            Node current = head, index = null;
            int temp;

            if (head == null)
            {
                return;
            }
            else
            {
                while (current != null)
                {
                    //Node index will point to node next to current  
                    index = current.next;

                    while (index != null)
                    {
                        //If current node's data is greater than index's node data, swap the data between them  
                        if (current.data > index.data)
                        {
                            temp = current.data;
                            current.data = index.data;
                            index.data = temp;
                        }
                        index = index.next;
                    }
                    current = current.next;
                }
            
        }
    }

    public void Append(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }

        public void printList()
        {
            Node nodes = head;
            Console.Write("\nLinked List:  ");
            while (nodes != null)
            {
                Console.Write(nodes.data + " ");
                nodes = nodes.next;
            }
        }
    }
}
