using System;
using System.Collections.Generic;

namespace NextGreaterElement
{
    /// Given an array, print the Next Greater Element (NGE) for every element. 
    /// The Next greater Element for an element x is the first greater element 
    /// on the right side of x in array. 
    /// Elements for which no greater element exist, consider next greater element as -1.
  
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 3, 8, 7, 9,12, 4, 3, 5,10};


            int[] Nge = NextGreaterElement(a, a.Length);

            Console.WriteLine("Array" + "\t -> \t" +"GreatElemnt");
            for (int i = 0; i< a.Length; i++)
            {
                Console.WriteLine(a[i] + "\t -> \t" + Nge[i]);
            }
        }

       static int[] NextGreaterElement(int[] a, int n)
        {
            int[] Ng = new int[n];
            Stack<int> s = new Stack<int>();

            s.Push(0);

            for(int i=1; i<n; i++)
            {
                if (a[s.Peek()] > a[i])       // Pushing elemenet that has less value than top stack
                    s.Push(i);
                else
                {
                    while (s.Count > 0 && a[s.Peek()] < a[i])
                    {
                        var x = s.Pop();  // Poping the top stack and assiging to greater value till then.
                        Ng[x] = a[i];
                    }
                    s.Push(i);
                }
            }
            while(s.Count > 0)
            {
                Ng[s.Pop()] = -1;  //Assiging -1 to left over elements. No Next great elements.
            }
            return Ng;

        }
    }
}
