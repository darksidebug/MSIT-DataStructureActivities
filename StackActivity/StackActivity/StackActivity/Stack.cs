using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackActivity
{
    internal class MyStack<T>
    {
        static readonly int MAX = 1000;
        int top;
        string[] stack = new string[MAX];

        bool IsEmpty()
        {
            return (top < 0);
        }
        public MyStack()
        {
            top = -1;
        }
        internal bool Push(string data)
        {
            if (top >= MAX)
            {
                MessageBox.Show("Index were outside the bound of array.", "INDEX EXCEPTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                stack[++top] = data;
                return true;
            }
        }

        internal string Pop()
        {
            if (top < 0)
            {
                MessageBox.Show("Index were outside the bound of array.", "INDEX EXCEPTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "0";
            }
            else
            {
                string value = stack[top--];
                return value;
            }
        }

        internal void Peek()
        {
            if (top < 0)
            {
                MessageBox.Show("Index were outside the bound of array.", "INDEX EXCEPTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
                Console.WriteLine("The topmost element of Stack is : {0}", stack[top]);
        }

        internal int Count()
        {
            int i = 0;
            for (i = 0; i < MAX; i++)
            {
                if (string.IsNullOrEmpty(stack[i]))
                {
                    break;
                }
            }

            return i;
        }

        internal void PrintStack()
        {
            if (top < 0)
            {
                MessageBox.Show("Index were outside the bound of array.", "INDEX EXCEPTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }
}
