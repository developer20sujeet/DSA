using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Design.Queue
{
    /*
     
        Enqueue: To add an element at the end of the queue.
        Dequeue: To remove an element from the front of the queue.
        Peek: To view the front-most element without removing it.
        IsEmpty: To check if the queue is empty.
        IsFull: To check if the queue is full.
        
        front - to remove 
        rear  - to add 
     
     */

    /// <summary>     
    /// Time Complexity: O(1) for all operations
    /// Space Complexity: O(n)      
    /// Not removing element in actual but pointer is changed 
    /// </summary>
    internal class StandardQueueArray
    {       

        private int[] queueArray;
        private int maxSize;
        private int front;
        private int rear;

        // Constructor to initialize queue
        public StandardQueueArray(int size)
        {
            // Step 1: Initialize variables
            maxSize = size;
            queueArray = new int[maxSize];
            front = 0;

            // -1 because array is 0 index based index so we will first increament the value of rear the put value at rear index 
            // -1 indicate that queue is empty 
            rear = -1;
        }

        // Check if the queue is empty
        public bool IsEmpty()
        {
            // Step 2: Check for emptiness
            // 1. you've removed more items than you've added,
            // 2. or you haven't added any items at all. I
            return (front > rear);
        }

        // Check if the queue is full
        public bool IsFull()
        {
            // Step 3: Check for fullness
            return (rear == maxSize - 1);
        }

        // Adding an element
        public void Enqueue(int item)
        {
            // Step 4: Check if queue is full
            if (IsFull())
            {
                Console.WriteLine("The queue is full.");
                return;
            }

            // Step 5: Insert the item
            queueArray[++rear] = item;
        }

        // Removing an element
        // When you dequeue an element, you don't actually remove it from the array; you just increment the front index. 
        // so that removed index never can be pointed 
        // even though the array may still contain old values, they are not part of the active queue as front not point it 
        public int Dequeue()
        {
            // Step 6: Check if the queue is empty
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty.");
                return -1;
            }

            // Step 7: Remove the item and return
            return queueArray[front++];
        }

        // Peek at the front item
        public int Peek()
        {
            // Step 8: Check if the queue is empty
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty.");
                return -1;
            }

            // Step 9: Peek the item and return
            return queueArray[front];
        }
    }
}