using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Main.DataStructure.Stacks
{
    class StacksUsingArray
    {
        private int[] data;

        private int top;

        public StacksUsingArray(int size)
        {
            data = new int[size];
            top = 0;
        }

        public bool IsFull()
        {
            return top == data.Length;
        }

        public bool IsEmpty()
        {
            return top == 0;
        }

        public void Push(int value)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full");
            }
            else
            {
                data[top] = value;
                top++;
            }
        }

        public void Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                var e = data[top - 1];
                data[top - 1] = default;
                top--;
            }
        }


        public void DisplayStack()
        {
            if (!IsEmpty())
            {
                for (int i = 0; i <= top - 1; i++)
                {

                    Console.Write($"{data[i]} ==>");
                }
            }
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
            else
                return data[top - 1];
        }


        public int LengthOfStack()
        {
            return top;
        }


    }
}