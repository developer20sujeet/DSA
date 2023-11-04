

using Practice;

SlinkedList slinkedList = new SlinkedList();

slinkedList.AddNodeAtBeginning(5);
slinkedList.AddNodeAtBeginning(4);
slinkedList.AddNodeAtBeginning(3);
slinkedList.AddLast(6);

Console.WriteLine("Print now ");

Console.ReadKey();
slinkedList.PrintAllNode();


slinkedList.AddAtIndex(3, 55);
Console.WriteLine();
Console.WriteLine("Print now after index add ");
Console.ReadKey();
slinkedList.PrintAllNode();


slinkedList.DeleteAtPosition(3);
Console.WriteLine();
Console.WriteLine("Print now - Delete at position");
Console.ReadKey();
slinkedList.PrintAllNode();





Console.ReadKey();

