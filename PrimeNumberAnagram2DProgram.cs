/*
 *  Purpose: Program to print the Prime Number that are anagram and not an Anagram in (0-1000).
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   18-12-2019
 */


using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProgram
{
    class PrimeNumberAnagram2DProgram
    {
        /// <summary>
        /// This Method is used to test the PrimeNumberAnagram2D Program Class.
        /// </summary>
        public static void PrimeNumberAnagram2D()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------Prime Number that are Anagram and not an Anagram 2D Program--------------------");
            Console.WriteLine();

            Utility utils = new Utility();
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

            int anagramCount = 0, notAnagramCount = 0;
            count = 0;
            int[] thatAreAnagram = new int[tempCount];
            int[] thatAreNotAnagram = new int[tempCount];
            Boolean flag1 = false;
            string str2;

            int[][] anagramNotAnagram = new int[2][];

            do
            {
                flag1 = false;
                string str1 = primeNumber[count];
                for (int i = count + 1; i < tempCount; i++)
                {
                    str2 = primeNumber[i];
                    if (utils.AnagramDetection(str1, str2))
                    {
                        flag1 = true;
                        break;
                    }
                }
                if(flag1)
                {
                    thatAreAnagram[anagramCount] = Convert.ToInt32(str1);
                    anagramCount++;
                }
                else
                {
                    thatAreNotAnagram[notAnagramCount] = Convert.ToInt32(str1);
                    notAnagramCount++;
                }
                count++;
            } while (count != tempCount);

            anagramNotAnagram[0] = new int[anagramCount];
            anagramNotAnagram[1] = new int[notAnagramCount];

            for(int i=0;i<anagramNotAnagram.Length;i++)
            {
                for (int j = 0; j < anagramNotAnagram[i].Length; j++)
                {
                    if (i == 0)
                        anagramNotAnagram[i][j] = thatAreAnagram[j];
                    else
                        anagramNotAnagram[i][j] = thatAreNotAnagram[j];
                    Console.Write(anagramNotAnagram[i][j] + " ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
