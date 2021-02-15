using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms
{
    class Node 
    {
        // pointer
        public Node next;
        // value
        public dynamic value;

        public Node(dynamic value)
        {
            this.value = value;
        }
    }
    class LinkedList
    {
        Node head;

        public void AddHead(Node node)
        {
            if (head == null)
            {
                head = node;
            }
            else
            {
                node.next = head;
                head = node;
            }
        }

        public void AddTail(Node node)
        {
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node currentNode = head;
                while(currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }
                currentNode.next = node;
            }
        }

        public void PrintNodes()
        {
            Node currentNode = head;
            while (currentNode.next != null)
            {
                Console.Write(currentNode.value + ", ");
                currentNode = currentNode.next;
            }
            Console.Write(currentNode.value + ", ");
        }
    }
}
