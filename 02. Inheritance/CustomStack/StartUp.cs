using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomStack
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var myStack = new StackOfStrings();
            var stack = new Stack<string>();

            int n = int.Parse(Console.ReadLine());

            while (n-- > 0)
            {
                string[] tokens = Console.ReadLine().Split();

                foreach (var token in tokens)
                {
                    stack.Push(token);
                }

                
            }

            myStack.AddRange(stack);

            Console.WriteLine($"Custom stack of strings: {string.Join(' ', myStack)}");
            Console.WriteLine();
            Console.WriteLine($"Stack: {string.Join(' ', stack)}");
            Console.WriteLine();
            Console.WriteLine($"IsEmpty method: {myStack.IsEmpty()}");


        }
    }
}
