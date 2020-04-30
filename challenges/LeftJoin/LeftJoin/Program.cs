using LeftJoin.Class;
using System;
using System.Collections.Generic;

namespace LeftJoin
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable(10);
            ht.Add("Water", "Moisture");
            ht.Add("Sleepy", "Nappy");
            ht.Add("Ice", "Snow");
            ht.Add("Mochi", "Dog");

            Hashtable htTwo = new Hashtable(10);
            htTwo.Add("Water", "Dry");
            htTwo.Add("Sleepy", "Awake");
            htTwo.Add("Ice", "Water");

            Hashtable resultTable = LeftJoins(ht, htTwo);
            string value = resultTable.Get("Water");
            string nullValue = resultTable.Get("Mochi");


            Console.WriteLine($"Expect Dry since it was added to the first node: {value}");

            Console.WriteLine($"Expect this output to be null {nullValue}");
        }

        /// <summary>
        /// This method is used to join two hashtables into one hastable carrying over the value that is in the second hashtable to the first hashtable
        /// </summary>
        /// <param name="ht">first hashtable</param>
        /// <param name="htTwo">second hashtable</param>
        /// <returns>Meshed hashtable</returns>
        public static Hashtable LeftJoins(Hashtable ht, Hashtable htTwo)
        {
                
            for (int i = 0; i < ht.Table.Length; i++)
            {
                if (ht.Table[i] != null)
                {
                    if (htTwo.Table[i] is null)
                    {
                        Node node = new Node("Null");
                        ht.Table[i].AddFirst(node);
                    }
                    else
                    {
                        var rightString = htTwo.Table[i].First.Value;

                        ht.Table[i].AddFirst(rightString);
                    }
                }
            }

            return ht;
        } 
    }
}
