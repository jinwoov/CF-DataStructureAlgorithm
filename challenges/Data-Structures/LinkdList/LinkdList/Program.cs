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
            RunMethod();
        }

        static void RunMethod()
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

                // Printing out everything in linklist
                Console.WriteLine("This is after inserting from beginning: {0}", ll.ToString());

                // A method that will append the node at last link list
                ll.Append(13);
                Console.WriteLine($"This is after appending 13 to the last node: {ll.ToString()}");

                // A method that will add before first argument value of node with second argument value node
                ll.InsertBefore(5, 911);
                Console.WriteLine($"This is after inserting 911 before 5: {ll.ToString()}");

                // Adding a node after 22 with node with 401 value
                ll.InsertAfter(13, 211);
                Console.WriteLine($"This is after inserting 211 after 13: {ll.ToString()}");

                // Checking from the back to return given index postion
                Console.WriteLine($"This is checking an index 1 from the back which should return |13|: result = {ll.kthFromEnd(1)}");

                // returning the middle element from the linked list
                Console.WriteLine($"This is checking middle index element {ll.kthFromMiddle()}");

                //checking



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
