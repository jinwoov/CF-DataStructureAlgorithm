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

                ll.Append(13);

                // Printing out everything in linklist
                Console.WriteLine(ll.ToString());
            }
            catch (ArgumentException)
            {
                throw new FormatException("please enter correct format");
            }
            catch (Exception)
            {
                throw new Exception("Your have messed up");
            }

            
        }
    }
}
