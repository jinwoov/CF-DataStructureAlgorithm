﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LinkdList.Classes
{
    public class Linklist
    {
        /// <summary>
        /// Adding new head everytime node is instantiated from Linklist
        /// </summary>
        public Node Head { get; set; }
        /// <summary>
        /// Current node that will act as temporary place holder to reference
        /// </summary>
        private Node Current { get; set; }

        /// <summary>
        /// Inserting new node to the link list
        /// </summary>
        /// <param name="value">new data that will be added to new node</param>
        public void Insert(int value)
        {
            // new node is inserted when Insert method is called
            Node node = new Node();

            // Set the value of node to argument integer
            node.Data = value;

            // Set the next to the head
            node.Next = Head;

            //reassign new node as new Head
            Head = node;
        }
        /// <summary>
        /// checking if the value is included in the link list
        /// </summary>
        /// <param name="value">Value is going to be finding a value</param>
        /// <returns></returns>
        public bool Includes(int value)
        {
            // Set a current as the head
            Current = Head;

            // create a while loop to check check if current value is matching the value that is being searched
            while(Current != null)
            {
                // checking if the value of current is matching input
                if (Current.Data == value)
                {   
                    // return when it matches
                    return true;
                }
                // traverse to next value if current is not a match
                Current = Current.Next;
            }
            // if it doesn't include value being searched
            return false;
        }

        public void ToString()
        {
            if (Head != null)
            {
                Head.PrintNode();
            }
        }
    }
}