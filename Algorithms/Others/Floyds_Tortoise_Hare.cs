using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Others
{
    /// <summary>
    /// Floyd's Tortoise and Hare (Cycle Detection) algorithm
    /// </summary>
    internal class Floyds_Tortoise_Hare
    {
        #region Array based implementation
        public int FindDuplicate(int[] nums)
        {
            #region Phase 1  Find if Cycle Exist in linked List or Duplicate exist in array


            // Start both the tortoise and hare at the first element of the array.
            // This is analogous to placing both pointers at the head of a linked list.
            int tortoise = nums[0]; // The value of the array at index 0 is assigned to tortoise.
            int hare = nums[0];     // The same value at index 0 is assigned to hare.

            // Use a do-while loop to iterate through the array.
            do
            {
                // Move the tortoise forward by one step.
                // This is like traversing to the next node in a linked list.
                // tortoise takes the value at the current index, which points to the next index.
                tortoise = nums[tortoise]; // Move by 1 step.

                // Move the hare forward by two steps.
                // This is achieved by moving the hare one step forward to get the intermediate index,
                // and then moving it another step from that intermediate index.
                hare = nums[nums[hare]]; // Move by 2 steps.

                // Continue this process until the tortoise and hare meet, which indicates a cycle is found.
                // This is the cycle detection phase.
            } while (tortoise != hare); // The condition for the loop is that the tortoise and hare are not at the same index. 


            #region cycleExists - bit modified 

            /*
                   // Phase 1: Finding the intersection point of the two runners.
                   bool cycleExists = false;
                   do
                   {
                       tortoise = nums[tortoise]; // Move by 1 step.
                       hare = nums[nums[hare]];   // Move by 2 steps.
                       if (tortoise == hare)
                       {
                           cycleExists = true;
                           break;
                       }
                   } while (true);

                   // If no cycle exists, there is no duplicate.
                   if (!cycleExists)
                   {
                       return -1; // Or throw an exception or handle the case as per the requirements.
                   }

               **/
            #endregion

            #endregion


            #region Find Cyclic node in liknked List or Duplicate value in array

            // Phase 2: Finding the entrance to the cycle (duplicate number).

            tortoise = nums[0]; // Reset tortoise/slow pointer  

            while (tortoise != hare) // when both are equal or same Duplicate found 
            {
                tortoise = nums[tortoise]; // Move by 1 step.
                hare = nums[hare];         // Move by 1 step as well, from the intersection point.
            }
            #endregion

            // The cycle start is the duplicate number.
            return hare;// or return tortoise; // as both are same 
        }
        #endregion

        #region LinkedList based implementation
        public ListNode DetectCycle(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return null;
            }

            ListNode tortoise = head;
            ListNode hare = head;
            bool hasCycle = false;

            #region Detect Cycle
            // Detect if the cycle exists using two pointers - tortoise and hare.
            while (hare != null && hare.next != null)
            {
                tortoise = tortoise.next;           // Move tortoise by one step.
                hare = hare.next.next;              // Move hare by two steps.

                if (tortoise == hare)
                {             // Cycle detected.
                    hasCycle = true;
                    break;
                }
            }
            #endregion

            if (!hasCycle)
            {
                return null;                        // No cycle detected.
            }

            #region Find Start Node
            // Find the start node of the cycle.
            tortoise = head;                       // Reset tortoise to the start of the list.
            while (tortoise != hare)
            {
                tortoise = tortoise.next;          // Move tortoise by one step.
                hare = hare.next;                  // Move hare by one step.
            }
            #endregion

            return tortoise;                       // Start node of the cycle.
        }

        public ListNode DetectCycle_way2(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return null;
            }

            ListNode tortoise = head;
            ListNode hare = head;

            #region Detect Cycle
            // Detect if the cycle exists using two pointers - tortoise and hare.
            while (hare.next != null && hare.next.next != null)
            {
                tortoise = tortoise.next;           // Move tortoise by one step.
                hare = hare.next.next;              // Move hare by two steps.

                if (tortoise == hare)
                {             // Cycle detected, proceed to find the start node.
                    #region Find Start Node
                    tortoise = head;               // Reset tortoise to the start of the list.
                    while (tortoise != hare)
                    {
                        tortoise = tortoise.next;  // Move tortoise by one step.
                        hare = hare.next;          // Move hare by one step.
                    }
                    return tortoise;               // Start node of the cycle found.
                    #endregion
                }
            }
            #endregion

            // If no cycle is detected, return null.
            return null;
        }

        #endregion
    }
}



    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

}
