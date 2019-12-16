/*
 *  Purpose: Program to simulate the banking Cash Counter.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   16-12-2019
 */

using System;

namespace DataStructureProgram
{
    class BankingCashCounterProgram
    {
        /// <summary>
        /// This method is used to test the BankingCashCounterProgram Class.
        /// </summary>
        public static void BankingCashCounter()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------Banking Cash Counter Program--------------------");
            Console.WriteLine();

            int choice;
            Boolean flag = false;

            Queue depositQueue = new Queue();
            Queue withdrawQueue = new Queue();

            do
            {
                Console.WriteLine("Welcome to bridgeLabz Bank");
                Console.WriteLine();
                Console.WriteLine("1. Do You Want to Deposit your Money.");
                Console.WriteLine("2. Do You want to Withdraw your Money.");
                Console.WriteLine("3. Exit");
                Console.Write("Enter Your Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 3:
                        flag = true;
                        break;

                    default:
                        Console.WriteLine("Invalid Choice. !!");
                        break;
                }
            } while (!flag);

        }
    }
}
