using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    class UC7_SearchNode
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

       
        public int SearchElement(int value)
        {
            int i = 0;
            while (this.head != null)
            {
                i++;
                if (this.head.data == value)
                {   
                    return i;
                }
                this.head = this.head.next;
            }
            return -1;
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
            Console.Write("\n\nLinked List:  ");
            while (nodes != null)
            {
                Console.Write(nodes.data + " ");
                nodes = nodes.next;
            }
        }
    }
}
