using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hashtables.Class
{
    public class Hashtable
    {
        /// <summary>
        /// hash table property
        /// </summary>
        public LinkedList<Node>[] Table = new LinkedList<Node>[50];

        /// <summary>
        /// Add node to the the linklist of arry
        /// </summary>
        /// <param name="key">key that will be hashed</param>
        /// <param name="value">value that will be stored in array</param>
        public void Add(string key, string value)
        {
            int hashedKey = Hash(key);

            if (this.Table[hashedKey] == null)
            {
                Node node = new Node(key, value);
                LinkedList<Node> ll = new LinkedList<Node>();
                ll.AddFirst(node);
                this.Table[hashedKey] = ll;
            }
            else
            {
                Node node = new Node(key, value);
                this.Table[hashedKey].AddFirst(node);
            }
        }
        
        /// <summary>
        /// Getting the value when key is called
        /// </summary>
        /// <param name="key">key that will be used to search</param>
        /// <returns>return the value</returns>
        public string Get(string key)
        {
            int position = Hash(key);
            if (this.Table[position] != null)
            {
                var linkList = this.Table[position];

                Node findNode = linkList.First();

                return findNode.Value;

            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// See if the has contains the key value
        /// </summary>
        /// <param name="key">Key that will be searched in the table</param>
        /// <returns>boolean</returns>
        public bool Contains(string key)
        {
            int position = Hash(key);

            return this.Table[position] != null ? true : false;
        }

        /// <summary>
        /// Hashing the key to be used in index
        /// </summary>
        /// <param name="key">Key to be hashed</param>
        /// <returns>has number</returns>
        public int Hash(string key)
        {
            int sum = 0;
            for (int i = 0; i < key.Length; i++)
            {
                sum += key[i] % 50;
            }

            if (Table.Length < sum)
            {
                Array.Resize(ref Table, Table.Length + sum);
            }

            return sum;
        }
    }
}
