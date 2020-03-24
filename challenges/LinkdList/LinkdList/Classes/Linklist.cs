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
        /// <summary>
        /// This is method that will create a node before the targed value
        /// </summary>
        /// <param name="value">Searching value</param>
        /// <param name="newValue">New value will be inserted right before the search value</param>
        public void InsertBefore(int value, int newValue)
        {
            Current = Head;
           // Check to make sure that value that we are trying look for is head
            if (Head.Data == value)
            {
                // Instantiating an object node
                Node node = new Node();
                // setting data to new value that is passed in
                node.Data = newValue;
                // setting the node next to current head object
                node.Next = Head;
                // changing current head to new node object
                Head = node;
                // return is needed because changing head will change current value which will throw null error
                return;
            }
            // create a while loop to check check if current value is matching the value that is being searched
            while (Current != null)
            {
                // checking if the value of current is matching input
                if (Current.Next.Data == value)
                {
                    // Instantiating node to class Node
                    Node node = new Node();
                    // seeting the current value to the argument value
                    node.Data = newValue;
                    // Set the next to the head
                    node.Next = Current.Next;
                    //seeing the next of current to be node
                    Current.Next = node;
                    //break out of this while loop
                    break;
                }
                // traverse to next value if current is not a match
                Current = Current.Next;
            }
        }
        
        /// <summary>
        /// This is to insert the new node with value after search value node
        /// </summary>
        /// <param name="value">This is search value which current node will traverse and look for the search value</param>
        /// <param name="newValue">Add that node with this value so it will be after search value</param>
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

                    //setting the current next to the node
                    Current.Next = node;

                    //break out of this while loop
                    break;
                }
                // traverse to next value if current is not a match
                Current = Current.Next;
            }
        }   
    }
}
