using System;
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
            while (Current != null)
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
        /// Append method will recursively call method from the node class 
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
                // recurse method from Node class
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
                Insert(newValue);
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

        /// <summary>
        /// Looking for the element from the back of the linked list from given k value.
        /// </summary>
        /// <param name="k">index of position from back that linked list going to look for</param>
        /// <returns>Element in k position</returns>
        public int kthFromEnd(int k)
        {
            //initializing currnet as a head
            Current = Head;
            // count will be used to traverse and incremented, counting each node outputing length of linked list
            int count = 0;
            // This will be used in second iteration when it will use as a second counter to look for an element
            int newCount = 0;

            // first loop to look at the length of given linked list
            while (Current != null)
            {
                count++;
                Current = Current.Next;
            }

            // using the total length, it will minus the given search index and it will be used to traverse and make a stop at node we are looking for
            count = count - k;

            // reinitializing the Current from null
            Current = Head;

            // second loop to stop at position where count is which will be our node that we are looking for
            while (Current != null)
            {
                // this is like i in the for loop
                newCount++;
                //if newcount hit the count we are looking for it will hit this `if` statement
                if (newCount == count)
                {
                    // returns that point of node value
                    return Current.Data;
                }
                // it will keep move the current node position
                Current = Current.Next;
            }
            // if the node we are looking for is out of range, this exception will be thrown to the user indicating the message
            throw new Exception("That value is out of range");
        }

        /// <summary>
        /// Stretchgoalto check k from the middle
        /// </summary>
        /// <returns>The node value that is in the middle of the link list</returns>
        public int kthFromMiddle()
        {
            // much like same as above method
            Current = Head;
            int count = 0;
            int newCount = 0;

            while (Current != null)
            {
                count++;
                Current = Current.Next;
            }
            
            // this is to math ceil if the value has remainder
            if (count % 2 != 0)
            {
                count = (count / 2)+1;
            }
            else
            {
                count = count / 2;
            }

            Current = Head;

            // this traversing will stop at middle of the linked list
            while (Current != null)
            {
                newCount++;
                if (newCount == count)
                {
                    return Current.Data;
                }
                Current = Current.Next;
            }

            throw new Exception("That value is out of range or have put incorrect value!");
        }

    }
}
