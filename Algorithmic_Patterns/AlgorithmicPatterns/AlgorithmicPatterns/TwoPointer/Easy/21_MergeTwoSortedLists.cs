using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicPatterns.TwoPointer.Easy
{


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public partial class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            // Create a dummy node to serve as the start of the merged list
            ListNode dummy = new ListNode();
            ListNode current = dummy;

            // Traverse both lists
            while (list1 != null && list2 != null)
            {
                // Compare the values of the current nodes
                if (list1.val < list2.val)
                {
                    // Append the smaller node to the merged list
                    current.next = list1;
                    // Move the pointer forward in list1
                    list1 = list1.next;
                }
                else
                {
                    // Append the smaller node to the merged list
                    current.next = list2;
                    // Move the pointer forward in list2
                    list2 = list2.next;
                }
                // Move the current pointer forward in the merged list
                current = current.next;
            }

            // Append the remaining nodes of the non-exhausted list
            if (list1 != null)
            {
                current.next = list1;
            }
            else
            {
                current.next = list2;
            }

            // Return the merged list, starting from the next node after dummy
            return dummy.next;
        }
    }

}

