using MultiBracketValidation.Classes;
using System;

namespace MultiBracketValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            string notPass = "[({}]";
            string pass = "{}{Code}[Fellows](())";
            Console.WriteLine("This is example when '{0}' is tested, and expect to be false: {1}", notPass, MultiBracketValidation(notPass));
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine();
            Console.WriteLine("This is example when '{0}' is tested and expect to be true: {1}", pass, MultiBracketValidation(pass));
            Console.WriteLine("--------------------------");
            Console.WriteLine();
            Console.WriteLine("This is example when '{0}' is tested and expect to be false: {1}", "EmptyString", MultiBracketValidation(""));
            Console.WriteLine("--------------------------");
        }
        /// <summary>
        /// The method that will check if given string has perfect set of bracket, if it is it will return true, otherwise it returns false.
        /// </summary>
        /// <param name="input">string input that user put in to check if it has perfect set of brackets</param>
        /// <returns>Returns true or false depending on the input</returns>
        public static bool MultiBracketValidation(string input)
        {
            if (input.Length <= 1)
                return false;

            Stack stack = new Stack();
            Stack stackTwo = new Stack();

            char[] charArray = input.ToCharArray();

            foreach (var character in charArray)
            {
                string characters = character.ToString();
                if (characters == "{" ||  characters == "(" ||  characters == "[")
                {
                    stack.Push(characters);
                }
                else if (characters == "}" || characters == ")" || characters == "]")
                {
                    stackTwo.Push(characters);
                }
            }

            while (stack.Top != null || stackTwo.Top != null)
            {
                string popChar = stack.Pop();
                string nextchar = stackTwo.Pop();
                switch (nextchar)
                {
                    case "}":
                        nextchar = "{";
                        break;
                    case "]":
                        nextchar = "[";
                        break;
                    case ")":
                        nextchar = "(";
                        break;
                }
                if (popChar != nextchar)
                {
                    return false;
                }
            }
            return true;
        }
    }
   
}
