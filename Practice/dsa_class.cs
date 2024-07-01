using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{

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

    public class SinglyLinkedList
    {
        Node head;
        Node current;


        public Node CreateLLof10Node()
        {
            Node node = new Node(1);

            head = node;
            current = head;

            for (int i = 2; i <= 10; i++)
            {
                Node _node = new Node(i);
                current.next = _node;
                current = current.next;
            }


            return head;
        }

        public void PrintAllNode()
        {
            Node node = head;

            Console.WriteLine("--------Start Print all node------");
            Console.WriteLine();

            while (node != null)
            {


                Console.Write(node.data);

                if (node.next != null)
                    Console.Write(">>");

                node = node.next;

            }

            Console.WriteLine();
            Console.WriteLine("--------Stop Print all node------");
        }


        public void InsertAtBeginning(int data)
        {
            Node node1 = new Node(data);

            node1.next = head;

            head = node1;

        }

        public void InsertAtEnd(int data)
        {
            Node node1 = new Node(data);

            Node curr = head;

            while (curr.next != null)
            {
                curr = curr.next;

            }

            curr.next = node1;


        }

        public void InsertAt(int index, int data)
        {
            int count = 1;

            Node curr = head;

            while (count < index - 1 && curr != null)
            {
                curr = curr.next;

            }

            Node n = new Node(data);

            n.next = current.next;

            current.next = n;


        }


        public void DeleteFirstNode()
        {

            if (head == null)
            {
                throw new Exception("there is no node to delete");

            }

            head = head.next;



        }


        public void DeleteLast()
        {
            Node last = head.next;
            Node secondlast = head;

            while (last.next != null)
            {
                last = last.next;
                secondlast = secondlast.next;
            }

            secondlast.next = null;


        }

        public void DeleteAtIndex(int index)
        {
            Node c = head;
            int count = 1;
            while (c.next != null && count < index - 1)
            {
                c = c.next;
                count++;

            }

            c.next = c.next.next;


        }

        public void DeleteByValue(int val)
        {

            Node c = head;
           
            while (c != null)
            {
              
                if (c.data == val)
                {                  
                    break;
                }

                c = c.next;

            }

            c.next = c.next.next;

        }

    }

}
