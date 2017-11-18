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
            foreach (var item in LinkedList.AsList())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(LinkedList.GetSize());
            LinkedList.GetByIndex(0);
            Console.ReadLine();
        }
    }
}
