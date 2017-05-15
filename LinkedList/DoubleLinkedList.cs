using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class DoubleLinkedList
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
                else if (position > 0) //insert at start
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

      
    }

    public class DLNode
    {
        public int data;
        public Node previous;
        public Node next;


        public DLNode(int d)
        {
            data = d;
        }

    }
}
