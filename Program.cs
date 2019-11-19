using System;
using System.Collections.Generic;
using Stack.Models;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleStack<int> myStack = new SimpleStack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);

            var item = myStack.Pop();
            var secondItem = myStack.Peek();

            Console.WriteLine(item);
            Console.WriteLine(secondItem);
            Console.ReadLine();

            Stack<double> stack = new Stack<double>();

            var linkedStack = new LinkedStack<int>();
            linkedStack.Push(10);
            linkedStack.Push(20);
            linkedStack.Push(30);
            linkedStack.Push(40);

            Console.WriteLine(linkedStack.Peek());
            Console.WriteLine(linkedStack.Pop());
            Console.WriteLine(linkedStack.Pop());
            Console.WriteLine(linkedStack.Peek());
            Console.ReadLine();

            var arrayStack = new ArrayStack<int>(5);
            arrayStack.Push(100);
            arrayStack.Push(200);
            arrayStack.Push(300);
            arrayStack.Push(400);
            arrayStack.Push(500);

            System.Console.WriteLine(arrayStack.Peek());
            System.Console.WriteLine(arrayStack.Pop());
            System.Console.WriteLine(arrayStack.Pop());
            System.Console.WriteLine(arrayStack.Peek());
            
            Console.ReadLine();

        }
    }
}
