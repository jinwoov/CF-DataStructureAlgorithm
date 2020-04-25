using Hashtables.Class;
using System;

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable(49);
            ht.Add("mochi", "rochi");
            ht.Add("water", "polo");
            ht.Add("coca", "cola");


            Console.WriteLine(ht.Get("mochi"));
            Console.WriteLine(ht.Get("water"));
            Console.WriteLine(ht.Get("bus"));




        }
    }
}
