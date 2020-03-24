using System;
using LinkdList.Classes;

namespace LinkdList
{
    class Program
    {
        /// <summary>
        /// Main method that will run all of the method
        /// </summary>
        /// <param name="args">none</param>
        static void Main(string[] args)
        {
            try
            {
                // instantiating the object
                Linklist ll = new Linklist();

                // inserting a nodes into the ink
                ll.Insert(2);
                ll.Insert(3);
                ll.Insert(4);
                ll.Insert(5);

                /// returns if the link list contains node value
                bool search = ll.Includes(3);
                Console.WriteLine($" This is the include method: {search.ToString()}");

                // A method that will append the node at last link list
                ll.Append(13);

                // A method that will add before first argument value of node with second argument value node
                ll.InsertBefore(5, 22);

                // Adding a node after 22 with node with 401 value
                ll.InsertAfter(22, 401);

                // Printing out everything in linklist
                Console.WriteLine(ll.ToString());
            }
            catch (ArgumentException)
            {
                throw new FormatException("please enter correct format");
            }
            catch (Exception)
            {
                throw new Exception("Your input was inputted wrongly @_@{0}");
            }

            
        }
    }
}
