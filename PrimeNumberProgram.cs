/*
 *  Purpose: Program to print the Prime Number in (0-1000).
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   17-12-2019
 */

using System;

namespace DataStructureProgram
{
    class PrimeNumberProgram
    {
        /// <summary>
        /// This method is used to test the PrimeNumberProgram Class.
        /// </summary>
        public static void PrimeNumber()
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("--------------------Prime Number Program--------------------");
                Console.WriteLine();

                Utility utils = new Utility();
                int count = 0, tempCount = 0;
                bool flag;

                Console.WriteLine("The Prime Number in the range of (0 - 1000) are: ");

                int[][] primeNumber = new int[10][];
                int[] tempPrime = new int[100];
                int min = 0, max = 100, oneDimCOunt = 0;

                while (count <= 1000)
                {
                    flag = utils.IsPrimeNumber(count);

                    if (flag)
                    {
                        tempPrime[tempCount] = count;
                        if (count >= min && count <= max)
                            tempCount++;
                    }
                    if (count >= max)
                    {
                        primeNumber[oneDimCOunt] = new int[tempCount];
                        for (int i = 0; i < tempCount; i++)
                            primeNumber[oneDimCOunt][i] = tempPrime[i];
                        oneDimCOunt++;
                        tempCount = 0;
                        min = max;
                        max += 100;
                    }
                    count++;
                }

                for (int i = 0; i < primeNumber.Length; i++)
                {
                    for (int j = 0; j < primeNumber[i].Length; j++)
                        Console.Write(primeNumber[i][j] + " ");

                    Console.WriteLine();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }

    }
}
