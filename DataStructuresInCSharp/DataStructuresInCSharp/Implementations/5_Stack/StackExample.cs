using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructuresInCSharp.Implementations._5_Stack
{
    public class StackExample
    {
        public void BaseExample()
        {
            var stack = new Stack<string>();
            //Push on top
            stack.Push("FisrtItem");
            stack.Push("SecondItem");
            stack.Push("ThridItem");

            //Remove from the top
            string removedTopStackItem = stack.Pop();

            //Get top without removing
            string topStackItem = stack.Peek();

            //Stack count
            int stackItemsCount = stack.Count;

            //Clear all stack
            stack.Clear();
        }

        public static void RealExample()
        {
            string str1 = "{[()]}";
            Console.WriteLine($"--------------{str1}------------------");
            Console.WriteLine($"{str1} -" 
                + VerifyIfBracketsCorrectlyParsed($"{str1}"));

            string str2 = "{[(])}";
            Console.WriteLine($"--------------{str2}------------------");
            Console.WriteLine($"{str2} -"
                + VerifyIfBracketsCorrectlyParsed($"{str2}"));

            string str3 = "{{[[(())]]}}";
            Console.WriteLine($"--------------{str3}--------------------");
            Console.WriteLine($"{str3} -"
                + VerifyIfBracketsCorrectlyParsed($"{str3}"));
        }

        private static bool VerifyIfBracketsCorrectlyParsed(string bracketsString)
        {
            var openBrackets = new List<char> { '{', '[', '(' };
            char [] chars = bracketsString.ToCharArray();
            var bracketsStack = new Stack<char>();

            foreach (var ch in chars)
            {
                if (openBrackets.Any(c => c.Equals(ch)))
                {
                    Console.WriteLine($"Pushing open char \"{ch}\" to Stack");
                    bracketsStack.Push(ch);
                }                 
                else
                {
                    char openChar = bracketsStack.Pop();
                    char expChar = openCloseBrackets[openChar];
                    Console.WriteLine($"Open char \"{openChar}\" is closing by \"{ch}\"");
                    if (!expChar.Equals(ch))
                        return false;
                }             
            }
            return true;
        }

        private static Dictionary<char, char> openCloseBrackets = new Dictionary<char, char>
        {
            {'{', '}' }, {'[', ']' }, {'(', ')' }
        };
    }
}
