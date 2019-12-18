/*
 *  Purpose: Program to check whether the given string is palindrome or not.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   16-12-2019
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProgram
{
    class PalindromeCheckerProgram
    {
        /// <summary>
        /// This Method is used to test the PalindromeCheckerProgram Class.
        /// </summary>
        public static void PalindromeChecker()
        {

            Console.WriteLine();
            Console.WriteLine("--------------------Palindrome Checker Program--------------------");
            Console.WriteLine();


            Console.Write("Enter the String: ");
            string str = Console.ReadLine();

            Utility utils = new Utility();

            if (utils.CheckPalindrome(str))
                Console.WriteLine("The String is a Palindrome");
            else
                Console.WriteLine("The String is not a Palindrome");
            

        }
    }
}
