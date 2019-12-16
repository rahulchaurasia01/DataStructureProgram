/*
 *  Purpose: Logic of stack.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   16-12-2019
 */

using System;

namespace DataStructureProgram
{
    class Stack
    {

        char[] stack = new char[100];

        int top = -1;

        /// <summary>
        /// It Push the element in the array.
        /// </summary>
        /// <param name="parentheses"></param>
        public void Push(char parentheses)
        {
            top++;
            stack[top] = parentheses;   
        }

        /// <summary>
        /// It removes the top element of the stack and display it.
        /// </summary>
        public void Pop()
        {
            if(top == -1)
                Console.WriteLine("Nothing to remove");
            else
            {
                //Console.WriteLine(stack[top]);
                stack[top] = ' ';
                top--;
            }
        }

        /// <summary>
        /// It Display the top most element of the stack.
        /// </summary>
        public void Peek()
        {
            if (top == -1)
                Console.WriteLine("Stack is Empty.");
            else
                Console.WriteLine(stack[top]);
        }

        /// <summary>
        /// It will check whether the stack is empty or not.
        /// </summary>
        /// <returns></returns>
        public Boolean IsEmpty()
        {
            if (top == -1)
                return true;
            else
                return false;
        }

        /// <summary>
        /// It return the number of item in the stack;
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            if (top == -1)
                return 0;
            else
                return top+1;
        }

    }
}
