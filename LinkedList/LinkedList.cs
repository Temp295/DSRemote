using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList
    {
        public Node head;

        /* This function prints contents of linked list starting from head */
        public void printList()
        {
            Node n = head;
            while (n != null)
            {
                Console.Write(n.data + " ");
                n = n.next;
            }
           
        }

        public void insertNode(int new_data,int? position = null)
        {
            Node newNode = new Node(new_data);
            if (head == null) //If it is first node
            {
                head = newNode;
                return;
            }
            else
            {
                if (!position.HasValue) //insert at end
                {
                    Node node = head;
                    while(node.next!= null)
                    {
                        node = node.next;
                    }

                    node.next = newNode;
                }
                else if (position ==0 ) //insert at start
                {
                    newNode.next = head;
                    head = newNode;
                }
                else if (position > 0) //insert at position
                {
                    Node prevNode=head;
                    Node nextNode = head;
                    for(int i =0;i<position && nextNode != null;i++)
                    {
                        prevNode = nextNode;
                        nextNode = nextNode.next;

                    }
                    newNode.next = nextNode;
                    prevNode.next = newNode;

                }

            }

            
        }

        public void pushFront(int new_data)
        {
            Node newHead = new Node(new_data);
            if(head!= null)
            {
                newHead.next = head;
            }
           
            head = newHead;
        }

        public void pushEnd(int new_data)
        {
            Node new_node = new Node(new_data);

            /* 4. If the Linked List is empty, then make the new node as head */
            if (head == null)
            {
                head = new_node;
                return;
            }            

            /*  traverse till the last node */
            Node last = head;
            while (last.next != null)
                last = last.next;

            last.next = new_node;
        }

        public void insertAfter(Node prev_node, int new_data)
        {
            /* 1. Check if the given Node is null */
            if (prev_node == null)
            {
                Console.WriteLine("The given previous node cannot be null");
                return;
            }
            Node new_node = new Node(new_data);

            /* 4. Make next of new Node as next of prev_node */
            new_node.next = prev_node.next;

            /* 5. make next of prev_node as new_node */
            prev_node.next = new_node;
        }
    }

    public class Node
    {
        public int data;
        public Node next;


        public Node(int d)
        {
            data = d;
        }

    }
}
