using System;
using System.Collections.Generic;

class Program
{
    //Implement Stack using Queues;

    public class Swq
    {
        public Queue<int> Q1= new Queue<int>();
        public Queue<int> Q2 = new Queue<int>();

        public void SEnq(int x)
        {
            Q2.Enqueue(x);
            while(Q1.Count > 0)
            {
                var y = Q1.Dequeue();
                Q2.Enqueue(y);
            }
            var Q = Q1;
            Q1= Q2;
            Q2 = Q;
        }

        public int SDeq()
        {
            if (Q1.Count > 0)
            {
                var z = Q1.Dequeue();
                return z;
            }
            return -1;
        }
    }
    static void Main(String[] args)
    {

        Swq s = new Swq();

        s.SEnq(1);  //1
        s.SEnq(2);
        s.SEnq(3);
        s.SEnq(4);   //1,2,3,4

        var z = s.SDeq();
        Console.WriteLine("POP:" + z);  //4
        z = s.SDeq();
        Console.WriteLine("POP:" + z); //3
        z = s.SDeq();
        Console.WriteLine("POP:" + z); //2

        s.SEnq(5); //1,5

        z = s.SDeq();
        Console.WriteLine("POP:" + z);  //5

        s.SEnq(6); //1,6

        z = s.SDeq();
        Console.WriteLine("POP:" + z);  //6

    }
}
