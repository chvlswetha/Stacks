using System;
using System.Collections.Generic;

namespace StackReverse
{
    class Program
    {
        static void Main(string[] args)
        {

            var A = new Stack<int>();
            var B = new Stack<int>();

            A.Push(10);
            A.Push(20);
            A.Push(30);
            A.Push(40);
            A.Push(50);

            Console.WriteLine("Stack A:");
            while (A.Count > 0)
            {
                Console.Write(A.Peek() +",");
                var x = A.Pop();
                B.Push(x);
            }

            A = B;

            Console.WriteLine("\n Reversed Stack A:");

            while (A.Count > 0)
            {
                Console.Write(A.Peek() + ",");
                A.Pop();         
            }

        }
    }
}
