using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{

    class Node
    {
        public int Data { get; set; }

        public Node Next { get; set; }

        public Node(int data)
        {
            Data = data;
            Next = null;
        }

    }

    class SlinkedList
    {
        Node head;

        public SlinkedList()
        {
            head = null;


        }

        public void AddNodeAtBeginning(int data)
        {
            Node current = new Node(data);

            if (head == null)
            {
                head = current;
                return;
            }

            current.Next = head;
            head = current;

        }

        public void AddLast(int data)
        {
            Node node = new Node(data);

            while (head == null)
            {
                head = node;

            }

            Node temp = head;

            while (temp.Next != null)
            {

                temp = temp.Next;
            }

            temp.Next = node;

        }
        internal void PrintAllNode()
        {

            if (head == null)
            {
                Console.WriteLine("No Node exist");
                return;
            }

            Node temp = head;

            while (temp != null)
            {

                Console.Write($"{temp.Data} -->");

                temp = temp.Next;

            }



        }

        public void AddAtIndex(int _index, int data)
        {
            Node node = new Node(data);

            Node temp = head;

            for (int index = 1; index < 10; index++)
            {

                if (index == _index - 1)
                {
                    node.Next = temp.Next;
                    temp.Next = node;
                    return;
                }

                temp = temp.Next;


            }



        }




        public void DeleteFirst()
        {

            head = head.Next;

        }

        public void DeleteAtPosition(int index)
        {
            Node temp = head;
            for (int i = 1; i < index-1; i++)
            {

               temp = temp.Next;

            }

            if(temp != null)
            {

                temp.Next = temp.Next.Next;

            }



        }
    }













}
