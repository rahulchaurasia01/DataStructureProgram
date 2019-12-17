/*
 *  Purpose: Program to print the Prime Number that are Anagram using Stack.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   17-12-2019
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProgram
{
    class PrimeNumberAnagramStackProgram
    {
        /// <summary>
        /// This Method is used to test the PrimeNumberAnagramStack Class.
        /// </summary>
        public static void PrimeNumberAnagramStack()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------Prime Number Anagram using Stack Program--------------------");
            Console.WriteLine();

            Utility utils = new Utility();
            StackLinkedList stackLinkedList1 = new StackLinkedList();
            StackLinkedList stackLinkedList2 = new StackLinkedList();
            int count = 0, tempCount = 0;

            string[] primeNumber = new string[200];

            while (count <= 1000)
            {
                Boolean flag = utils.IsPrimeNumber(count);

                if (flag)
                {
                    primeNumber[tempCount] = count + "";
                    tempCount++;
                }

                count++;
            }
            Console.WriteLine();
            count = 0;

            do
            {
                string str1 = primeNumber[count];
                for(int i=count+1;i<tempCount;i++)
                {
                    string str2 = primeNumber[i];
                    if (utils.AnagramDetection(str1, str2))
                    {
                        stackLinkedList1.Push(Convert.ToInt32(str1));
                        stackLinkedList2.Push(Convert.ToInt32(str2));
                    }
                }
                count++;
            } while (count != tempCount);


            int n = stackLinkedList1.Size();
            string[] tempAnag = stackLinkedList1.ToString().Split(' ');
            string[] tempRevAnag = stackLinkedList2.ToString().Split(' ');
            Array.Reverse(tempAnag);
            Array.Reverse(tempRevAnag);
            Console.WriteLine("The Prime Number that are Anagram using Stack: ");
            for (int i = 0; i < n; i++)
                Console.WriteLine(tempAnag[i] + " " + tempRevAnag[i]);
         
        }
    }
}
