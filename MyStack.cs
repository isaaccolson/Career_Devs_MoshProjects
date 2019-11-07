using System;
using System.Collections;
namespace StackPractice
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var stack = new MyStack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

        }

        public class MyStack
        {
            Stack myStack;

            public MyStack()
            {
                myStack = new Stack();
            }

            public void Push(object obj)
            {
                if (obj != null)
                {
                    myStack.Push(obj);

                }
                else
                {
                    throw new System.InvalidOperationException("Objects on stack cannot be null.");

                }
            }

            public object Pop()
            {
                if (myStack.Count > 0)
                {
                    return myStack.Pop();
                }
                else
                {
                    throw new System.InvalidOperationException("The stack is empty and has nothing to pop.");
                }
            }
            public void Clear()
            {
                myStack.Clear();
            }
        }
    }
}
