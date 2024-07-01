using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
namespace AlgorithmicPatterns.TwoPointer.Easy
{
    public partial class Solution
    {
        #region Stack Way: T-O(N) , S-O(N)
        /// <summary>
        /// Approach and Intuition
        ///  To solve this problem, we can use a stack to simulate the typing process of both strings.When we encounter a #, we pop from the stack if it is not empty; otherwise, we push the current character onto the stack.
        /// Time Complexity: O(N) , Space Complexity: O(N)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool BackspaceCompare(string s, string t)
        {
            // Helper function to process the string with backspaces


            // Process both strings
            string processedS = ProcessString(s);
            string processedT = ProcessString(t);

            // Compare the processed strings
            return processedS == processedT;
        }
        string ProcessString(string str)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in str)
            {
                if (c == '#')
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    stack.Push(c);
                }
            }

            return new string(stack.ToArray());
        }
        #endregion


        #region Final Solution -  T-O(N) , S-O(1)

        /// <summary>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// Central Idea:
        /// 1. Traverse from the end: The effect of backspaces can be easily accounted for by traversing from the end.
        /// 2. Use two pointers to traverse both strings from the end.
        /// 3. Use backspace counters to skip characters.
        /// </summary>
        public bool BackspaceCompareV2(string S, string T)
        {
            // Step 1: Initialize pointers and backspace counters for each string
            // Reason: We will traverse each string from right to left, accounting for backspaces.
            int pointerS = S.Length - 1;
            int pointerT = T.Length - 1;


            int backspaceCountS = 0, backspaceCountT = 0;


            // Step 2: Start comparing the strings from the end
            // Reason: The effect of backspaces can be easily accounted for by traversing from the end.
            while (pointerS >= 0 || pointerT >= 0)
            {
                // Step 2.1: Move the pointerS position, accounting for backspaces in string S
                // Reason: To find the next valid character in string S after applying backspaces.
                // (S[pointerS] == '#' || backspaceCountS > 0) : both because to increments and decrements -backspaceCountS
                // If backspaceCountS > 0, it means we need to apply a backspace, skipping the current character and decrementing backspaceCountS.
                while (pointerS >= 0 && (S[pointerS] == '#' || backspaceCountS > 0))
                {
                    if (S[pointerS] == '#')
                        backspaceCountS++;
                    else
                        backspaceCountS--;

                    pointerS--;
                }

                // Step 2.2: Move the pointerT position, accounting for backspaces in string T
                // Reason: To find the next valid character in string T after applying backspaces.
                while (pointerT >= 0 && (T[pointerT] == '#' || backspaceCountT > 0))
                {
                    if (T[pointerT] == '#') 
                        backspaceCountT++; 
                    else 
                        backspaceCountT--;

                    pointerT--;
                }


                // Step 2.3: Compare the valid characters found in both strings
                // Reason: If the valid characters differ, then the strings are not equivalent.
                //          For S[pointerS] != T[pointerT]:
                //              At this point in the code, these pointers should be at valid characters, as they have already been adjusted for any backspace ('#') characters.
                //              This comparison is crucial for the algorithm because it quickly identifies if the two strings can be the same after applying the backspaces
                // Test this condition on S = ("a#b", "a#c") or  
                if (pointerS >= 0 && pointerT >= 0 && S[pointerS] != T[pointerT])
                    return false;


                // Step 2.4: Check if one pointer is out of bounds while the other is not
                // Reason: This implies one string has additional valid characters, making the strings unequal.
                //          If one string is 'used up' and the other still has characters left to consider, then the two strings cannot be the same.
                //          This condition checks if one of the strings has reached its beginning while the other has not
                // Test this condition on  :S = "a##"  T = "a#b"
                // One String Ended, the Other Didn't
                if ((pointerS >= 0) != (pointerT >= 0))
                    return false;

                // Step 2.5: Move both pointers one position backwards for the next iteration
                // Reason: Prepares for the next round of comparison.
                // Helping input : Needed if input is such as - S = "ab#c" && T = "ad#c"
                pointerS--;// 
                pointerT--;
            }

            // Step 3: Return true as all valid characters matched
            // Reason: If we've exited the loop, it means all comparisons were successful.
            return true;
        }

        #endregion
    }
}
