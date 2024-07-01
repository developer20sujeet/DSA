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
     
        We are removing the value in actual 
     
     */

    internal class StandardQueueArrayWay2
    {


        private int[] items;
        private int rear;
        private int maxSize;

        /// <summary>
        /// Initializes a new instance of the Queue class.
        /// Time Complexity: O(1)
        /// Space Complexity: O(n)
        /// </summary>
        /// <param name="size">Size of the queue.</param>
        public StandardQueueArrayWay2(int size)
        {
            items = new int[size];
            maxSize = size;
            rear = -1;
        }

        /// <summary>
        /// Enqueues an item into the queue.
        /// Time Complexity: O(1)
        /// Space Complexity: O(1)
        /// </summary>
        /// <param name="item">Item to enqueue.</param>
        public void Enqueue(int item)
        {
            if (rear == maxSize - 1)
            {
                throw new InvalidOperationException("Queue is full");
            }

            // Increment the rear pointer.
            rear++;

            // Insert the item at the rear index.
            items[rear] = item;
        }

        /// <summary>
        /// Dequeues an item from the queue.
        /// Time Complexity: O(n)
        /// Space Complexity: O(1)
        /// </summary>
        /// <returns>The dequeued item.</returns>
        public int Dequeue()
        {
            if (rear == -1)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            // Save the front item.
            int frontItem = items[0];

            // Shift all items to the left.
            for (int i = 0; i < rear; i++)
            {
                items[i] = items[i + 1];
            }

            // Decrement the rear pointer.
            rear--;

            // Return the dequeued item.
            return frontItem;
        }
    }
}
