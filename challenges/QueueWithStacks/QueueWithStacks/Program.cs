using QueueWithStacks.Classes;
using System;

namespace QueueWithStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RunApplication();

            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("----------------------");
            }
            finally
            {
                Console.WriteLine("Thank you for checking out my data structure");
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// This will test out the code have enqueue 2 numbers then dequeue 2. Thereafter, dequeue one more to throw an error.
        /// </summary>
        static void RunApplication()
        {
            PseudoQueue pseudo = new PseudoQueue(); 
            Console.WriteLine("----- Enqueue------");
            pseudo.Enqueue(5);
            Console.WriteLine($"After adding 5 into queue: {pseudo.PseudoQ.Peek()}");
            Console.WriteLine("");


            Console.WriteLine("----- After adding another Queue------");
            pseudo.Enqueue(20);
            Console.WriteLine($"After adding 20 into queue, expected answer is still 5: {pseudo.PseudoQ.Peek()}");
            Console.WriteLine("");

            Console.WriteLine("----- After dequeuing ------");
            pseudo.Dequeue();
            Console.WriteLine($"After dequeuing first in line, expected answer is 20: {pseudo.PseudoQ.Peek()}");
            Console.WriteLine("");

            Console.WriteLine("----- Dequeuing more than what I have queued will throw an error! Enter to see!");
            Console.ReadLine();

            pseudo.Dequeue();
            pseudo.Dequeue();


        }
    }
}
