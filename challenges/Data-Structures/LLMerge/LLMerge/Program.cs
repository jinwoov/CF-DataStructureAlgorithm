using LinkdList.Classes;
using System;

namespace LLMerge
{
    class Program
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
            // Creating second link list of nodes
            Linklist llTwo = new Linklist();
            llTwo.Append(101);
            llTwo.Append(102);
            llTwo.Append(103);
            llTwo.Append(104);
            llTwo.Append(105);
            llTwo.Append(106);

            // calling the method to merge it together and store that result to a new link list
            Linklist result = mergeLists(ll, llTwo);

            // Output of merged link list
            Console.WriteLine(result.ToString());
        }

        /// <summary>
        /// This is method that makes the magic happens. The method takes in two list links and connect them together using point of reference call match
        /// </summary>
        /// <param name="list1">First link list</param>
        /// <param name="list2">Second link list</param>
        /// <returns>Link list that tied together</returns>
        public static Linklist mergeLists(Linklist list1, Linklist list2)
        {
            //Three nodes created current is traversing through first link list and current2 will be traversing through second link list. temp act as placeholder for current2 as it will sever the link betweent current and next node while its merging to the link list.
            Node current = new Node();
            Node current2 = new Node();
            Node temp = new Node();

            //Every nodes are starting from the head and will be traverse as it merge together
            current = list1.Head;
            temp = list2.Head;
            current2 = list2.Head;

            // while loop will be ran as a loop to catch any null references
            while (current != null)
            {
                // this if statement is crucial piece for merging two link list it will catch incase second linklist is shorter than first link list
                if (temp != null)
                {
                    //first you set the current2 to the temp as initializer which will be a linklist2
                    current2 = temp;
                    // then before you make any changes to the current2, you change the temp to temp next so it will not sever the ties between two nodes
                    temp = temp.Next;
                    // current2 will copy the next node of current one which will tie first link between node from linklist2 to linklist1
                    current2.Next = current.Next;
                    // then you tie the node on linklist 1 to tie to linklist 2
                    current.Next = current2;
                }
                // this else statmente catches incase linklist2 is done traversing
                else
                {
                    break;
                }
                // this will always change the current node to the next traversal node
                current = current2.Next;
            }

            // In the end you return the merged link list
            return list1;
        }
    }
}
