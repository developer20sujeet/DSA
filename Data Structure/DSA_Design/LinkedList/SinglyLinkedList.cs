using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSA_Design.LinkedList
{
    public class Node
    {
        /// <summary>
        /// Data stored in the node.
        /// </summary>
        public int Data { get; set; }

        /// <summary>
        /// Reference to the next node in the linked list.
        /// Self - Referencial Property 
        /// </summary>
        public Node Next { get; set; } // Self Referencial 

        /// <summary>
        /// Constructor to create a new node.
        /// </summary>
        /// <param name="data">Data to be stored in the node.</param>
        public Node(int data)
        {

            this.Data = data;
            this.Next = null;
        }
    }

    public class SinglyLinkedList
    {
        // Head node to point to the first node in the list
        public Node? Head { get; set; }

        public SinglyLinkedList()
        {
            //signify that the list is empty at the start.
            Head = null;
        }

        #region Addition  
        public void AddFirst(int data)
        {

            #region Visualization 
            /*
                   Original list: 
                   Head -> [1] -> [2] -> null

                   Step 1: Create a new node with the data you want to add (let's say data = 0)
                   newNode(0) -> null

                   Step 2: Point the 'next' of the new node to the current Head node
                   newNode(0) -> Head -> [1] -> [2] -> null

                   Step 3: Update Head to point to the new node
                   Head -> [0] -> [1] -> [2] -> null

                 */
            #endregion

            // Step 1: Create a new node with the given data
            Node newNode = new Node(data);


            // Step 2: Point the new node's 'Next' to the current head
            //         When your linked list is not empty, and it already contains some elements.
            //         In this case, you want the newNode to point to what was previously the first node in the list.
            newNode.Next = Head;

            // Step 3: Update the head to point to the new node
            Head = newNode;

        }
        public void AddLast(int data)
        {
            #region Visualization

            /*
             
            Before AddLast(4): Head -> [1] -> [2] -> [3] -> null
            AddLast(4): Head -> [1] -> [2] -> [3] -> newNode(4) -> null
            After AddLast(4): Head -> [1] -> [2] -> [3] -> [4] -> null

             */

            #endregion

            // Step 1: Create a new Node instance with the given data
            Node newNode = new Node(data);

            // Step 2: Check if the list is empty
            if (Head == null)
            {
                // The list is empty, make the new node the head
                Head = newNode;
                return;
            }

            // Step 3: Initialize a temporary node pointing to the head
            Node temp = Head;

            // Step 4: Traverse the list to find the last node
            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            // Step 5: Update the 'next' of the last node to the new node
            // temp and the head are references pointing to nodes within the same single list, so any change you make while traversing the list using temp will reflect in the original list itself.
            temp.Next = newNode;
        }
        public void AddAtPosition(int position, int data)
        {
            #region Visualization
            /*
                Before: Head-> [1]-> [2]-> [3]-> null
                Operation: AddAtPosition(3, 4)
                After: Head-> [1]-> [2]-> [4]-> [3]-> null

            */
            #endregion

            Node newNode = new Node(data);

            // Step 1: Check if position is valid
            if (position < 1)
            {
                Console.WriteLine("Invalid position.");
                return;
            }

            // Step 2: If position is 1, add the node at the beginning
            if (position == 1)
            {
                newNode.Next = Head;
                Head = newNode;
                return;
            }

            // Step 3: Initialize temp node to head and traverse to the previous node of the position
            Node temp = Head;
            for (int i = 1; i < position - 1; i++)
            {
                if (temp == null)
                {
                    Console.WriteLine("Invalid position.");
                    return;
                }
                temp = temp.Next;
            }

            // Step 4: Insert the new node at the specific position
            if (temp != null)
            {
                newNode.Next = temp.Next;
                temp.Next = newNode;
            }
            else
            {
                Console.WriteLine("Invalid position.");
            }
        }

        #endregion


        #region Delete 
        public void DeleteFirst()
        {
            // Step 1: Check if the list is empty
            if (Head == null)
            {
                Console.WriteLine("The list is empty.");
                return;
            }

            // Step 2: Point the head to the second node
            Head = Head.Next;
        }
        public void DeleteAtPosition(int position)
        {
            #region Visualization 

            /*
             For deleting the node at position 2 in a list with nodes [1, 2, 3]:

            Original list: Head -> [1] -> [2] -> [3] -> null
            After DeleteAtPosition(2): Head -> [1] -> [3] -> null

            */

            #endregion


            // Step 1: Check if the list is empty
            if (Head == null)
            {
                Console.WriteLine("The list is empty.");
                return;
            }

            // Step 2: Initialize a temp node pointing to Head
            Node temp = Head;

            // Step 3: Special case for position being 1 (the first node)
            if (position == 1)
            {
                Head = temp.Next;  // Move head to point to next node
                return;
            }

            // Step 4: Traverse the list to the previous node of the node to be deleted
            for (int i = 1; temp != null && i < position - 1; i++)
            {
                temp = temp.Next;
            }

            // Step 5: If position is greater than the number of nodes, do nothing
            if (temp == null || temp.Next == null)
                return;

            // Step 6: Delete the node
            Node next = temp.Next.Next;
            temp.Next = next;
        }
        public void DeleteLast()
        {
            #region Visualization
            /*
                For deleting the last node in a list with nodes[1, 2, 3]:

                Original list: Head-> [1]-> [2]-> [3]-> null
                After DeleteLast(): Head-> [1]-> [2]-> null

            */

            #endregion

            // Step 1: Check if the list is empty
            if (Head == null)
            {
                Console.WriteLine("The list is empty.");
                return;
            }

            // Step 2: Special case for single-node list
            if (Head.Next == null)
            {
                Head = null;
                return;
            }

            // Step 3: Initialize two pointers pointing to Head
            // Deleting a last node requires keeping track of its predecessor - first .
            Node first = Head;
            Node second = Head;

            // Step 4: Traverse to the last node using two pointers
            while (second.Next != null)
            {
                first = second;
                second = second.Next;
            }

            // Step 5: Delete the last node
            first.Next = null;
        }
        public void DeleteByValue(int value)
        {
            #region Visualization
            /*
            For deleting a node with value 2 in a list with nodes[1, 2, 3]:
            Original list: Head-> [1]-> [2]-> [3]-> null
            After DeleteByValue(2): Head-> [1]-> [3]-> null
            */

            #endregion


            // Step 1: Check if the list is empty
            if (Head == null)
            {
                Console.WriteLine("The list is empty.");
                return;
            }

            // Step 2: Check if the head node contains the value
            if (Head.Data == value)
            {
                Head = Head.Next;
                return;
            }

            // Step 3: Initialize two pointers pointing to Head
            Node first = Head;
            Node second = Head.Next;

            // Step 4: Traverse the list to find the node with the value
            while (second != null)
            {
                if (second.Data == value)
                {
                    first.Next = second.Next;
                    return;
                }
                first = second;
                second = second.Next;
            }

            // Step 5: If we reach this point, the value was not found
            Console.WriteLine("Value not found in the list.");
        }
        #endregion


        #region Search and Find and Print
        public void TraverseAndPrint()
        {
            // Step 1: Check if the list is empty
            if (Head == null)
            {
                Console.WriteLine("The list is empty.");
                return;
            }

            // Step 2: Initialize a temporary node to the head
            Node temp = Head;

            // Step 3: Traverse the list and print the elements
            while (temp != null)
            {
                Console.Write($"{temp.Data} -> ");
                temp = temp.Next;
            }

            // Step 4: Print null to indicate the end of the list
            Console.WriteLine("null");
        }
        public int Search(int data)
        {
            // Step 1: Initialize variables
            Node temp = Head;
            int position = 1;

            // Step 2: Traverse the list and search for the value
            while (temp != null)
            {
                if (temp.Data == data)
                {
                    return position;
                }
                temp = temp.Next;
                position++;
            }

            // Step 3: If the value is not found, return -1
            return -1;
        }
        public int FindMiddle()
        {

            #region Visualization

            /*
            For finding the middle element in a list with nodes [1, 2, 3, 4, 5]:

            Original list: Head -> [1] -> [2] -> [3] -> [4] -> [5] -> null
            After FindMiddle(): returns 3
             */

            #endregion


            // Step 1: Initialize two pointers, slow and fast, at the head
            Node slow = Head;
            Node fast = Head;

            // Step 2: Move the fast pointer twice as fast as the slow pointer
            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            // Step 3: When the fast pointer reaches the end, the slow pointer will be at the middle
            if (slow != null)
            {
                return slow.Data;
            }

            return -1; // Return -1 if the list is empty
        }
        #endregion


        #region Cycle Detection
        /// <summary>
        /// Detects whether the linked list contains a cycle.
        /// Algorithm used: Floyd's Cycle Detection Algorithm
        /// Time Complexity: O(n)
        /// Space Complexity: O(1)
        /// </summary>
        /// <returns>True if the list contains a cycle, otherwise false.</returns>
        public bool HasCycle()
        {
            #region Visualization:
            /*
            Imagine we have two pointers: slow and fast.The slow pointer moves one node at a time, while the fast pointer moves two nodes.If there is a cycle, these two pointers will eventually meet at some node; otherwise, the fast pointer will reach the end of the list.

            No cycle: Head-> [1]-> [2]-> [3]-> null
            With cycle: Head-> [1]-> [2]-> [3]-> [4]-> [5]-> [2](cycle back to[2])

            */
            #endregion

            // Step 1: Initialize slow and fast pointers to head
            Node slow = Head;
            Node fast = Head;

            // Step 2: Traverse the list with slow and fast pointers
            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;           // Move slow pointer one step
                fast = fast.Next.Next;      // Move fast pointer two steps

                // Step 3: Check for cycle
                if (slow == fast)
                {
                    return true; // Cycle detected
                }
            }

            // Step 4: If the loop exits, no cycle detected
            return false;
        }

        /// <summary>
        /// Determines the length of the cycle in the linked list.
        /// Algorithm used: Modified Floyd's Cycle Detection Algorithm
        /// Time Complexity: O(n)
        /// Space Complexity: O(1)
        /// </summary>
        /// <returns>Length of the cycle, or -1 if no cycle exists.</returns>
        public int CycleLength()
        {
            Node slow = Head;
            Node fast = Head;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                if (slow == fast)
                {
                    // Cycle detected, now find its length
                    int length = 0;
                    do
                    {
                        length++;
                        slow = slow.Next;
                    } while (slow != fast);

                    return length;  // Return the length of the cycle
                }
            }
            return -1;  // No cycle
        }

        /// <summary>
        /// Removes the cycle from the linked list, if it exists.
        /// Algorithm used: Modified Floyd's Cycle Detection Algorithm
        /// Time Complexity: O(n)
        /// Space Complexity: O(1)
        /// </summary>
        public void RemoveCycle()
        {

            #region Visualization:
            // With cycle: Head-> [1]-> [2]-> [3]-> [4]-> [5]-> [2](cycle back to[2])
            //After removal: Head-> [1]-> [2]-> [3]-> [4]-> [5]-> null

            #endregion

            Node slow = Head;
            Node fast = Head;

            // Step 1: Detect Cycle using Floyd's Cycle Detection Algorithm
            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                // Cycle detected
                if (slow == fast)
                {
                    // Step 2: Remove Cycle
                    slow = Head;
                    while (slow.Next != fast.Next)
                    {
                        slow = slow.Next;
                        fast = fast.Next;
                    }

                    // Detach the last node of the cycle to break it
                    fast.Next = null;
                    return;
                }
            }
        }
        #endregion


        #region Miscellaneous
        public void Reverse()
        {
            // Step 1: Initialize three pointers - prev, current, and next
            Node prev = null;
            Node current = Head;
            Node next = null;

            // Step 2: Iterate through the linked list
            while (current != null)
            {
                // Step 3: Store the next node
                next = current.Next;

                // Step 4: Reverse the current node's next pointer
                current.Next = prev;

                // Step 5: Move pointers one position ahead
                prev = current;
                current = next;
            }

            // Step 6: Reset the head pointer to the new head (prev)
            Head = prev;
        }

        //Check for Palindrome
        //Rotate a List

        #endregion


        #region Sorting and Merging

        string s;




        #endregion


        #region Recursion

        // Recursive Reverse: Reverse the linked list using a recursive function.
        // Recursive Search: Implement search functionality using recursion.

        string s1 = "";

        #endregion


        #region Two-Pointers Techniques

        string s23 = "";

        // N-th Node from the End: Implement a function to find the N-th node from the end of the linked list.
        // Find Intersection Point: Find the intersection point of two linked lists if they intersect.


        #endregion


    }
}
