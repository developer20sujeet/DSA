using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Design.Stack
{
    // Node class to represent an element in the stack
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }

    // Stack class to implement stack operations
    public class Stack
    {
        private Node top;
        public Stack()
        {
            top = null;
        }
    
        /// <summary>
        /// Push an element onto the stack.
        /// Time Complexity: O(1)
        /// Space Complexity: O(1)
        /// </summary>
        /// <param name="value">The value to be pushed onto the stack.</param>
        public void Push(int value)
        {
            // Step 1: Create a new node
            Node newNode = new Node(value);

            // Step 2: Link the new node to the current top node
            newNode.Next = top;

            // Step 3: Update the top node to be the new node
            top = newNode;
        }

        /// <summary>
        /// Pop an element from the stack.
        /// Time Complexity: O(1)
        /// Space Complexity: O(1)
        /// </summary>
        /// <returns>The popped value.</returns>
        public int Pop()
        {
            // Step 1: Check if stack is empty
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return int.MinValue;
            }

            // Step 2: Save the value of the top node
            int value = top.Value;

            // Step 3: Update top to the next node
            top = top.Next;

            // Step 4: Return the popped value
            return value;
        }

        /// <summary>
        /// Peek at the top element without removing it.
        /// Time Complexity: O(1)
        /// Space Complexity: O(1)
        /// </summary>
        /// <returns>The top value.</returns>
        public int Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return int.MinValue;
            }

            return top.Value;
        }

        /// <summary>
        /// Check if the stack is empty.
        /// Time Complexity: O(1)
        /// Space Complexity: O(1)
        /// </summary>
        /// <returns>True if the stack is empty, otherwise false.</returns>
        public bool IsEmpty()
        {
            return top == null;
        }
    }
}