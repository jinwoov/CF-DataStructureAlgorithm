using Hashtables.Class;
using System;
using System.Text.RegularExpressions;

namespace RepeatedWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            string sen = "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...";
            Console.WriteLine(RepeatedWord(sen));

            string sen2 = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...";

            Console.WriteLine(RepeatedWord(sen2));

            string sen3 = "Once upon a time, there was a brave princess who...";

            Console.WriteLine(RepeatedWord(sen3));
        }

        /// <summary>
        /// Checking if the string has repeated word
        /// </summary>
        /// <param name="sentence">string sentence</param>
        /// <returns>the repeated word</returns>
        public static string RepeatedWord(string sentence)
        {
            sentence = sentence.Replace(",", "");
            string[] splitted = sentence.Split(" ");
            Hashtable ht = new Hashtable();

            for (int i = 0; i < splitted.Length; i++)
            {
                if (ht.Contains(splitted[i]))
                {
                    return splitted[i];
                }
                ht.Add(splitted[i], "");
            }

            return "There are no duplicated";
        }
    }
}
