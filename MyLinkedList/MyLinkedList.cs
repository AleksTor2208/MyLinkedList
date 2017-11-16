using System;

namespace MyLinkedList
{
    class MyLinkedList<T>
    {
        public Node<T> Head = null;
        public Node<T> Current = null;

        public void Add(T value)
        {
            var newNode = new Node<T>(value);
            if (Head == null)
            {
                Head = newNode;
                Current = newNode;
            }
            else
            {
                Current.Next = newNode;
                Current = Current.Next;
            }            
        }

        public int GetSize()
        {
            var hasNextNode = true;
            var count = 0;
            while (hasNextNode)
            {
                if (Head.Next == null)
                    hasNextNode = false;
                Head = Head.Next;
                count++;                
            }   
            return count;
        }

        public void DisplayAll()
        {
            Current = Head;
            if (Current != null)
                Console.WriteLine(Current.Value);
            while (Current.Next != null)
            {
                Current = Current.Next;              
                Console.WriteLine(Current.Value);                
            }                      
        }
    }
}
