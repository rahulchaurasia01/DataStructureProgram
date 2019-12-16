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

    }
}
