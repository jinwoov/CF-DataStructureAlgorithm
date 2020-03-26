using System;
using System.Collections.Generic;
using System.Text;

namespace LLMerge.Classes
{
    public class LLMerged
    {
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

            // while loop will be ran until temp is null 
            while (temp != null)
            {
                //first you set the current2 to the temp as initializer which will be a linklist2
                current2 = temp;
                // then before you make any changes to the current2, you change the temp to temp next so it will not sever the ties between two nodes
                temp = temp.Next;
                /// checking  if current.next is null hence first link list shorter
                if (current.Next != null)
                {
                    // current2 will copy the next node of current one which will tie first link between node from linklist2 to linklist1
                    current2.Next = current.Next;
                    // then you tie the node on linklist 1 to tie to linklist 2
                    current.Next = current2;
                }
                //if link list is shorter this will just tie link list 2 and its remaining at the end
                else
                {
                    current.Next = current2;
                    break;
                }
                // traversing through current
                current = current2.Next;
            }

            // In the end you return the merged link list
            return list1;
        }
    }
}
