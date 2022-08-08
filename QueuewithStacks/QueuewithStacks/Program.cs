using System;
using System.Collections.Generic;

namespace QueuewithStacks
{
    //Implement Queue using Stacks;
    class Program
    {    
        public class Qws
        {
            public Stack<int> In = new Stack<int>();
            public Stack<int> Out = new Stack<int>();

        public  void  PushQ(int x)
            {
                In.Push(x);
            }

         public   int PopQ()
            {
                int y;
                if(Out.Count > 0)
                {
                    y = Out.Pop();
                    return y;
                }
                else
                {
                    while(In.Count > 0)
                    {
                        Out.Push(In.Pop());
                    }

                    if (Out.Count > 0)
                    {
                        y = Out.Pop();
                        return y;
                    }
                    return -1;
                }
            }
        }
        static void Main(string[] args)
        {
            Qws s = new Qws();
            s.PushQ(1);
            s.PushQ(2);
            s.PushQ(3);
            s.PushQ(4);   //1,2,3,4

            var z = s.PopQ();
            Console.WriteLine("Dequeue:" + z);  //1
            z = s.PopQ();
            Console.WriteLine("Dequeue:" + z); //2
            z = s.PopQ();
            Console.WriteLine("Dequeue:" + z); //3

            s.PushQ(5);  //push 5 - 4,5

            z = s.PopQ();
            Console.WriteLine("Dequeue:" + z); //4

            z = s.PopQ();
            Console.WriteLine("Dequeue:" + z); //5

            z = s.PopQ();
            Console.WriteLine("Dequeue:" + z); // -1
        }
    }
}
