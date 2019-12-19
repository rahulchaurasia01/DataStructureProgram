/*
 *  Purpose: Program to check for the balanced Parentheses.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   16-12-2019
 */

using System;

namespace DataStructureProgram
{
    class SimpleBalancedParenthesesProgram
    {
        /// <summary>
        /// This method is used to test the SimpleBalancedParenthesesProgram Class.
        /// </summary>
        public static void SimpleBalancedParentheses()
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("--------------------Simple Balanced Parentheses Program--------------------");
                Console.WriteLine();


                Console.Write("Enter the Arithmetic Expression: ");
                string str = Console.ReadLine();

                Utility utils = new Utility();

                if (utils.CheckParentheses(str))
                    Console.WriteLine("The Arithmetic Expression are Balanced");
                else
                    Console.WriteLine("The Arithmetic Expression are not Balanced");

            }
            catch(Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }
    }
}
