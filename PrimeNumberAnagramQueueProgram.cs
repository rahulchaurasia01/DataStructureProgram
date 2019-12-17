/*
 *  Purpose: Program to print the Prime Number that are Anagram using Queue.
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
    class PrimeNumberAnagramQueueProgram
    {
        /// <summary>
        /// This Method is used to Test the PrimeNumberAnagramQueue Class.
        /// </summary>
        public static void PrimeNumberAnagramQueue()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------Prime Number Anagram using Queue Program--------------------");
            Console.WriteLine();

            Utility utils = new Utility();

            int count = 0, tempCount = 0;

            string[] primeNumber = new string[200];
            QueueLinkedList queueLinkedList1 = new QueueLinkedList();
            QueueLinkedList queueLinkedList2 = new QueueLinkedList();

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
            count = 0;

            do
            {
                string str1 = primeNumber[count];
                for (int i = count + 1; i < tempCount; i++)
                {
                    string str2 = primeNumber[i];
                    if (utils.AnagramDetection(str1, str2))
                    {
                        queueLinkedList1.Enqueue(Convert.ToInt32(str1));
                        queueLinkedList2.Enqueue(Convert.ToInt32(str2));
                    }
                }
                count++;
            } while (count != tempCount);

            int n = queueLinkedList1.Size();
            string[] tempAnag = queueLinkedList1.ToString().Split(' ');
            string[] tempRevAnag = queueLinkedList2.ToString().Split(' ');
            Console.WriteLine("The Prime Number that are Anagram using Queue: ");
            for (int i = 0; i < n; i++)
                Console.WriteLine(tempAnag[i] + " " + tempRevAnag[i]);
        }

    }
}
