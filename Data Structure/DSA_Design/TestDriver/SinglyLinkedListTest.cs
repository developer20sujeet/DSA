using DSA_Design.LinkedList;
using System;

namespace DSA_Design.TestDriver  
{
    public class SinglyLinkedListTest
    {
        public static void RunAllTests()
        {
            //TestAddFirst();
            //TestTraverseAndPrint();

            TestAddLast();
        }

        public static void TestAddFirst()
        {
            Console.WriteLine("Testing AddFirst...");

            var linkedList = new SinglyLinkedList();
            linkedList.AddFirst(5);

            Console.Write("List after AddFirst: ");
            linkedList.TraverseAndPrint();
            Console.WriteLine();

            Console.WriteLine("------------------------------------------------");
        }     

        public static void TestAddLast()
        {
            Console.WriteLine("Testing AddLast() method:");

            // Initialize a new linked list and add some nodes.
            SinglyLinkedList list = new SinglyLinkedList();
            list.AddFirst(2);
            list.AddFirst(1);

            // Display the list before adding the last node.
            Console.WriteLine("Before adding last node:");
            list.TraverseAndPrint();

            // Add a new node at the end with data = 3.
            list.AddLast(3);

            // Display the list after adding the last node.
            Console.WriteLine("After adding last node:");
            list.TraverseAndPrint();


            Console.WriteLine("------------------------------------------------");

            // Here, you should see output like:
            // Before adding last node:
            // 1 -> 2
            // After adding last node:
            // 1 -> 2 -> 3
        }

        public static void TestAddAtPosition()
        {
            SinglyLinkedList list = new SinglyLinkedList();
            list.AddFirst(3);
            list.AddFirst(2);
            list.AddFirst(1);
            list.TraverseAndPrint(); // Should print: 1 2 3

            Console.WriteLine("Adding 4 at position 3...");
            list.AddAtPosition(3, 4);
            list.TraverseAndPrint(); // Should print: 1 2 4 3

            Console.WriteLine("Adding 0 at position 1...");
            list.AddAtPosition(1, 0);
            list.TraverseAndPrint(); // Should print: 0 1 2 4 3
        }




        public void TestSearch()
        {
            SinglyLinkedList list = new SinglyLinkedList();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);

            int position = list.Search(3);
            Console.WriteLine("Position of 3 is: " + position);  // Should print 3

            position = list.Search(4);
            Console.WriteLine("Position of 4 is: " + position);  // Should print -1
        }
        public static void TestTraverseAndPrint()
        {
            Console.WriteLine("Testing TraverseAndPrint...");

            var linkedList = new SinglyLinkedList();
            linkedList.AddFirst(1);
            linkedList.AddFirst(2);
            linkedList.AddFirst(3);

            Console.Write("List after multiple AddFirst: ");
            linkedList.TraverseAndPrint();
            Console.WriteLine();

            Console.WriteLine("------------------------------------------------");
        }



        public void TestDeleteFirst()
        {
            SinglyLinkedList list = new SinglyLinkedList();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);

            Console.WriteLine("Before DeleteFirst:");
            list.TraverseAndPrint();

            list.DeleteFirst();

            Console.WriteLine("After DeleteFirst:");
            list.TraverseAndPrint();
        }
        public void TestDeleteAtPosition()
        {
            SinglyLinkedList list = new SinglyLinkedList();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);

            Console.WriteLine("Before DeleteAtPosition(2):");
            list.TraverseAndPrint();

            list.DeleteAtPosition(2);

            Console.WriteLine("After DeleteAtPosition(2):");
            list.TraverseAndPrint();
        }

        public void TestDeleteLast()
        {
            SinglyLinkedList list = new SinglyLinkedList();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);

            Console.WriteLine("Before DeleteLast():");
            list.TraverseAndPrint();

            list.DeleteLast();

            Console.WriteLine("After DeleteLast():");
            list.TraverseAndPrint();
        }


        public void TestDeleteByValue()
        {
            SinglyLinkedList list = new SinglyLinkedList();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);

            Console.WriteLine("Before DeleteByValue(2):");
            list.TraverseAndPrint();

            list.DeleteByValue(2);

            Console.WriteLine("After DeleteByValue(2):");
            list.TraverseAndPrint();
        }



        public void TestReverse()
        {
            SinglyLinkedList list = new SinglyLinkedList();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);

            Console.WriteLine("Before Reverse():");
            list.TraverseAndPrint();

            list.Reverse();

            Console.WriteLine("After Reverse():");
            list.TraverseAndPrint();
        }


        public void TestFindMiddle()
        {
            SinglyLinkedList list = new SinglyLinkedList();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);

            Console.WriteLine($"Middle element is: {list.FindMiddle()}");
        }


        #region Cycle Detection Test

        public void TestHasCycle()
        {
            SinglyLinkedList list = new SinglyLinkedList();

            // Add elements
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);

            // Test without cycle
            bool result = list.HasCycle();
            Console.WriteLine($"Has Cycle (Expected False): {result}");

            // Create a cycle for testing
            list.Head.Next.Next.Next = list.Head.Next;  // Create a cycle

            // Test with cycle
            result = list.HasCycle();
            Console.WriteLine($"Has Cycle (Expected True): {result}");
        }

        #endregion

        #region Cycle Length Test

        public void TestCycleLength()
        {
            SinglyLinkedList list = new SinglyLinkedList();

            // Add elements
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);

            // Test without cycle
            int length = list.CycleLength();
            Console.WriteLine($"Cycle Length (Expected -1): {length}");

            // Create a cycle for testing
            list.Head.Next.Next.Next = list.Head.Next;  // Create a cycle

            // Test with cycle
            length = list.CycleLength();
            Console.WriteLine($"Cycle Length (Expected > 0): {length}");
        }

        #endregion

        #region Remove Cycle Test

        public void TestRemoveCycle()
        {
            SinglyLinkedList list = new SinglyLinkedList();

            // Add elements and create a cycle
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.Head.Next.Next.Next = list.Head.Next;  // Create a cycle

            // Test with cycle
            list.RemoveCycle();

            // Test if cycle is removed
            // You can do this by calling your TraverseAndPrint() method.
            list.TraverseAndPrint();
        }

        #endregion

    }
}
