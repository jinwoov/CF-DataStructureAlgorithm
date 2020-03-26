using System;
using LLMerge.Classes;

namespace LLMerge
{
    public class Program
    {
        /// <summary>
        /// Program is using a reference to created classes from LinkdList
        /// </summary>
        static void Main(string[] args)
        {
            // creating first link list of nodes
            Linklist ll = new Linklist();
            ll.Append(1);
            ll.Append(2);
            ll.Append(3);
            ll.Append(4);
            ll.Append(5);
            ll.Append(6);
            ll.Append(7);


            Console.WriteLine($"This is first link list created: {ll.ToString()}");

            // Creating second link list of nodes
            Linklist llTwo = new Linklist();
            llTwo.Append(101);
            llTwo.Append(102);
            llTwo.Append(103);
            llTwo.Append(104);
            llTwo.Append(105);
            llTwo.Append(106);

            Console.WriteLine($"This is second link list created: {llTwo.ToString()}");

            // calling the method to merge it together and store that result to a new link list
            Linklist result = LLMerged.MergeLists(ll, llTwo);

            // Output of merged link list
            Console.WriteLine($"This is when its finally merged and outputting merged link list: {result.ToString()}");
        }
    }
}
