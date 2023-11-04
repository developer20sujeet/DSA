using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DSA_Design.Stack
{
    /// <summary>
    /// Stack implementation using an array.
    /// Time Complexity: 
    ///     - Push: O(1)
    ///     - Pop: O(1)
    ///     - Peek: O(1)
    /// Space Complexity: O(n)
    /// Algorithm Used: Basic operations for stack (LIFO)
    /// Data Structure Used: Array
    ///  
    /// =================================================================================
    /// top variable plays a pivotal role
    /// 1.Empty Check: If top is -1, the stack is empty.
    /// 2.Full Check: If top equals maxSize - 1, the stack is full.
    /// 3.Push Operation: Increment top and then insert the element at that position.
    /// 4.Pop Operation: Retrieve the element at top and then decrement it.
    /// 5.Peek Operation: Simply access the element at top without modifying it.
    /// </summary>
    internal class Stack_UsingArray
    {
        private int[] stackArray;
        private int top;
        private int maxSize;

        // Initialize the stack
        public Stack_UsingArray(int size)
        {
            maxSize = size;
            stackArray = new int[maxSize];
            top = -1;
        }


        /// <summary>
        /// Pushes an item onto the stack.
        /// </summary>
        /// <param name="item">The item to push.</param>
        public void Push(int item)
        {
            // Step 1: Check if the stack is full
            // because array indices are zero-based, the maximum index you can access in the array is maxSize - 1
            if (top == maxSize - 1)
            {
                Console.WriteLine("Stack is full. Cannot push.");
                return;
            }

            // Step 2: Increment the top pointer and push the item
            stackArray[++top] = item;
        }

        /// <summary>
        /// Pops an item from the top of the stack.
        /// </summary>
        /// <returns>The popped item.</returns>
        public int Pop()
        {
            // Step 1: Check if the stack is empty
            if (top == -1)
            {
                Console.WriteLine("Stack is empty. Cannot pop.");
                return int.MinValue;
            }

            // Step 2: Pop item from the stack
            // top -- , first return value at index top then decrement top by 1
            return stackArray[top--];
        }

        /// <summary>
        /// Peeks at the item on the top of the stack.
        /// </summary>
        /// <returns>The item at the top.</returns>
        public int Peek()
        {
            // Step 1: Check if the stack is empty
            if (top == -1)
            {
                Console.WriteLine("Stack is empty. Cannot peek.");
                return int.MinValue;
            }

            // Step 2: Return the top item without removing it
            return stackArray[top];
        }
    }


}
