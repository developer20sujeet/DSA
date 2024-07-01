

using Practice;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

SinglyLinkedList sll = new SinglyLinkedList();

Node node = sll.CreateLLof10Node();

//sll.InsertAtBeginning(0);
//// print
//sll.PrintAllNode();

//sll.InsertAtEnd(11);
//sll.PrintAllNode();

//sll.InsertAt(5, 55);
//sll.PrintAllNode();

//-----------------------------------------------------------------------------
//sll.DeleteFirstNode();
//sll.PrintAllNode();


//sll.DeleteLast();
//sll.PrintAllNode();

//sll.DeleteAtIndex(3);
//sll.PrintAllNode();


sll.DeleteByValue(3);
sll.PrintAllNode();






string test = "";



