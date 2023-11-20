using System;

namespace tes
{
    public class Program
    {
        static bool isOperator(string c)
        {
            return c == "+" || c == "-" || c == "*" || c == "/";
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Input Prefix : ");
            string[] input = Console.ReadLine().Split(' ');

            StackArr astack = new StackArr((input.Length + 1) / 2);

            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (isOperator(input[i]))
                {
                    string op1 = astack.Pop();
                    string op2 = astack.Pop();
                    string opHasil = op1 + " " + op2 + " " + input[i];
                    Console.WriteLine("haha " + opHasil);
                    astack.Push(opHasil);
                }
                else
                {
                    astack.Push(input[i]);
                }
                Console.WriteLine("top : " + astack.Top + " : " + astack.arrayData[astack.Top]);
            }

            Console.WriteLine("Bentuk postfix : " + astack.Pop());
        }
    }
}
