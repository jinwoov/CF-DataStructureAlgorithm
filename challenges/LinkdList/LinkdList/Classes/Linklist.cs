using System;
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
        /// <returns>Returns false/true if value exists in the link lis tchain</returns>
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
        /// <summary>
        /// Will return all of the appended text with string builder as an output
        /// </summary>
        public override string ToString()
        {
            Current = Head;
            StringBuilder sb = new StringBuilder();
            while (Current != null)
            {
                sb.Append($"{Current.Data} -> ");
                Current = Current.Next;
            }

            // we are at null at this point
            sb.Append("NULL");
            return sb.ToString();
        }

        /// <summary>
        /// Append method will call method in the node class
        /// </summary>
        /// <param name="input">input is what user put for value</param>
        public void Append(int input)
        {
            if (Head == null)
            {
                Head = new Node();
                Head.Data = input;
            }
            else
            {
                Head.AppendNode(input);
            }
        }

        public void InsertBefore(int value, int newValue)
        {
            Current = Head;
           
            if (Head.Data == value)
            {
                Node node = new Node();

                node.Data = newValue;

                node.Next = Head;

                Head = node;

                return;
            }
            // create a while loop to check check if current value is matching the value that is being searched
            while (Current != null)
            {
                // checking if the value of current is matching input
                if (Current.Next.Data == value)
                {
                    Node node = new Node();

                    node.Data = newValue;
                    // Set the next to the head
                    node.Next = Current.Next;

                    Current.Next = node;

                    break;
                }
                // traverse to next value if current is not a match
                Current = Current.Next;
            }
        }
        
        public void InsertAfter(int value, int newValue)
        {
            Current = Head;
            Node node = new Node();
            node.Data = newValue;

            // create a while loop to check check if current value is matching the value that is being searched
            while (Current != null)
            {
                // checking if the value of current is matching input
                if (Current.Data == value)
                {
                    // Set the value of node to argument integer

                    // Set the next to the head
                    node.Next = Current.Next;

                    Current.Next = node;

                    break;
                }
                // traverse to next value if current is not a match
                Current = Current.Next;
            }
        }   
    }
}
