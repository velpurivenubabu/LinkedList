using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class CustomLinkedList
    {
        public Node head;
        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if(head == null )
            {
                head = newNode;
                Console.WriteLine("{0} node is added into linkedlist", newNode.data);
            }
            else
            {
                Node temp = GetLastNode();
                temp.next= newNode;
                Console.WriteLine("{0} node is added into linkedlist", newNode.data);
            }
        }
        private Node GetLastNode() {
            Node temp = head;
            while( temp != null )
            {
                temp = temp.next;
            }
            return temp;
        }
        public void AddFirst(int data)
        {
            Node newNode =new Node(data);
            if( head == null )
            {
                head = newNode;
                Console.WriteLine("{0} node is added into linkedlist", newNode.data);

            }
            else
            {
                newNode.next = head;
                head = newNode;
                Console.WriteLine("{0} node is added into linkedlist", newNode.data);
            }
        }
        public void Append(int data)
        {
            AddLast(data);
        }
        public void Display()
        {
            if(head == null)
            {
                Console.WriteLine("Linkedlist is empty");
            }
            else
            {
                Node temp = head;
                while (temp != null) {
                    Console.WriteLine(temp.data);
                    temp= temp.next;
                }
            }
        }
    }
}
