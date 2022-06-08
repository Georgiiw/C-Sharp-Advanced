using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList

    {
        public class ListNode
        {
            public int Value { get; set; }
            public ListNode Next { get; set; }
            public ListNode Previous { get; set; }

            public ListNode(int value)
            {
                this.Value = value;
            }

        }

        public ListNode Head;
        public ListNode Tail;

        public int Count { get; private set; }

        // void AddFirst(int element) – adds an element at the beginning of the collection
        public void AddFirst(int element)
        {
            if (this.Count == 0)          
                this.Head = this.Tail = new ListNode(element);
            else
            {
                var newHead = new ListNode(element);
                newHead.Next = this.Head;
                this.Head.Previous = newHead;
                this.Head = newHead;
            }
            this.Count++;
           
        }
        // void AddLast(int element) – adds an element at the end of the collection
        public void AddLast(int element)
        {
            if (this.Count == 0)
                this.Head = this.Tail = new ListNode(element);
            else
            {
                var newTail = new ListNode(element);
                newTail.Previous = this.Tail;
                this.Tail.Next = newTail;
                this.Tail = newTail;
            }
            this.Count++;
        }
        // int RemoveFirst() – removes the element at the beginning of the collection
        public int RemoveFirst()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }
            var itemToRemove = this.Head.Value;
            this.Head = this.Head.Next;
            if (this.Head != null)
            {
                this.Head.Previous = null;
            }
            else
            {
               this.Head = this.Tail = null;
            }
            this.Count--;
            return itemToRemove;
        }
        // int RemoveLast() – removes the element at the end of the collection
        public int RemoveLast()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }
            var itemToRemove = this.Tail.Value;
            this.Tail = this.Tail.Previous;
            if (this.Tail != null)
            {
                this.Tail.Next = null;
            }
            else
            {
                this.Head = this.Tail = null;
            }
            this.Count--;
            return itemToRemove;
        }
        // void ForEach() – goes through the collection and executes a given action
        public void ForEach(Action<int> action)
        {
            var currNode = this.Head;
            while (currNode != null)
            {
                action(currNode.Value);
                currNode = currNode.Next;
            }
        }
        // int[] ToArray() – returns the collection as an array
        public int[] ToArray()
        {
            int[] arr = new int[this.Count];
            int counter = 0;
            var currNode = this.Head;

            while (currNode != null)
            {
                arr[counter] = currNode.Value;
                currNode = currNode.Next;
                counter++;

            }

            return arr;
        }
    }
}
