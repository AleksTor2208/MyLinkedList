using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var LinkedList = new MyLinkedList<string>();
            LinkedList.Add("Ola");
            LinkedList.Add("ma");
            LinkedList.Add("Psa");
            LinkedList.Add("i");
            LinkedList.Add("Kota");
            LinkedList.DisplayAll();
            Console.WriteLine(LinkedList.GetSize());
            Console.ReadLine();
        }
    }
}
