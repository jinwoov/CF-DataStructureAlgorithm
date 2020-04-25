using Hashtables.Class;
using System;

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable(49);
            ht.Add("Michael", "Scott");
            ht.Add("Dwight", "Shrute");
            ht.Add("Stanley", "Hudson");


            Console.WriteLine($"IF I search for Michael, {ht.Get("Michael")} comes out");
            Console.WriteLine($"IF I search for Dwight, {ht.Get("Dwight")} comes out");
            Console.WriteLine($"IF I search for Stanley, {ht.Get("Stanley")} comes out");

            Console.WriteLine($"This is checking if its exist, expect it to be True: {ht.Contains("Michael")}");
        }
    }
}
