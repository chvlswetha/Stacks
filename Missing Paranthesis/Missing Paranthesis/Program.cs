using System;
using System.Collections.Generic;


namespace Missing_Paranthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "2 *  ((((3 + 5";
            FindMiss(str);
        }
        static void  FindMiss(string str)
        {
            var stack = new Stack<char>();

            foreach(char i in str)
            {
                if(i == '(')
                {
                    stack.Push('(');

                }
                else if (i == ')')
                {
                    if (stack.Count > 0)
                        stack.Pop();
                    else
                        Console.WriteLine("Missing is: (" );
                }
            }
            if (stack.Count > 0)
                Console.WriteLine("Missing is: ) of count " + stack.Count);
        }
    }
}
