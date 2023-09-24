using DSA_Design.LinkedList;
using NUnit.Framework;
using System;
using System.IO;

namespace DSA_Design_UnitTesting.LinkedList
{
    [TestFixture]
    public class LinkedListTests
    {
        #region Add First Node

        [Test]
        public void AddFirst_SingleNode_AddsNodeAtBeginning()
        {
            // Arrange
            var list = new SinglyLinkedList();
            int valueToAdd = 5;

            // Act
            list.AddFirst(valueToAdd);

            // Redirect Console output to StringWriter for testing
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            list.TraverseAndPrint();
            string output = sw.ToString().Trim();

            // Assert
            Assert.AreEqual("5", output);
        }

        #endregion


        #region TraverseAndPrint
        [Test]
        public void TraverseAndPrint_EmptyList_ShouldPrintEmptyMessage()
        {
            // Arrange
            SinglyLinkedList list = new SinglyLinkedList();
            StringWriter sw = new StringWriter();
            //Redirect the console's standard output to this StringWriter: Console.SetOut(sw);
            Console.SetOut(sw);

            // Act
            list.TraverseAndPrint();

            // Assert
            string expected = "The list is empty.\r\n";
            Assert.AreEqual(expected, sw.ToString());
        }

        [Test]
        public void TraverseAndPrint_NonEmptyList_ShouldPrintElements()
        {
            // Arrange
            SinglyLinkedList list = new SinglyLinkedList();
            list.AddFirst(2);
            list.AddFirst(1);
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            list.TraverseAndPrint();

            // Assert
            string expected = "1 -> 2 -> null\r\n";
            Assert.AreEqual(expected, sw.ToString());
        }

        #endregion
    }
}

