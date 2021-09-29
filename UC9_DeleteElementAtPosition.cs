using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    class UC9_DeleteElementAtPosition
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
        public void size()
        {
            Node temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            Console.WriteLine("\n\nLinked list size:  {0}", count);
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

        public void deleteAt(int position)
        {
            
            if(head == null)
            {
                return;
            }
            Node temp = head;
            if (position == 0)
            {
                head = temp.next;
                return;
            }
           for (int i = 0; temp != null && i < position - 1; i++)
           {
                temp = temp.next;
           }

            if (temp == null || temp.next == null)
                return;
            Node next = temp.next.next;
            temp.next = next;
        }

        public void printList()
        {
            Node nodes = head;
            Console.Write("\n\nLinked List:  ");
            while (nodes != null)
            {
                Console.Write(nodes.data + " ");
                nodes = nodes.next;
            }
        }
    }
}
