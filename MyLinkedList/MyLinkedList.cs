using System;
using System.Collections.Generic;

namespace MyLinkedList
{
    public class MyLinkedList<T>
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

        public List<T> AsList()
        {            
            Current = Head;            
            var endList = new List<T>();
            while (Current != null)
            {               
                endList.Add(Current.Value);
                if (Current.Next == null) break;
                Current = Current.Next;                     
            }
            return endList;
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

        public T GetByIndex(int index)
        {
            var count = 0;
            Current = Head;
            while (true)
            {
                if (Current == null)                
                    throw new IndexOutOfRangeException("Index Out Of Range.");                
                if (count == index)
                    return Current.Value;
                Current = Current.Next;
                count++;
            }
            //return Current.Value;
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
