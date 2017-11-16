using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    class Node<T>
    {
        public Node<T> Next = null;
        public T Value;

        public Node(T name)
        {
            Value = name;
        }
    }
}
