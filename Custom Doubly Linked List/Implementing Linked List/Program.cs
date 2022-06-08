using System;

namespace CustomDoublyLinkedList
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            DoublyLinkedList list = new DoublyLinkedList();
            
            list.AddFirst(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);
            
            Console.WriteLine(list.Head.Value);
            Console.WriteLine(list.Head.Next.Value);
            Console.WriteLine(list.Tail.Previous.Value);
            Console.WriteLine(list.Tail.Value);

            list.RemoveLast();
            Console.WriteLine(list.Tail.Value);
            list.RemoveFirst();
            Console.WriteLine(list.Head.Value);

            list.ForEach(n => Console.Write(n + " "));
        }
    }
}
