using System;

namespace Evalute_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "2*3+5*7";
            int result = EvaluteExp(str);

            if (result == -1)
                Console.WriteLine("Invalid Expression");
            else
                Console.WriteLine("Expression: " + str + " = " + result);
        }
         static int EvaluteExp(string str)
        {
            if (str.Length == 0)
            {
                Console.WriteLine("Expression is empty");
                return -1;
            }
            var res_char = str[0];
            int res;
                      
           if (res_char >= '0' && res_char <= '9')
            {
               res= int.Parse(str[0].ToString());
            }
           else     
                return -1;

            for ( int i=1; i< str.Length; i= i + 2)
            {
                var Op = str[i];
                var dig  = str[i + 1];
                int di;
                if (dig >= '0' && dig <= '9')
                {
                     di = int.Parse(str[i + 1].ToString());
                }
                else
                    return -1;
                if (Op == '+')
                    res = res + di;
                else if (Op == '*')
                    res = res * di;
                else
                    return -1;
            }
            return res;
        }
    }
}
