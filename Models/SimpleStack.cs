using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack.Models
{
    public class SimpleStack<T>: ICloneable
    {
        private List<T> Items = new List<T>();

        public int Count => Items.Count;
        public bool isEmpty => Items.Count == 0;

        public void Push(T item)
        {
            Items.Add(item);
        }

        public T Pop()
        {
            if (!isEmpty)
            {
                var item = Items.LastOrDefault();
                Items.Remove(item);
                return item;
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
        }


        public T Peek()
        {

            if (!isEmpty)
            {
                return Items.LastOrDefault();
            }
            else
            {
                throw new NullReferenceException("Stack is empty");

            }

        }

        public void Clear()
        {
            Items.Clear();
        }

        public override string ToString()
        {
            return $"Stack contains {Count} elements";
        }

        public object Clone()
        {
            var newStack = new SimpleStack<T>();
            newStack.Items = new List<T>(Items);
            return newStack;
        }
    } 
}