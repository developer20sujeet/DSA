using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Design.Queue
{

    /// <summary>
    /// Time Complexity: O(1) for Enqueue, Dequeue, and Peek operations.
    /// Space Complexity: O(n) where n is the number of elements in the queue.
    /// Algorithm Used: Custom Linked List Implementation
    /// Algorithmic Code Pattern: Basic Queue Operations
    /// Data Structure Used: Linked List
    /// Company Name: Common interview question, seen in multiple companies.
    /// Lessons Learned: Always maintain a reference to both head and tail for O(1) enqueue and dequeue operations.
    /// </summary>
    
    public class StandardQueueLinkedList
    {
        // Always maintain both head and tail pointers to make enqueue and dequeue operations efficient.

        private Node head; // head of the linked list
        private Node tail; // tail of the linked list

        private class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
                this.next = null;
            }
        }

        /// <summary>
        /// Step 1: Add an element to the end of the queue.
        /// </summary>
        /// <param name="data">Data to enqueue.</param>
        public void Enqueue(int data)
        {
            // Step 2: Create a new node
            Node newNode = new Node(data);

            // Step 3: If queue is empty, head and tail will point to the new node
            if (head == null)
            {
                head = tail = newNode;
                return;
            }

            // Step 4: Else add the new node to the end of the queue
            tail.next = newNode;
            tail = newNode;
        }

        /// <summary>
        /// Step 5: Remove an element from the front of the queue.
        /// </summary>
        public void Dequeue()
        {
            // Step 6: Check for an empty queue
            if (head == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            // Step 7: Move the head pointer to the next node
            head = head.next;

            // Step 8: If the queue becomes empty
            if (head == null)
            {
                tail = null;
            }
        }

        /// <summary>
        /// Step 9: Get the front element without removing it.
        /// </summary>
        public int Peek()
        {
            if (head == null)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            return head.data;
        }

        /// <summary>
        /// Step 10: Display all the elements of the queue.
        /// </summary>
        public void Display()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}

/*

// Main class
public class Program
{
    public static void Main(string[] args)
    {
        QueueLinkedList queue = new QueueLinkedList();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);

        // Display the queue elements
        queue.Display();

        // Peek at the front element
        Console.WriteLine("Front element is: " + queue.Peek());

        // Dequeue elements
        queue.Dequeue();
        queue.Dequeue();

        // Display the queue elements
        queue.Display();
    }
} 
 
 */








