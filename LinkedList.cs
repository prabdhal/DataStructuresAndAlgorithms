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

        // 1234
        public void AddMiddle(Node node)
        {
            int counter = 1;

            if (head == null)
            {
                head = node;
                return;
            }
            else
            {
                Node currentNode = head;

                while (currentNode.next != null)
                {
                    currentNode = currentNode.next;
                    counter++;
                }
            }
            // add to tail of linked list of only 
            // 1 node exists within linked list
            if (counter == 1)
            {
                AddTail(node);
                return;
            }
            // 
            int halfLength = counter / 2;
            Console.WriteLine(halfLength);

            counter = 1; 
            Node nodeBeforeHalf = head;

            while (counter != halfLength)
            {
                nodeBeforeHalf = nodeBeforeHalf.next;
                counter++;
            }

            Node temp = nodeBeforeHalf.next;
            nodeBeforeHalf.next = node;
            node.next = temp;
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
