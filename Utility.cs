/*
 *  Purpose: The Utility Class is used to store the logic of the Data Structure Program.
 *  
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   14-12-2019
 * 
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProgram
{
    class Utility
    {
        
        
        /// <summary>
        /// It check whether the parentheses are balanced or not.
        /// </summary>
        /// <param name="Parentheses"></param>
        /// <returns></returns>
        public Boolean CheckParentheses(string Parentheses)
        {
            Stack stack = new Stack();

            char[] parent = Parentheses.ToCharArray();

            for(int i=0;i<Parentheses.Length;i++)
            {
                if (parent[i] == '(')
                    stack.Push(parent[i]);
                else if (parent[i] == ')')
                    stack.Pop();
            }

            if (stack.IsEmpty())
                return true;
            else
                return false;
        }

        /// <summary>
        /// It Check whether the String 
        /// </summary>
        /// <param name="palindromeString"></param>
        /// <returns></returns>
        public Boolean CheckPalindrome(string palindromeString)
        {
            Deque deque = new Deque();

            char[] str = palindromeString.ToCharArray();

            int n = str.Length;

            return false;
        }


        /// <summary>
        /// It Check Whether the Number is a Prime Number or Not.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public Boolean IsPrimeNumber(int number)
        {
            if (number == 0 || number == 1)
                return false;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;

            }
            return true;
        }
    
    
    }
}
