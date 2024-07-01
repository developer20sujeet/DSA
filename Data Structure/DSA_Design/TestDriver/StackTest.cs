using DSA_Design.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Design.TestDriver
{
    internal class StackTest
    {

        public static void RunAllTests()
        {

        }
        public static void Stack_Array()
        {
            Stack_UsingArray myStack = new Stack_UsingArray(5);

            // Test pushing elements
            Console.WriteLine("Start Pushing ");
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);

            // Test popping elements
            Console.WriteLine("Start Popping ");
            Console.WriteLine("Popped: " + myStack.Pop());
            Console.WriteLine("Popped: " + myStack.Pop());

            // Test peeking at the top element
            Console.WriteLine("Start Peeking ");
            myStack.Push(4);
            Console.WriteLine("Peek: " + myStack.Peek());
        }

        public static void Stack_List()
        {
            StackUsingList stack = new StackUsingList();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine($"Top element is: {stack.Peek()}");  // Should print 3

            Console.WriteLine($"Popped element is: {stack.Pop()}");  // Should print 3
            Console.WriteLine($"Popped element is: {stack.Pop()}");  // Should print 2
            Console.WriteLine($"Popped element is: {stack.Pop()}");  // Should print 1

            Console.WriteLine($"Popped element is: {stack.Pop()}");  // Should print "Stack is empty. Cannot pop."
        }

        public static void Stack_LinkedList()
        {

            DSA_Design.Stack.Stack stack = new DSA_Design.Stack.Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            Console.WriteLine($"Peek: {stack.Peek()}"); // Output should be 4

            Console.WriteLine($"Pop: {stack.Pop()}"); // Output should be 4

            Console.WriteLine($"Is Stack Empty: {stack.IsEmpty()}"); // Output should be false
        }

    }
}
