using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Design.Stack
{
    public class StackUsingList
    {
        private List<int> stackList;

        public StackUsingList()
        {
            stackList = new List<int>();
        }


        /// <summary>
        /// Push an element onto the stack.
        /// Time Complexity: O(1)
        /// Space Complexity: O(1)
        /// </summary>
        /// <param name="item">The item to push.</param>
        public void Push(int item)
        {
            // Step 1: Add the item to the list
            stackList.Add(item);
        }

        /// <summary>
        /// Pop an element from the stack.
        /// Time Complexity: O(1)
        /// Space Complexity: O(1)
        /// </summary>
        /// <returns>The popped item.</returns>
        public int Pop()
        {
            // Step 1: Check if the stack is empty
            if (stackList.Count == 0)
            {
                Console.WriteLine("Stack is empty. Cannot pop.");
                return int.MinValue;
            }

            // Step 2: Remove and return the last element from the list
            int lastElement = stackList[stackList.Count - 1];
            stackList.RemoveAt(stackList.Count - 1);
            return lastElement;
        }

        /// <summary>
        /// Peek the top element of the stack.
        /// Time Complexity: O(1)
        /// Space Complexity: O(1)
        /// </summary>
        /// <returns>The top element of the stack.</returns>
        public int Peek()
        {
            // Step 1: Check if the stack is empty
            if (stackList.Count == 0)
            {
                Console.WriteLine("Stack is empty. Nothing to peek.");
                return int.MinValue;
            }

            // Step 2: Return the last element from the list
            return stackList[stackList.Count - 1];
        }
    }
}