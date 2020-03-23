using System;
using LinkdList.Classes;

namespace LinkdList
{
    class Program
    {
        static void Main(string[] args)
        {
            Linklist ll = new Linklist();

            ll.Insert(2);
            ll.Insert(3);
            ll.Insert(4);
            ll.Insert(5);

            bool search = ll.Includes(3);
            Console.WriteLine(search.ToString()); 

            ll.ToString();
        }
    }
}
