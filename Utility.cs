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
using System.Globalization;
using System.IO;
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

            for (int i = 0; i < str.Length; i++)
                deque.AddFront(str[i]);

            int n = str.Length / 2;
            Boolean flag = false;

            for(int i=1;i<=n;i++)
            {
                char a, b;
                a = deque.RemoveFront();
                b = deque.RemoveRear();

                if(a !=b)
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
                return false;
            else
                return true;
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

        /// <summary>
        /// Anagram Detection.
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public Boolean AnagramDetection(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;

            char[] a = str1.ToCharArray();
            char[] b = str2.ToCharArray();

            Array.Sort(a);
            Array.Sort(b);

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    return false;
            }

            return true;
        }
    
        /// <summary>
        /// To Print the Month of the given year.
        /// </summary>
        /// <param name="month"></param>
        /// <param name="year"></param>
        public void Calendar(int month, int year)
        {
            DateTime dt = new DateTime(year, month, 1);
            
            Calendar calendar = CultureInfo.InvariantCulture.Calendar;

            int totalDays = calendar.GetDaysInMonth(year, month);

            int day = DayOfWeek(month, 1, year);

            int count = 1;

            int[,] calendarArray = new int[6,7];

            Console.WriteLine("Sun\tMon\tTue\tWed\tThr\tFri\tSat");

            for (int i = 0; i < 6; i++)
            {
                for(int j = 0; j< 7; j++)
                {
                    if(i==0 && j < day)
                        calendarArray[0, j] = 0;
                    else
                    {
                        if(count <= totalDays)
                        {
                            calendarArray[i, j] = count;
                            count++;
                        }
                    }
                }
            }


            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (calendarArray[i, j] == 0)
                        Console.Write("\t");
                    else
                        Console.Write(calendarArray[i, j] + "\t");
                }
                Console.WriteLine();

            }

        }

        /// <summary>
        /// It return true if it is a leap year or else false
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public Boolean LeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 != 0)
                {
                    if (year % 400 == 0)
                        return true;
                    else
                        return false;
                }
                else
                    return true;
            }
            else
                return false;
        }

        /// <summary>
        /// To get the Day Of Week from the date.
        /// </summary>
        /// <param name="m"></param>
        /// <param name="d"></param>
        /// <param name="y"></param>
        public static int DayOfWeek(int m, int d, int y)
        {
            int y0 = y - (14 - m) / 12;
            int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + ((31 * m0) / 12)) % 7;

            return d0;

        }

        /// <summary>
        /// It Display the Error Message 
        /// </summary>
        /// <param name="flag">It store the true or false value</param>
        public static void ErrorMessage(Boolean flag)
        {
            if (!flag)
                Console.WriteLine("Please Input the Number. !!");
        }

        /// <summary>
        /// Write Data to the file
        /// </summary>
        /// <param name="path"></param>
        public void WriteFile(string path, OrderedSingleLinkedList[] slot)
        {
            OrderedSingleLinkedList orderedSingleLinkedList;
            using StreamWriter writer = new StreamWriter(path);
            for (int i = 0; i < 11; i++)
            {
                writer.Write(i + "\t");
                if (slot[i] != null)
                {
                    orderedSingleLinkedList = slot[i];
                    writer.Write(orderedSingleLinkedList.ToString());
                }
                writer.WriteLine();
            }
        }
    
    
    }
}
