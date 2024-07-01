using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Others
{
    internal class Dutch_National_Flag_Algorithms
    {
        /// <summary>
        /// Sorts an array of 0s, 1s, and 2s in ascending order.
        /// </summary>
        /// <param name="nums">The array to sort.</param>
        /// <remarks>
        /// <para>Time complexity: O(n), as the array is traversed in a single pass.</para>
        /// <para>Space complexity: O(1), as the sorting is done in place with no extra space.</para>
        /// <para>Algorithm used: Dutch National Flag.</para>
        /// <para>Algorithmic pattern: Two-pointers.</para>
        /// <para>Data structure: Array.</para>
        /// <para>Interviewed at: Google, Facebook.</para>
        /// <para>Tip: The key is to move all 0s to the beginning and all 2s to the end, leaving 1s in the middle.</para>
        /// <para>Lesson Learned: Maintaining and understanding the invariants (what low, mid, and high represent) is crucial for solving this efficiently.</para>
        /// </remarks>
        public void SortColors(int[] nums)
        {
            // 'low' and 'mid' start from the beginning of the array,
            // 'high' starts from the end of the array.
            int low = 0, mid = 0, high = nums.Length - 1;

            // Process until 'mid' surpasses 'high'.
            // process 'mid' only 
            while (mid <= high)
            {
                switch (nums[mid])
                {
                    // if found 0 in middle then need to put at beginning 
                    case 0: 
                        // Swap nums[mid] and nums[low] and increment 'low' and 'mid'.
                        Swap(nums, low, mid);
                        low++; // increase as 0 is put at index low and now need to adjust next low
                        mid++; // Increment as value at this index got processed 
                        break;


                    // if found 1 in middle then it is already at currect place no action just see next value in array
                    case 1:
                        // '1' is in its right place, just move 'mid'.
                        mid++;
                        break;


                    // if found 2 in middle then need to put at end  
                    case 2:
                        // Swap nums[mid] and nums[high] and decrement 'high'.
                        Swap(nums, mid, high);
                        high--; // descreasing because value at index high processed 
                        // 'mid' is not incremented because the swapped element needs to be evaluated also as hight swapped value can be 0 that need to go at begining 
                        break;
                }
            }
        }

        /// <summary>
        /// Swaps two elements in an array.
        /// </summary>
        /// <param name="nums">The array containing the elements.</param>
        /// <param name="i">The index of the first element.</param>
        /// <param name="j">The index of the second element.</param>
        private void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
            // A temporary variable 'temp' is used to hold the value of nums[i] while nums[i] and nums[j] are swapped.
        }

    }
}
